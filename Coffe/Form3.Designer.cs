namespace Coffe
{
    partial class Form3
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
            System.Windows.Forms.Label working_hourseLabel;
            System.Windows.Forms.Label instagram_accountLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label houseLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.coffeTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.CoffeTableAdapter();
            this.coffeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.coffeBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.coffeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coffe_nameTextBox = new System.Windows.Forms.TextBox();
            this.working_hourseTextBox = new System.Windows.Forms.TextBox();
            this.instagram_accountTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.houseTextBox = new System.Windows.Forms.TextBox();
            this.button_rating = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.coffe_RatingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            working_hourseLabel = new System.Windows.Forms.Label();
            instagram_accountLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            houseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingNavigator)).BeginInit();
            this.coffeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_RatingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // working_hourseLabel
            // 
            working_hourseLabel.AutoSize = true;
            working_hourseLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            working_hourseLabel.ForeColor = System.Drawing.SystemColors.Window;
            working_hourseLabel.Location = new System.Drawing.Point(290, 157);
            working_hourseLabel.Name = "working_hourseLabel";
            working_hourseLabel.Size = new System.Drawing.Size(110, 19);
            working_hourseLabel.TabIndex = 3;
            working_hourseLabel.Text = "Время работы";
            // 
            // instagram_accountLabel
            // 
            instagram_accountLabel.AutoSize = true;
            instagram_accountLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            instagram_accountLabel.ForeColor = System.Drawing.SystemColors.Window;
            instagram_accountLabel.Location = new System.Drawing.Point(107, 399);
            instagram_accountLabel.Name = "instagram_accountLabel";
            instagram_accountLabel.Size = new System.Drawing.Size(146, 19);
            instagram_accountLabel.TabIndex = 5;
            instagram_accountLabel.Text = "Аккаунт в Instagram";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cityLabel.ForeColor = System.Drawing.SystemColors.Window;
            cityLabel.Location = new System.Drawing.Point(291, 206);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(51, 19);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "Город";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            streetLabel.ForeColor = System.Drawing.SystemColors.Window;
            streetLabel.Location = new System.Drawing.Point(290, 253);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(54, 19);
            streetLabel.TabIndex = 9;
            streetLabel.Text = "Улица";
            // 
            // houseLabel
            // 
            houseLabel.AutoSize = true;
            houseLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            houseLabel.ForeColor = System.Drawing.SystemColors.Window;
            houseLabel.Location = new System.Drawing.Point(291, 298);
            houseLabel.Name = "houseLabel";
            houseLabel.Size = new System.Drawing.Size(40, 19);
            houseLabel.TabIndex = 11;
            houseLabel.Text = "Дом";
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeTableAdapter
            // 
            this.coffeTableAdapter.ClearBeforeFill = true;
            // 
            // coffeBindingNavigator
            // 
            this.coffeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coffeBindingNavigator.BindingSource = this.coffeBindingSource;
            this.coffeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coffeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coffeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coffeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coffeBindingNavigatorSaveItem});
            this.coffeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coffeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coffeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coffeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coffeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coffeBindingNavigator.Name = "coffeBindingNavigator";
            this.coffeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coffeBindingNavigator.Size = new System.Drawing.Size(1096, 27);
            this.coffeBindingNavigator.TabIndex = 0;
            this.coffeBindingNavigator.Text = "bindingNavigator1";
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
            // coffeBindingSource
            // 
            this.coffeBindingSource.DataMember = "Coffe";
            this.coffeBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // coffeBindingNavigatorSaveItem
            // 
            this.coffeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coffeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coffeBindingNavigatorSaveItem.Image")));
            this.coffeBindingNavigatorSaveItem.Name = "coffeBindingNavigatorSaveItem";
            this.coffeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.coffeBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.coffeBindingNavigatorSaveItem.Click += new System.EventHandler(this.coffeBindingNavigatorSaveItem_Click);
            // 
            // coffe_nameTextBox
            // 
            this.coffe_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeBindingSource, "Coffe_name", true));
            this.coffe_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffe_nameTextBox.Location = new System.Drawing.Point(54, 83);
            this.coffe_nameTextBox.Name = "coffe_nameTextBox";
            this.coffe_nameTextBox.Size = new System.Drawing.Size(221, 32);
            this.coffe_nameTextBox.TabIndex = 2;
            this.coffe_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.coffe_nameTextBox.TextChanged += new System.EventHandler(this.coffe_nameTextBox_TextChanged);
            // 
            // working_hourseTextBox
            // 
            this.working_hourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeBindingSource, "Working_hourse", true));
            this.working_hourseTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.working_hourseTextBox.Location = new System.Drawing.Point(413, 150);
            this.working_hourseTextBox.Name = "working_hourseTextBox";
            this.working_hourseTextBox.Size = new System.Drawing.Size(135, 28);
            this.working_hourseTextBox.TabIndex = 4;
            // 
            // instagram_accountTextBox
            // 
            this.instagram_accountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeBindingSource, "Instagram_account", true));
            this.instagram_accountTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instagram_accountTextBox.Location = new System.Drawing.Point(90, 438);
            this.instagram_accountTextBox.Name = "instagram_accountTextBox";
            this.instagram_accountTextBox.Size = new System.Drawing.Size(163, 28);
            this.instagram_accountTextBox.TabIndex = 6;
            this.instagram_accountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeBindingSource, "City", true));
            this.cityTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.Location = new System.Drawing.Point(413, 195);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(200, 28);
            this.cityTextBox.TabIndex = 8;
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeBindingSource, "Street", true));
            this.streetTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.streetTextBox.Location = new System.Drawing.Point(413, 244);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(200, 28);
            this.streetTextBox.TabIndex = 10;
            // 
            // houseTextBox
            // 
            this.houseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffeBindingSource, "House", true));
            this.houseTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.houseTextBox.Location = new System.Drawing.Point(413, 292);
            this.houseTextBox.Name = "houseTextBox";
            this.houseTextBox.Size = new System.Drawing.Size(135, 28);
            this.houseTextBox.TabIndex = 12;
            // 
            // button_rating
            // 
            this.button_rating.BackColor = System.Drawing.Color.Moccasin;
            this.button_rating.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_rating.Location = new System.Drawing.Point(822, 136);
            this.button_rating.Name = "button_rating";
            this.button_rating.Size = new System.Drawing.Size(198, 61);
            this.button_rating.TabIndex = 13;
            this.button_rating.Text = "Рейтинг кофеен";
            this.button_rating.UseVisualStyleBackColor = false;
            this.button_rating.Click += new System.EventHandler(this.button_rating_Click);
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
            // coffe_RatingBindingSource
            // 
            this.coffe_RatingBindingSource.DataMember = "Coffe_Rating";
            this.coffe_RatingBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(822, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 61);
            this.button1.TabIndex = 14;
            this.button1.Text = "Найти кофейню по заданной улице";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(822, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 61);
            this.button2.TabIndex = 15;
            this.button2.Text = "Узнать время работы заданной кофейни";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(710, 135);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(723, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(723, 334);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1096, 566);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_rating);
            this.Controls.Add(houseLabel);
            this.Controls.Add(this.houseTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(instagram_accountLabel);
            this.Controls.Add(this.instagram_accountTextBox);
            this.Controls.Add(working_hourseLabel);
            this.Controls.Add(this.working_hourseTextBox);
            this.Controls.Add(this.coffe_nameTextBox);
            this.Controls.Add(this.coffeBindingNavigator);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Кофейни";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingNavigator)).EndInit();
            this.coffeBindingNavigator.ResumeLayout(false);
            this.coffeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_RatingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource coffeBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.CoffeTableAdapter coffeTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coffeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coffeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox coffe_nameTextBox;
        private System.Windows.Forms.TextBox working_hourseTextBox;
        private System.Windows.Forms.TextBox instagram_accountTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox houseTextBox;
        private System.Windows.Forms.BindingSource coffe_RatingBindingSource;
        private System.Windows.Forms.Button button_rating;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}