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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OPDSReader
{
    public partial class CardsPodbor : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;

        public int IDPodbor { get; set; }
        public CardsPodbor(int IdPodbor, checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            IDPodbor = IdPodbor;
            _user = user;
        }

        private void ReadSingleRow(IDataRecord record)
        {
            lbNamePodbor.Text=record.GetString(1);
            lbAbout.Text = record.GetString(2);
            lbAuthor.Text= "Автор: "+record.GetString(4);
            Text = record.GetString(1);
        }

        private void ReadSingleRow2(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetString(1), record.GetString(2), record.GetString(3) + " " + record.GetString(4));
        }

        private List<string> IDBOOK=new List<string>();
        private void ReadSingleRowBook15(IDataRecord record)
        {
            string n = record.GetString(1).ToString();
            IDBOOK.Add(n);
        }

        private void CardsPodbor_Load(object sender, EventArgs e)
        {
            string searchString = "select * from podbor where id_podbor = '" + IDPodbor + "'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(read);
            }
            read.Close();

            string searchString1 = "select * from bookinpodbor where id_podborbook = '" + IDPodbor + "'";

            SqlCommand com1 = new SqlCommand(searchString1, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read1 = com1.ExecuteReader();
            while (read1.Read())
            {
                ReadSingleRowBook15(read1);
            }
            read1.Close();

            for (int i=0; i < IDBOOK.Count; i++)
            {
                string searchString2 = "select * from books where idbook = '" + IDBOOK[i] + "'";

                SqlCommand com2 = new SqlCommand(searchString2, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader read12 = com2.ExecuteReader();
                while (read12.Read())
                {
                    ReadSingleRow2(read12);
                }
                read12.Close();
            }
            
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
    }
}
