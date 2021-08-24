namespace Coffe
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.coffe_cooperatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffe_cooperatorTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Coffe_cooperatorTableAdapter();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.compnameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.coffe_cooperatorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffe_cooperatorDataGridView = new System.Windows.Forms.DataGridView();
            this.compnameToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_cooperatorBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_cooperatorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_cooperatorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffe_cooperatorBindingSource
            // 
            this.coffe_cooperatorBindingSource.DataMember = "Coffe_cooperator";
            this.coffe_cooperatorBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // coffe_cooperatorTableAdapter
            // 
            this.coffe_cooperatorTableAdapter.ClearBeforeFill = true;
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
            this.fillToolStrip.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compnameToolStripLabel,
            this.compnameToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(87, 57);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(332, 29);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // compnameToolStripLabel
            // 
            this.compnameToolStripLabel.Name = "compnameToolStripLabel";
            this.compnameToolStripLabel.Size = new System.Drawing.Size(97, 26);
            this.compnameToolStripLabel.Text = "Кофейня";
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(71, 26);
            this.fillToolStripButton.Text = "Найти";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // coffe_cooperatorBindingSource1
            // 
            this.coffe_cooperatorBindingSource1.DataMember = "Coffe_cooperator";
            this.coffe_cooperatorBindingSource1.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // coffe_cooperatorDataGridView
            // 
            this.coffe_cooperatorDataGridView.AutoGenerateColumns = false;
            this.coffe_cooperatorDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.coffe_cooperatorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coffe_cooperatorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.coffe_cooperatorDataGridView.DataSource = this.coffe_cooperatorBindingSource;
            this.coffe_cooperatorDataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.coffe_cooperatorDataGridView.Location = new System.Drawing.Point(87, 169);
            this.coffe_cooperatorDataGridView.Name = "coffe_cooperatorDataGridView";
            this.coffe_cooperatorDataGridView.RowTemplate.Height = 24;
            this.coffe_cooperatorDataGridView.Size = new System.Drawing.Size(626, 228);
            this.coffe_cooperatorDataGridView.TabIndex = 2;
            // 
            // compnameToolStripTextBox
            // 
            this.compnameToolStripTextBox.Items.AddRange(new object[] {
            "Coffe_Like",
            "Кофейная_строка",
            "Open_Coffe",
            "Варим_кофе",
            "Opetit",
            "Coffe_Box",
            "Кофе_Тайм"});
            this.compnameToolStripTextBox.Name = "compnameToolStripTextBox";
            this.compnameToolStripTextBox.Size = new System.Drawing.Size(150, 29);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Middle_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coffe_cooperatorDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "ФИО сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_cooperatorBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_cooperatorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_cooperatorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource coffe_cooperatorBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Coffe_cooperatorTableAdapter coffe_cooperatorTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel compnameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource coffe_cooperatorBindingSource1;
        private System.Windows.Forms.DataGridView coffe_cooperatorDataGridView;
        private System.Windows.Forms.ToolStripComboBox compnameToolStripTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}