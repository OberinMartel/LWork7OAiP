
namespace KassirRu
{
    partial class Authorization
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
            this.labelHaveNotAccount = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEnterPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEnterEMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForgotPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHaveNotAccount
            // 
            this.labelHaveNotAccount.AutoSize = true;
            this.labelHaveNotAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHaveNotAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.labelHaveNotAccount.Location = new System.Drawing.Point(8, 241);
            this.labelHaveNotAccount.Name = "labelHaveNotAccount";
            this.labelHaveNotAccount.Size = new System.Drawing.Size(111, 19);
            this.labelHaveNotAccount.TabIndex = 17;
            this.labelHaveNotAccount.Text = "Нет аккаунта";
            this.labelHaveNotAccount.Click += new System.EventHandler(this.labelNoAccount_Click);
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.Location = new System.Drawing.Point(12, 197);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(258, 39);
            this.buttonLogIn.TabIndex = 16;
            this.buttonLogIn.Text = "ВОЙТИ";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Введите пароль:";
            // 
            // textBoxEnterPassword
            // 
            this.textBoxEnterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.textBoxEnterPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterPassword.Location = new System.Drawing.Point(12, 154);
            this.textBoxEnterPassword.Name = "textBoxEnterPassword";
            this.textBoxEnterPassword.Size = new System.Drawing.Size(258, 28);
            this.textBoxEnterPassword.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите EMail:";
            // 
            // textBoxEnterEMail
            // 
            this.textBoxEnterEMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.textBoxEnterEMail.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEnterEMail.Location = new System.Drawing.Point(12, 98);
            this.textBoxEnterEMail.Name = "textBoxEnterEMail";
            this.textBoxEnterEMail.Size = new System.Drawing.Size(258, 28);
            this.textBoxEnterEMail.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // labelForgotPassword
            // 
            this.labelForgotPassword.AutoSize = true;
            this.labelForgotPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(100)))), ((int)(((byte)(113)))));
            this.labelForgotPassword.Location = new System.Drawing.Point(140, 241);
            this.labelForgotPassword.Name = "labelForgotPassword";
            this.labelForgotPassword.Size = new System.Drawing.Size(140, 19);
            this.labelForgotPassword.TabIndex = 18;
            this.labelForgotPassword.Text = "Забыл(а) пароль";
            this.labelForgotPassword.Click += new System.EventHandler(this.labelForgotPassword_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(292, 269);
            this.Controls.Add(this.labelForgotPassword);
            this.Controls.Add(this.labelHaveNotAccount);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEnterPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEnterEMail);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHaveNotAccount;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxEnterPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEnterEMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForgotPassword;
    }
}