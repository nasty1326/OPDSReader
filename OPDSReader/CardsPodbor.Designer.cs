namespace OPDSReader
{
    partial class CardsPodbor
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
            this.lbNamePodbor = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenBook = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNamePodbor
            // 
            this.lbNamePodbor.AutoSize = true;
            this.lbNamePodbor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNamePodbor.Location = new System.Drawing.Point(12, 9);
            this.lbNamePodbor.Name = "lbNamePodbor";
            this.lbNamePodbor.Size = new System.Drawing.Size(70, 25);
            this.lbNamePodbor.TabIndex = 0;
            this.lbNamePodbor.Text = "label1";
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.Location = new System.Drawing.Point(14, 48);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(44, 16);
            this.lbAbout.TabIndex = 1;
            this.lbAbout.Text = "label2";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(621, 148);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(44, 16);
            this.lbAuthor.TabIndex = 3;
            this.lbAuthor.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NameBook,
            this.AuthorBook,
            this.OpenBook});
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(877, 319);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // NameBook
            // 
            this.NameBook.HeaderText = "Название";
            this.NameBook.MinimumWidth = 6;
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // AuthorBook
            // 
            this.AuthorBook.HeaderText = "Автор";
            this.AuthorBook.MinimumWidth = 6;
            this.AuthorBook.Name = "AuthorBook";
            this.AuthorBook.ReadOnly = true;
            // 
            // OpenBook
            // 
            this.OpenBook.HeaderText = "Открыть";
            this.OpenBook.MinimumWidth = 50;
            this.OpenBook.Name = "OpenBook";
            this.OpenBook.ReadOnly = true;
            this.OpenBook.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OpenBook.Text = "Открыть";
            this.OpenBook.UseColumnTextForButtonValue = true;
            // 
            // CardsPodbor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbNamePodbor);
            this.Name = "CardsPodbor";
            this.Text = "Podbor";
            this.Load += new System.EventHandler(this.CardsPodbor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNamePodbor;
        private System.Windows.Forms.Label lbAbout;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBook;
        private System.Windows.Forms.DataGridViewButtonColumn OpenBook;
    }
}