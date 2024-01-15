namespace yes
{
    partial class form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nume2 = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.parola2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Înregistrare";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label2.Location = new System.Drawing.Point(143, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label3.Location = new System.Drawing.Point(143, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label4.Location = new System.Drawing.Point(143, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola";
            // 
            // nume2
            // 
            this.nume2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.nume2.Location = new System.Drawing.Point(359, 146);
            this.nume2.Name = "nume2";
            this.nume2.Size = new System.Drawing.Size(260, 34);
            this.nume2.TabIndex = 4;
            this.nume2.TabStop = false;
            this.nume2.MouseEnter += new System.EventHandler(this.nume2_MouseEnter);
            this.nume2.MouseLeave += new System.EventHandler(this.nume2_MouseLeave);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.email.Location = new System.Drawing.Point(359, 225);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(260, 34);
            this.email.TabIndex = 5;
            this.email.TabStop = false;
            this.email.MouseEnter += new System.EventHandler(this.email_MouseEnter);
            this.email.MouseLeave += new System.EventHandler(this.email_MouseLeave);
            // 
            // parola2
            // 
            this.parola2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.parola2.Location = new System.Drawing.Point(359, 305);
            this.parola2.Name = "parola2";
            this.parola2.Size = new System.Drawing.Size(260, 34);
            this.parola2.TabIndex = 6;
            this.parola2.TabStop = false;
            this.parola2.UseSystemPasswordChar = true;
            this.parola2.MouseEnter += new System.EventHandler(this.parola2_MouseEnter);
            this.parola2.MouseLeave += new System.EventHandler(this.parola2_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 29F);
            this.button1.Location = new System.Drawing.Point(359, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 67);
            this.button1.TabIndex = 7;
            this.button1.TabStop = false;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.parola2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.nume2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form2";
            this.Text = "Înregistrare";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nume2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox parola2;
        private System.Windows.Forms.Button button1;
    }
}