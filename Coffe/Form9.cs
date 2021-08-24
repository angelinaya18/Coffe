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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "COFFE_HOUSEDataSet.Checks". При необходимости она может быть перемещена или удалена.
            this.ChecksTableAdapter.Fill(this.COFFE_HOUSEDataSet.Checks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "COFFE_HOUSEDataSet.Order_Check". При необходимости она может быть перемещена или удалена.
            this.Order_CheckTableAdapter.Fill(this.COFFE_HOUSEDataSet.Order_Check);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "COFFE_HOUSEDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.OrdersTableAdapter.Fill(this.COFFE_HOUSEDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "COFFE_HOUSEDataSet.Food". При необходимости она может быть перемещена или удалена.
            this.FoodTableAdapter.Fill(this.COFFE_HOUSEDataSet.Food);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
