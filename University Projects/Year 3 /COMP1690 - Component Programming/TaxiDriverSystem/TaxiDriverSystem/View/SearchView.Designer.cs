using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class SearchView :IView
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
            this.components = new System.ComponentModel.Container();
            this.DriverGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.EditSelectTBox = new System.Windows.Forms.ComboBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GeoTestGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.DrivingLicenceGrid = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TrainingGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DriverGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTestGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrivingLicenceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DriverGrid
            // 
            this.DriverGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DriverGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DriverGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DriverGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriverGrid.Location = new System.Drawing.Point(10, 81);
            this.DriverGrid.Name = "DriverGrid";
            this.DriverGrid.ReadOnly = true;
            this.DriverGrid.Size = new System.Drawing.Size(793, 37);
            this.DriverGrid.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Select Driver";
            // 
            // EditSelectTBox
            // 
            this.EditSelectTBox.FormattingEnabled = true;
            this.EditSelectTBox.Location = new System.Drawing.Point(143, 14);
            this.EditSelectTBox.Name = "EditSelectTBox";
            this.EditSelectTBox.Size = new System.Drawing.Size(323, 21);
            this.EditSelectTBox.TabIndex = 55;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(490, 7);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(96, 32);
            this.SubmitBtn.TabIndex = 57;
            this.SubmitBtn.Text = "Search";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Driver";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Geographical Test";
            // 
            // GeoTestGrid
            // 
            this.GeoTestGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GeoTestGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GeoTestGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.GeoTestGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GeoTestGrid.Location = new System.Drawing.Point(10, 144);
            this.GeoTestGrid.Name = "GeoTestGrid";
            this.GeoTestGrid.ReadOnly = true;
            this.GeoTestGrid.Size = new System.Drawing.Size(793, 84);
            this.GeoTestGrid.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Driving Licence ";
            // 
            // DrivingLicenceGrid
            // 
            this.DrivingLicenceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DrivingLicenceGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DrivingLicenceGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DrivingLicenceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrivingLicenceGrid.Location = new System.Drawing.Point(10, 254);
            this.DrivingLicenceGrid.Name = "DrivingLicenceGrid";
            this.DrivingLicenceGrid.ReadOnly = true;
            this.DrivingLicenceGrid.Size = new System.Drawing.Size(793, 84);
            this.DrivingLicenceGrid.TabIndex = 62;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TrainingGrid
            // 
            this.TrainingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrainingGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TrainingGrid.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.TrainingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainingGrid.Location = new System.Drawing.Point(10, 364);
            this.TrainingGrid.Name = "TrainingGrid";
            this.TrainingGrid.ReadOnly = true;
            this.TrainingGrid.Size = new System.Drawing.Size(793, 84);
            this.TrainingGrid.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Training";
            // 
            // SearchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.TrainingGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DrivingLicenceGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GeoTestGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditSelectTBox);
            this.Controls.Add(this.DriverGrid);
            this.Name = "SearchView";
            this.Size = new System.Drawing.Size(812, 483);
            ((System.ComponentModel.ISupportInitialize)(this.DriverGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeoTestGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrivingLicenceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrainingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ActivateView(IController myController)
        {
            this.SubmitBtn.Click += myController.MyClickEvent;
            this.EditSelectTBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
        }

        public int getTabindex()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DriverBox;
        private System.Windows.Forms.Button SearchBtn;
        private DataGridView DriverGrid;
        private Label label6;
        private ComboBox EditSelectTBox;
        private Button SubmitBtn;
        private Label label1;
        private Label label2;
        private DataGridView GeoTestGrid;
        private Label label3;
        private DataGridView DrivingLicenceGrid;
        private ErrorProvider errorProvider1;
        private DataGridView TrainingGrid;
        private Label label5;

        public DataGridView DataGridView1 { get => dataGridView1; set => dataGridView1 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public ComboBox DriverBox1 { get => DriverBox; set => DriverBox = value; }
        public Button SearchBtn1 { get => SearchBtn; set => SearchBtn = value; }
        public DataGridView DriverGrid1 { get => DriverGrid; set => DriverGrid = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public ComboBox EditSelectTBox1 { get => EditSelectTBox; set => EditSelectTBox = value; }
        public Button SubmitBtn1 { get => SubmitBtn; set => SubmitBtn = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public DataGridView GeoTestGrid1 { get => GeoTestGrid; set => GeoTestGrid = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DataGridView DrivingLicenceGrid1 { get => DrivingLicenceGrid; set => DrivingLicenceGrid = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
        public DataGridView TrainingGrid1 { get => TrainingGrid; set => TrainingGrid = value; }
    }
}
