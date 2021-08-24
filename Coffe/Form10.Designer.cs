namespace Coffe
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.coffe_streetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffe_streetTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Coffe_streetTableAdapter();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.street_nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.street_nameToolStripTextBox = new System.Windows.Forms.ToolStripComboBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.coffe_streetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffe_working_hourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffe_working_hourseTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Coffe_working_hourseTableAdapter();
            this.coffe_working_hourseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffe_working_hourseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_streetBindingSource)).BeginInit();
            this.fillToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_streetDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffe_streetBindingSource
            // 
            this.coffe_streetBindingSource.DataMember = "Coffe_street";
            this.coffe_streetBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // coffe_streetTableAdapter
            // 
            this.coffe_streetTableAdapter.ClearBeforeFill = true;
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
            this.fillToolStrip.AutoSize = false;
            this.fillToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.street_nameToolStripLabel,
            this.street_nameToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.fillToolStrip.Location = new System.Drawing.Point(341, 98);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(229, 102);
            this.fillToolStrip.TabIndex = 1;
            this.fillToolStrip.Text = "fillToolStrip";
            // 
            // street_nameToolStripLabel
            // 
            this.street_nameToolStripLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.street_nameToolStripLabel.Name = "street_nameToolStripLabel";
            this.street_nameToolStripLabel.Size = new System.Drawing.Size(56, 20);
            this.street_nameToolStripLabel.Text = "Улица";
            // 
            // street_nameToolStripTextBox
            // 
            this.street_nameToolStripTextBox.Items.AddRange(new object[] {
            "Космонавтов",
            "Интернациональная",
            "Верхнеторговая_площадь",
            "Ленина",
            "Блохина"});
            this.street_nameToolStripTextBox.Name = "street_nameToolStripTextBox";
            this.street_nameToolStripTextBox.Size = new System.Drawing.Size(224, 28);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fillToolStripButton.AutoSize = false;
            this.fillToolStripButton.AutoToolTip = false;
            this.fillToolStripButton.BackColor = System.Drawing.Color.Salmon;
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(150, 24);
            this.fillToolStripButton.Text = "Найти кофейню";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // coffe_streetDataGridView
            // 
            this.coffe_streetDataGridView.AutoGenerateColumns = false;
            this.coffe_streetDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.coffe_streetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coffe_streetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.coffe_streetDataGridView.DataSource = this.coffe_streetBindingSource;
            this.coffe_streetDataGridView.Location = new System.Drawing.Point(97, 277);
            this.coffe_streetDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.coffe_streetDataGridView.Name = "coffe_streetDataGridView";
            this.coffe_streetDataGridView.RowTemplate.Height = 24;
            this.coffe_streetDataGridView.Size = new System.Drawing.Size(473, 228);
            this.coffe_streetDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Coffe_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Кофейня";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn2.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // coffe_working_hourseBindingSource
            // 
            this.coffe_working_hourseBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            this.coffe_working_hourseBindingSource.Position = 0;
            // 
            // coffe_working_hourseTableAdapter
            // 
            this.coffe_working_hourseTableAdapter.ClearBeforeFill = true;
            // 
            // coffe_working_hourseBindingSource1
            // 
            this.coffe_working_hourseBindingSource1.DataSource = this.cOFFE_HOUSEDataSet;
            this.coffe_working_hourseBindingSource1.Position = 0;
            // 
            // coffe_working_hourseBindingSource2
            // 
            this.coffe_working_hourseBindingSource2.DataSource = this.cOFFE_HOUSEDataSet;
            this.coffe_working_hourseBindingSource2.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(670, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.coffe_streetDataGridView);
            this.Controls.Add(this.fillToolStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form10";
            this.Text = "Найти кофейню на заданной улице";
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_streetBindingSource)).EndInit();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_streetDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffe_working_hourseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource coffe_streetBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Coffe_streetTableAdapter coffe_streetTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel street_nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.DataGridView coffe_streetDataGridView;
        private System.Windows.Forms.ToolStripComboBox street_nameToolStripTextBox;
        private System.Windows.Forms.BindingSource coffe_working_hourseBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Coffe_working_hourseTableAdapter coffe_working_hourseTableAdapter;
        private System.Windows.Forms.BindingSource coffe_working_hourseBindingSource1;
        private System.Windows.Forms.BindingSource coffe_working_hourseBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}