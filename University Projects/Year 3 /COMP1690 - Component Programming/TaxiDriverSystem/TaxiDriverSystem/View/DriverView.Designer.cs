using System.Windows.Forms;
using TaxiDriverSystem.Components;
using TaxiDriverSystem.Controller;
using TaxiDriverSystem.Interfaces;

namespace TaxiDriverSystem.View
{
    partial class DriverView : IView
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
            System.Windows.Forms.TabPage tabPage3;
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.delDriverCBox = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.addSubmitBtn = new System.Windows.Forms.Button();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.dobLbl = new System.Windows.Forms.Label();
            this.PhoneNumLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.addPhoneComp = new TaxiDriverSystem.Components.PhoneBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.editPhoneComp = new TaxiDriverSystem.Components.PhoneBox();
            this.label9 = new System.Windows.Forms.Label();
            this.driverCBox = new System.Windows.Forms.ComboBox();
            this.editDobPicker = new System.Windows.Forms.DateTimePicker();
            this.editPasswordTxt = new System.Windows.Forms.TextBox();
            this.EditUserNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.editSubmitBtn = new System.Windows.Forms.Button();
            this.editLastNameTxt = new System.Windows.Forms.TextBox();
            this.editFirstNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            tabPage3 = new System.Windows.Forms.TabPage();
            tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.BackColor = System.Drawing.SystemColors.Control;
            tabPage3.Controls.Add(this.deleteBtn);
            tabPage3.Controls.Add(this.label10);
            tabPage3.Controls.Add(this.delDriverCBox);
            tabPage3.Location = new System.Drawing.Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(847, 354);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Delete Driver";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(530, 35);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 32);
            this.deleteBtn.TabIndex = 34;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(98, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Select Driver";
            // 
            // delDriverCBox
            // 
            this.delDriverCBox.FormattingEnabled = true;
            this.delDriverCBox.Location = new System.Drawing.Point(221, 40);
            this.delDriverCBox.Name = "delDriverCBox";
            this.delDriverCBox.Size = new System.Drawing.Size(293, 21);
            this.delDriverCBox.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(10, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 380);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dobPicker);
            this.tabPage1.Controls.Add(this.passwordTxt);
            this.tabPage1.Controls.Add(this.userNameTxt);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.userNameLbl);
            this.tabPage1.Controls.Add(this.addSubmitBtn);
            this.tabPage1.Controls.Add(this.lastNameTxt);
            this.tabPage1.Controls.Add(this.firstNameTxt);
            this.tabPage1.Controls.Add(this.dobLbl);
            this.tabPage1.Controls.Add(this.PhoneNumLbl);
            this.tabPage1.Controls.Add(this.lastNameLbl);
            this.tabPage1.Controls.Add(this.firstNameLbl);
            this.tabPage1.Controls.Add(this.addPhoneComp);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Driver";
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(601, 92);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(204, 26);
            this.dobPicker.TabIndex = 16;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(601, 137);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(204, 26);
            this.passwordTxt.TabIndex = 15;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(131, 140);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(263, 26);
            this.userNameTxt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(3, 143);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(89, 20);
            this.userNameLbl.TabIndex = 12;
            this.userNameLbl.Text = "User Name";
            // 
            // addSubmitBtn
            // 
            this.addSubmitBtn.Location = new System.Drawing.Point(709, 209);
            this.addSubmitBtn.Name = "addSubmitBtn";
            this.addSubmitBtn.Size = new System.Drawing.Size(96, 39);
            this.addSubmitBtn.TabIndex = 11;
            this.addSubmitBtn.Text = "Submit";
            this.addSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.Location = new System.Drawing.Point(601, 34);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(204, 26);
            this.lastNameTxt.TabIndex = 6;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.Location = new System.Drawing.Point(131, 37);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(263, 26);
            this.firstNameTxt.TabIndex = 5;
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.Location = new System.Drawing.Point(493, 92);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(102, 20);
            this.dobLbl.TabIndex = 4;
            this.dobLbl.Text = "Date Of Birth";
            // 
            // PhoneNumLbl
            // 
            this.PhoneNumLbl.AutoSize = true;
            this.PhoneNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumLbl.Location = new System.Drawing.Point(3, 92);
            this.PhoneNumLbl.Name = "PhoneNumLbl";
            this.PhoneNumLbl.Size = new System.Drawing.Size(115, 20);
            this.PhoneNumLbl.TabIndex = 3;
            this.PhoneNumLbl.Text = "Phone Number";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.Location = new System.Drawing.Point(493, 40);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(86, 20);
            this.lastNameLbl.TabIndex = 2;
            this.lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.Location = new System.Drawing.Point(6, 40);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(86, 20);
            this.firstNameLbl.TabIndex = 1;
            this.firstNameLbl.Text = "First Name";
            // 
            // addPhoneComp
            // 
            this.addPhoneComp.Location = new System.Drawing.Point(111, 77);
            this.addPhoneComp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPhoneComp.MaximumSize = new System.Drawing.Size(375, 55);
            this.addPhoneComp.MinimumSize = new System.Drawing.Size(375, 55);
            this.addPhoneComp.Name = "addPhoneComp";
            this.addPhoneComp.Size = new System.Drawing.Size(375, 55);
            this.addPhoneComp.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.editPhoneComp);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.driverCBox);
            this.tabPage2.Controls.Add(this.editDobPicker);
            this.tabPage2.Controls.Add(this.editPasswordTxt);
            this.tabPage2.Controls.Add(this.EditUserNameTxt);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.editSubmitBtn);
            this.tabPage2.Controls.Add(this.editLastNameTxt);
            this.tabPage2.Controls.Add(this.editFirstNameTxt);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Driver";
            // 
            // editPhoneComp
            // 
            this.editPhoneComp.Location = new System.Drawing.Point(161, 140);
            this.editPhoneComp.MaximumSize = new System.Drawing.Size(250, 36);
            this.editPhoneComp.MinimumSize = new System.Drawing.Size(250, 36);
            this.editPhoneComp.Name = "editPhoneComp";
            this.editPhoneComp.Size = new System.Drawing.Size(250, 36);
            this.editPhoneComp.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Select Driver";
            // 
            // driverCBox
            // 
            this.driverCBox.FormattingEnabled = true;
            this.driverCBox.Location = new System.Drawing.Point(169, 45);
            this.driverCBox.Name = "driverCBox";
            this.driverCBox.Size = new System.Drawing.Size(121, 21);
            this.driverCBox.TabIndex = 30;
            // 
            // editDobPicker
            // 
            this.editDobPicker.Location = new System.Drawing.Point(525, 156);
            this.editDobPicker.Name = "editDobPicker";
            this.editDobPicker.Size = new System.Drawing.Size(215, 20);
            this.editDobPicker.TabIndex = 29;
            // 
            // editPasswordTxt
            // 
            this.editPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editPasswordTxt.Location = new System.Drawing.Point(525, 201);
            this.editPasswordTxt.Name = "editPasswordTxt";
            this.editPasswordTxt.PasswordChar = '*';
            this.editPasswordTxt.Size = new System.Drawing.Size(215, 26);
            this.editPasswordTxt.TabIndex = 28;
            // 
            // EditUserNameTxt
            // 
            this.EditUserNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserNameTxt.Location = new System.Drawing.Point(169, 198);
            this.EditUserNameTxt.Name = "EditUserNameTxt";
            this.EditUserNameTxt.Size = new System.Drawing.Size(215, 26);
            this.EditUserNameTxt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "User Name";
            // 
            // editSubmitBtn
            // 
            this.editSubmitBtn.Location = new System.Drawing.Point(644, 267);
            this.editSubmitBtn.Name = "editSubmitBtn";
            this.editSubmitBtn.Size = new System.Drawing.Size(96, 39);
            this.editSubmitBtn.TabIndex = 24;
            this.editSubmitBtn.Text = "Submit";
            this.editSubmitBtn.UseVisualStyleBackColor = true;
            // 
            // editLastNameTxt
            // 
            this.editLastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLastNameTxt.Location = new System.Drawing.Point(525, 98);
            this.editLastNameTxt.Name = "editLastNameTxt";
            this.editLastNameTxt.Size = new System.Drawing.Size(215, 26);
            this.editLastNameTxt.TabIndex = 22;
            // 
            // editFirstNameTxt
            // 
            this.editFirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editFirstNameTxt.Location = new System.Drawing.Point(169, 101);
            this.editFirstNameTxt.Name = "editFirstNameTxt";
            this.editFirstNameTxt.Size = new System.Drawing.Size(215, 26);
            this.editFirstNameTxt.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(417, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(417, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkRate = 100;
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // DriverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "DriverView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(875, 462);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;

       

        public void ActivateView(IController myController)
        { 
            // click events
            this.addSubmitBtn.Click += myController.MyClickEvent;
            this.editSubmitBtn.Click += myController.MyClickEvent;
            this.deleteBtn.Click += myController.MyClickEvent;

            // validation events for Add Tab
            this.firstNameTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.lastNameTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.passwordTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.addPhoneComp.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.editPhoneComp.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.userNameTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);

            // validation events for Edit tab
            this.editFirstNameTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.editLastNameTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.editPasswordTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);
            this.EditUserNameTxt.Validating += new System.ComponentModel.CancelEventHandler(myController.textBox_Validating);


            //  combo box index changed events 
            this.driverCBox.SelectedIndexChanged += myController.MyIndexChange;
            this.delDriverCBox.SelectedIndexChanged += myController.MyIndexChange;

            // tab index events
            tabControl1.SelectedIndexChanged += myController.tabControl1_SelectedIndexChanged;
        }
        public int getTabindex()
        {
            return this.tabControl1.SelectedIndex;
        }

        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label PhoneNumLbl;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Button addSubmitBtn;
        private TextBox passwordTxt;
        private TextBox userNameTxt;
        private Label label2;
        private Label userNameLbl;
        private DateTimePicker dobPicker;
        private Button deleteBtn;
        private Label label10;
        private ComboBox delDriverCBox;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private TabPage tabPage2;
        private Label label9;
        private ComboBox driverCBox;
        private DateTimePicker editDobPicker;
        private TextBox editPasswordTxt;
        private TextBox EditUserNameTxt;
        private Label label3;
        private Label label4;
        private Button editSubmitBtn;
        private TextBox editLastNameTxt;
        private TextBox editFirstNameTxt;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PhoneBox addPhoneComp;
        private PhoneBox editPhoneComp;








        // getters for UI elements
        public Label LastNameLbl { get => lastNameLbl; set => lastNameLbl = value; }
        public Label FirstNameLbl { get => firstNameLbl; set => firstNameLbl = value; }
        public Label DobLbl { get => dobLbl; set => dobLbl = value; }
        public Label PhoneNumLbl1 { get => PhoneNumLbl; set => PhoneNumLbl = value; }
        public TextBox LastNameTxt { get => lastNameTxt; set => lastNameTxt = value; }
        public TextBox FirstNameTxt { get => firstNameTxt; set => firstNameTxt = value; }
        public Button AddSubmitBtn { get => addSubmitBtn; set => addSubmitBtn = value; }
        public TextBox PasswordTxt { get => passwordTxt; set => passwordTxt = value; }
        public TextBox UserNameTxt { get => userNameTxt; set => userNameTxt = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label UserNameLbl { get => userNameLbl; set => userNameLbl = value; }
        public DateTimePicker DobPicker { get => dobPicker; set => dobPicker = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public ComboBox DriverCBox { get => driverCBox; set => driverCBox = value; }
        public DateTimePicker EditDobPicker { get => editDobPicker; set => editDobPicker = value; }
        public TextBox EditPasswordTxt { get => editPasswordTxt; set => editPasswordTxt = value; }
        public TextBox EditUserNameTxt1 { get => EditUserNameTxt; set => EditUserNameTxt = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Button Button1 { get => editSubmitBtn; set => editSubmitBtn = value; }
        public TextBox EditLastNameTxt { get => editLastNameTxt; set => editLastNameTxt = value; }
        public TextBox EditFirstNameTxt { get => editFirstNameTxt; set => editFirstNameTxt = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Button EditSubmitBtn { get => editSubmitBtn; set => editSubmitBtn = value; }
        public ComboBox DelDriverCBox { get => delDriverCBox; set => delDriverCBox = value; }
        public Button DeleteBtn { get => deleteBtn; set => deleteBtn = value; }
        public ErrorProvider ErrorProvider1 { get => errorProvider1; set => errorProvider1 = value; }
        public ErrorProvider ErrorProvider2 { get => errorProvider2; set => errorProvider2 = value; }
        public PhoneBox AddPhoneComp { get => addPhoneComp; set => addPhoneComp = value; }
        public PhoneBox EditPhoneComp1 { get => editPhoneComp; set => editPhoneComp = value; }
    }
}
