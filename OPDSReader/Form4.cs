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
using Application = System.Windows.Forms.Application;

namespace OPDSReader
{
    public partial class Form4 : Form
    {

        private readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public Form4(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            //Form1.form2.Close();
            //Form form = new Form1();
            //form.ShowDialog();

            //this.Close();
            
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name == "Form4")
                    Application.OpenForms[i].Hide();
                if (Application.OpenForms[i].Name == "Form2")
                    Application.OpenForms[i].Hide();
            }
            Form form = new Form1();
            form.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lbWellcome.Text = _user.Login;
            IsAdmin();
        }
        private void IsAdmin()
        {
            btMyPodbor.Enabled = _user.IsAdmin;
            btMyPodbor.Visible = _user.IsAdmin;
        }

        private List<string> IDBOOK = new List<string>();
        private void ReadSingleRow(IDataRecord record)
        {
            string n = record.GetString(1).ToString();
            IDBOOK.Add(n);
        }
        private void ReadSingleRow1(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetString(1), record.GetString(2), record.GetString(3) + " " + record.GetString(4));
        }

        private void btFavouriteBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string searchString = "select * from favoritebook where id_user = '" + _user.IDuser + "'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(read);
            }
            read.Close();

            for (int i = 0; i < IDBOOK.Count; i++)
            {
                string searchString2 = "select * from books where idbook = '" + IDBOOK[i] + "'";

                SqlCommand com2 = new SqlCommand(searchString2, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read12 = com2.ExecuteReader();
                while (read12.Read())
                {
                    ReadSingleRow1(read12);
                }
                read12.Close();
            }
            IDBOOK.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "OpenBook")
            {
                string idbookSite;
                idbookSite = dataGridView1[0, e.RowIndex].Value.ToString();
                Form form = new CardBook(_user, idbookSite);
                form.ShowDialog();
            }
        }

        private void btSaveBooks_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string searchString = "select * from savebook where id_user = '" + _user.IDuser + "'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(read);
            }
            read.Close();

            for (int i = 0; i < IDBOOK.Count; i++)
            {
                string searchString2 = "select * from books where idbook = '" + IDBOOK[i] + "'";

                SqlCommand com2 = new SqlCommand(searchString2, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read12 = com2.ExecuteReader();
                while (read12.Read())
                {
                    ReadSingleRow1(read12);
                }
                read12.Close();
            }
            IDBOOK.Clear();
        }

        private void btMyPodbor_Click(object sender, EventArgs e)
        {
            Form form = new MyPodbor( _user);
            form.ShowDialog();
        }
    }
    
}
