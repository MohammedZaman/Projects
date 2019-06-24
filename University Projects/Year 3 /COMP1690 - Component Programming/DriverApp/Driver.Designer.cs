namespace DriverApp
{
    partial class Driver
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startDayBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startJBtn = new System.Windows.Forms.Button();
            this.endDayBtn = new System.Windows.Forms.Button();
            this.endJBtn = new System.Windows.Forms.Button();
            this.DriverLbl = new System.Windows.Forms.Label();
            this.DriverIdTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startDayBtn
            // 
            this.startDayBtn.Location = new System.Drawing.Point(6, 19);
            this.startDayBtn.Name = "startDayBtn";
            this.startDayBtn.Size = new System.Drawing.Size(151, 23);
            this.startDayBtn.TabIndex = 0;
            this.startDayBtn.Text = "Start Day";
            this.startDayBtn.UseVisualStyleBackColor = true;
            this.startDayBtn.Click += new System.EventHandler(this.startDayBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.endDayBtn);
            this.groupBox1.Controls.Add(this.startDayBtn);
            this.groupBox1.Location = new System.Drawing.Point(59, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Day";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.endJBtn);
            this.groupBox2.Controls.Add(this.startJBtn);
            this.groupBox2.Location = new System.Drawing.Point(293, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Journey";
            // 
            // startJBtn
            // 
            this.startJBtn.Location = new System.Drawing.Point(6, 19);
            this.startJBtn.Name = "startJBtn";
            this.startJBtn.Size = new System.Drawing.Size(151, 23);
            this.startJBtn.TabIndex = 0;
            this.startJBtn.Text = "Start Journey";
            this.startJBtn.UseVisualStyleBackColor = true;
            this.startJBtn.Click += new System.EventHandler(this.startJBtn_Click);
            // 
            // endDayBtn
            // 
            this.endDayBtn.Location = new System.Drawing.Point(6, 100);
            this.endDayBtn.Name = "endDayBtn";
            this.endDayBtn.Size = new System.Drawing.Size(151, 23);
            this.endDayBtn.TabIndex = 1;
            this.endDayBtn.Text = "End Day";
            this.endDayBtn.UseVisualStyleBackColor = true;
            this.endDayBtn.Click += new System.EventHandler(this.endDayBtn_Click);
            // 
            // endJBtn
            // 
            this.endJBtn.Location = new System.Drawing.Point(6, 100);
            this.endJBtn.Name = "endJBtn";
            this.endJBtn.Size = new System.Drawing.Size(151, 23);
            this.endJBtn.TabIndex = 1;
            this.endJBtn.Text = "End Journey";
            this.endJBtn.UseVisualStyleBackColor = true;
            this.endJBtn.Click += new System.EventHandler(this.endJBtn_Click);
            // 
            // DriverLbl
            // 
            this.DriverLbl.AutoSize = true;
            this.DriverLbl.Location = new System.Drawing.Point(122, 23);
            this.DriverLbl.Name = "DriverLbl";
            this.DriverLbl.Size = new System.Drawing.Size(49, 13);
            this.DriverLbl.TabIndex = 3;
            this.DriverLbl.Text = "Driver ID";
            // 
            // DriverIdTxt
            // 
            this.DriverIdTxt.Location = new System.Drawing.Point(177, 20);
            this.DriverIdTxt.Name = "DriverIdTxt";
            this.DriverIdTxt.Size = new System.Drawing.Size(237, 20);
            this.DriverIdTxt.TabIndex = 4;
            // 
            // Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 328);
            this.Controls.Add(this.DriverIdTxt);
            this.Controls.Add(this.DriverLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Driver";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startDayBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button endDayBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button endJBtn;
        private System.Windows.Forms.Button startJBtn;
        private System.Windows.Forms.Label DriverLbl;
        private System.Windows.Forms.TextBox DriverIdTxt;
    }
}

