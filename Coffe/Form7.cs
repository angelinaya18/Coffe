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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.providerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cOFFE_HOUSEDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Запись не обновилась");

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Provider);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
        }
    }
}
