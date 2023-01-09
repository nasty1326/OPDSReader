using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using System.Xml;
using System.Data.SqlClient;
using System.Net;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Data.SqlTypes;

namespace OPDSReader
{
    public partial class Podbor : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;
        public Podbor(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
        }
        public int colomn = 1;
        public int row = 1;
        private void ReadSingleRow(IDataRecord record)
        {
            int ID = record.GetInt32(0);
            Panel panel = new Panel();
            panel.Size = new System.Drawing.Size(250, 150);
            panel.Location = new System.Drawing.Point(colomn*250-250, row*150-150);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            colomn++;
            if (colomn == 4)
            {
                colomn = 1;
                row++;
            }
            panel.SuspendLayout();

            Label labelName = new Label();
            labelName.AutoSize = true;
            labelName.Location = new System.Drawing.Point(5, 5);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(44, 16);
            labelName.TabIndex = 0;
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            labelName.Text = record.GetString(1);
            

            Label labelAbout = new Label();
            labelAbout.AutoSize = true;
            labelAbout.MaximumSize = new System.Drawing.Size(220, 0);
            labelAbout.Location = new System.Drawing.Point(5, 30);
            labelAbout.Name = "labelAbout";
            labelAbout.Size = new System.Drawing.Size(44, 16);
            labelAbout.TabIndex = 0;
            labelAbout.Text ="Описание: "+ record.GetString(2);

            Label labelAuthor = new Label();
            labelAuthor.AutoSize = true;
            labelAuthor.Location = new System.Drawing.Point(5, 105);
            labelAuthor.Name = "labelAbout";
            labelAuthor.Size = new System.Drawing.Size(44, 16);
            labelAuthor.TabIndex = 0;
            labelAuthor.Text ="Автор: " + record.GetString(4);            

            Button btOpen = new Button();
            btOpen.Dock = System.Windows.Forms.DockStyle.Bottom;
            btOpen.Location = new System.Drawing.Point(0, 125);
            btOpen.Name = "btOpen";
            btOpen.Size = new System.Drawing.Size(250, 25);
            btOpen.TabIndex = 3;
            btOpen.Text = "Открыть";
            btOpen.UseVisualStyleBackColor = true;
            btOpen.UseVisualStyleBackColor = true;
            btOpen.Click += (s, e) => { OpenCardPodbor(ID); }; ;

            this.Controls.Add(panel);
            panel.Controls.Add(labelName);
            panel.Controls.Add(labelAuthor);
            panel.Controls.Add(labelAbout);
            panel.Controls.Add(btOpen);
        }
        private void Podbor_Load(object sender, EventArgs e)
        {

            string queryString = $"select * from podbor";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(reader);
            }

            reader.Close();

        }

        private void OpenCardPodbor ( int id)
        {
            Form form = new CardsPodbor(id, _user);
            form.ShowDialog();

        }

    }
}
