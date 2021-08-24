namespace Coffe
{
    partial class Form4
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
            System.Windows.Forms.Label avg_CoffeLabel;
            System.Windows.Forms.Label coffe_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.coffe_RatingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.coffe_RatingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
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
            this.coffe_RatingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coffe_nameTextBox = new System.Windows.Forms.TextBox();
            this.avg_CoffeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.coffe_RatingTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Coffe_RatingTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            avg_CoffeLabel = new System.Windows.Forms.Label();
            coffe_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_RatingBindingNavigator)).BeginInit();
            this.coffe_RatingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_RatingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // avg_CoffeLabel
            // 
            avg_CoffeLabel.AutoSize = true;
            avg_CoffeLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            avg_CoffeLabel.Location = new System.Drawing.Point(85, 184);
            avg_CoffeLabel.Name = "avg_CoffeLabel";
            avg_CoffeLabel.Size = new System.Drawing.Size(352, 30);
            avg_CoffeLabel.TabIndex = 1;
            avg_CoffeLabel.Text = "Рейтинг среди посетителей";
            // 
            // coffe_nameLabel
            // 
            coffe_nameLabel.AutoSize = true;
            coffe_nameLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            coffe_nameLabel.Location = new System.Drawing.Point(106, 114);
            coffe_nameLabel.Name = "coffe_nameLabel";
            coffe_nameLabel.Size = new System.Drawing.Size(125, 30);
            coffe_nameLabel.TabIndex = 3;
            coffe_nameLabel.Text = "Кофейня";
            coffe_nameLabel.Click += new System.EventHandler(this.coffe_nameLabel_Click_1);
            // 
            // coffe_RatingBindingNavigator
            // 
            this.coffe_RatingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coffe_RatingBindingNavigator.BindingSource = this.coffe_RatingBindingSource;
            this.coffe_RatingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coffe_RatingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coffe_RatingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coffe_RatingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coffe_RatingBindingNavigatorSaveItem});
            this.coffe_RatingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coffe_RatingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coffe_RatingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coffe_RatingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coffe_RatingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coffe_RatingBindingNavigator.Name = "coffe_RatingBindingNavigator";
            this.coffe_RatingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coffe_RatingBindingNavigator.Size = new System.Drawing.Size(604, 27);
            this.coffe_RatingBindingNavigator.TabIndex = 0;
            this.coffe_RatingBindingNavigator.Text = "bindingNavigator1";
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
            // coffe_RatingBindingSource
            // 
            this.coffe_RatingBindingSource.DataMember = "Coffe_Rating";
            this.coffe_RatingBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // coffe_RatingBindingNavigatorSaveItem
            // 
            this.coffe_RatingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coffe_RatingBindingNavigatorSaveItem.Enabled = false;
            this.coffe_RatingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coffe_RatingBindingNavigatorSaveItem.Image")));
            this.coffe_RatingBindingNavigatorSaveItem.Name = "coffe_RatingBindingNavigatorSaveItem";
            this.coffe_RatingBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.coffe_RatingBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // coffe_nameTextBox
            // 
            this.coffe_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffe_RatingBindingSource, "Coffe_name", true));
            this.coffe_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffe_nameTextBox.Location = new System.Drawing.Point(262, 115);
            this.coffe_nameTextBox.Name = "coffe_nameTextBox";
            this.coffe_nameTextBox.Size = new System.Drawing.Size(242, 32);
            this.coffe_nameTextBox.TabIndex = 4;
            // 
            // avg_CoffeMaskedTextBox
            // 
            this.avg_CoffeMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffe_RatingBindingSource, "Avg_Coffe", true));
            this.avg_CoffeMaskedTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avg_CoffeMaskedTextBox.Location = new System.Drawing.Point(443, 185);
            this.avg_CoffeMaskedTextBox.Mask = "0.00";
            this.avg_CoffeMaskedTextBox.Name = "avg_CoffeMaskedTextBox";
            this.avg_CoffeMaskedTextBox.Size = new System.Drawing.Size(61, 32);
            this.avg_CoffeMaskedTextBox.TabIndex = 5;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoffeTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CooperatorTableAdapter = null;
            this.tableAdapterManager.FoodTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProviderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // coffe_RatingTableAdapter
            // 
            this.coffe_RatingTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(185, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Лучшие кофейни";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.avg_CoffeMaskedTextBox);
            this.Controls.Add(coffe_nameLabel);
            this.Controls.Add(this.coffe_nameTextBox);
            this.Controls.Add(avg_CoffeLabel);
            this.Controls.Add(this.coffe_RatingBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Рейтинг";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coffe_RatingBindingNavigator)).EndInit();
            this.coffe_RatingBindingNavigator.ResumeLayout(false);
            this.coffe_RatingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_RatingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource coffe_RatingBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coffe_RatingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coffe_RatingBindingNavigatorSaveItem;
        private COFFE_HOUSEDataSetTableAdapters.Coffe_RatingTableAdapter coffe_RatingTableAdapter;
        private System.Windows.Forms.TextBox coffe_nameTextBox;
        private System.Windows.Forms.MaskedTextBox avg_CoffeMaskedTextBox;
        private System.Windows.Forms.Button button1;
    }
}