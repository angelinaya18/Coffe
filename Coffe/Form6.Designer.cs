namespace Coffe
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label food_nameLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label kbzhuLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.foodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.FoodTableAdapter();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.coffeTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.CoffeTableAdapter();
            this.foodBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.foodBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.food_nameTextBox = new System.Windows.Forms.TextBox();
            this.kbzhuTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.coffeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            food_nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            kbzhuLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingNavigator)).BeginInit();
            this.foodBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // food_nameLabel
            // 
            food_nameLabel.AutoSize = true;
            food_nameLabel.Location = new System.Drawing.Point(74, 161);
            food_nameLabel.Name = "food_nameLabel";
            food_nameLabel.Size = new System.Drawing.Size(134, 20);
            food_nameLabel.TabIndex = 1;
            food_nameLabel.Text = "Название блюда";
            food_nameLabel.Click += new System.EventHandler(this.food_nameLabel_Click);
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(159, 228);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Цена";
            // 
            // kbzhuLabel
            // 
            kbzhuLabel.AutoSize = true;
            kbzhuLabel.Location = new System.Drawing.Point(153, 300);
            kbzhuLabel.Name = "kbzhuLabel";
            kbzhuLabel.Size = new System.Drawing.Size(51, 20);
            kbzhuLabel.TabIndex = 5;
            kbzhuLabel.Text = "КБЖУ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(130, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 9;
            label1.Text = "Кофейня";
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodBindingSource
            // 
            this.foodBindingSource.DataMember = "Food";
            this.foodBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // foodTableAdapter
            // 
            this.foodTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoffeTableAdapter = this.coffeTableAdapter;
            this.tableAdapterManager.CooperatorTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = this.foodTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // coffeTableAdapter
            // 
            this.coffeTableAdapter.ClearBeforeFill = true;
            // 
            // foodBindingNavigator
            // 
            this.foodBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.foodBindingNavigator.BindingSource = this.foodBindingSource;
            this.foodBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.foodBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.foodBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.foodBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.foodBindingNavigatorSaveItem});
            this.foodBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.foodBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.foodBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.foodBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.foodBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.foodBindingNavigator.Name = "foodBindingNavigator";
            this.foodBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.foodBindingNavigator.Size = new System.Drawing.Size(487, 27);
            this.foodBindingNavigator.TabIndex = 0;
            this.foodBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(56, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // foodBindingNavigatorSaveItem
            // 
            this.foodBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foodBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("foodBindingNavigatorSaveItem.Image")));
            this.foodBindingNavigatorSaveItem.Name = "foodBindingNavigatorSaveItem";
            this.foodBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.foodBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.foodBindingNavigatorSaveItem.Click += new System.EventHandler(this.foodBindingNavigatorSaveItem_Click);
            // 
            // food_nameTextBox
            // 
            this.food_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Food_name", true));
            this.food_nameTextBox.Location = new System.Drawing.Point(214, 158);
            this.food_nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.food_nameTextBox.Name = "food_nameTextBox";
            this.food_nameTextBox.Size = new System.Drawing.Size(165, 26);
            this.food_nameTextBox.TabIndex = 2;
            // 
            // kbzhuTextBox
            // 
            this.kbzhuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Kbzhu", true));
            this.kbzhuTextBox.Location = new System.Drawing.Point(214, 296);
            this.kbzhuTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kbzhuTextBox.Name = "kbzhuTextBox";
            this.kbzhuTextBox.Size = new System.Drawing.Size(165, 26);
            this.kbzhuTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(214, 228);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(165, 26);
            this.priceTextBox.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.foodBindingSource, "Coffe_id", true));
            this.comboBox1.DataSource = this.coffeBindingSource;
            this.comboBox1.DisplayMember = "Coffe_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 96);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "Coffe_id";
            // 
            // coffeBindingSource
            // 
            this.coffeBindingSource.DataMember = "Coffe";
            this.coffeBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(487, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(kbzhuLabel);
            this.Controls.Add(this.kbzhuTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(food_nameLabel);
            this.Controls.Add(this.food_nameTextBox);
            this.Controls.Add(this.foodBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form6";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodBindingNavigator)).EndInit();
            this.foodBindingNavigator.ResumeLayout(false);
            this.foodBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource foodBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.FoodTableAdapter foodTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator foodBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton foodBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox food_nameTextBox;
        private System.Windows.Forms.TextBox kbzhuTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private COFFE_HOUSEDataSetTableAdapters.CoffeTableAdapter coffeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource coffeBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}