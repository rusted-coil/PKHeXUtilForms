namespace PKHeXUtilForms.Pokemon.NameParser.Internal
{
    internal interface INameParserEditorForm
    {
        /// <summary>
        /// 使用するデータソースをセットします。
        /// </summary>
        void SetDataSource(List<NameParserEditorEntry> dataSource);

        /// <summary>
        /// 値が変更された時に発行されるストリームを取得します。
        /// </summary>
        IObservable<int> ValueChanged { get; }
    }
}
