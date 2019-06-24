using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class AssignView :IView
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
            this.assignBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sessionBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SelectDBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.editSessionBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editDriverBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(449, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assign Driver to Session";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(606, 265);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.assignBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sessionBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.SelectDBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assign";
            // 
            // assignBtn
            // 
            this.assignBtn.Location = new System.Drawing.Point(392, 138);
            this.assignBtn.Name = "assignBtn";
            this.assignBtn.Size = new System.Drawing.Size(96, 39);
            this.assignBtn.TabIndex = 50;
            this.assignBtn.Text = "Assign";
            this.assignBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Select Session";
            // 
            // sessionBox
            // 
            this.sessionBox.FormattingEnabled = true;
            this.sessionBox.Location = new System.Drawing.Point(195, 76);
            this.sessionBox.Name = "sessionBox";
            this.sessionBox.Size = new System.Drawing.Size(293, 21);
            this.sessionBox.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Select Driver";
            // 
            // SelectDBox
            // 
            this.SelectDBox.FormattingEnabled = true;
            this.SelectDBox.Location = new System.Drawing.Point(195, 33);
            this.SelectDBox.Name = "SelectDBox";
            this.SelectDBox.Size = new System.Drawing.Size(293, 21);
            this.SelectDBox.TabIndex = 46;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.statusBox);
            this.tabPage2.Controls.Add(this.updateBtn);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.editSessionBox);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.editDriverBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pass/Fail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Outcome";
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Pass",
            "Fail"});
            this.statusBox.Location = new System.Drawing.Point(217, 126);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(293, 21);
            this.statusBox.TabIndex = 56;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(414, 164);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 39);
            this.updateBtn.TabIndex = 55;
            this.updateBtn.Text = "Update ";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Select Session";
            // 
            // editSessionBox
            // 
            this.editSessionBox.FormattingEnabled = true;
            this.editSessionBox.Location = new System.Drawing.Point(217, 88);
            this.editSessionBox.Name = "editSessionBox";
            this.editSessionBox.Size = new System.Drawing.Size(293, 21);
            this.editSessionBox.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Select Driver";
            // 
            // editDriverBox
            // 
            this.editDriverBox.FormattingEnabled = true;
            this.editDriverBox.Location = new System.Drawing.Point(217, 48);
            this.editDriverBox.Name = "editDriverBox";
            this.editDriverBox.Size = new System.Drawing.Size(293, 21);
            this.editDriverBox.TabIndex = 51;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AssignView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "AssignView";
            this.Size = new System.Drawing.Size(677, 345);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void ActivateView(IController myController)
        {
            this.assignBtn.Click += myController.MyClickEvent;
            this.updateBtn.Click += myController.MyClickEvent;
           

            // validation events for Assign Tab
            this.SelectDBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.sessionBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);

            // validation events for Pass/Fail Tab
            this.statusBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.editDriverBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.editSessionBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
           
            //  combo box index changed events 
            this.SelectDBox.SelectedIndexChanged += myController.MyIndexChange;
            this.sessionBox.SelectedIndexChanged += myController.MyIndexChange;
            this.statusBox.SelectedIndexChanged += myController.MyIndexChange;
            this.editDriverBox.SelectedIndexChanged += myController.MyIndexChange;
            this.editSessionBox.SelectedIndexChanged += myController.MyIndexChange;
            

            // tab index events
            tabControl1.SelectedIndexChanged += myController.tabControl1_SelectedIndexChanged;
        }

        public int getTabindex()
        {
            return tabControl1.SelectedIndex;
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sessionBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SelectDBox;
        private System.Windows.Forms.Button assignBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox editSessionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox editDriverBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;

        public Label Label1 { get => label1; set => label1 = value; }
        public TabControl TabControl1 { get => tabControl1; set => tabControl1 = value; }
        public TabPage TabPage1 { get => tabPage1; set => tabPage1 = value; }
        public TabPage TabPage2 { get => tabPage2; set => tabPage2 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public ComboBox SessionBox { get => sessionBox; set => sessionBox = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public ComboBox SelectDBox1 { get => SelectDBox; set => SelectDBox = value; }
        public Button AssignBtn { get => assignBtn; set => assignBtn = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public ComboBox StatusBox { get => statusBox; set => statusBox = value; }
        public Button UpdateBtn { get => updateBtn; set => updateBtn = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ComboBox EditSessionBox { get => editSessionBox; set => editSessionBox = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public ComboBox EditDriverBox { get => editDriverBox; set => editDriverBox = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
        public ErrorProvider ErrorProvider2 { get => errorProvider2; set => errorProvider2 = value; }
    }
}
