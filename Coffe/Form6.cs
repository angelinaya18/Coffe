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
    public partial class Form6 : Form
    {
        public Form6(Boolean flag)
        {
            InitializeComponent();
            if (flag == false)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                foodBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = false;
            }
        }

        private void foodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.foodBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cOFFE_HOUSEDataSet);
                MessageBox.Show("Сохранено");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Запись не обновилась");
            }

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Coffe". При необходимости она может быть перемещена или удалена.
            this.coffeTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Coffe);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cOFFE_HOUSEDataSet.Food". При необходимости она может быть перемещена или удалена.
            this.foodTableAdapter.Fill(this.cOFFE_HOUSEDataSet.Food);

        }

        private void food_nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
