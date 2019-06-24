using System.Windows.Forms;
using TaxiDriverSystem.Controller;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class GeoTestView : IView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.GeoLocationCBox = new System.Windows.Forms.ComboBox();
            this.ScoreTxt = new System.Windows.Forms.TextBox();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.expiryPicker = new System.Windows.Forms.DateTimePicker();
            this.expiryLbl = new System.Windows.Forms.Label();
            this.AddSubmitBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SelectDBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editErrLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EditSelectTestBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EditGeoLocationCBox = new System.Windows.Forms.ComboBox();
            this.EditScoreTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editExpiryPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.EditSubmitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EditSelectDBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.delErrLbl = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DelSelectTestBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DelSelectDBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Geographical Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 292);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.GeoLocationCBox);
            this.tabPage1.Controls.Add(this.ScoreTxt);
            this.tabPage1.Controls.Add(this.ScoreLbl);
            this.tabPage1.Controls.Add(this.expiryPicker);
            this.tabPage1.Controls.Add(this.expiryLbl);
            this.tabPage1.Controls.Add(this.AddSubmitBtn);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.SelectDBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Location";
            // 
            // GeoLocationCBox
            // 
            this.GeoLocationCBox.FormattingEnabled = true;
            this.GeoLocationCBox.Items.AddRange(new object[] {
            "Central London",
            "North London",
            "South London",
            "East London",
            "West London"});
            this.GeoLocationCBox.Location = new System.Drawing.Point(154, 127);
            this.GeoLocationCBox.Name = "GeoLocationCBox";
            this.GeoLocationCBox.Size = new System.Drawing.Size(293, 21);
            this.GeoLocationCBox.TabIndex = 51;
            // 
            // ScoreTxt
            // 
            this.ScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTxt.Location = new System.Drawing.Point(154, 84);
            this.ScoreTxt.MaxLength = 3;
            this.ScoreTxt.Name = "ScoreTxt";
            this.ScoreTxt.Size = new System.Drawing.Size(293, 26);
            this.ScoreTxt.TabIndex = 50;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(42, 84);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(51, 20);
            this.ScoreLbl.TabIndex = 49;
            this.ScoreLbl.Text = "Score";
            // 
            // expiryPicker
            // 
            this.expiryPicker.Location = new System.Drawing.Point(154, 165);
            this.expiryPicker.Name = "expiryPicker";
            this.expiryPicker.Size = new System.Drawing.Size(293, 20);
            this.expiryPicker.TabIndex = 48;
            // 
            // expiryLbl
            // 
            this.expiryLbl.AutoSize = true;
            this.expiryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryLbl.Location = new System.Drawing.Point(42, 165);
            this.expiryLbl.Name = "expiryLbl";
            this.expiryLbl.Size = new System.Drawing.Size(90, 20);
            this.expiryLbl.TabIndex = 47;
            this.expiryLbl.Text = "Expiry Date";
            // 
            // AddSubmitBtn
            // 
            this.AddSubmitBtn.Location = new System.Drawing.Point(351, 218);
            this.AddSubmitBtn.Name = "AddSubmitBtn";
            this.AddSubmitBtn.Size = new System.Drawing.Size(96, 32);
            this.AddSubmitBtn.TabIndex = 46;
            this.AddSubmitBtn.Text = "Submit";
            this.AddSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Select Driver";
            // 
            // SelectDBox
            // 
            this.SelectDBox.FormattingEnabled = true;
            this.SelectDBox.Location = new System.Drawing.Point(154, 27);
            this.SelectDBox.Name = "SelectDBox";
            this.SelectDBox.Size = new System.Drawing.Size(293, 21);
            this.SelectDBox.TabIndex = 44;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.editErrLbl);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.EditSelectTestBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.EditGeoLocationCBox);
            this.tabPage2.Controls.Add(this.EditScoreTxt);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.editExpiryPicker);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.EditSubmitBtn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.EditSelectDBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            // 
            // editErrLbl
            // 
            this.editErrLbl.AutoSize = true;
            this.editErrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editErrLbl.ForeColor = System.Drawing.Color.Red;
            this.editErrLbl.Location = new System.Drawing.Point(70, 213);
            this.editErrLbl.Name = "editErrLbl";
            this.editErrLbl.Size = new System.Drawing.Size(0, 20);
            this.editErrLbl.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Select Test";
            // 
            // EditSelectTestBox
            // 
            this.EditSelectTestBox.FormattingEnabled = true;
            this.EditSelectTestBox.Location = new System.Drawing.Point(179, 58);
            this.EditSelectTestBox.Name = "EditSelectTestBox";
            this.EditSelectTestBox.Size = new System.Drawing.Size(293, 21);
            this.EditSelectTestBox.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Location";
            // 
            // EditGeoLocationCBox
            // 
            this.EditGeoLocationCBox.FormattingEnabled = true;
            this.EditGeoLocationCBox.Items.AddRange(new object[] {
            "Central London",
            "North London",
            "South London",
            "East London",
            "West London"});
            this.EditGeoLocationCBox.Location = new System.Drawing.Point(179, 138);
            this.EditGeoLocationCBox.Name = "EditGeoLocationCBox";
            this.EditGeoLocationCBox.Size = new System.Drawing.Size(293, 21);
            this.EditGeoLocationCBox.TabIndex = 60;
            // 
            // EditScoreTxt
            // 
            this.EditScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditScoreTxt.Location = new System.Drawing.Point(179, 95);
            this.EditScoreTxt.MaxLength = 3;
            this.EditScoreTxt.Name = "EditScoreTxt";
            this.EditScoreTxt.Size = new System.Drawing.Size(293, 26);
            this.EditScoreTxt.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 58;
            this.label4.Text = "Score";
            // 
            // editExpiryPicker
            // 
            this.editExpiryPicker.Location = new System.Drawing.Point(179, 176);
            this.editExpiryPicker.Name = "editExpiryPicker";
            this.editExpiryPicker.Size = new System.Drawing.Size(293, 20);
            this.editExpiryPicker.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Expiry Date";
            // 
            // EditSubmitBtn
            // 
            this.EditSubmitBtn.Location = new System.Drawing.Point(376, 213);
            this.EditSubmitBtn.Name = "EditSubmitBtn";
            this.EditSubmitBtn.Size = new System.Drawing.Size(96, 32);
            this.EditSubmitBtn.TabIndex = 55;
            this.EditSubmitBtn.Text = "Submit";
            this.EditSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Select Driver";
            // 
            // EditSelectDBox
            // 
            this.EditSelectDBox.FormattingEnabled = true;
            this.EditSelectDBox.Location = new System.Drawing.Point(179, 22);
            this.EditSelectDBox.Name = "EditSelectDBox";
            this.EditSelectDBox.Size = new System.Drawing.Size(293, 21);
            this.EditSelectDBox.TabIndex = 53;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.delErrLbl);
            this.tabPage3.Controls.Add(this.DelBtn);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.DelSelectTestBox);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.DelSelectDBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 266);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            // 
            // delErrLbl
            // 
            this.delErrLbl.AutoSize = true;
            this.delErrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delErrLbl.ForeColor = System.Drawing.Color.Red;
            this.delErrLbl.Location = new System.Drawing.Point(66, 122);
            this.delErrLbl.Name = "delErrLbl";
            this.delErrLbl.Size = new System.Drawing.Size(0, 20);
            this.delErrLbl.TabIndex = 69;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(375, 122);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(96, 32);
            this.DelBtn.TabIndex = 68;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Select Test";
            // 
            // DelSelectTestBox
            // 
            this.DelSelectTestBox.FormattingEnabled = true;
            this.DelSelectTestBox.Location = new System.Drawing.Point(178, 74);
            this.DelSelectTestBox.Name = "DelSelectTestBox";
            this.DelSelectTestBox.Size = new System.Drawing.Size(293, 21);
            this.DelSelectTestBox.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Select Driver";
            // 
            // DelSelectDBox
            // 
            this.DelSelectDBox.FormattingEnabled = true;
            this.DelSelectDBox.Location = new System.Drawing.Point(178, 38);
            this.DelSelectDBox.Name = "DelSelectDBox";
            this.DelSelectDBox.Size = new System.Drawing.Size(293, 21);
            this.DelSelectDBox.TabIndex = 64;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // GeoTestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "GeoTestView";
            this.Size = new System.Drawing.Size(582, 353);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public void ActivateView(IController myController)
        {
            // click events 
            this.AddSubmitBtn.Click += myController.MyClickEvent;
            this.EditSubmitBtn.Click += myController.MyClickEvent;
            this.DelBtn.Click += myController.MyClickEvent;

            //  combo box index changed events 
            this.EditSelectTestBox.SelectedIndexChanged += myController.MyIndexChange;
            this.GeoLocationCBox.SelectedIndexChanged += myController.MyIndexChange;
            this.SelectDBox.SelectedIndexChanged += myController.MyIndexChange;
            this.EditGeoLocationCBox.SelectedIndexChanged += myController.MyIndexChange;
            this.EditSelectDBox.SelectedIndexChanged += myController.MyIndexChange;
            this.DelSelectDBox.SelectedIndexChanged += myController.MyIndexChange;
            this.DelSelectTestBox.SelectedIndexChanged += myController.MyIndexChange;
           


            // tab index events
            tabControl1.SelectedIndexChanged += myController.tabControl1_SelectedIndexChanged;

            //Validation for add geographical Test
            this.ScoreTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.SelectDBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.GeoLocationCBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.ExpiryPicker.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);


            this.EditScoreTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.EditSelectDBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.EditGeoLocationCBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.EditExpiryPicker.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.EditGeoLocationCBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);



        }


        public int getTabindex()
        {
            return this.tabControl1.SelectedIndex;
        }

        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GeoLocationCBox;
        private System.Windows.Forms.TextBox ScoreTxt;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.DateTimePicker expiryPicker;
        private System.Windows.Forms.Label expiryLbl;
        private System.Windows.Forms.Button AddSubmitBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SelectDBox;
        private ErrorProvider errorProvider1;
        private Label label7;
        private ComboBox EditSelectTestBox;
        private Label label3;
        private ComboBox EditGeoLocationCBox;
        private TextBox EditScoreTxt;
        private Label label4;
        private DateTimePicker editExpiryPicker;
        private Label label5;
        private Button EditSubmitBtn;
        private Label label6;
        private ComboBox EditSelectDBox;
        private Button DelBtn;
        private Label label8;
        private ComboBox DelSelectTestBox;
        private Label label9;
        private ComboBox DelSelectDBox;
        private ErrorProvider errorProvider2;
        private Label editErrLbl;
        private Label delErrLbl;

        public Label Label1 { get => label1; set => label1 = value; }
        public TabControl TabControl1 { get => tabControl1; set => tabControl1 = value; }
        public TabPage TabPage1 { get => tabPage1; set => tabPage1 = value; }
        public TabPage TabPage2 { get => tabPage2; set => tabPage2 = value; }
        public TabPage TabPage3 { get => tabPage3; set => tabPage3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox GeoLocationCBox1 { get => GeoLocationCBox; set => GeoLocationCBox = value; }
        public TextBox ScoreTxt1 { get => ScoreTxt; set => ScoreTxt = value; }
        public Label ScoreLbl1 { get => ScoreLbl; set => ScoreLbl = value; }
        public DateTimePicker ExpiryPicker { get => expiryPicker; set => expiryPicker = value; }
        public Label ExpiryLbl { get => expiryLbl; set => expiryLbl = value; }
        public Button AddSubmit1 { get => AddSubmitBtn; set => AddSubmitBtn = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public ComboBox SelectDBox1 { get => SelectDBox; set => SelectDBox = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public ComboBox EditSelectTestBox1 { get => EditSelectTestBox; set => EditSelectTestBox = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ComboBox EditGeoLocationCBox1 { get => EditGeoLocationCBox; set => EditGeoLocationCBox = value; }
        public TextBox EditScoreTxt1 { get => EditScoreTxt; set => EditScoreTxt = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public DateTimePicker EditExpiryPicker { get => editExpiryPicker; set => editExpiryPicker = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button EditSubmitBtn1 { get => EditSubmitBtn; set => EditSubmitBtn = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public ComboBox EditSelectDBox1 { get => EditSelectDBox; set => EditSelectDBox = value; }
        public Button DelBtn1 { get => DelBtn; set => DelBtn = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public ComboBox DelSelectTestBox1 { get => DelSelectTestBox; set => DelSelectTestBox = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public ComboBox DelSelectDBox1 { get => DelSelectDBox; set => DelSelectDBox = value; }
        public ErrorProvider ErrorProvider2 { get => errorProvider2; set => errorProvider2 = value; }
        public Label EditErrLbl { get => editErrLbl; set => editErrLbl = value; }
        public Label DelErrLbl { get => delErrLbl; set => delErrLbl = value; }
    }
}
