using System.Windows.Forms;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class IncidentTypeView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addIncidentTypeTxt = new System.Windows.Forms.TextBox();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.AddSubmitBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.editIncidentTypeTxt = new System.Windows.Forms.TextBox();
            this.EditSubmitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EditSelectIBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.delSelectIBox = new System.Windows.Forms.ComboBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(59, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 292);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.addIncidentTypeTxt);
            this.tabPage1.Controls.Add(this.ScoreLbl);
            this.tabPage1.Controls.Add(this.AddSubmitBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            // 
            // addIncidentTypeTxt
            // 
            this.addIncidentTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncidentTypeTxt.Location = new System.Drawing.Point(151, 64);
            this.addIncidentTypeTxt.MaxLength = 100;
            this.addIncidentTypeTxt.Name = "addIncidentTypeTxt";
            this.addIncidentTypeTxt.Size = new System.Drawing.Size(293, 26);
            this.addIncidentTypeTxt.TabIndex = 50;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLbl.Location = new System.Drawing.Point(42, 67);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(104, 20);
            this.ScoreLbl.TabIndex = 49;
            this.ScoreLbl.Text = "Incident Type";
            // 
            // AddSubmitBtn
            // 
            this.AddSubmitBtn.Location = new System.Drawing.Point(351, 126);
            this.AddSubmitBtn.Name = "AddSubmitBtn";
            this.AddSubmitBtn.Size = new System.Drawing.Size(96, 32);
            this.AddSubmitBtn.TabIndex = 46;
            this.AddSubmitBtn.Text = "Submit";
            this.AddSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.editIncidentTypeTxt);
            this.tabPage2.Controls.Add(this.EditSubmitBtn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.EditSelectIBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Training Type";
            // 
            // editIncidentTypeTxt
            // 
            this.editIncidentTypeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editIncidentTypeTxt.Location = new System.Drawing.Point(179, 95);
            this.editIncidentTypeTxt.MaxLength = 100;
            this.editIncidentTypeTxt.Name = "editIncidentTypeTxt";
            this.editIncidentTypeTxt.Size = new System.Drawing.Size(293, 26);
            this.editIncidentTypeTxt.TabIndex = 59;
            // 
            // EditSubmitBtn
            // 
            this.EditSubmitBtn.Location = new System.Drawing.Point(376, 140);
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
            this.label6.Location = new System.Drawing.Point(17, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Select Training Type ";
            // 
            // EditSelectIBox
            // 
            this.EditSelectIBox.FormattingEnabled = true;
            this.EditSelectIBox.Location = new System.Drawing.Point(179, 58);
            this.EditSelectIBox.Name = "EditSelectIBox";
            this.EditSelectIBox.Size = new System.Drawing.Size(293, 21);
            this.EditSelectIBox.TabIndex = 53;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.delSelectIBox);
            this.tabPage3.Controls.Add(this.DelBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 266);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 71;
            this.label3.Text = "Select Training Type ";
            // 
            // delSelectIBox
            // 
            this.delSelectIBox.FormattingEnabled = true;
            this.delSelectIBox.Location = new System.Drawing.Point(197, 60);
            this.delSelectIBox.Name = "delSelectIBox";
            this.delSelectIBox.Size = new System.Drawing.Size(293, 21);
            this.delSelectIBox.TabIndex = 70;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(394, 117);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(96, 32);
            this.DelBtn.TabIndex = 68;
            this.DelBtn.Text = "Delete";
            this.DelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 8;
            this.label1.Text = "Incident Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // IncidentTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "IncidentTypeView";
            this.Size = new System.Drawing.Size(657, 370);
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



        public void ActivateView(IController myController)
        {
            // click events 
            this.AddSubmitBtn.Click += myController.MyClickEvent;
            this.EditSubmitBtn.Click += myController.MyClickEvent;
            this.DelBtn.Click += myController.MyClickEvent;

            //  combo box index changed events 
            this.EditSelectIBox.SelectedIndexChanged += myController.MyIndexChange;
            this.delSelectIBox.SelectedIndexChanged += myController.MyIndexChange;


            // tab index events
            tabControl1.SelectedIndexChanged += myController.tabControl1_SelectedIndexChanged;

            //Validation for add geographical Test
            this.addIncidentTypeTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);

            //Edit
            this.EditSelectIBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.editIncidentTypeTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);

            //Delete
            this.delSelectIBox.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);



        }

        public int getTabindex()
        {
            return this.tabControl1.SelectedIndex;
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox addIncidentTypeTxt;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Button AddSubmitBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox editIncidentTypeTxt;
        private System.Windows.Forms.Button EditSubmitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EditSelectIBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox delSelectIBox;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label label1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;

        public TabControl TabControl1 { get => tabControl1; set => tabControl1 = value; }
        public TabPage TabPage1 { get => tabPage1; set => tabPage1 = value; }
        public TextBox AddIncidentTypeTxt { get => addIncidentTypeTxt; set => addIncidentTypeTxt = value; }
        public Label ScoreLbl1 { get => ScoreLbl; set => ScoreLbl = value; }
        public Button AddSubmitBtn1 { get => AddSubmitBtn; set => AddSubmitBtn = value; }
        public TabPage TabPage2 { get => tabPage2; set => tabPage2 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox EditIncidentTypeTxt { get => editIncidentTypeTxt; set => editIncidentTypeTxt = value; }
        public Button EditSubmitBtn1 { get => EditSubmitBtn; set => EditSubmitBtn = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public ComboBox EditSelectIBox1 { get => EditSelectIBox; set => EditSelectIBox = value; }
        public TabPage TabPage3 { get => tabPage3; set => tabPage3 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public ComboBox DelSelectIBox { get => delSelectIBox; set => delSelectIBox = value; }
        public Button DelBtn1 { get => DelBtn; set => DelBtn = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
        public ErrorProvider ErrorProvider2 { get => errorProvider2; set => errorProvider2 = value; }
    }
}
