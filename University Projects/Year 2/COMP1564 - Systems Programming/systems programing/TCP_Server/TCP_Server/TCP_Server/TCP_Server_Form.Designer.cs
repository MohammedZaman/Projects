/*	File			TCP_Server_Form.Designer.cs
	Purpose			TCP Server example for demonstration purposes
	Author			Richard Anthony	(R.J.Anthony@gre.ac.uk)
	Date			December 2011
	
	Special notes:
		This code has been specially prepared to demonstrate how to create an application using TCP over IP.
		Students following the "Systems Programming" course may use this
		code as a starting point for the development of their coursework.
*/

namespace TCP_Server
{
    partial class TCP_Server_Form
    {
        private System.ComponentModel.IContainer components = null;

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
            this.IP_Address_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.About_button = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReceivePort_textBox = new System.Windows.Forms.TextBox();
            this.Message_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Status_textBox = new System.Windows.Forms.TextBox();
            this.NumberOfClients_textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Accept_button = new System.Windows.Forms.Button();
            this.Listen_button = new System.Windows.Forms.Button();
            this.Bind_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP_Address_textBox
            // 
            this.IP_Address_textBox.Location = new System.Drawing.Point(158, 24);
            this.IP_Address_textBox.Name = "IP_Address_textBox";
            this.IP_Address_textBox.ReadOnly = true;
            this.IP_Address_textBox.Size = new System.Drawing.Size(107, 20);
            this.IP_Address_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local IP Address";
            // 
            // About_button
            // 
            this.About_button.Location = new System.Drawing.Point(21, 454);
            this.About_button.Name = "About_button";
            this.About_button.Size = new System.Drawing.Size(106, 37);
            this.About_button.TabIndex = 2;
            this.About_button.Text = "About";
            this.About_button.UseVisualStyleBackColor = true;
            this.About_button.Click += new System.EventHandler(this.About_button_Click);
            // 
            // Done_button
            // 
            this.Done_button.Location = new System.Drawing.Point(171, 454);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(106, 37);
            this.Done_button.TabIndex = 3;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port for receiving";
            // 
            // ReceivePort_textBox
            // 
            this.ReceivePort_textBox.Location = new System.Drawing.Point(175, 50);
            this.ReceivePort_textBox.Name = "ReceivePort_textBox";
            this.ReceivePort_textBox.Size = new System.Drawing.Size(69, 20);
            this.ReceivePort_textBox.TabIndex = 5;
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(100, 22);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.ReadOnly = true;
            this.Message_textBox.Size = new System.Drawing.Size(165, 20);
            this.Message_textBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message received";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Status_textBox);
            this.groupBox1.Controls.Add(this.NumberOfClients_textBox);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Accept_button);
            this.groupBox1.Controls.Add(this.Listen_button);
            this.groupBox1.Controls.Add(this.Bind_button);
            this.groupBox1.Controls.Add(this.ReceivePort_textBox);
            this.groupBox1.Controls.Add(this.IP_Address_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 273);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // Status_textBox
            // 
            this.Status_textBox.Location = new System.Drawing.Point(45, 244);
            this.Status_textBox.Name = "Status_textBox";
            this.Status_textBox.ReadOnly = true;
            this.Status_textBox.Size = new System.Drawing.Size(187, 20);
            this.Status_textBox.TabIndex = 12;
            // 
            // NumberOfClients_textBox
            // 
            this.NumberOfClients_textBox.Location = new System.Drawing.Point(196, 219);
            this.NumberOfClients_textBox.Name = "NumberOfClients_textBox";
            this.NumberOfClients_textBox.ReadOnly = true;
            this.NumberOfClients_textBox.Size = new System.Drawing.Size(36, 20);
            this.NumberOfClients_textBox.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(266, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of connected Clients";
            // 
            // Accept_button
            // 
            this.Accept_button.Location = new System.Drawing.Point(43, 164);
            this.Accept_button.Name = "Accept_button";
            this.Accept_button.Size = new System.Drawing.Size(189, 37);
            this.Accept_button.TabIndex = 8;
            this.Accept_button.Text = "Accept Connection request";
            this.Accept_button.UseVisualStyleBackColor = true;
            this.Accept_button.Click += new System.EventHandler(this.Accept_button_Click);
            // 
            // Listen_button
            // 
            this.Listen_button.Location = new System.Drawing.Point(43, 122);
            this.Listen_button.Name = "Listen_button";
            this.Listen_button.Size = new System.Drawing.Size(189, 37);
            this.Listen_button.TabIndex = 7;
            this.Listen_button.Text = "Listen for Connection requests";
            this.Listen_button.UseVisualStyleBackColor = true;
            this.Listen_button.Click += new System.EventHandler(this.Listen_button_Click);
            // 
            // Bind_button
            // 
            this.Bind_button.Location = new System.Drawing.Point(90, 81);
            this.Bind_button.Name = "Bind_button";
            this.Bind_button.Size = new System.Drawing.Size(95, 37);
            this.Bind_button.TabIndex = 6;
            this.Bind_button.Text = "Bind to port";
            this.Bind_button.UseVisualStyleBackColor = true;
            this.Bind_button.Click += new System.EventHandler(this.Bind_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Message_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 99);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // TCP_Server_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 598);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.About_button);
            this.Name = "TCP_Server_Form";
            this.Text = "TCP_Server    C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox IP_Address_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button About_button;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReceivePort_textBox;
        private System.Windows.Forms.TextBox Message_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Bind_button;
        private System.Windows.Forms.Button Accept_button;
        private System.Windows.Forms.Button Listen_button;
        private System.Windows.Forms.TextBox NumberOfClients_textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Status_textBox;
    }
}

