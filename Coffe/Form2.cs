using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe
{
    public partial class Form2 : Form
    {
        Boolean flag;
        public Form2(Boolean prov)
        {
            InitializeComponent();
            flag = prov;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_cof_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(flag);
            f3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Form5 f5 = new Form5();
                f5.Show();
            }
            else
            {
                MessageBox.Show("Вам запрещён доступ к данным о сотрудниках!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(flag);
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Form7 f7 = new Form7();
                f7.Show();
            }
            else
            {
                MessageBox.Show("Вам запрещён доступ к данным о поставщиках!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Form8 f8 = new Form8();
                f8.Show();
            }
            else
            {
                MessageBox.Show("Вам запрещён доступ к данным о заказах!");
            }
        }
    }
}
