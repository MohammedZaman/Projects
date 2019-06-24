using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class SessionView : IView
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
            this.label10 = new System.Windows.Forms.Label();
            this.SelectTTBox = new System.Windows.Forms.ComboBox();
            this.sDatePicker = new System.Windows.Forms.DateTimePicker();
            this.expiryLbl = new System.Windows.Forms.Label();
            this.eTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.sTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.expiryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Schedule Session";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Select Training Type ";
            // 
            // SelectTTBox
            // 
            this.SelectTTBox.FormattingEnabled = true;
            this.SelectTTBox.Location = new System.Drawing.Point(299, 98);
            this.SelectTTBox.Name = "SelectTTBox";
            this.SelectTTBox.Size = new System.Drawing.Size(293, 21);
            this.SelectTTBox.TabIndex = 46;
            // 
            // sDatePicker
            // 
            this.sDatePicker.Location = new System.Drawing.Point(299, 141);
            this.sDatePicker.Name = "sDatePicker";
            this.sDatePicker.Size = new System.Drawing.Size(293, 20);
            this.sDatePicker.TabIndex = 50;
            // 
            // expiryLbl
            // 
            this.expiryLbl.AutoSize = true;
            this.expiryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiryLbl.Location = new System.Drawing.Point(118, 141);
            this.expiryLbl.Name = "expiryLbl";
            this.expiryLbl.Size = new System.Drawing.Size(87, 20);
            this.expiryLbl.TabIndex = 49;
            this.expiryLbl.Text = "Start Date ";
            // 
            // eTimePicker
            // 
            this.eTimePicker.CustomFormat = "HH:mm";
            this.eTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eTimePicker.Location = new System.Drawing.Point(300, 215);
            this.eTimePicker.Name = "eTimePicker";
            this.eTimePicker.ShowUpDown = true;
            this.eTimePicker.Size = new System.Drawing.Size(293, 20);
            this.eTimePicker.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "End Time";
            // 
            // sTimePicker
            // 
            this.sTimePicker.CustomFormat = "HH:mm";
            this.sTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.sTimePicker.Location = new System.Drawing.Point(300, 177);
            this.sTimePicker.Name = "sTimePicker";
            this.sTimePicker.ShowUpDown = true;
            this.sTimePicker.Size = new System.Drawing.Size(293, 20);
            this.sTimePicker.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Start Time ";
            // 
            // expiryDatePicker
            // 
            this.expiryDatePicker.Location = new System.Drawing.Point(300, 252);
            this.expiryDatePicker.Name = "expiryDatePicker";
            this.expiryDatePicker.Size = new System.Drawing.Size(293, 20);
            this.expiryDatePicker.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Expiry Date";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(496, 300);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(96, 32);
            this.SubmitBtn.TabIndex = 59;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SessionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.expiryDatePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sDatePicker);
            this.Controls.Add(this.expiryLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SelectTTBox);
            this.Controls.Add(this.label1);
            this.Name = "SessionView";
            this.Size = new System.Drawing.Size(742, 336);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ActivateView(IController myController)
        {
           
            // click events 
            this.SubmitBtn.Click += myController.MyClickEvent;
          

            //  combo box index changed events 
            this.SelectTTBox.SelectedIndexChanged += myController.MyIndexChange;
          
            //Validation for add 
            this.SelectTTBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.sDatePicker.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.sTimePicker.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.eTimePicker.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);




        }

        public int getTabindex()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SelectTTBox;
        private System.Windows.Forms.DateTimePicker sDatePicker;
        private System.Windows.Forms.Label expiryLbl;
        private System.Windows.Forms.DateTimePicker eTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker sTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker expiryDatePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitBtn;
        private ErrorProvider errorProvider1;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public ComboBox SelectTTBox1 { get => SelectTTBox; set => SelectTTBox = value; }
        public DateTimePicker SDatePicker { get => sDatePicker; set => sDatePicker = value; }
        public Label ExpiryLbl { get => expiryLbl; set => expiryLbl = value; }
        public DateTimePicker ETimePicker { get => eTimePicker; set => eTimePicker = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public DateTimePicker STimePicker { get => sTimePicker; set => sTimePicker = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public DateTimePicker ExpiryDatePicker { get => expiryDatePicker; set => expiryDatePicker = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Button SubmitBtn1 { get => SubmitBtn; set => SubmitBtn = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
    }
}
