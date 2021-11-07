using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace KassirRu
{
    public partial class ForgotPasswordFirst : Form
    {
        public Authorization authorization;
        int code;
        Random rnd = new Random();
        MailAddress from = new MailAddress("m79172942106@gmail.com", "Служба продажи билетов");
        
        public ForgotPasswordFirst()
        {
            InitializeComponent();
        }
        public ForgotPasswordFirst(Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
        }

        // обработчик события клика по кнопке "Отправить код"
        private void buttonSendTheCode_Click(object sender, EventArgs e)
        {
            if (textBoxEMail.Text != "")
            {
                using (UserContext db = new UserContext())
                {
                    bool flag = true;
                    foreach (User user in db.Users)
                    {
                        if (textBoxEMail.Text == user.Email)
                        {
                            code = rnd.Next(1000, 9999);

                            MailAddress to = new MailAddress(textBoxEMail.Text);
                            MailMessage message = new MailMessage(from, to);
                            message.Subject = "Проверочный код";
                            message.Body = $"<h2>Проверочный код: {code}</h2>";
                            message.IsBodyHtml = true;
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                            smtp.Credentials = new NetworkCredential("m79172942106@gmail.com", "rabota000doma");
                            smtp.EnableSsl = true;
                            smtp.Send(message);
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        MessageBox.Show("Введённая почта не зарегистрирована");
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите электронную почту");
            }
        }

        // обработчик события клика по кнопке "Изменить пароль"
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text != "")
            {
                if (int.Parse(textBoxCode.Text) == code)
                {
                    ForgotPasswordSecond forgotPasswordSecond = new ForgotPasswordSecond(this);
                    forgotPasswordSecond.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Код неверный");
                }
            }
            else
            {
                MessageBox.Show("Введите проверочный код");
            }
        }

        private void ForgotPasswordFirst_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }
    }
}
