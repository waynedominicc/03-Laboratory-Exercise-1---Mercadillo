namespace _03_Laboratory_Exercise_1___Mercadillo
{
    partial class frmConfirmation
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
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNo.Location = new System.Drawing.Point(37, 63);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(89, 18);
            this.lblStudentNo.TabIndex = 2;
            this.lblStudentNo.Text = "Student No. :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(74, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name :";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(59, 146);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(67, 18);
            this.lblProgram.TabIndex = 4;
            this.lblProgram.Text = "Program :";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(87, 187);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 18);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Age :";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(59, 234);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(67, 18);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Birthday :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(64, 286);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(62, 18);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Gender :";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(39, 331);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(87, 18);
            this.lblContactNo.TabIndex = 8;
            this.lblContactNo.Text = "Contact No. :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblStudentNo);
            this.Name = "frmConfirmation";
            this.Text = "frmConfirmation";
            this.Load += new System.EventHandler(this.frmConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Button button1;
    }
}