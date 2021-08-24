namespace Coffe
{
    partial class Form8
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
            System.Windows.Forms.Label datee_orderLabel;
            System.Windows.Forms.Label time_orderLabel;
            System.Windows.Forms.Label sum_OrderLabel;
            System.Windows.Forms.Label rating_OrderLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.order_CheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_CheckTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Order_CheckTableAdapter();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.coffeTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.CoffeTableAdapter();
            this.order_CheckBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.order_CheckBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.datee_orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_orderTextBox = new System.Windows.Forms.TextBox();
            this.sum_OrderTextBox = new System.Windows.Forms.TextBox();
            this.rating_OrderMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.coffeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            datee_orderLabel = new System.Windows.Forms.Label();
            time_orderLabel = new System.Windows.Forms.Label();
            sum_OrderLabel = new System.Windows.Forms.Label();
            rating_OrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_CheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_CheckBindingNavigator)).BeginInit();
            this.order_CheckBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // datee_orderLabel
            // 
            datee_orderLabel.AutoSize = true;
            datee_orderLabel.ForeColor = System.Drawing.SystemColors.Window;
            datee_orderLabel.Location = new System.Drawing.Point(343, 172);
            datee_orderLabel.Name = "datee_orderLabel";
            datee_orderLabel.Size = new System.Drawing.Size(100, 20);
            datee_orderLabel.TabIndex = 1;
            datee_orderLabel.Text = "Дата заказа";
            // 
            // time_orderLabel
            // 
            time_orderLabel.AutoSize = true;
            time_orderLabel.ForeColor = System.Drawing.SystemColors.Window;
            time_orderLabel.Location = new System.Drawing.Point(331, 230);
            time_orderLabel.Name = "time_orderLabel";
            time_orderLabel.Size = new System.Drawing.Size(112, 20);
            time_orderLabel.TabIndex = 3;
            time_orderLabel.Text = "Время заказа";
            // 
            // sum_OrderLabel
            // 
            sum_OrderLabel.AutoSize = true;
            sum_OrderLabel.ForeColor = System.Drawing.SystemColors.Window;
            sum_OrderLabel.Location = new System.Drawing.Point(324, 291);
            sum_OrderLabel.Name = "sum_OrderLabel";
            sum_OrderLabel.Size = new System.Drawing.Size(119, 20);
            sum_OrderLabel.TabIndex = 5;
            sum_OrderLabel.Text = "Сумма заказа";
            // 
            // rating_OrderLabel
            // 
            rating_OrderLabel.AutoSize = true;
            rating_OrderLabel.ForeColor = System.Drawing.SystemColors.Window;
            rating_OrderLabel.Location = new System.Drawing.Point(285, 346);
            rating_OrderLabel.Name = "rating_OrderLabel";
            rating_OrderLabel.Size = new System.Drawing.Size(158, 20);
            rating_OrderLabel.TabIndex = 7;
            rating_OrderLabel.Text = "Оценка посетителя";
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_CheckBindingSource
            // 
            this.order_CheckBindingSource.DataMember = "Order_Check";
            this.order_CheckBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // order_CheckTableAdapter
            // 
            this.order_CheckTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoffeTableAdapter = this.coffeTableAdapter;
            this.tableAdapterManager.CooperatorTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // coffeTableAdapter
            // 
            this.coffeTableAdapter.ClearBeforeFill = true;
            // 
            // order_CheckBindingNavigator
            // 
            this.order_CheckBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.order_CheckBindingNavigator.BindingSource = this.order_CheckBindingSource;
            this.order_CheckBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order_CheckBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.order_CheckBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.order_CheckBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.order_CheckBindingNavigatorSaveItem});
            this.order_CheckBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_CheckBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_CheckBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_CheckBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_CheckBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_CheckBindingNavigator.Name = "order_CheckBindingNavigator";
            this.order_CheckBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_CheckBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.order_CheckBindingNavigator.TabIndex = 0;
            this.order_CheckBindingNavigator.Text = "bindingNavigator1";
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
            // order_CheckBindingNavigatorSaveItem
            // 
            this.order_CheckBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.order_CheckBindingNavigatorSaveItem.Enabled = false;
            this.order_CheckBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("order_CheckBindingNavigatorSaveItem.Image")));
            this.order_CheckBindingNavigatorSaveItem.Name = "order_CheckBindingNavigatorSaveItem";
            this.order_CheckBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.order_CheckBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // datee_orderDateTimePicker
            // 
            this.datee_orderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_CheckBindingSource, "Datee_order", true));
            this.datee_orderDateTimePicker.Location = new System.Drawing.Point(463, 172);
            this.datee_orderDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datee_orderDateTimePicker.Name = "datee_orderDateTimePicker";
            this.datee_orderDateTimePicker.Size = new System.Drawing.Size(224, 26);
            this.datee_orderDateTimePicker.TabIndex = 2;
            // 
            // time_orderTextBox
            // 
            this.time_orderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CheckBindingSource, "Time_order", true));
            this.time_orderTextBox.Location = new System.Drawing.Point(463, 230);
            this.time_orderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.time_orderTextBox.Name = "time_orderTextBox";
            this.time_orderTextBox.Size = new System.Drawing.Size(112, 26);
            this.time_orderTextBox.TabIndex = 4;
            // 
            // sum_OrderTextBox
            // 
            this.sum_OrderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CheckBindingSource, "Sum_Order", true));
            this.sum_OrderTextBox.Location = new System.Drawing.Point(463, 285);
            this.sum_OrderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sum_OrderTextBox.Name = "sum_OrderTextBox";
            this.sum_OrderTextBox.Size = new System.Drawing.Size(112, 26);
            this.sum_OrderTextBox.TabIndex = 6;
            // 
            // rating_OrderMaskedTextBox
            // 
            this.rating_OrderMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_CheckBindingSource, "Rating_Order", true));
            this.rating_OrderMaskedTextBox.Location = new System.Drawing.Point(463, 340);
            this.rating_OrderMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rating_OrderMaskedTextBox.Mask = "0.00";
            this.rating_OrderMaskedTextBox.Name = "rating_OrderMaskedTextBox";
            this.rating_OrderMaskedTextBox.Size = new System.Drawing.Size(43, 26);
            this.rating_OrderMaskedTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.order_CheckBindingSource, "Coffe_id", true));
            this.comboBox1.DataSource = this.coffeBindingSource;
            this.comboBox1.DisplayMember = "Coffe_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(463, 113);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 28);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "Coffe_id";
            // 
            // coffeBindingSource
            // 
            this.coffeBindingSource.DataMember = "Coffe";
            this.coffeBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(364, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Кофейня";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Location = new System.Drawing.Point(58, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 52);
            this.button1.TabIndex = 11;
            this.button1.Text = "Отчёт чек";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(rating_OrderLabel);
            this.Controls.Add(this.rating_OrderMaskedTextBox);
            this.Controls.Add(sum_OrderLabel);
            this.Controls.Add(this.sum_OrderTextBox);
            this.Controls.Add(time_orderLabel);
            this.Controls.Add(this.time_orderTextBox);
            this.Controls.Add(datee_orderLabel);
            this.Controls.Add(this.datee_orderDateTimePicker);
            this.Controls.Add(this.order_CheckBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form8";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_CheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_CheckBindingNavigator)).EndInit();
            this.order_CheckBindingNavigator.ResumeLayout(false);
            this.order_CheckBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource order_CheckBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Order_CheckTableAdapter order_CheckTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator order_CheckBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton order_CheckBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker datee_orderDateTimePicker;
        private System.Windows.Forms.TextBox time_orderTextBox;
        private System.Windows.Forms.TextBox sum_OrderTextBox;
        private System.Windows.Forms.MaskedTextBox rating_OrderMaskedTextBox;
        private COFFE_HOUSEDataSetTableAdapters.CoffeTableAdapter coffeTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource coffeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}