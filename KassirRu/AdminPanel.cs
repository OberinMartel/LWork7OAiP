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
    public partial class AdminPanel : Form
    {
        Authorization authorization;
        User user = new User();
        User userInMainMenu = new User();
        public AdminPanel()
        {
            InitializeComponent();
        }
        public AdminPanel(Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
        }

        // обработчик события выбора пользователя из списка с пользователями
        private void listBoxWithUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBoxWithUsers.SelectedItem.ToString() != "" && listBoxWithUsers.SelectedItem.ToString() != null)
                {
                    User user;
                    using (UserContext db = new UserContext())
                    {
                        user = db.FindUserWithID(GetUserIDFromString(listBoxWithUsers.SelectedItem.ToString(), ')'));
                    }
                    userInMainMenu = user;
                    textBoxEMail.Text = user.Email;
                    textBoxPassword.Text = "secret";
                    textBoxRole.Text = user.Role;
                }
            } catch
            {

            }
        }

        // обработчик события изменения видимости панели администратора
        private void AdminPanel_VisibleChanged(object sender, EventArgs e)
        {
            // поиск пользователя в БД
            using (UserContext db = new UserContext())
            {
                user = db.FindUserWithEMail(this.Text);
            }

            // обновление листбокса
            listBoxWithUsersUpdate();
        }

        // метод обновления листбокса с мероприятиями
        private void listBoxWithUsersUpdate()
        {

                if (listBoxWithUsers.SelectedIndex.ToString() != "")
                {
                    using (UserContext db = new UserContext())
                    {
                        listBoxWithUsers.Items.Clear();
                        foreach (User user in db.Users)
                        {
                            listBoxWithUsers.Items.Add($"{user.Id}) Почта: {user.Email}");
                        }
                    }
                }
        }

        // метод извлечения ID из строки
        private int GetUserIDFromString(string s, char c)
        {
            string sRes = "";

            for (int i = 0; i < s.Length; i++)
            {
                while (s[i] != c)
                {
                    sRes += s[i];
                    i++;
                }
                if (s[i] == c) break;
            }
            return int.Parse(sRes);
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

        // обработчик события клика по кнопке "Добавить пользователя"
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (textBoxEMail.Text != "" && textBoxPassword.Text != "" && textBoxRole.Text != "")
            {
                if (textBoxRole.Text == "User" || textBoxRole.Text == "Manager" || textBoxRole.Text == "Admin")
                {
                    using (UserContext db = new UserContext())
                    {
                        User user = new User(textBoxEMail.Text, this.GetHashString(textBoxPassword.Text), "User");

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
                            textBoxEMail.Text = "";
                            textBoxPassword.Text = "";
                            textBoxRole.Text = "";
                        }
                    }
                    AdminPanel_VisibleChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Некорректно введена роль(User, Manager, Admin)");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        // обработчик события клика по кнопке "Удалить пользователя"
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxWithUsers.SelectedItem != null)
            {
                using (UserContext db = new UserContext())
                {
                    User user = db.Users.Find(userInMainMenu.Id);
                    if (user.Email != this.Text)
                    {
                        db.Users.Remove(user);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Учетную запись администратора может удалить только другой администратор");
                    }
                }
                AdminPanel_VisibleChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Выберите пользователя из списка.");
            }
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            User user = userInMainMenu;

            if (textBoxEMail.Text != "" && textBoxEMail.Text != user.Email)
            {
                using (UserContext db = new UserContext())
                {
                    User tempUser = db.Users.Find(user.Id);

                    bool flag = true;
                    foreach (User u in db.Users)
                    {
                        if (u.Email == textBoxEMail.Text)
                        {
                            MessageBox.Show("Пользователь с такой почтой уже зарегистрирован");
                            flag = false;
                        }
                    }

                    if (flag)
                    {
                        tempUser.Email = textBoxEMail.Text;
                        db.SaveChanges();
                        user = tempUser;
                    }
                }
            }

            if (textBoxPassword.Text != "" && GetHashString(textBoxPassword.Text) != user.Password)
            {
                using (UserContext db = new UserContext())
                {
                    user = db.Users.Find(user.Id);
                    user.Password = GetHashString(textBoxPassword.Text);
                    db.SaveChanges();
                }
            }

            if (textBoxRole.Text != "" && textBoxRole.Text != user.Role)
            {
                if (textBoxRole.Text == "User" || textBoxRole.Text == "Manager" || textBoxRole.Text == "Admin")
                {
                    using (UserContext db = new UserContext())
                    {
                        user = db.Users.Find(user.Id);
                        user.Role = textBoxEMail.Text;
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Некорректно введена роль(User, Manager, Admin)");
                }                
            }
            AdminPanel_VisibleChanged(sender, e);
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }
    }
}
