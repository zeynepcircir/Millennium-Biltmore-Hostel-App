﻿namespace Millennium_Biltmore_Hostel_App
{
    partial class FrmUpdatePassword
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
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Pink;
            this.BtnLogin.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(322, 269);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(146, 43);
            this.BtnLogin.TabIndex = 9;
            this.BtnLogin.Text = "Update";
            this.BtnLogin.UseVisualStyleBackColor = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BackColor = System.Drawing.Color.Pink;
            this.TxtPassword.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(374, 201);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(222, 35);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.Color.Pink;
            this.TxtUserName.Font = new System.Drawing.Font("Yu Gothic Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.Location = new System.Drawing.Point(374, 135);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(222, 35);
            this.TxtUserName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(189, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(166, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "User Name :";
            // 
            // FrmUpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(214)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdatePassword";
            this.Text = "FrmUpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}