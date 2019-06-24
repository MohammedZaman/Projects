using System.Drawing;
using System.Windows.Forms;

namespace TaxiDriverSystem.Components
{
    partial class PhoneBox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.phoneTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "+44 ",
            "+1",
            "+86",
            "+91"});
            this.comboBox1.Location = new System.Drawing.Point(10, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(53, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxtBox.Location = new System.Drawing.Point(69, 6);
            this.phoneTxtBox.MaximumSize = new System.Drawing.Size(160, 26);
            this.phoneTxtBox.MinimumSize = new System.Drawing.Size(160, 26);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(160, 26);
            this.phoneTxtBox.TabIndex = 6;
            this.phoneTxtBox.TextChanged += new System.EventHandler(this.phoneTxtBox_TextChanged);
            this.phoneTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTxtBox_KeyPress);
            // 
            // PhoneBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.phoneTxtBox);
            this.MaximumSize = new System.Drawing.Size(250, 36);
            this.MinimumSize = new System.Drawing.Size(250, 36);
            this.Name = "PhoneBox";
            this.Size = new System.Drawing.Size(250, 36);
            this.Load += new System.EventHandler(this.PhoneBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox PhoneTxtBox { get => phoneTxtBox; }
        public ComboBox ComboBox1 { get => comboBox1;}
        

        override
        public string ToString() {
            return comboBox1.SelectedValue + phoneTxtBox.Text; 
        }

        public string getCountryCode() {
            return comboBox1.SelectedValue.ToString();
        }

        public string getPhoneNumber() {
            return phoneTxtBox.Text;
        }

        
        private ComboBox comboBox1;
        private TextBox phoneTxtBox;
    }
}
