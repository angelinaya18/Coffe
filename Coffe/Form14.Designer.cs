namespace Coffe
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.cOFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.best_CoffeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.best_CoffeTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Best_CoffeTableAdapter();
            this.tableAdapterManager = new Coffe.COFFE_HOUSEDataSetTableAdapters.TableAdapterManager();
            this.best_CoffeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.best_CoffeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.best_CoffeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cOFFE_HOUSEDataSet
            // 
            this.cOFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.cOFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // best_CoffeBindingSource
            // 
            this.best_CoffeBindingSource.DataMember = "Best_Coffe";
            this.best_CoffeBindingSource.DataSource = this.cOFFE_HOUSEDataSet;
            // 
            // best_CoffeTableAdapter
            // 
            this.best_CoffeTableAdapter.ClearBeforeFill = true;
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
            // best_CoffeDataGridView
            // 
            this.best_CoffeDataGridView.AutoGenerateColumns = false;
            this.best_CoffeDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.best_CoffeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.best_CoffeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.best_CoffeDataGridView.DataSource = this.best_CoffeBindingSource;
            this.best_CoffeDataGridView.Location = new System.Drawing.Point(14, 15);
            this.best_CoffeDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.best_CoffeDataGridView.Name = "best_CoffeDataGridView";
            this.best_CoffeDataGridView.RowTemplate.Height = 24;
            this.best_CoffeDataGridView.Size = new System.Drawing.Size(792, 135);
            this.best_CoffeDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name_Coffe";
            this.dataGridViewTextBoxColumn1.HeaderText = "Кофейня";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "Город";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name_Street";
            this.dataGridViewTextBoxColumn3.HeaderText = "Улица";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "House";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дом";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Instagram";
            this.dataGridViewTextBoxColumn5.HeaderText = "Instagram";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Rating";
            this.dataGridViewTextBoxColumn6.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(821, 162);
            this.Controls.Add(this.best_CoffeDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form14";
            this.Text = "Лучшая кофейня";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cOFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.best_CoffeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.best_CoffeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COFFE_HOUSEDataSet cOFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource best_CoffeBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Best_CoffeTableAdapter best_CoffeTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView best_CoffeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}