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
    public partial class ManagerPanel : Form
    {
        Authorization authorization;
        User user = new User();
        TicketPack ticketPackInMainMenu;
        Stock stockInStockMenu;
        public ManagerPanel()
        {
            InitializeComponent();
        }
        public ManagerPanel(Authorization authorization)
        {
            InitializeComponent();
            this.authorization = authorization;
        }

        // обработчик события изменения видимости панели менеджера
        private void ManagerPanel_VisibleChanged(object sender, EventArgs e)
        {
            // поиск пользователя в БД
            using (UserContext db = new UserContext())
            {
                user = db.FindUserWithEMail(this.Text);
            }

            // обновление листбоксов
            listBoxWithAllEventsUpdate();
            listBoxWithContractsUpdate();
            listBoxWithStocksUpdate();
        }

        // обработчик события выбора мероприятия из списка
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
                    textBoxEventName.Text = ticketPack.Name.ToString();
                    textBoxEventDate.Text = ticketPack.Date.ToString();
                    textBoxTicketCost.Text = ticketPack.Cost.ToString();
                    textBoxTicketAmount.Text = ticketPack.Amount.ToString();
                }
            }
        }

        // обработчик события выбора мероприятия из списка
        private void listBoxWithContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWithContracts.SelectedItem != null)
            {
                if (listBoxWithContracts.SelectedItem.ToString() != "")
                {
                    Contract contract;
                    using (ContractContext db = new ContractContext())
                    {
                        contract = db.FindContractWithID(GetEventIDFromString(listBoxWithContracts.SelectedItem.ToString(), ')'));
                    }
                    labelContractDate.Text = $"Дата заключения: {contract.Registration_Date.ToString()}";
                    labelContractId.Text = $"Номер договора: {contract.Id.ToString()}";
                    labelContractEventName.Text = $"Название мероприятия: {contract.Event_Name.ToString()}";
                    labelContractMoney.Text = $"Сумма покупки: {contract.Sum.ToString()}";
                    labelContractUser.Text = $"Покупатель: {contract.Buyer.ToString()}";
                }
            }
        }

        // обработчик события выбора мероприятия из списка
        private void listBoxWithStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWithStocks.SelectedItem != null)
            {
                if (listBoxWithStocks.SelectedItem.ToString() != "")
                {
                    Stock stock;
                    using (StockContext db = new StockContext())
                    {
                        stock = db.FindStockWithID(GetEventIDFromString(listBoxWithContracts.SelectedItem.ToString(), ')'));
                    }
                    stockInStockMenu = stock;
                    textBoxStockDateStart.Text = stock.DateStart.ToString();
                    textBoxStockDateEnd.Text = stock.DateEnd.ToString();
                    textBoxStockPercent.Text = stock.Percent.ToString();
                    textBoxStockEventID.Text = stock.EventID.ToString();
                }
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

        // метод обновления листбокса с договорами
        private void listBoxWithContractsUpdate()
        {
            using (ContractContext db = new ContractContext())
            {
                listBoxWithContracts.Items.Clear();
                foreach (Contract contract in db.Contracts)
                {
                    if (contract.Seller == this.Text)
                    {
                        listBoxWithContracts.Items.Add($"{contract.Id}) Пользователь: {contract.Buyer}");
                    }
                }
            }
        }

        // метод обновления листбокса с договорами
        private void listBoxWithStocksUpdate()
        {
            using (StockContext db = new StockContext())
            {
                listBoxWithStocks.Items.Clear();
                foreach (Stock stock in db.Stocks)
                {
                    listBoxWithStocks.Items.Add($"{stock.Id}) Процент скидки: {stock.Percent}");
                }
            }
        }

        // метод извлечения ID из строки
        private int GetEventIDFromString(string s, char c)
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

        // обработчик события клика по кнопке "Добавить мероприятие"
        private void buttonAddTickets_Click(object sender, EventArgs e)
        {
            if (textBoxEventName.Text != "" && textBoxEventDate.Text != "" && textBoxTicketAmount.Text != "" && textBoxTicketCost.Text != "")
            {
                try
                {
                    using (TicketPackContext db = new TicketPackContext())
                    {
                        TicketPack ticketPack = new TicketPack(textBoxEventName.Text, decimal.Parse(textBoxTicketCost.Text),
                            int.Parse(textBoxTicketAmount.Text), DateTime.Parse(textBoxEventDate.Text), this.Text);

                        db.TicketPacks.Add(ticketPack);
                        db.SaveChanges();
                        MessageBox.Show("Билеты занесены в базу данных");
                        textBoxEventName.Text = "";
                        textBoxEventDate.Text = "";
                        textBoxTicketCost.Text = "";
                        textBoxTicketAmount.Text = "";
                    }
                }
                catch
                {

                }
                ManagerPanel_VisibleChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        // обработчик события клика по кнопке "Удалить мероприятие"
        private void buttonDeleteTickets_Click(object sender, EventArgs e)
        {
            if (listBoxWithAllEvents.SelectedItem != null)
            {
                using (TicketPackContext db = new TicketPackContext())
                {
                    TicketPack ticketPack = db.TicketPacks.Find(ticketPackInMainMenu.Id);
                    db.TicketPacks.Remove(ticketPack);
                    db.SaveChanges();
                }
                ManagerPanel_VisibleChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Выберите пользователя из списка.");
            }
        }

        // обработчик события клика по кнопке "Изменить мероприятие"
        private void buttonChangeTickets_Click(object sender, EventArgs e)
        {
            TicketPack ticketPack = ticketPackInMainMenu;

            if (textBoxEventName.Text != "" && textBoxEventName.Text != ticketPack.Name)
            {
                using (TicketPackContext db = new TicketPackContext())
                {
                    TicketPack tempTicketPack = db.TicketPacks.Find(ticketPack.Id);

                    tempTicketPack.Name = textBoxEventName.Text;
                    db.SaveChanges();
                    ticketPack = tempTicketPack;
                }
            }

            if (textBoxEventDate.Text != "" && DateTime.Parse(textBoxEventDate.Text) != ticketPack.Date)
            {
                using (TicketPackContext db = new TicketPackContext())
                {
                    ticketPack = db.TicketPacks.Find(ticketPack.Id);
                    ticketPack.Date = DateTime.Parse(textBoxEventDate.Text);
                    db.SaveChanges();
                }
            }

            if (textBoxTicketCost.Text != "" && decimal.Parse(textBoxTicketCost.Text) != ticketPack.Cost)
            {
                using (TicketPackContext db = new TicketPackContext())
                {
                    ticketPack = db.TicketPacks.Find(ticketPack.Id);
                    ticketPack.Cost = decimal.Parse(textBoxTicketCost.Text);
                    db.SaveChanges();
                }
            }

            if (textBoxTicketAmount.Text != "" && int.Parse(textBoxTicketAmount.Text) != ticketPack.Amount)
            {
                using (TicketPackContext db = new TicketPackContext())
                {
                    ticketPack = db.TicketPacks.Find(ticketPack.Id);
                    ticketPack.Amount = int.Parse(textBoxTicketAmount.Text);
                    db.SaveChanges();
                }
            }

            ManagerPanel_VisibleChanged(sender, e);
        }

        // обработчик события клика по кнопке "Добавить акцию"
        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            if (textBoxStockDateStart.Text != "" && textBoxStockDateEnd.Text != "" && textBoxStockPercent.Text != "" && textBoxStockEventID.Text != "")
            {
                if (int.Parse(textBoxStockPercent.Text) < 101 && int.Parse(textBoxStockPercent.Text) > 0)
                {
                    Stock stock = new Stock(DateTime.Parse(textBoxStockDateStart.Text), DateTime.Parse(textBoxStockDateEnd.Text),
                                int.Parse(textBoxStockPercent.Text), int.Parse(textBoxStockEventID.Text));
                    bool flag = false;

                    using (TicketPackContext db = new TicketPackContext())
                    {
                        foreach (TicketPack ticketPack in db.TicketPacks)
                        {
                            if (ticketPack.Id == int.Parse(textBoxStockEventID.Text))
                            {
                                if (ticketPack.StockID == 0)
                                {
                                    flag = true;
                                    ticketPack.StockID = stock.Id;
                                    ticketPack.StockPercent = Convert.ToInt32(ticketPack.Cost);
                                    ticketPack.Cost = ticketPack.Cost * ((100 - stock.Percent) / 100);

                                }
                            }
                        }
                    }

                    if (flag)
                    {
                        using (StockContext db = new StockContext())
                        {
                            db.Stocks.Add(stock);
                            db.SaveChanges();
                            MessageBox.Show("Акция занесена в базу данных");
                            textBoxStockDateStart.Text = "";
                            textBoxStockDateEnd.Text = "";
                            textBoxStockPercent.Text = "";
                            textBoxStockEventID.Text = "";
                        }


                    }
                    else
                    {
                        MessageBox.Show("Мероприятия с таким ID нет или у этого мероприятия уже есть активная акция");
                    }

                    ManagerPanel_VisibleChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Процент скидки должен быть в диапазоне от 0 до 100");
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        // обработчик события клика по кнопке "Удалить акцию"
        private void buttonDeleteStock_Click(object sender, EventArgs e)
        {
            if (listBoxWithAllEvents.SelectedItem != null)
            {
                using (StockContext db = new StockContext())
                {
                    Stock stock = db.Stocks.Find(stockInStockMenu.Id);
                    db.Stocks.Remove(stock);
                    db.SaveChanges();
                }
                using (TicketPackContext db = new TicketPackContext())
                {
                    foreach(TicketPack ticketPack in db.TicketPacks)
                    {
                        if(ticketPack.StockID == stockInStockMenu.Id)
                        {
                            TicketPack ticketPack1 = db.TicketPacks.Find(ticketPack.Id);
                            ticketPack.StockID = 0;
                            ticketPack.Cost = ticketPack.StockPercent;
                            ticketPack.StockPercent = 0;
                            db.SaveChanges();
                        }
                    }
                }
                ManagerPanel_VisibleChanged(sender, e);
            }
            else
            {
                MessageBox.Show("Выберите акцию из списка.");
            }
        }

        // обработчик события клика по кнопке "Изменить акцию"
        private void buttonChangeStock_Click(object sender, EventArgs e)
        {
            Stock stock = stockInStockMenu;

            if (textBoxStockDateStart.Text != "" && DateTime.Parse(textBoxStockDateStart.Text) != stock.DateStart)
            {
                using (StockContext db = new StockContext())
                {
                    Stock tempStock = db.Stocks.Find(stock.Id);

                    stock.DateStart = DateTime.Parse(textBoxStockDateStart.Text);
                    db.SaveChanges();
                    stock = tempStock;
                }
            }

            if (textBoxStockDateEnd.Text != "" && DateTime.Parse(textBoxStockDateEnd.Text) != stock.DateEnd)
            {
                using (StockContext db = new StockContext())
                {
                    Stock tempStock = db.Stocks.Find(stock.Id);

                    stock.DateEnd = DateTime.Parse(textBoxStockDateEnd.Text);
                    db.SaveChanges();
                    stock = tempStock;
                }
            }

            if (textBoxStockPercent.Text != "" && int.Parse(textBoxStockPercent.Text) != stock.Percent)
            {
                using (StockContext db = new StockContext())
                {
                    Stock tempStock = db.Stocks.Find(stock.Id);

                    stock.Percent = int.Parse(textBoxStockPercent.Text);
                    db.SaveChanges();
                    stock = tempStock;
                }
            }

            if (textBoxStockEventID.Text != "" && int.Parse(textBoxStockEventID.Text) != stock.EventID)
            {
                using (StockContext db = new StockContext())
                {
                    Stock tempStock = db.Stocks.Find(stock.Id);

                    stock.EventID = int.Parse(textBoxStockEventID.Text);
                    db.SaveChanges();
                    stock = tempStock;
                }
            }

            ManagerPanel_VisibleChanged(sender, e);
        }
        private void ManagerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            authorization.Show();
        }
    }
}
