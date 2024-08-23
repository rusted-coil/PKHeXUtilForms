namespace PKHeXUtilLib.Control
{
    internal class DataGridViewTextBoxColumnEx : DataGridViewTextBoxColumn
    {
        public DataGridViewTextBoxColumnEx() { }    

        public DataGridViewTextBoxColumnEx(string name, string headerText, int? width = null) 
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
            SortMode = DataGridViewColumnSortMode.NotSortable;
            HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DefaultCellStyle = StyleFactory.GetTextBoxDefaultStyle();
        }
    }
}
