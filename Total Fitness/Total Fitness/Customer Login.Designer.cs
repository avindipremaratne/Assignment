namespace Total_Fitness
{
    partial class Customer_Login
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
            this.btnclogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcpassword = new System.Windows.Forms.TextBox();
            this.txtcusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclogin
            // 
            this.btnclogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnclogin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnclogin.FlatAppearance.BorderSize = 10;
            this.btnclogin.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclogin.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnclogin.Location = new System.Drawing.Point(430, 385);
            this.btnclogin.Name = "btnclogin";
            this.btnclogin.Size = new System.Drawing.Size(126, 32);
            this.btnclogin.TabIndex = 11;
            this.btnclogin.Text = "Login";
            this.btnclogin.UseVisualStyleBackColor = false;
            this.btnclogin.Click += new System.EventHandler(this.btnclogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // txtcpassword
            // 
            this.txtcpassword.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpassword.Location = new System.Drawing.Point(541, 285);
            this.txtcpassword.Name = "txtcpassword";
            this.txtcpassword.Size = new System.Drawing.Size(193, 25);
            this.txtcpassword.TabIndex = 8;
            this.txtcpassword.UseSystemPasswordChar = true;
            // 
            // txtcusername
            // 
            this.txtcusername.Font = new System.Drawing.Font("Microsoft MHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusername.Location = new System.Drawing.Point(541, 204);
            this.txtcusername.Name = "txtcusername";
            this.txtcusername.Size = new System.Drawing.Size(193, 29);
            this.txtcusername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(153, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Fitness Pharmacy Management System";
            // 
            // Customer_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Total_Fitness.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(986, 547);
            this.Controls.Add(this.btnclogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcpassword);
            this.Controls.Add(this.txtcusername);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Login";
            this.Text = "Total Fitness Pharmacy Management System - Customer  Login";
            this.Load += new System.EventHandler(this.Customer_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcpassword;
        private System.Windows.Forms.TextBox txtcusername;
        private System.Windows.Forms.Label label1;
    }
}