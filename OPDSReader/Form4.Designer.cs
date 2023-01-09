namespace OPDSReader
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.btFavouriteBooks = new System.Windows.Forms.Button();
            this.btSaveBooks = new System.Windows.Forms.Button();
            this.btMyPodbor = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenBook = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Личный кабинет пользователя";
            // 
            // lbWellcome
            // 
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWellcome.Location = new System.Drawing.Point(348, 23);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(70, 25);
            this.lbWellcome.TabIndex = 2;
            this.lbWellcome.Text = "label3";
            // 
            // btFavouriteBooks
            // 
            this.btFavouriteBooks.Location = new System.Drawing.Point(12, 71);
            this.btFavouriteBooks.Name = "btFavouriteBooks";
            this.btFavouriteBooks.Size = new System.Drawing.Size(136, 53);
            this.btFavouriteBooks.TabIndex = 3;
            this.btFavouriteBooks.Text = "Избранное";
            this.btFavouriteBooks.UseVisualStyleBackColor = true;
            this.btFavouriteBooks.Click += new System.EventHandler(this.btFavouriteBooks_Click);
            // 
            // btSaveBooks
            // 
            this.btSaveBooks.Location = new System.Drawing.Point(12, 221);
            this.btSaveBooks.Name = "btSaveBooks";
            this.btSaveBooks.Size = new System.Drawing.Size(136, 60);
            this.btSaveBooks.TabIndex = 4;
            this.btSaveBooks.Text = "Скаченное";
            this.btSaveBooks.UseVisualStyleBackColor = true;
            this.btSaveBooks.Click += new System.EventHandler(this.btSaveBooks_Click);
            // 
            // btMyPodbor
            // 
            this.btMyPodbor.Location = new System.Drawing.Point(12, 376);
            this.btMyPodbor.Name = "btMyPodbor";
            this.btMyPodbor.Size = new System.Drawing.Size(136, 64);
            this.btMyPodbor.TabIndex = 5;
            this.btMyPodbor.Text = "Мои подборки";
            this.btMyPodbor.UseVisualStyleBackColor = true;
            this.btMyPodbor.Click += new System.EventHandler(this.btMyPodbor_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(743, 12);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(131, 46);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Выйти";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(169, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 369);
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btMyPodbor);
            this.Controls.Add(this.btSaveBooks);
            this.Controls.Add(this.btFavouriteBooks);
            this.Controls.Add(this.lbWellcome);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Личный кабинет";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWellcome;
        private System.Windows.Forms.Button btFavouriteBooks;
        private System.Windows.Forms.Button btSaveBooks;
        private System.Windows.Forms.Button btMyPodbor;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBook;
        private System.Windows.Forms.DataGridViewButtonColumn OpenBook;
    }
}