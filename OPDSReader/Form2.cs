using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.Net;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Data.SqlTypes;


namespace OPDSReader
{
    
    public partial class Form2 : Form
    {
        private readonly checkUser _user;
        DataBase dataBase = new DataBase();
        public Form2(checkUser user)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _user = user; 
        }
        private void IsAdmin()
        {
            btCreatePodbor.Enabled=_user.IsAdmin;
            btCreatePodbor.Visible = _user.IsAdmin;
        }
        public class Catalog
        {

            public string Name { get; set; } //название каталога
            public string SubName { get; set; } // подзаголовок каталога
            public string URLPictureCatalog { get; set; } // иконка каталога 
            public string URLSearch { get; set; } // ссылка на поиск  

            public Url URLPicturesC { get; set; }
            public Url URLSearchC { get; set; }

        }
        public Url StringToURL(string s)
        {
            Url uri = new Url(s);
            return uri;
        }
        public class Genre
        {
            public string Name { get; set; }
            public string URLGenre { get; set; }
            public string Content { get; set; }
            public string ID { get; set; }
        }

        public class Book
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public string Content { get; set; }
            public string URLPicturesBook { get; set; }
            public string URLSaveBook { get; set; }
            public string Author { get; set; }
            public string TitleName { get; set; }
            public string AuthorName { get; set; }
            public string AuthorSurname { get; set; }
            public List<String> Genre { get; set; }

        }
        public void TitleAndAuthor(Book b)
        {
            b.Name=b.Name.Replace("[fb2, ePub]", "");
            string[] words = b.Name.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length ==2)
            {
                b.TitleName = words[0];
                b.Author = words[1];
            }
            if (words.Length == 1)
            {
                b.TitleName = words[0];
                b.Author = "Unknown";
            }
            if (words.Length == 0)
            {
                b.TitleName = b.Name;
                b.Author = "Unknown";
            }
            if (words.Length > 2)
            {
                b.TitleName = b.Name;
                b.Author = "Unknown";
            }

            if (b.Author ==  "Unknown")
            {
                b.AuthorName = "Unknown";
                b.AuthorSurname = "Unknown";
            } else
            {
                string[] words1 = b.Author.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (words1.Length == 1)
                {
                    b.AuthorSurname=b.Author;
                    b.AuthorName = "Unknown";
                }
                if (words1.Length == 2)
                {
                    b.AuthorName = words1[0];
                    b.AuthorSurname = words1[1];
                }
                if (words1.Length > 2)
                {
                    string strg = "";
                    for (int i = 1; i < words1.Length; i++)
                    {
                        strg = strg + words1[i];
                    }
                    b.AuthorName = words1[0];
                    b.AuthorSurname = strg;
                }
            }  
        }

        public string contenttext;
        public int non = 0;
        Book bojk = new Book();
        

        public void SearchGenre(Book b)
        {
            string con = b.Content;
            b.Genre = new List<string>();

            int indexOfSubstring = -1;
            indexOfSubstring = con.IndexOf("Жанр:");

            if (indexOfSubstring == -1)
            {
                indexOfSubstring = con.IndexOf("жанр:");
            }
            //if (indexOfSubstring == -1)
            //{
            //    non ++;
            //}
            //  
            if (indexOfSubstring != -1)
            {
                if (indexOfSubstring != 0)
                {
                    con = con.Remove(0, indexOfSubstring-1);
                }
                
                int indexOfEnd = -1;
                indexOfEnd = con.IndexOf("\n");
                if (indexOfEnd != -1)
                {
                    con = con.Remove(indexOfEnd);

                }
                int indexOfS = -1;
                indexOfS = con.IndexOf(":");
                if (indexOfS != -1)
                {
                    con = con.Remove(0, indexOfS + 1);
                }
                if (con.Length > 0)
                {
                    if (con[0] == ' ')
                    {
                        con = con.Remove(0, 1);
                    }
                }

                if (con.Length > 0)
                {
                    int indexZap = -1;
                    indexZap = con.IndexOf(",");

                    if ((indexZap == -1))
                    {
                        char[] charsToTrim = { ':', ' ', ';' };
                        string result = con.Trim(charsToTrim);
                        b.Genre.Add(result);
                    }
                    else
                    {
                        while (con.Length > 0)
                        {
                            if (indexZap != -1)
                            {
                                string n = con.Substring(0, indexZap);
                                char[] charsToTrim = { ':', ' ', ';' };
                                string result = n.Trim(charsToTrim);

                                b.Genre.Add(result);
                                con = con.Remove(0, indexZap + 1);
                                if (con.Length > 0)
                                {
                                    if (con[0] == ' ')
                                    {
                                        con = con.Remove(0, 1);
                                    }
                                }
                                con.ToUpper();
                                indexZap = -1;
                                indexZap = con.IndexOf(",");
                            }
                            else
                            {
                                string n = con;
                                char[] charsToTrim = { ':', ' ', ';' };
                                string result = n.Trim(charsToTrim);
                                b.Genre.Add(result);
                                con = "";
                            }

                        }

                    }

                }
            }


        }
        public void ReadXMLAll()
        {
            string searchString = "Delete from [opdsDATA].[dbo].[books]";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            

            string searchStringa = "Delete from [opdsDATA].[dbo].[genrebooks]";

            SqlCommand coms = new SqlCommand(searchStringa, dataBase.getConnection());
            SqlDataReader read = com.ExecuteReader();

            read.Close();
            // загружаем библиотеку
            XmlDocument doc = new XmlDocument();

            var xmlContent = File.ReadAllText("D:\\lib.xml");
            xmlContent = xmlContent.Replace("k&R", "-");
            doc.LoadXml(xmlContent);

            Catalog catalog = new Catalog(); // создаем каталог
            List<Genre> genres = new List<Genre>(); // создаем список сортировок и выборок
            List<Book> book = new List<Book>(); // создаем список книг
            XmlElement element = doc.DocumentElement;
            dataBase.openConnection();
            foreach (XmlNode node in element)
            {
                //Считываем Данные о библиотеке

                if (node.Name == "title") { catalog.Name = node.InnerText; }
                if (node.Name == "subtitle") catalog.SubName = node.InnerText;
                if (node.Name == "icon") catalog.URLPictureCatalog = node.InnerText;
                if (node.Name == "link" && node.Attributes.GetNamedItem("type").InnerText == "application/atom+xml")
                {
                    catalog.URLSearch = node.Attributes.GetNamedItem("href").InnerText;
                }

                //Считываем данные о разделах

                if (node.Name == "entry" && node.ChildNodes.Count == 6)
                {
                    Genre gen = new Genre();
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if (node2.Name == "title") gen.Name = node2.InnerText;
                        if (node2.Name == "link" && node2.Attributes.GetNamedItem("type").InnerText == "application/atom+xml;profile=opds-catalog")
                        {
                            gen.URLGenre = node2.Attributes.GetNamedItem("href").InnerText;
                        }
                        if (node2.Name == "id") gen.ID = node2.InnerText;
                        if (node2.Name == "content") gen.Content = node2.InnerText;
                    }
                    genres.Add(gen);




                    XmlDocument docs = new XmlDocument();

                    string xmlCon;
                    using (var webClient = new WebClient())
                    {
                        webClient.Encoding = System.Text.Encoding.UTF8;
                        xmlCon = webClient.DownloadString(gen.URLGenre);
                    }
                    xmlCon = xmlCon.Replace("k&R", "-");
                    docs.LoadXml(xmlCon);
                    XmlElement elementcat = docs.DocumentElement;
                    foreach (XmlNode node3 in elementcat)
                    {
                        if (node3.Name == "entry")
                        {
                            Book bo = new Book();
                            foreach (XmlNode node4 in node3.ChildNodes)
                            {
                                if (node4.Name == "title") bo.Name = node4.InnerText;
                                if (node4.Name == "id") bo.ID = node4.InnerText;
                                if (node4.Name == "content") bo.Content = node4.InnerText;
                                if (node4.Name == "link" && node4.Attributes.GetNamedItem("type").InnerText == "image/jpg")
                                {
                                    bo.URLPicturesBook = node4.Attributes.GetNamedItem("href").InnerText;
                                }
                                if (node4.Name == "link" && node4.Attributes.GetNamedItem("type").InnerText == "application/fb2+zip")
                                {
                                    bo.URLSaveBook = node4.Attributes.GetNamedItem("href").InnerText;
                                }

                            }
                            if (bo.Name != "?")
                            {
                                book.Add(bo);
                            }
                            
                        }
                    }
                }
                //Считываем данные о книгах

                if (node.Name == "entry" && node.ChildNodes.Count == 11)
                {
                    Book bo = new Book();
                    foreach (XmlNode node2 in node.ChildNodes)
                    {
                        if (node2.Name == "title") bo.Name = node2.InnerText;
                        if (node2.Name == "id") bo.ID = node2.InnerText;
                        if (node2.Name == "content") bo.Content = node2.InnerText;
                        if (node2.Name == "link" && node2.Attributes.GetNamedItem("type").InnerText == "image/jpg")
                        {
                            bo.URLPicturesBook = node2.Attributes.GetNamedItem("href").InnerText;
                        }
                        if (node2.Name == "link" && node2.Attributes.GetNamedItem("type").InnerText == "application/fb2+zip")
                        {
                            bo.URLSaveBook = node2.Attributes.GetNamedItem("href").InnerText;
                        }

                    }
                    book.Add(bo);
                }
            }
            Console.WriteLine(book.Count);


            for (int i = 0; i < book.Count; i++)
            {
                 
                TitleAndAuthor(book[i]);
                
                SearchGenre(book[i]);

                string sql = "INSERT INTO books (titlebook,authorName,authorSurname ,contentBook,URLPicturesBook,URLSaveBook,idbook) VALUES(@param1,@param2,@param21,@param3,@param4,@param5,@param6)";
                using (SqlCommand cmd = new SqlCommand(sql, dataBase.getConnection()))
                {
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 100).Value = book[i].TitleName;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = book[i].AuthorName;
                    cmd.Parameters.Add("@param21", SqlDbType.VarChar, 50).Value = book[i].AuthorSurname;
                    cmd.Parameters.Add("@param3", SqlDbType.VarChar, 2000).Value = book[i].Content;
                    cmd.Parameters.Add("@param4", SqlDbType.VarChar, 1000).Value = book[i].URLPicturesBook;
                    cmd.Parameters.Add("@param5", SqlDbType.VarChar, 1000).Value = book[i].URLSaveBook;
                    cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = book[i].ID;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }

                for (int j = 0; j < book[i].Genre.Count; j++)
                {
                    string sqlt = "INSERT INTO genrebooks (idbook,genre) VALUES(@param15,@param16)";
                    using (SqlCommand cmd = new SqlCommand(sqlt, dataBase.getConnection()))
                    {
                        cmd.Parameters.Add("@param15", SqlDbType.VarChar, 50).Value = book[i].ID;
                        cmd.Parameters.Add("@param16", SqlDbType.VarChar, 150).Value = book[i].Genre[j];                    
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            string sqldub = "DELETE T\r\nFROM\r\n(\r\nSELECT *\r\n, DupRank = ROW_NUMBER() OVER (\r\n              PARTITION BY idbook\r\n              ORDER BY (SELECT NULL)\r\n            )\r\nFROM books\r\n) AS T\r\nWHERE DupRank > 1 ";
            using (SqlCommand cmd = new SqlCommand(sqldub, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            string sqldubgenre = "DELETE T\r\nFROM\r\n(\r\nSELECT *\r\n, DupRank = ROW_NUMBER() OVER (\r\n              PARTITION BY idbook\r\n              ORDER BY (SELECT NULL)\r\n            )\r\nFROM [opdsDATA].[dbo].[genrebooks]\r\n) AS T\r\nWHERE DupRank > 1  ";
            using (SqlCommand cmd = new SqlCommand(sqldubgenre, dataBase.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }

            dataBase.closeConnection();

            MessageBox.Show("Все");
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            ReadXMLAll();
            
        }



        private void ReadSingleRow(DataGridView dwg, IDataRecord record)
        {
            dwg.Rows.Add(record.GetString(1),record.GetString(2), record.GetString(3) + " " + record.GetString(4));            
        }
        private void ReadSingleRowGenre(DataGridView dwg, IDataRecord record)
        {
            string n = record.GetString(0);
            dwg.Rows.Add(n);
        }

        private void ReadSingleRow2(List<string> dwg, IDataRecord record)
        {
            string n = record.GetString(0);
            dwg.Add(n);
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"select * from books";
            SqlCommand command= new SqlCommand(queryString,dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            RefreshDataGridGenre(dataGridViewGenre);
            IsAdmin();
            lbWellcome.Text = "Здравствуйте, " + _user.Login + "!";
        }

        private void RefreshDataGridGenre (DataGridView dgv)
        {
            dgv.Rows.Clear();
            string queryString = $"select distinct genre from [opdsDATA].[dbo].[genrebooks]";
            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRowGenre(dgv, reader);
            }

            reader.Close();
        }
        private void Search (DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"select * from books where concat (titleBook,authorName, authorSurname) like '%" + textBox1.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        public string searchgenre;
        private void dataGridViewGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            searchgenre = dataGridViewGenre[0, e.RowIndex].Value.ToString();
            dataGridView1.Rows.Clear();
            string s = $"select * from [opdsDATA].[dbo].[genrebooks] where genre='" + searchgenre + "'";
            SqlCommand com = new SqlCommand(s, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            List <string> listID = new List<string>();
            while (read.Read())
            {
                ReadSingleRow2(listID, read);
            }
            read.Close();

            for (int i= 0; i < listID.Count; i++)
            {
                string q = $"select * from [opdsDATA].[dbo].[books] where idbook='" + listID[i] + "'";
                SqlCommand comn = new SqlCommand(q, dataBase.getConnection());
                dataBase.openConnection();
                SqlDataReader reads = comn.ExecuteReader();
                while (reads.Read())
                {
                    ReadSingleRow(dataGridView1, reads);
                }
                reads.Close();
            }

        }

        private void btAllBooks_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void btCreatePodbor_Click(object sender, EventArgs e)
        {
            Form form = new CreatePodborBooks(_user);
            form.ShowDialog();
        }

        private void btPodbor_Click(object sender, EventArgs e)
        {
            Form form = new Podbor(_user);
            form.ShowDialog();
        }
        public Form form4;
        private void btLichCab_Click(object sender, EventArgs e)
        {
            form4 = new Form4(_user);
            form4.ShowDialog();
        }
    }
}
