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
using Microsoft.SqlServer.Server;

namespace Coffe
{
    public partial class Form3 : Form
    {
        Boolean flagG;
        public Form3(Boolean flag)
        {
            InitializeComponent();
            if (flag == false)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                coffeBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }
            flagG = flag;
        }

        private void coffeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.coffeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cOFFE_HOUSEDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Запись не обновилась");

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Coffe_Rating". При необходимости она может быть перемещена или удалена.
            //this.coffe_RatingTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Coffe_Rating);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Coffe". При необходимости она может быть перемещена или удалена.
            this.coffeTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Coffe);

        }

        private void button_rating_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(flagG);
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void coffe_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string Coffe_Name = coffe_nameTextBox.Text;
            string connectionString = @"Data Source=LAPTOP-4DLJ461I\SQLEXPRESS;Initial Catalog=COFFE_HOUSE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
          
            string chechcmd = String.Format("DELETE FROM Coffe WHERE Coffe_name = ('{0}')",Coffe_Name);
            SqlCommand check = new SqlCommand(chechcmd, connection);
            connection.Open();
            check.Prepare();
            check.ExecuteNonQuery();
            MessageBox.Show("Кофейня удалена");
        }
    }
}
