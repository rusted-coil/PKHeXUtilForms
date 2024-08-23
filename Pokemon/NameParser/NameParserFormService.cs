namespace PKHeXUtilForms.Pokemon.NameParser
{
    public static class NameParserFormService
    {
        static Internal.NameParserEditorForm? s_Form = null;

        /// <summary>
        /// NameParserのデータ編集ウィンドウを開きます。
        /// <para> * 既に開かれている場合はそのウィンドウにフォーカスします。</para>
        /// </summary>
        public static void OpenNameParserDataEditor()
        {
            if (s_Form == null)
            {
                s_Form = new Internal.NameParserEditorForm();

                var presenter = new Internal.NameParserEditorPresenter(s_Form);

                s_Form.FormClosingEvent.Subscribe(_ => 
                {
                    s_Form = null;
                    presenter.Dispose();
                });

                s_Form.Show();
            }
            else
            {
                s_Form.Focus();
            }
        }
    }
}
