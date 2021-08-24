namespace Coffe
{
    partial class Form9
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.COFFE_HOUSEDataSet = new Coffe.COFFE_HOUSEDataSet();
            this.FoodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdersTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.OrdersTableAdapter();
            this.FoodTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.FoodTableAdapter();
            this.Order_CheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Order_CheckTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.Order_CheckTableAdapter();
            this.ChecksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChecksTableAdapter = new Coffe.COFFE_HOUSEDataSetTableAdapters.ChecksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.COFFE_HOUSEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_CheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ChecksBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Coffe.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(876, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.COFFE_HOUSEDataSet;
            // 
            // COFFE_HOUSEDataSet
            // 
            this.COFFE_HOUSEDataSet.DataSetName = "COFFE_HOUSEDataSet";
            this.COFFE_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FoodBindingSource
            // 
            this.FoodBindingSource.DataMember = "Food";
            this.FoodBindingSource.DataSource = this.COFFE_HOUSEDataSet;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // FoodTableAdapter
            // 
            this.FoodTableAdapter.ClearBeforeFill = true;
            // 
            // Order_CheckBindingSource
            // 
            this.Order_CheckBindingSource.DataMember = "Order_Check";
            this.Order_CheckBindingSource.DataSource = this.COFFE_HOUSEDataSet;
            // 
            // Order_CheckTableAdapter
            // 
            this.Order_CheckTableAdapter.ClearBeforeFill = true;
            // 
            // ChecksBindingSource
            // 
            this.ChecksBindingSource.DataMember = "Checks";
            this.ChecksBindingSource.DataSource = this.COFFE_HOUSEDataSet;
            // 
            // ChecksTableAdapter
            // 
            this.ChecksTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form9";
            this.Text = "Отчёт";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.COFFE_HOUSEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Order_CheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChecksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private COFFE_HOUSEDataSet COFFE_HOUSEDataSet;
        private System.Windows.Forms.BindingSource FoodBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.OrdersTableAdapter OrdersTableAdapter;
        private COFFE_HOUSEDataSetTableAdapters.FoodTableAdapter FoodTableAdapter;
        private System.Windows.Forms.BindingSource Order_CheckBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.Order_CheckTableAdapter Order_CheckTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ChecksBindingSource;
        private COFFE_HOUSEDataSetTableAdapters.ChecksTableAdapter ChecksTableAdapter;
    }
}