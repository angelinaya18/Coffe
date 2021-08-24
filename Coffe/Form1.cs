using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Coffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prov_Click(object sender, EventArgs e)
        {
            string User = user.Text;
            string Password = password.Text;
            string connectionString = @"Data Source=LAPTOP-4DLJ461I\SQLEXPRESS;Initial Catalog=COFFE_HOUSE;Integrated Security=True";
            string chechcmd = String.Format("Select * from Users where login = '{0}' and password = '{1}'", User, Password);
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand check = new SqlCommand(chechcmd, connection);
            connection.Open();
            check.Prepare();
            check.ExecuteNonQuery();
            if (check.ExecuteScalar() == null)
            {
                MessageBox.Show("Учетная запись не найдена! Проверьте правильность введенных данных.");

            }
            else
            {
                if (1==(int)check.ExecuteScalar())
                {
                    MessageBox.Show("Вы вошли под учетной записью администратора");
                    Form2 f2 = new Form2(true);
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("Вы вошли под учетной записью гость. Ваш разрешен режим просмотра.");
                    Form2 f2 = new Form2(false);
                    f2.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
