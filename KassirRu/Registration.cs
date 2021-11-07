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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            //using (UserContext db = new UserContext())
            //{
            //    User user = new User("Admin", this.GetHashString("Admin"), "Admin");
            //    db.Users.Add(user);
            //    db.SaveChanges();
            //}
        }

        // переход на форму авторизации
        private void labelHaveAccount_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Hide();
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

        // обработчик события кнопки "Зарегистрироваться"
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxEnterEMail.Text != "" && textBoxEnterPassword.Text != "" && textBoxRepeatPassword.Text != "")
            {
                if (textBoxEnterPassword.Text == textBoxRepeatPassword.Text)
                {
                    using (UserContext db = new UserContext())
                    {
                        User user = new User(textBoxEnterEMail.Text, this.GetHashString(textBoxEnterPassword.Text), "User");
                        
                        bool flag = true;
                        foreach (User u in db.Users)
                        {
                            if (u.Email == user.Email)
                            {
                                MessageBox.Show("Пользователь с такой почтой уже зарегистрирован");
                                flag = false;
                            }
                        }

                        if (flag)
                        {
                            db.Users.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("Пользователь зарегистрирован");
                            textBoxEnterEMail.Text = "";
                            textBoxEnterPassword.Text = "";
                            textBoxRepeatPassword.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }
    }
}
