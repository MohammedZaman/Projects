using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class MainConsole : IView
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.driverToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualificationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driLicMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingTypesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SheduleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AssignMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewExpryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IncidentTypeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DisaplinaryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayout = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainLayout);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 461);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(273, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 461);
            this.vScrollBar1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driverToolMenuItem,
            this.qualificationMenuItem,
            this.trainingTypesMenuItem,
            this.SheduleMenuItem,
            this.AssignMenuItem,
            this.searchMenuItem,
            this.ViewExpryMenuItem,
            this.IncidentTypeMenuItem,
            this.DisaplinaryMenuItem,
            this.predictionMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 20, 20, 2);
            this.menuStrip1.Size = new System.Drawing.Size(290, 461);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // driverToolMenuItem
            // 
            this.driverToolMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driverToolMenuItem.Name = "driverToolMenuItem";
            this.driverToolMenuItem.Size = new System.Drawing.Size(263, 24);
            this.driverToolMenuItem.Text = "Driver";
            this.driverToolMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // qualificationMenuItem
            // 
            this.qualificationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.geoMenuItem,
            this.driLicMenuItem});
            this.qualificationMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualificationMenuItem.Name = "qualificationMenuItem";
            this.qualificationMenuItem.Size = new System.Drawing.Size(263, 24);
            this.qualificationMenuItem.Text = "Qualifications";
            this.qualificationMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // geoMenuItem
            // 
            this.geoMenuItem.Name = "geoMenuItem";
            this.geoMenuItem.Size = new System.Drawing.Size(208, 24);
            this.geoMenuItem.Text = "Geographical Test";
            // 
            // driLicMenuItem
            // 
            this.driLicMenuItem.Name = "driLicMenuItem";
            this.driLicMenuItem.Size = new System.Drawing.Size(208, 24);
            this.driLicMenuItem.Text = "Driving License";
            // 
            // trainingTypesMenuItem
            // 
            this.trainingTypesMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingTypesMenuItem.Name = "trainingTypesMenuItem";
            this.trainingTypesMenuItem.Size = new System.Drawing.Size(263, 24);
            this.trainingTypesMenuItem.Text = "Training Types";
            this.trainingTypesMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SheduleMenuItem
            // 
            this.SheduleMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SheduleMenuItem.Name = "SheduleMenuItem";
            this.SheduleMenuItem.Size = new System.Drawing.Size(263, 24);
            this.SheduleMenuItem.Text = "Schedule Training Session";
            this.SheduleMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AssignMenuItem
            // 
            this.AssignMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignMenuItem.Name = "AssignMenuItem";
            this.AssignMenuItem.Size = new System.Drawing.Size(263, 24);
            this.AssignMenuItem.Text = "Assign Driver to Session";
            this.AssignMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(263, 24);
            this.searchMenuItem.Text = "Search Driver";
            this.searchMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewExpryMenuItem
            // 
            this.ViewExpryMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewExpryMenuItem.Name = "ViewExpryMenuItem";
            this.ViewExpryMenuItem.Size = new System.Drawing.Size(263, 24);
            this.ViewExpryMenuItem.Text = "View Drivers with 30 days Till Expiry";
            this.ViewExpryMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IncidentTypeMenuItem
            // 
            this.IncidentTypeMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentTypeMenuItem.Name = "IncidentTypeMenuItem";
            this.IncidentTypeMenuItem.Size = new System.Drawing.Size(263, 24);
            this.IncidentTypeMenuItem.Text = "Incident Type";
            this.IncidentTypeMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisaplinaryMenuItem
            // 
            this.DisaplinaryMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisaplinaryMenuItem.Name = "DisaplinaryMenuItem";
            this.DisaplinaryMenuItem.Size = new System.Drawing.Size(263, 24);
            this.DisaplinaryMenuItem.Text = "Add Disciplinary";
            this.DisaplinaryMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // predictionMenuItem
            // 
            this.predictionMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictionMenuItem.Name = "predictionMenuItem";
            this.predictionMenuItem.Size = new System.Drawing.Size(263, 24);
            this.predictionMenuItem.Text = "Prediction";
            this.predictionMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainLayout
            // 
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Size = new System.Drawing.Size(890, 461);
            this.MainLayout.TabIndex = 0;
            // 
            // MainConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1100, 500);
            this.Name = "MainConsole";
            this.Text = "Taxi System";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        public void ActivateView(IController myController)
        {
            this.driverToolMenuItem.Click += myController.MyClickEvent;
            this.geoMenuItem.Click += myController.MyClickEvent;
            this.driLicMenuItem.Click += myController.MyClickEvent;
            this.trainingTypesMenuItem.Click += myController.MyClickEvent;
            this.SheduleMenuItem.Click += myController.MyClickEvent;
            this.AssignMenuItem.Click += myController.MyClickEvent;
            this.searchMenuItem.Click += myController.MyClickEvent;
            this.ViewExpryMenuItem.Click += myController.MyClickEvent;
            this.IncidentTypeMenuItem.Click += myController.MyClickEvent;
            this.DisaplinaryMenuItem.Click += myController.MyClickEvent;
            this.predictionMenuItem.Click += myController.MyClickEvent;
        }


        public int getTabindex()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private SplitContainer splitContainer1;
        private VScrollBar vScrollBar1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem driverToolMenuItem;
        private ToolStripMenuItem qualificationMenuItem;
        private ToolStripMenuItem trainingTypesMenuItem;
        private FlowLayoutPanel MainLayout;
        private ToolStripMenuItem geoMenuItem;
        private ToolStripMenuItem driLicMenuItem;
        private ToolStripMenuItem SheduleMenuItem;
        private ToolStripMenuItem AssignMenuItem;
        private ToolStripMenuItem searchMenuItem;
        private ToolStripMenuItem ViewExpryMenuItem;
        private ToolStripMenuItem DisaplinaryMenuItem;
        private ToolStripMenuItem IncidentTypeMenuItem;
        private ToolStripMenuItem predictionMenuItem;

        public SplitContainer SplitContainer1 { get => splitContainer1; set => splitContainer1 = value; }
        public VScrollBar VScrollBar1 { get => vScrollBar1; set => vScrollBar1 = value; }
        public MenuStrip MenuStrip1 { get => menuStrip1; set => menuStrip1 = value; }
        public ToolStripMenuItem DriverToolMenuItem { get => driverToolMenuItem; set => driverToolMenuItem = value; }
        public ToolStripMenuItem QualificationMenuItem { get => qualificationMenuItem; set => qualificationMenuItem = value; }
        public ToolStripMenuItem TrainingTypesMenuItem { get => trainingTypesMenuItem; set => trainingTypesMenuItem = value; }
        public FlowLayoutPanel MainLayout1 { get => MainLayout; set => MainLayout = value; }
        public ToolStripMenuItem GeoMenuItem { get => geoMenuItem; set => geoMenuItem = value; }
        public ToolStripMenuItem DriLicMenuItem { get => driLicMenuItem; set => driLicMenuItem = value; }
        public ToolStripMenuItem SheduleMenuItem1 { get => SheduleMenuItem; set => SheduleMenuItem = value; }
        public ToolStripMenuItem AssignMenuItem1 { get => AssignMenuItem; set => AssignMenuItem = value; }
        public ToolStripMenuItem SearchMenuItem { get => searchMenuItem; set => searchMenuItem = value; }
        public ToolStripMenuItem ViewExpryMenuItem1 { get => ViewExpryMenuItem; set => ViewExpryMenuItem = value; }
        public ToolStripMenuItem DisaplinaryMenuItem1 { get => DisaplinaryMenuItem; set => DisaplinaryMenuItem = value; }
        public ToolStripMenuItem IncidentTypeMenuItem1 { get => IncidentTypeMenuItem; set => IncidentTypeMenuItem = value; }
        public ToolStripMenuItem PredictionMenuItem { get => predictionMenuItem; set => predictionMenuItem = value; }
    }
}