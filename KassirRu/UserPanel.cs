using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KassirRu
{
    public partial class UserPanel : Form
    {
        Authorization authorization;
        User user = new User();
        TicketPack ticketPackInMainMenu = new TicketPack("0", 0, 0, DateTime.Now, "0");
        TicketPack ticketPackInPersonMenu = new TicketPack("0", 0, 0, DateTime.Now, "0");
        Contract contractInPersonMenu;
        public UserPanel()
        {
            InitializeComponent();
        }
        public UserPanel(Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
        }

        // обработчик события при нажатии на чекбокс
        private void checkBoxBuySeveral_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBuySeveral.Checked)
            {
                labelAmountOfAdditionalTickets.Show();
                labelEndSum.Show();
                textBoxNumberOfTickets.Show();
            }
            else
            {
                labelAmountOfAdditionalTickets.Hide();
                labelEndSum.Hide();
                textBoxNumberOfTickets.Hide();
            }
        }

        // обработчик события изменения видимости панели пользователя
        private void UserPanel_VisibleChanged(object sender, EventArgs e)
        {
            // поиск пользователя в БД
            using(UserContext db = new UserContext())
            {
                user = db.FindUserWithEMail(this.Text);
            }

            // обновление листбоксов
            listBoxWithAllEventsUpdate();
            listBoxWithPurchasedTicketsUpdate();

            // обновление баланса
            labelBalance.Text = $"Баланс: {user.Money} руб.";
        }

        // обработчик события выбора мероприятия из списка с мероприятиями
        private void listBoxWithAllEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxWithAllEvents.SelectedItem != null)
            {
                if (listBoxWithAllEvents.SelectedItem.ToString() != "")
                {
                    TicketPack ticketPack;
                    using (TicketPackContext db = new TicketPackContext())
                    {
                        ticketPack = db.FindTicketPackWithID(GetEventIDFromString(listBoxWithAllEvents.SelectedItem.ToString(), ')'));
                    }
                    ticketPackInMainMenu = ticketPack;
                    labelEventName.Text = ticketPack.Name;
                    labelEventDate.Text = $"Дата мероприятия: {ticketPack.Date.ToString()}";
                    labelTicketCost.Text = $"Стоимость одного билета: {ticketPack.Cost} руб.";
                    labelTicketAmount.Text = $"Количество нераспроданных билетов: {ticketPack.Amount}";
                }
            }
        }

        // обработчик события выбора мероприятия из списка с купленными билетами
        private void listBoxWithPurchasedTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxWithPurchasedTickets.SelectedItem != null)
            {
                if (listBoxWithPurchasedTickets.SelectedItem.ToString() != "")
                {
                    using (ContractContext db = new ContractContext())
                    {
                        contractInPersonMenu = db.FindContractWithID(GetEventIDFromString(listBoxWithPurchasedTickets.SelectedItem.ToString(), ')'));
                    }

                    TicketPack ticketPack;
                    using (TicketPackContext db = new TicketPackContext())
                    {
                        ticketPack = db.FindTicketPackWithName(contractInPersonMenu.Event_Name);
                    }
                    labelEventNameOfPurchasedTicket.Text = ticketPack.Name;
                    labelEventDateOfPurchasedTicket.Text = $"Дата мероприятия: {ticketPack.Date.ToString()}";
                    labelTicketCostOfPurchasedTicket.Text = $"Стоимость одного билета: {ticketPack.Cost} руб.";
                    if (contractInPersonMenu.Reserv == 0)
                    {
                        labelTicketAmountOfPurchasedTicket.Text = $"Количество купленных билетов: {contractInPersonMenu.Sum / ticketPack.Cost}";
                        buttonReturnTicket.Enabled = true;
                        buttonCancelReservation.Enabled = false;
                    }
                    else
                    {
                        labelTicketAmountOfPurchasedTicket.Text = $"Количество забронированных билетов: {contractInPersonMenu.Reserv}";
                        buttonReturnTicket.Enabled = false;
                        buttonCancelReservation.Enabled = true;
                    }
                }
            }
        }

        // обработчик события ввода кол-ва билетов при покупке нескольких билетов
        private void textBoxNumberOfTickets_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxNumberOfTickets.Text = textBoxNumberOfTickets.Text == "" ? "0" : textBoxNumberOfTickets.Text;
                int numOfTickets = int.Parse(textBoxNumberOfTickets.Text);
                labelEndSum.Text = $"Итоговая стоимость: {ticketPackInMainMenu.Cost * numOfTickets}";
            } catch
            {
                MessageBox.Show("Вводите целое число.");
            }
        }

        // метод обновления листбокса с мероприятиями
        private void listBoxWithAllEventsUpdate()
        {
            using (TicketPackContext db = new TicketPackContext())
            {
                listBoxWithAllEvents.Items.Clear();
                foreach (TicketPack ticketPack in db.TicketPacks)
                {
                    listBoxWithAllEvents.Items.Add($"{ticketPack.Id}) Мероприятие: {ticketPack.Name}");
                }
            }
        }

        // метод обновления листбокса с купленными билетами
        private void listBoxWithPurchasedTicketsUpdate()
        {
            using (ContractContext db = new ContractContext())
            {
                listBoxWithPurchasedTickets.Items.Clear();
                foreach (Contract contract in db.Contracts)
                {
                    if(this.Text == contract.Buyer)
                    {
                        listBoxWithPurchasedTickets.Items.Add($"{contract.Id}) Мероприятие: {contract.Event_Name}");
                    }
                }
            }
        }

        // метод извлечения ID из строки
        private int GetEventIDFromString(string s, char c)
        {
            string sRes = "";

            for(int i = 0; i < s.Length; i++)
            {
                while(s[i] != c)
                {
                    sRes += s[i];
                    i++;
                }
                if (s[i] == c) break;
            }
            return int.Parse(sRes);
        }

        // обработчик события клика по кнопке "Пополнить баланс"
        private void buttonAddMoney_Click(object sender, EventArgs e)
        {
            if (textBoxAddMoney.Visible)
            {
                using (UserContext db = new UserContext())
                {
                    user = db.Users.Find(db.FindUserWithEMail(this.Text).Id);
                    user.Money += decimal.Parse(textBoxAddMoney.Text);
                    db.SaveChanges();
                }

                labelBalance.Text = $"Баланс: {user.Money} руб.";

                labelAddMoney.Hide();
                textBoxAddMoney.Hide();
            } else
            {
                labelAddMoney.Show();
                textBoxAddMoney.Show();
            }
        }

        // обработчик события клика по кнопке "Вернуть средства"
        private void buttonReturnMoney_Click(object sender, EventArgs e)
        {
            if (textBoxReturnMoney.Visible)
            {
                using (UserContext db = new UserContext())
                {
                    user = db.Users.Find(db.FindUserWithEMail(this.Text).Id);
                    user.Money -= decimal.Parse(textBoxReturnMoney.Text);
                    db.SaveChanges();
                }

                labelBalance.Text = $"Баланс: {user.Money} руб.";

                labelReturnMoney.Hide();
                textBoxReturnMoney.Hide();
            }
            else
            {
                labelReturnMoney.Show();
                textBoxReturnMoney.Show();
            }
        }

        // обработчик события клика по кнопке "Купить билет"
        private void buttonBuyTicket_Click(object sender, EventArgs e)
        {
            if(ticketPackInMainMenu != null)
            {
                if (checkBoxBuySeveral.Checked)
                {
                    if(textBoxNumberOfTickets.Text != "")
                    {
                        int amount = int.Parse(textBoxNumberOfTickets.Text);

                        using (TicketPackContext db = new TicketPackContext())
                        {
                            ticketPackInMainMenu = db.TicketPacks.Find(ticketPackInMainMenu.Id);

                            if (ticketPackInMainMenu.Amount - amount > 0)
                            {
                                ticketPackInMainMenu.Amount -= amount;
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Билеты закончились");
                                return;
                            }
                        }

                        using (UserContext db = new UserContext())
                        {
                            user = db.Users.Find(db.FindUserWithEMail(this.Text).Id);

                            if (user.Money - ticketPackInMainMenu.Cost * amount >= 0)
                            {
                                user.Money -= ticketPackInMainMenu.Cost * amount;
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Недостаточно средств на балансе");
                                return;
                            }
                        }

                        Contract contract;
                        using (ContractContext db = new ContractContext())
                        {
                            contract = new Contract(DateTime.Now, ticketPackInMainMenu.Name, ticketPackInMainMenu.Cost * amount, user.Email, ticketPackInMainMenu.Manager);

                            db.Contracts.Add(contract);
                            db.SaveChanges();
                        }

                        UserPanel_VisibleChanged(sender, e);
                    }
                } else
                {
                    using (TicketPackContext db = new TicketPackContext())
                    {
                        ticketPackInMainMenu = db.TicketPacks.Find(ticketPackInMainMenu.Id);

                        if (ticketPackInMainMenu.Amount > 0)
                        {
                            ticketPackInMainMenu.Amount--;
                            db.SaveChanges();
                        } else
                        {
                            MessageBox.Show("Билеты закончились");
                            return;
                        }
                    }

                    using (UserContext db = new UserContext())
                    {
                        user = db.Users.Find(db.FindUserWithEMail(this.Text).Id);

                        if (user.Money - ticketPackInMainMenu.Cost >= 0)
                        {
                            user.Money -= ticketPackInMainMenu.Cost;
                            db.SaveChanges();
                        } else
                        {
                            MessageBox.Show("Недостаточно средств на балансе");
                            return;
                        }
                    }

                    Contract contract;
                    using (ContractContext db = new ContractContext())
                    {
                        contract = new Contract(DateTime.Now, ticketPackInMainMenu.Name, ticketPackInMainMenu.Cost, user.Email, ticketPackInMainMenu.Manager);

                        db.Contracts.Add(contract);
                        db.SaveChanges();
                    }

                    UserPanel_VisibleChanged(sender, e);
                }
            }
        }

        // обработчик события клика по кнопке "Забронировать билет"
        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (ticketPackInMainMenu != null)
            {
                if (checkBoxBuySeveral.Checked)
                {
                    if (textBoxNumberOfTickets.Text != "")
                    {
                        int amount = int.Parse(textBoxNumberOfTickets.Text);

                        using (TicketPackContext db = new TicketPackContext())
                        {
                            ticketPackInMainMenu = db.TicketPacks.Find(ticketPackInMainMenu.Id);

                            if (ticketPackInMainMenu.Amount - amount > 0)
                            {
                                ticketPackInMainMenu.Amount -= amount;
                                ticketPackInMainMenu.Reservation_Amount += amount;
                                db.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Билеты закончились");
                                return;
                            }
                        }

                        Contract contract;
                        using (ContractContext db = new ContractContext())
                        {
                            contract = new Contract(DateTime.Now, ticketPackInMainMenu.Name, ticketPackInMainMenu.Cost * amount, user.Email, ticketPackInMainMenu.Manager, amount);

                            db.Contracts.Add(contract);
                            db.SaveChanges();
                        }

                        UserPanel_VisibleChanged(sender, e);
                    }
                }
                else
                {
                    using (TicketPackContext db = new TicketPackContext())
                    {
                        ticketPackInMainMenu = db.TicketPacks.Find(ticketPackInMainMenu.Id);

                        if (ticketPackInMainMenu.Amount > 0)
                        {
                            ticketPackInMainMenu.Amount--;
                            ticketPackInMainMenu.Reservation_Amount++;
                            db.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Билеты закончились");
                            return;
                        }
                    }

                    Contract contract;
                    using (ContractContext db = new ContractContext())
                    {
                        contract = new Contract(DateTime.Now, ticketPackInMainMenu.Name, ticketPackInMainMenu.Cost, user.Email, ticketPackInMainMenu.Manager, 1);

                        db.Contracts.Add(contract);
                        db.SaveChanges();
                    }

                    UserPanel_VisibleChanged(sender, e);
                }
            }
        }

        // обработчик события клика по кнопке "Вернуть деньги"
        private void buttonReturnTicket_Click(object sender, EventArgs e)
        {
            using (TicketPackContext db = new TicketPackContext())
            {
                ticketPackInPersonMenu = db.TicketPacks.Find(ticketPackInMainMenu.Id);
                ticketPackInPersonMenu.Amount += Convert.ToInt32(contractInPersonMenu.Sum / ticketPackInPersonMenu.Cost);
                db.SaveChanges();
            }

            using (UserContext db = new UserContext())
            {
                user = db.Users.Find(db.FindUserWithEMail(this.Text).Id);
                user.Money += contractInPersonMenu.Sum;
                db.SaveChanges();
            }

            using (ContractContext db = new ContractContext())
            {
                contractInPersonMenu = db.Contracts.Find(db.FindContractWithID(GetEventIDFromString(listBoxWithPurchasedTickets.SelectedItem.ToString(), ')')).Id);
                db.Contracts.Remove(contractInPersonMenu);
                db.SaveChanges();
            }

            UserPanel_VisibleChanged(sender, e);
        }

        // обработчик события клика по кнопке "Отменить бронь"
        private void buttonCancelReservation_Click(object sender, EventArgs e)
        {
            using (TicketPackContext db = new TicketPackContext())
            {
                ticketPackInPersonMenu = db.TicketPacks.Find(ticketPackInMainMenu.Id);
                ticketPackInPersonMenu.Amount += contractInPersonMenu.Reserv;
                ticketPackInPersonMenu.Reservation_Amount -= contractInPersonMenu.Reserv;
                db.SaveChanges();
            }

            using(ContractContext db = new ContractContext())
            {
                contractInPersonMenu = db.Contracts.Find(db.FindContractWithID(GetEventIDFromString(listBoxWithPurchasedTickets.SelectedItem.ToString(), ')')).Id);
                db.Contracts.Remove(contractInPersonMenu);
                db.SaveChanges();
            }

            UserPanel_VisibleChanged(sender, e);
        }

        private void UserPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }
    }
}
