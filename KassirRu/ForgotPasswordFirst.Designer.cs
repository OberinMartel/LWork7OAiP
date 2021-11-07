
namespace KassirRu
{
    partial class ForgotPasswordFirst
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.buttonSendTheCode = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите EMail:";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.textBoxEMail.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEMail.Location = new System.Drawing.Point(16, 34);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(258, 28);
            this.textBoxEMail.TabIndex = 14;
            // 
            // buttonSendTheCode
            // 
            this.buttonSendTheCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonSendTheCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendTheCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendTheCode.Location = new System.Drawing.Point(12, 68);
            this.buttonSendTheCode.Name = "buttonSendTheCode";
            this.buttonSendTheCode.Size = new System.Drawing.Size(264, 42);
            this.buttonSendTheCode.TabIndex = 38;
            this.buttonSendTheCode.Text = "ОТПРАВИТЬ КОД";
            this.buttonSendTheCode.UseVisualStyleBackColor = false;
            this.buttonSendTheCode.Click += new System.EventHandler(this.buttonSendTheCode_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePassword.Location = new System.Drawing.Point(12, 194);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(264, 42);
            this.buttonChangePassword.TabIndex = 41;
            this.buttonChangePassword.Text = "ИЗМЕНИТЬ ПАРОЛЬ";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Введите полученный код:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.textBoxCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.Location = new System.Drawing.Point(16, 160);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(258, 28);
            this.textBoxCode.TabIndex = 39;
            // 
            // ForgotPasswordFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(288, 248);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.buttonSendTheCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEMail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ForgotPasswordFirst";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ForgotPasswordFirst_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSendTheCode;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCode;
        public System.Windows.Forms.TextBox textBoxEMail;
    }
}