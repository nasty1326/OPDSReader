namespace OPDSReader
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbWellcome = new System.Windows.Forms.Label();
            this.btCreatePodbor = new System.Windows.Forms.Button();
            this.btLichCab = new System.Windows.Forms.Button();
            this.btPodbor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenBook = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.dataGridViewGenre = new System.Windows.Forms.DataGridView();
            this.genre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btAllBooks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbWellcome);
            this.panel1.Controls.Add(this.btCreatePodbor);
            this.panel1.Controls.Add(this.btLichCab);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 36);
            this.panel1.TabIndex = 12;
            // 
            // lbWellcome
            // 
            this.lbWellcome.AutoSize = true;
            this.lbWellcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWellcome.Location = new System.Drawing.Point(18, 4);
            this.lbWellcome.Name = "lbWellcome";
            this.lbWellcome.Size = new System.Drawing.Size(70, 25);
            this.lbWellcome.TabIndex = 17;
            this.lbWellcome.Text = "label3";
            // 
            // btCreatePodbor
            // 
            this.btCreatePodbor.Location = new System.Drawing.Point(1108, 3);
            this.btCreatePodbor.Name = "btCreatePodbor";
            this.btCreatePodbor.Size = new System.Drawing.Size(152, 30);
            this.btCreatePodbor.TabIndex = 16;
            this.btCreatePodbor.Text = "Создать подборку";
            this.btCreatePodbor.UseVisualStyleBackColor = true;
            this.btCreatePodbor.Click += new System.EventHandler(this.btCreatePodbor_Click);
            // 
            // btLichCab
            // 
            this.btLichCab.Location = new System.Drawing.Point(1282, 3);
            this.btLichCab.Name = "btLichCab";
            this.btLichCab.Size = new System.Drawing.Size(197, 32);
            this.btLichCab.TabIndex = 0;
            this.btLichCab.Text = "Личный кабинет";
            this.btLichCab.UseVisualStyleBackColor = true;
            this.btLichCab.Click += new System.EventHandler(this.btLichCab_Click);
            // 
            // btPodbor
            // 
            this.btPodbor.Location = new System.Drawing.Point(23, 42);
            this.btPodbor.Name = "btPodbor";
            this.btPodbor.Size = new System.Drawing.Size(272, 37);
            this.btPodbor.TabIndex = 1;
            this.btPodbor.Text = "Подборки";
            this.btPodbor.UseVisualStyleBackColor = true;
            this.btPodbor.Click += new System.EventHandler(this.btPodbor_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(521, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(935, 631);
            this.dataGridView1.TabIndex = 11;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(450, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-128, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(1292, 42);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(188, 66);
            this.btStart.TabIndex = 7;
            this.btStart.Text = "Запустить OPDS";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Visible = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // dataGridViewGenre
            // 
            this.dataGridViewGenre.AllowUserToAddRows = false;
            this.dataGridViewGenre.AllowUserToDeleteRows = false;
            this.dataGridViewGenre.AllowUserToOrderColumns = true;
            this.dataGridViewGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.genre});
            this.dataGridViewGenre.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewGenre.Name = "dataGridViewGenre";
            this.dataGridViewGenre.ReadOnly = true;
            this.dataGridViewGenre.RowHeadersWidth = 51;
            this.dataGridViewGenre.RowTemplate.Height = 24;
            this.dataGridViewGenre.Size = new System.Drawing.Size(446, 631);
            this.dataGridViewGenre.TabIndex = 13;
            this.dataGridViewGenre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGenre_CellContentClick);
            // 
            // genre
            // 
            this.genre.HeaderText = "Жанры";
            this.genre.MinimumWidth = 6;
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            this.genre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(376, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Поиск";
            // 
            // btAllBooks
            // 
            this.btAllBooks.Location = new System.Drawing.Point(23, 85);
            this.btAllBooks.Name = "btAllBooks";
            this.btAllBooks.Size = new System.Drawing.Size(272, 39);
            this.btAllBooks.TabIndex = 15;
            this.btAllBooks.Text = "Все книги";
            this.btAllBooks.UseVisualStyleBackColor = true;
            this.btAllBooks.Click += new System.EventHandler(this.btAllBooks_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 773);
            this.Controls.Add(this.btPodbor);
            this.Controls.Add(this.btAllBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewGenre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStart);
            this.Name = "Form2";
            this.Text = "Главная страница";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.DataGridView dataGridViewGenre;
        private System.Windows.Forms.DataGridViewButtonColumn genre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPodbor;
        private System.Windows.Forms.Button btLichCab;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBook;
        private System.Windows.Forms.DataGridViewButtonColumn OpenBook;
        private System.Windows.Forms.Button btAllBooks;
        private System.Windows.Forms.Button btCreatePodbor;
        private System.Windows.Forms.Label lbWellcome;
    }
}