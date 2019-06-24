using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class PredictionView :IView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainingBtn = new System.Windows.Forms.Button();
            this.TirednessBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(20, 62);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(775, 352);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Accident Prediction";
            this.chart1.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prediction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TrainingBtn
            // 
            this.TrainingBtn.Location = new System.Drawing.Point(20, 54);
            this.TrainingBtn.Name = "TrainingBtn";
            this.TrainingBtn.Size = new System.Drawing.Size(242, 32);
            this.TrainingBtn.TabIndex = 47;
            this.TrainingBtn.Text = "Predict Accident From Lack of Training ";
            this.TrainingBtn.UseVisualStyleBackColor = true;
            // 
            // TirednessBtn
            // 
            this.TirednessBtn.Location = new System.Drawing.Point(335, 54);
            this.TirednessBtn.Name = "TirednessBtn";
            this.TirednessBtn.Size = new System.Drawing.Size(208, 32);
            this.TirednessBtn.TabIndex = 48;
            this.TirednessBtn.Text = "Predict Accident Form Tiredness  ";
            this.TirednessBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TrainingBtn);
            this.groupBox1.Controls.Add(this.TirednessBtn);
            this.groupBox1.Location = new System.Drawing.Point(119, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 138);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prediction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Prediction based on Training";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Prediction based on hours worked in the past 7 days";
            // 
            // PredictionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "PredictionView";
            this.Size = new System.Drawing.Size(815, 593);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ActivateView(IController myController)
        {
            this.TirednessBtn.Click += myController.MyClickEvent;
            this.TrainingBtn.Click += myController.MyClickEvent;
        }

        public int getTabindex()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TrainingBtn;
        private System.Windows.Forms.Button TirednessBtn;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;

        public Chart Chart1 { get => chart1; set => chart1 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button TrainingBtn1 { get => TrainingBtn; set => TrainingBtn = value; }
        public Button TirednessBtn1 { get => TirednessBtn; set => TirednessBtn = value; }
    }
}
