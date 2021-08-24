namespace Coffe
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.coffe_working_hourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffe_working_hourseTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Coffe_working_hourseTableAdapter();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.coffe_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.working_hourseTextBox = new System.Windows.Forms.TextBox();
            this.coffe_nameToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            working_hourseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // working_hourseLabel
            // 
            working_hourseLabel.AutoSize = true;
            working_hourseLabel.Location = new System.Drawing.Point(72, 161);
            working_hourseLabel.Name = "working_hourseLabel";
            working_hourseLabel.Size = new System.Drawing.Size(118, 20);
            working_hourseLabel.TabIndex = 2;
            working_hourseLabel.Text = "Время работы";
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffe_working_hourseBindingSource
            // 
            this.coffe_working_hourseBindingSource.DataMember = "Coffe_working_hourse";
            this.coffe_working_hourseBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // coffe_working_hourseTableAdapter
            // 
            this.coffe_working_hourseTableAdapter.ClearBeforeFill = true;
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
            // fillToolStrip
            // 
            this.fillToolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coffe_nameToolStripLabel,
            this.coffe_nameToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(218, 87);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(298, 28);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // coffe_nameToolStripLabel
            // 
            this.coffe_nameToolStripLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coffe_nameToolStripLabel.Name = "coffe_nameToolStripLabel";
            this.coffe_nameToolStripLabel.Size = new System.Drawing.Size(83, 25);
            this.coffe_nameToolStripLabel.Text = "Кофейня:";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.BackColor = System.Drawing.Color.Tan;
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(33, 25);
            this.fillToolStripButton.Text = "ОК";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // working_hourseTextBox
            // 
            this.working_hourseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coffe_working_hourseBindingSource, "Working_hourse", true));
            this.working_hourseTextBox.Location = new System.Drawing.Point(71, 185);
            this.working_hourseTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.working_hourseTextBox.Name = "working_hourseTextBox";
            this.working_hourseTextBox.Size = new System.Drawing.Size(119, 26);
            this.working_hourseTextBox.TabIndex = 3;
            // 
            // coffe_nameToolStripTextBox
            // 
            this.coffe_nameToolStripTextBox.Items.AddRange(new object[] {
            "Coffe_Like",
            "Кофейная_строка",
            "Open_Coffe",
            "Варим_кофе",
            "Opetit",
            "Coffe_Box",
            "Кофе_Тайм"});
            this.coffe_nameToolStripTextBox.Name = "coffe_nameToolStripTextBox";
            this.coffe_nameToolStripTextBox.Size = new System.Drawing.Size(168, 28);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(working_hourseLabel);
            this.Controls.Add(this.working_hourseTextBox);
            this.Controls.Add(this.fillToolStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form11";
            this.Text = "Время работы кофейни";
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource coffe_working_hourseBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Coffe_working_hourseTableAdapter coffe_working_hourseTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel coffe_nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.TextBox working_hourseTextBox;
        private System.Windows.Forms.ToolStripComboBox coffe_nameToolStripTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}