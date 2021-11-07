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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        // обработчик события строчки "Зарегистрироваться"
        private void labelNoAccount_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        // обработчик события строчки "Забыл(а) пароль"
        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordFirst forgotPasswordFirst = new ForgotPasswordFirst(this);
            forgotPasswordFirst.Show();
            this.Hide();
        }

        // обработчик события кнопки "Авторизоваться"
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxEnterEMail.Text != "" && textBoxEnterPassword.Text != "")
            {
                using (UserContext db = new UserContext())
                {
                    foreach (User user in db.Users)
                    {
                        if (textBoxEnterEMail.Text == user.Email && this.GetHashString(textBoxEnterPassword.Text) == user.Password)
                        {
                            if (user.Role == "User      ")
                            {
                                MessageBox.Show("Вход успешен!");
                                UserPanel userPanel = new UserPanel(this);
                                userPanel.Text = user.Email;
                                userPanel.Show();
                                this.Visible = false;
                                textBoxEnterEMail.Text = "";
                                textBoxEnterPassword.Text = "";
                                return;
                            }
                            else if (user.Role == "Manager   ")
                            {
                                MessageBox.Show("Вход успешен!");
                                ManagerPanel managerPanel = new ManagerPanel(this);
                                managerPanel.Text = user.Email;
                                managerPanel.Show();
                                this.Visible = false;
                                textBoxEnterEMail.Text = "";
                                textBoxEnterPassword.Text = "";
                                return;
                            }
                            else if (user.Role == "Admin     ")
                            {
                                MessageBox.Show("Вход успешен!");
                                AdminPanel adminPanel = new AdminPanel(this);
                                adminPanel.Text = user.Email;
                                adminPanel.Show();
                                this.Visible = false;
                                textBoxEnterEMail.Text = "";
                                textBoxEnterPassword.Text = "";
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Логин или пароль указан неверно!");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
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
    }
}
