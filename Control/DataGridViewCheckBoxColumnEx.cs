namespace PKHeXUtilLib.Control
{
    internal class DataGridViewCheckBoxColumnEx : DataGridViewCheckBoxColumn
    {
        public DataGridViewCheckBoxColumnEx() : base() { }

        public DataGridViewCheckBoxColumnEx(string name, string headerText, int? width = null)
        {
            Name = name;
            HeaderText = headerText;
            DataPropertyName = name;

            if (width != null)
            {
                Width = width.Value;
            }
            else
            {
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }
            HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
