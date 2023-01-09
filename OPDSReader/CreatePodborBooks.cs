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
    public partial class CreatePodborBooks : Form
    {

        private readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public CreatePodborBooks(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
        }

        private void btCreatePodborNow_Click(object sender, EventArgs e)
        {
            string namePodbor = tbNamePodbor.Text.ToString();
            string aboutPodbor = tbAboutPodbor.Text.ToString();

            //Заносим информацию о подборке в базу подборок
            string querystring = $"insert into podbor (name_podbor, about_podbor,id_author,author) values ('{namePodbor}', '{aboutPodbor}','{_user.IDuser}','{_user.Login}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            command.ExecuteNonQuery();


           // Получаем данные об ID подборки

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string idstring = $"select id_podbor from podbor where name_podbor = '{namePodbor}' and about_podbor='{aboutPodbor}'";


            SqlCommand commands = new SqlCommand(idstring, dataBase.getConnection());

            adapter.SelectCommand = commands;
            adapter.Fill(table);
            int id_Podbor;
            id_Podbor = Convert.ToInt32(table.Rows[0].ItemArray[0].ToString());
            //Заносим информаци о книгах в подборке
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string querystring1 = $"insert into bookinpodbor (id_podborbook, id_books) values ('{id_Podbor}', '{dataGridView1[0, i].Value.ToString()}')";
                SqlCommand command6 = new SqlCommand(querystring1, dataBase.getConnection());
                command6.ExecuteNonQuery();

            }

            MessageBox.Show("Подборка создана", "Успех");
            
            dataBase.closeConnection();

        }
        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(false,record.GetString(1), record.GetString(2), record.GetString(3) + " " + record.GetString(4));
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from books where concat (titleBook,authorName, authorSurname) like '%" + tbPoisk.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"select * from books";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }
        private void CreatePodborBooks_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridViewPodbor);
        }

        private void tbPoisk_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridViewPodbor);
        }
        static public string idbookSite;
        private void dataGridViewPodbor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPodbor.Columns[e.ColumnIndex].Name == "vibor")
            {
                dataGridView1.Rows.Add(dataGridViewPodbor[1, e.RowIndex].Value.ToString(), dataGridViewPodbor[2, e.RowIndex].Value.ToString(), dataGridViewPodbor[3, e.RowIndex].Value.ToString());
                dataGridViewPodbor[0, e.RowIndex].Value=null;
            }
            if (dataGridViewPodbor.Columns[e.ColumnIndex].Name == "OpenBooks")
            {
                string idbookSite;
                idbookSite = dataGridViewPodbor[1, e.RowIndex].Value.ToString();
                Form form = new CardBook(_user, idbookSite);
                form.ShowDialog();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deletebookIn")
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "openbookIn")
            {

                string idbookSite;
                idbookSite = dataGridView1[0, e.RowIndex].Value.ToString();
                Form form = new CardBook(_user, idbookSite);
                form.ShowDialog();
            }

        }
    }
}
