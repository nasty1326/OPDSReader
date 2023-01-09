namespace OPDSReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PassworBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label12266332 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btRegistr = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPasswordReg = new System.Windows.Forms.TextBox();
            this.TBLoginReg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBAdmin = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 328);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btEntry);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.PassworBox);
            this.tabPage1.Controls.Add(this.loginBox);
            this.tabPage1.Controls.Add(this.label12266332);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 299);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // btEntry
            // 
            this.btEntry.Location = new System.Drawing.Point(232, 208);
            this.btEntry.Name = "btEntry";
            this.btEntry.Size = new System.Drawing.Size(194, 50);
            this.btEntry.TabIndex = 5;
            this.btEntry.Text = "Войти";
            this.btEntry.UseVisualStyleBackColor = true;
            this.btEntry.Click += new System.EventHandler(this.btRegistr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // PassworBox
            // 
            this.PassworBox.Location = new System.Drawing.Point(232, 160);
            this.PassworBox.Name = "PassworBox";
            this.PassworBox.Size = new System.Drawing.Size(194, 22);
            this.PassworBox.TabIndex = 4;
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(232, 122);
            this.loginBox.MaxLength = 50;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(194, 22);
            this.loginBox.TabIndex = 2;
            // 
            // label12266332
            // 
            this.label12266332.AutoSize = true;
            this.label12266332.Location = new System.Drawing.Point(120, 163);
            this.label12266332.Name = "label12266332";
            this.label12266332.Size = new System.Drawing.Size(56, 16);
            this.label12266332.TabIndex = 3;
            this.label12266332.Text = "Пароль";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btRegistr);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TBPasswordReg);
            this.tabPage2.Controls.Add(this.TBLoginReg);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CBAdmin);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 299);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btRegistr
            // 
            this.btRegistr.Location = new System.Drawing.Point(218, 187);
            this.btRegistr.Name = "btRegistr";
            this.btRegistr.Size = new System.Drawing.Size(194, 50);
            this.btRegistr.TabIndex = 13;
            this.btRegistr.Text = "Зарегистроваться";
            this.btRegistr.UseVisualStyleBackColor = true;
            this.btRegistr.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Регистрация ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин";
            // 
            // TBPasswordReg
            // 
            this.TBPasswordReg.Location = new System.Drawing.Point(218, 133);
            this.TBPasswordReg.Name = "TBPasswordReg";
            this.TBPasswordReg.Size = new System.Drawing.Size(194, 22);
            this.TBPasswordReg.TabIndex = 12;
            // 
            // TBLoginReg
            // 
            this.TBLoginReg.Location = new System.Drawing.Point(218, 95);
            this.TBLoginReg.MaxLength = 50;
            this.TBLoginReg.Name = "TBLoginReg";
            this.TBLoginReg.Size = new System.Drawing.Size(194, 22);
            this.TBLoginReg.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // CBAdmin
            // 
            this.CBAdmin.AutoSize = true;
            this.CBAdmin.Location = new System.Drawing.Point(218, 161);
            this.CBAdmin.Name = "CBAdmin";
            this.CBAdmin.Size = new System.Drawing.Size(202, 20);
            this.CBAdmin.TabIndex = 7;
            this.CBAdmin.Text = "Хочу быть Библиотекарем";
            this.CBAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 355);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Вход\\Регистрация";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox CBAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassworBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label12266332;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btRegistr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPasswordReg;
        private System.Windows.Forms.TextBox TBLoginReg;
        private System.Windows.Forms.Label label5;
    }
}

