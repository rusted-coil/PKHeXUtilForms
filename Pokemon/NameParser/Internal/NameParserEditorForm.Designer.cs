namespace PKHeXUtilForms.Pokemon.NameParser.Internal
{
	partial class NameParserEditorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NameParserDataGridView = new DataGridView();
            NameParserDataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)NameParserDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NameParserDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // NameParserDataGridView
            // 
            NameParserDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameParserDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NameParserDataGridView.Location = new Point(12, 12);
            NameParserDataGridView.MultiSelect = false;
            NameParserDataGridView.Name = "NameParserDataGridView";
            NameParserDataGridView.Size = new Size(920, 537);
            NameParserDataGridView.TabIndex = 1;
            NameParserDataGridView.CellValueChanged += NameParserDataGridView_CellValueChanged;
            // 
            // NameParserEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 561);
            Controls.Add(NameParserDataGridView);
            Name = "NameParserEditorForm";
            Text = "NameParserEditorForm";
            FormClosing += NameParserEditorForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)NameParserDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)NameParserDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView NameParserDataGridView;
        internal BindingSource NameParserDataBindingSource;
    }
}