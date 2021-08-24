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
    public partial class Form4 : Form
    {
        public Form4(Boolean flag)
        {
            InitializeComponent();
            if (flag == false)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                coffe_RatingBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Coffe_Rating". При необходимости она может быть перемещена или удалена.
            this.coffe_RatingTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Coffe_Rating);

        }

        private void coffe_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void coffe_nameLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
        }
    }
}
