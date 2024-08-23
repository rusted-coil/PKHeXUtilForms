using PKHeXUtilForms.Control;
using System.Reactive;
using System.Reactive.Subjects;

namespace PKHeXUtilLib.Pokemon.NameParser.View.Internal
{
    internal partial class NameParserEditorForm : Form, INameParserEditorForm
    {
        public enum Columns
        {
            PokemonName = 0,
            FormWord,
            DexIndex,
            FormIndex,
            Confirm,
        }

        private readonly Subject<int> m_ValueChanged = new Subject<int>();
        public IObservable<int> ValueChanged => m_ValueChanged;

        private readonly AsyncSubject<Unit> m_FormClosingEvent = new AsyncSubject<Unit>();
        public IObservable<Unit> FormClosingEvent => m_FormClosingEvent;

        public NameParserEditorForm()
        {
            InitializeComponent();
            InitializeView();
        }

        void InitializeView()
        {
            NameParserDataGridView.Columns.Add(new DataGridViewTextBoxColumnEx("PokemonName", "ポケモン名", 100));
            NameParserDataGridView.Columns.Add(new DataGridViewTextBoxColumnEx("FormWord", "フォルムワード", 100));
            NameParserDataGridView.Columns.Add(new DataGridViewTextBoxColumnEx("DexIndex", "全国図鑑No.", 80));
            NameParserDataGridView.Columns.Add(new DataGridViewTextBoxColumnEx("FormIndex", "フォルムIndex", 80));
            NameParserDataGridView.Columns.Add(new DataGridViewTextBoxColumnEx("Confirm", "確認", 400));

            NameParserDataGridView.DataSource = NameParserDataBindingSource;
        }

        private void NameParserDataGridView_CellValueChanged(object? sender, DataGridViewCellEventArgs e) => m_ValueChanged.OnNext(e.RowIndex);

        private void NameParserEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_FormClosingEvent.OnNext(default);
            m_FormClosingEvent.OnCompleted();
        }
    }
}
