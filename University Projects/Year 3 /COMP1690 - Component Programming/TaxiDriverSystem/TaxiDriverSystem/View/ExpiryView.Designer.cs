using System.Windows.Forms;
using TaxiDriverSystem.Controller;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class ExpiryView : IView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DriverGrid = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TrainingGrid = new System.Windows.Forms.DataGridView();
            this.DriLicGrid = new System.Windows.Forms.DataGridView();
            this.GeoTestGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGrid)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriLicGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTestGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // driverGrid
            // 
            this.DriverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverGrid.Location = new System.Drawing.Point(18, 32);
            this.DriverGrid.MultiSelect = false;
            this.DriverGrid.Name = "driverGrid";
            this.DriverGrid.Size = new System.Drawing.Size(768, 137);
            this.DriverGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(14, 6);
            this.Label1.Name = "label1";
            this.Label1.Size = new System.Drawing.Size(50, 20);
            this.Label1.TabIndex = 59;
            this.Label1.Text = "Driver";
            // 
            // groupBox1
            // 
            this.GroupBox1.Controls.Add(this.TrainingGrid);
            this.GroupBox1.Controls.Add(this.DriLicGrid);
            this.GroupBox1.Controls.Add(this.GeoTestGrid);
            this.GroupBox1.Location = new System.Drawing.Point(18, 175);
            this.GroupBox1.Name = "groupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(768, 259);
            this.GroupBox1.TabIndex = 63;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Qaulifications/Training";
            // 
            // trainingGrid
            // 
            this.TrainingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainingGrid.Location = new System.Drawing.Point(27, 181);
            this.TrainingGrid.Name = "trainingGrid";
            this.TrainingGrid.Size = new System.Drawing.Size(707, 68);
            this.TrainingGrid.TabIndex = 3;
            // 
            // driLicGrid
            // 
            this.DriLicGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriLicGrid.Location = new System.Drawing.Point(27, 100);
            this.DriLicGrid.Name = "driLicGrid";
            this.DriLicGrid.Size = new System.Drawing.Size(707, 68);
            this.DriLicGrid.TabIndex = 2;
            // 
            // geoTestGrid
            // 
            this.GeoTestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeoTestGrid.Location = new System.Drawing.Point(27, 19);
            this.GeoTestGrid.Name = "geoTestGrid";
            this.GeoTestGrid.Size = new System.Drawing.Size(707, 68);
            this.GeoTestGrid.TabIndex = 1;
            // 
            // ExpiryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DriverGrid);
            this.Name = "ExpiryView";
            this.Size = new System.Drawing.Size(806, 437);
            ((System.ComponentModel.ISupportInitialize)(this.DriverGrid)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DriLicGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTestGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ActivateView(IController myController)
        {
       
            this.DriverGrid.SelectionChanged += myController.MyClickEvent;

        }

        public int getTabindex()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView driverGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView trainingGrid;
        private System.Windows.Forms.DataGridView driLicGrid;
        private System.Windows.Forms.DataGridView geoTestGrid;

        public DataGridView DriverGrid { get => driverGrid; set => driverGrid = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public DataGridView TrainingGrid { get => trainingGrid; set => trainingGrid = value; }
        public DataGridView DriLicGrid { get => driLicGrid; set => driLicGrid = value; }
        public DataGridView GeoTestGrid { get => geoTestGrid; set => geoTestGrid = value; }
    }
}
