namespace PKHeXUtilForms.Pokemon.NameParser.Internal
{
    /// <summary>
    /// NameParserEditorのデータ1つのクラスです。
    /// </summary>
    internal class NameParserEditorEntry
    {
        /// <summary>
        /// ポケモン名を取得・設定します。
        /// </summary>
        public string? PokemonName { get; set; }

        /// <summary>
        /// フォルムの名称を取得・設定します。
        /// </summary>
        public string? FormWord { get; set; }

        /// <summary>
        /// 全国図鑑番号を取得・設定します。
        /// </summary>
        public string? DexIndex { get; set; }

        /// <summary>
        /// フォルム番号を取得・設定します。
        /// </summary>
        public string? FormIndex { get; set; }

        /// <summary>
        /// 確認用のテキストを取得・設定します。
        /// </summary>
        public string? Confirm { get; set; }
    }
}
