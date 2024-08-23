using FormRx.Extensions;
using PKHeX.Core;
using PKHeXUtilLib.Application;
using PKHeXUtilLib.Infrastructure;
using PKHeXUtilLib.Pokemon.NameParser;
using PKHeXUtilLib.Pokemon.Species;
using PKHeXUtilLib.Type;
using System.Reactive.Disposables;

namespace PKHeXUtilForms.Pokemon.NameParser.Internal
{
    internal sealed class NameParserEditorPresenter : IDisposable
    {
        List<NameParserEditorEntry> m_Entries;

        readonly INameParserEditorForm m_Form;
        readonly CompositeDisposable m_Disposables = new CompositeDisposable();

        public NameParserEditorPresenter(INameParserEditorForm form)
        { 
            m_Form = form;
            m_Entries = NameParserFactory.LoadEntries()
                .Select(entry =>
                { 
                    var data = new NameParserEditorEntry
                    {
                        PokemonName = entry.PokemonName,
                        FormWord = entry.FormWord,
                        DexIndex = entry.DexIndex.ToString(),
                        FormIndex = entry.FormIndex.ToString(),
                    };
                    SetConfirm(data);
                    return data;
                })
                .ToList();

            form.SetDataSource(m_Entries);
            form.ValueChanged.Subscribe(OnChanged).AddTo(m_Disposables);
        }

        public void Dispose() 
        {
            m_Disposables.Dispose();
        }

        // フォーム変更時イベント
        internal sealed class NameParserEntry : INameParserEntry
        {
            public required string PokemonName { get; set; }
            public required string FormWord { get; set; }
            public required int DexIndex { get; set; }
            public required int FormIndex { get; set; }
        }
        bool m_isConfirmSetting = false;
        void OnChanged(int index)
        {
            if (m_isConfirmSetting)
            {
                return;
            }

            if (index >= 0 && index < m_Entries.Count)
            {
                m_isConfirmSetting = true;
                SetConfirm(m_Entries[index]);
                m_isConfirmSetting = false;
            }

            // 変更があったら保存
            if (!Serializer.Serialize(FilePath.NameParserDataPath,
                m_Entries
                .Where(data => data.IsValid())
                .Select(entry =>
                    new NameParserEntry
                    {
                        PokemonName = entry.PokemonName ?? string.Empty,
                        FormWord = entry.FormWord ?? string.Empty,
                        DexIndex = int.Parse(entry.DexIndex ?? "-1"),
                        FormIndex = int.Parse(entry.FormIndex ?? "-1"),
                    })
                .ToArray(),
                out string errorMessage))
            { 
                MessageBox.Show(errorMessage);
            }
        }

        void SetConfirm(NameParserEditorEntry entry)
        {
            if (entry.IsValid())
            {
                int.TryParse(entry.DexIndex, out int dexIndex);
                int.TryParse(entry.FormIndex, out int formIndex);
                var personalInfo = PersonalTable.SV[(ushort)dexIndex, (byte)formIndex];
                if (personalInfo.IsPresentInGame && formIndex < personalInfo.FormCount)
                {
                    entry.Confirm = GetConfirmString(personalInfo, dexIndex);
                }
                else
                {
                    entry.Confirm = "Indexエラー";
                }
            }
            else
            {
                entry.Confirm = "入力形式エラー";
            }
        }

        // 入力データから確認用文字列を返す
        string GetConfirmString(PersonalInfo personalInfo, int dexIndex)
        {
            var name = SpeciesUtil.GetSpeciesNames("ja")[dexIndex];
            string type;
            if (personalInfo.Type1 != personalInfo.Type2)
            {
                type = $"{TypeUtil.GetTypeName(personalInfo.Type1, "ja")}/{TypeUtil.GetTypeName(personalInfo.Type2, "ja")}";
            }
            else
            {
                type = TypeUtil.GetTypeName(personalInfo.Type1, "ja");
            }
            return $"{name}({type}):{personalInfo.HP}-{personalInfo.ATK}-{personalInfo.DEF}-{personalInfo.SPA}-{personalInfo.SPD}-{personalInfo.SPE}";
        }
    }
}
