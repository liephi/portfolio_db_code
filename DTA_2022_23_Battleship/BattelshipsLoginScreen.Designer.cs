﻿namespace DTA_2022_23_Battleship
{
    partial class BattelshipsLoginScreen
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
            this.Login = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUsername_newAccount = new System.Windows.Forms.TextBox();
            this.txtPassword_newAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATTELSHIPS";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(174, 212);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(46, 20);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(174, 235);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(125, 27);
            this.txtUsername.TabIndex = 4;
            // 
            // txtUsername_newAccount
            // 
            this.txtUsername_newAccount.Location = new System.Drawing.Point(428, 188);
            this.txtUsername_newAccount.Name = "txtUsername_newAccount";
            this.txtUsername_newAccount.Size = new System.Drawing.Size(125, 27);
            this.txtUsername_newAccount.TabIndex = 5;
            // 
            // txtPassword_newAccount
            // 
            this.txtPassword_newAccount.Location = new System.Drawing.Point(428, 296);
            this.txtPassword_newAccount.Name = "txtPassword_newAccount";
            this.txtPassword_newAccount.Size = new System.Drawing.Size(125, 27);
            this.txtPassword_newAccount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "new Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "new Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(174, 288);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Birthday (DD/MM/YYYY)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 12;
            // 
            // BattelshipsLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword_newAccount);
            this.Controls.Add(this.txtUsername_newAccount);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Name = "BattelshipsLoginScreen";
            this.Text = "BattelshipsLoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label Login;
        private Button button1;
        private Button button2;
        private TextBox txtUsername;
        private TextBox txtUsername_newAccount;
        private TextBox txtPassword_newAccount;
        private Label label3;
        private Label label4;
        private Label label2;
        private TextBox txtPassword;
        private Label label5;
        private TextBox textBox1;
    }
}