using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPDSReader
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        //АВТОРИЗАЦИЯ
        public static Form form2;
        private void btRegistr_Click(object sender, EventArgs e)
        {
            var loginUser = loginBox.Text;
            var passUser = PassworBox.Text;
            

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user='{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);


            
            if (table.Rows.Count == 1)
            {
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3].ToString()), Convert.ToInt32(table.Rows[0].ItemArray[0].ToString()));

                form2 = new Form2(user);
                form2.ShowDialog();
                //this.Hide();
                this.Close();
                
                
            }
            else
            {
                MessageBox.Show("Аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //РЕГИСТРАЦИЯ
        private void button1_Click(object sender, EventArgs e)
        {
            var login =TBLoginReg.Text;
            var password = TBPasswordReg.Text;
            bool x = CBAdmin.Checked;
           
            string querystring = $"insert into register (login_user, password_user,is_admin) values ('{login}', '{password}','{x}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт Успешно зарегистрирован", "Успех");               
            }
            else
            {
                MessageBox.Show("Аккаунт не зарегистрирован");
            }
            dataBase.closeConnection();

            bool v = checkuser();
        }
        private Boolean checkuser()
        {
            var loginUser = TBLoginReg.Text;
            var passUser = TBPasswordReg.Text;
            bool x = CBAdmin.Checked;
            int p = 0;
            if (x) p = 1;
            var AdminUser = p;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id_user, login_user, password_user, is_admin from register where login_user = '{loginUser}' and password_user='{passUser}' and is_admin='{x}'";

            SqlCommand command=new SqlCommand(querystring,dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь существует");
                return true;
            }
            else { return false; }
        }

    }
}
