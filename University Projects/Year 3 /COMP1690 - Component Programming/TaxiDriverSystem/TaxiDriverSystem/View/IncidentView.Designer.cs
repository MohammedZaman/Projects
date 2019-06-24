using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class IncidentView : IView
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
            this.SelectDBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectIBox = new System.Windows.Forms.ComboBox();
            this.AddSubmitBtn = new System.Windows.Forms.Button();
            this.iBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(313, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add  Disciplinary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Select Driver";
            // 
            // SelectDBox
            // 
            this.SelectDBox.FormattingEnabled = true;
            this.SelectDBox.Location = new System.Drawing.Point(196, 63);
            this.SelectDBox.Name = "SelectDBox";
            this.SelectDBox.Size = new System.Drawing.Size(293, 21);
            this.SelectDBox.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Select Incident Type";
            // 
            // selectIBox
            // 
            this.selectIBox.FormattingEnabled = true;
            this.selectIBox.Location = new System.Drawing.Point(196, 101);
            this.selectIBox.Name = "selectIBox";
            this.selectIBox.Size = new System.Drawing.Size(293, 21);
            this.selectIBox.TabIndex = 48;
            // 
            // AddSubmitBtn
            // 
            this.AddSubmitBtn.Location = new System.Drawing.Point(393, 288);
            this.AddSubmitBtn.Name = "AddSubmitBtn";
            this.AddSubmitBtn.Size = new System.Drawing.Size(96, 32);
            this.AddSubmitBtn.TabIndex = 50;
            this.AddSubmitBtn.Text = "Submit";
            this.AddSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // iBox
            // 
            this.iBox.Location = new System.Drawing.Point(196, 142);
            this.iBox.Multiline = true;
            this.iBox.Name = "iBox";
            this.iBox.Size = new System.Drawing.Size(293, 130);
            this.iBox.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Report";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // IncidentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iBox);
            this.Controls.Add(this.AddSubmitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectIBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SelectDBox);
            this.Controls.Add(this.label1);
            this.Name = "IncidentView";
            this.Size = new System.Drawing.Size(576, 369);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ActivateView(IController myController)
        {
            this.AddSubmitBtn.Click += myController.MyClickEvent;

            this.SelectDBox.Validating += myController.textBox_Validating;
            this.selectIBox.Validating += myController.textBox_Validating;
            this.iBox.Validating += myController.textBox_Validating;

        }

        public int getTabindex()
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SelectDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectIBox;
        private System.Windows.Forms.Button AddSubmitBtn;
        private System.Windows.Forms.TextBox iBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public ComboBox SelectDBox1 { get => SelectDBox; set => SelectDBox = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox SelectIBox { get => selectIBox; set => selectIBox = value; }
        public Button AddSubmitBtn1 { get => AddSubmitBtn; set => AddSubmitBtn = value; }
        public TextBox IBox { get => iBox; set => iBox = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
    }
}
