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

namespace Coffe
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void cooperatorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cooperatorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cOFFE_HOUSEDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Coffe". При необходимости она может быть перемещена или удалена.
            this.coffeTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Coffe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Cooperator". При необходимости она может быть перемещена или удалена.
            this.cooperatorTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Cooperator);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cooperatorBindingSource.RemoveCurrent();
        }

        private void coffe_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cooperatorBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cooperatorBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cooperatorBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cooperatorBindingSource.MoveLast();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cooperatorBindingSource.AddNew();
            /*string Surname = surnameTextBox.Text;
            string Name = nameTextBox.Text;
            string Middle_name = middle_nameTextBox.Text;
            string Id = comboBox1.Text;
            string Salary = salaryTextBox.Text;

            string Position = positionTextBox.Text;
            
            string connectionString = @"Data Source=LAPTOP-4DLJ461I\SQLEXPRESS;Initial Catalog=COFFE_HOUSE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string chechcmd = String.Format("INSERT INTO Cooperator(Coffe_id, Position, Surname, Name, Middle_name, Salary) VALUES(('{0}'), ('{0}'), ('{0}'), ('{0}'), ('{0}'), ('{0}'))",Id, Position,Surname,Name,Middle_name,Salary);
            SqlCommand check = new SqlCommand(chechcmd, connection);
            connection.Open();
            check.Prepare();
            check.ExecuteNonQuery();
            MessageBox.Show("Сотрудник добавлен");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Сотрудник не добавлен");
            }*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cooperatorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cOFFE_HOUSEDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Не удалось сохранить");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Company = company.Text;
            string connectionString = @"Data Source=LAPTOP-4DLJ461I\SQLEXPRESS;Initial Catalog=COFFE_HOUSE;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            string chechcmd = String.Format("SELECT dbo.[AVG_Salary] ('{0}')", Company);
            SqlCommand check = new SqlCommand(chechcmd, connection);
            connection.Open();
            check.Prepare();
            check.ExecuteNonQuery();
            MessageBox.Show("Средняя зарплата: "+check.ExecuteScalar().ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
        }
    }
}
