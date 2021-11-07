using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KassirRu
{
    public partial class ForgotPasswordSecond : Form
    {
        ForgotPasswordFirst forgotPasswordFirst;

        public ForgotPasswordSecond()
        {
            InitializeComponent();
        }
        public ForgotPasswordSecond(ForgotPasswordFirst forgotPasswordFirst)
        {
            InitializeComponent();
            this.forgotPasswordFirst = forgotPasswordFirst;
            this.Text = forgotPasswordFirst.textBoxEMail.Text;
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxEnterNewPassword.Text != "")
            {
                if(textBoxEnterNewPassword.Text == textBoxChangePassword.Text)
                {
                    using (UserContext db = new UserContext())
                    {
                        User user = db.Users.Find(db.FindUserWithEMail(this.Text).Id);
                        user.Password = this.GetHashString(textBoxEnterNewPassword.Text);
                        db.SaveChanges();

                        forgotPasswordFirst.authorization.Show();
                        this.Close();
                    }
                } else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Напишите новый пароль");
            }
        }



        // метод для хэширования пароля
        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }

        private void ForgotPasswordSecond_FormClosed(object sender, FormClosedEventArgs e)
        {
            forgotPasswordFirst.Show();
        }
    }
}
