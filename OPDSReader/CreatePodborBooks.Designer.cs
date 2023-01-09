namespace OPDSReader
{
    partial class CreatePodborBooks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btCreatePodborNow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNamePodbor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAboutPodbor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPodbor = new System.Windows.Forms.DataGridView();
            this.vibor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IDbooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorBooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenBooks = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPoisk = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idookIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBookIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorbookIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openbookIn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletebookIn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodbor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCreatePodborNow
            // 
            this.btCreatePodborNow.Location = new System.Drawing.Point(773, 78);
            this.btCreatePodborNow.Name = "btCreatePodborNow";
            this.btCreatePodborNow.Size = new System.Drawing.Size(194, 56);
            this.btCreatePodborNow.TabIndex = 0;
            this.btCreatePodborNow.Text = "Создать подборку";
            this.btCreatePodborNow.UseVisualStyleBackColor = true;
            this.btCreatePodborNow.Click += new System.EventHandler(this.btCreatePodborNow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Создание подборки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название подборки";
            // 
            // tbNamePodbor
            // 
            this.tbNamePodbor.Location = new System.Drawing.Point(176, 78);
            this.tbNamePodbor.Name = "tbNamePodbor";
            this.tbNamePodbor.Size = new System.Drawing.Size(349, 22);
            this.tbNamePodbor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание подборки";
            // 
            // tbAboutPodbor
            // 
            this.tbAboutPodbor.Location = new System.Drawing.Point(175, 123);
            this.tbAboutPodbor.Name = "tbAboutPodbor";
            this.tbAboutPodbor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAboutPodbor.Size = new System.Drawing.Size(569, 22);
            this.tbAboutPodbor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Выберите книги из списка";
            // 
            // dataGridViewPodbor
            // 
            this.dataGridViewPodbor.AllowUserToAddRows = false;
            this.dataGridViewPodbor.AllowUserToDeleteRows = false;
            this.dataGridViewPodbor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPodbor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodbor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vibor,
            this.IDbooks,
            this.NameBook,
            this.AuthorBooks,
            this.OpenBooks});
            this.dataGridViewPodbor.Location = new System.Drawing.Point(34, 210);
            this.dataGridViewPodbor.Name = "dataGridViewPodbor";
            this.dataGridViewPodbor.RowHeadersWidth = 51;
            this.dataGridViewPodbor.RowTemplate.Height = 24;
            this.dataGridViewPodbor.Size = new System.Drawing.Size(933, 257);
            this.dataGridViewPodbor.TabIndex = 7;
            this.dataGridViewPodbor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPodbor_CellContentClick);
            // 
            // vibor
            // 
            this.vibor.FillWeight = 21.39037F;
            this.vibor.HeaderText = "";
            this.vibor.MinimumWidth = 6;
            this.vibor.Name = "vibor";
            // 
            // IDbooks
            // 
            this.IDbooks.HeaderText = "IDКниги";
            this.IDbooks.MinimumWidth = 6;
            this.IDbooks.Name = "IDbooks";
            this.IDbooks.ReadOnly = true;
            this.IDbooks.Visible = false;
            // 
            // NameBook
            // 
            this.NameBook.FillWeight = 126.2032F;
            this.NameBook.HeaderText = "Название";
            this.NameBook.MinimumWidth = 6;
            this.NameBook.Name = "NameBook";
            this.NameBook.ReadOnly = true;
            // 
            // AuthorBooks
            // 
            this.AuthorBooks.FillWeight = 126.2032F;
            this.AuthorBooks.HeaderText = "Автор";
            this.AuthorBooks.MinimumWidth = 6;
            this.AuthorBooks.Name = "AuthorBooks";
            this.AuthorBooks.ReadOnly = true;
            // 
            // OpenBooks
            // 
            this.OpenBooks.FillWeight = 126.2032F;
            this.OpenBooks.HeaderText = "Открыть";
            this.OpenBooks.MinimumWidth = 6;
            this.OpenBooks.Name = "OpenBooks";
            this.OpenBooks.ReadOnly = true;
            this.OpenBooks.Text = "Открыть";
            this.OpenBooks.UseColumnTextForButtonValue = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поиск";
            // 
            // tbPoisk
            // 
            this.tbPoisk.Location = new System.Drawing.Point(670, 182);
            this.tbPoisk.Name = "tbPoisk";
            this.tbPoisk.Size = new System.Drawing.Size(297, 22);
            this.tbPoisk.TabIndex = 9;
            this.tbPoisk.TextChanged += new System.EventHandler(this.tbPoisk_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idookIn,
            this.nameBookIn,
            this.authorbookIn,
            this.openbookIn,
            this.deletebookIn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(34, 512);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(933, 257);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idookIn
            // 
            this.idookIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idookIn.HeaderText = "IDКниги";
            this.idookIn.MinimumWidth = 6;
            this.idookIn.Name = "idookIn";
            this.idookIn.ReadOnly = true;
            this.idookIn.Visible = false;
            this.idookIn.Width = 125;
            // 
            // nameBookIn
            // 
            this.nameBookIn.FillWeight = 35.88398F;
            this.nameBookIn.HeaderText = "Название";
            this.nameBookIn.MinimumWidth = 200;
            this.nameBookIn.Name = "nameBookIn";
            this.nameBookIn.ReadOnly = true;
            this.nameBookIn.Width = 200;
            // 
            // authorbookIn
            // 
            this.authorbookIn.FillWeight = 288.77F;
            this.authorbookIn.HeaderText = "Автор";
            this.authorbookIn.MinimumWidth = 200;
            this.authorbookIn.Name = "authorbookIn";
            this.authorbookIn.ReadOnly = true;
            this.authorbookIn.Width = 200;
            // 
            // openbookIn
            // 
            this.openbookIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.openbookIn.FillWeight = 31.46822F;
            this.openbookIn.HeaderText = "Открыть";
            this.openbookIn.MinimumWidth = 60;
            this.openbookIn.Name = "openbookIn";
            this.openbookIn.ReadOnly = true;
            this.openbookIn.Text = "Открыть";
            this.openbookIn.UseColumnTextForButtonValue = true;
            // 
            // deletebookIn
            // 
            this.deletebookIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deletebookIn.FillWeight = 43.87775F;
            this.deletebookIn.HeaderText = "Удалить";
            this.deletebookIn.MinimumWidth = 60;
            this.deletebookIn.Name = "deletebookIn";
            this.deletebookIn.ReadOnly = true;
            this.deletebookIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletebookIn.Text = "Удалить";
            this.deletebookIn.UseColumnTextForButtonValue = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "В подборке";
            // 
            // CreatePodborBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 781);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbPoisk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewPodbor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAboutPodbor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNamePodbor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCreatePodborNow);
            this.Name = "CreatePodborBooks";
            this.Text = "Создание подборки книг";
            this.Load += new System.EventHandler(this.CreatePodborBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodbor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreatePodborNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNamePodbor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAboutPodbor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPodbor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPoisk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vibor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorBooks;
        private System.Windows.Forms.DataGridViewButtonColumn OpenBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idookIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorbookIn;
        private System.Windows.Forms.DataGridViewButtonColumn openbookIn;
        private System.Windows.Forms.DataGridViewButtonColumn deletebookIn;
        private System.Windows.Forms.Label label6;
    }
}