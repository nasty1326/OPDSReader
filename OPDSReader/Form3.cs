using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Security.Policy;
using System.Xml;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace OPDSReader
{ 

    public partial class CardBook : Form
    {
        private readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public string idbooks;
        public CardBook(checkUser user, string idbook)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            idbooks = idbook;
        }
        public string urlSave;
        private void btSave_Click(object sender, EventArgs e)
        {
            WebClient Client = new WebClient();
            int indexOfChar = 0;
            string urlstring = urlSave;
            do
            {
                indexOfChar = urlstring.IndexOf("/");
                if (indexOfChar != -1)
                {
                    urlstring = urlstring.Remove(0, indexOfChar+1);
                }
            } while (indexOfChar != -1);

            Client.DownloadFile(urlSave, urlstring);

            string querystring = $"insert into savebook (id_user, id_book) values ('{_user.Login}', '{idbooks}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();
            command.ExecuteNonQuery();

            dataBase.closeConnection();

            MessageBox.Show("Книга успешно скачена", "Успех");

        }
        private void ReadSingleRow(IDataRecord record)
        {
            lbTitle.Text = record.GetString(2) + " - " + record.GetString(3) + " " + record.GetString(4);
            lbContent.Text = record.GetString(5);
            pictureBox1.Load(record.GetString(6));
            urlSave = record.GetString(7);
            Text = record.GetString(2) + " - " + record.GetString(3) + " " + record.GetString(4);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string queryString = "select * from books where idbook= '" + idbooks + "'"; 
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(reader);
            }
            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool v = checkBook();
            if (!v)
            {
                string querystring = $"insert into favoritebook (id_user, id_book) values ('{_user.Login}', '{idbooks}')";

                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Книга успешно добавлена в Избранное", "Успех");
                }
                else
                {
                    MessageBox.Show("Ошибка");
                }
                dataBase.closeConnection();
            }           
        }
        private Boolean checkBook()
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, id_book from favoritebook where id_user = '{_user.Login}' and id_book='{idbooks}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Книга уже в Избранном");
                return true;
            }
            else { return false; }
        }
    }
}
