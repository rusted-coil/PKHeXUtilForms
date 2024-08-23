namespace PKHeXUtilForms.Control
{
    public static class StyleFactory
    {
        static DataGridViewCellStyle s_TextBoxDefaultStyle = new DataGridViewCellStyle
        {
            Font = new Font("メイリオ", 9, FontStyle.Regular),
            Alignment = DataGridViewContentAlignment.MiddleCenter,
        };

        public static DataGridViewCellStyle GetTextBoxDefaultStyle() => s_TextBoxDefaultStyle;
    }
}
