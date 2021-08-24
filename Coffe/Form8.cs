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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Coffe". При необходимости она может быть перемещена или удалена.
            this.coffeTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Coffe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Order_Check". При необходимости она может быть перемещена или удалена.
            this.order_CheckTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Order_Check);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }
    }
}
