
namespace KassirRu
{
    partial class UserPanel
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonCancelReservation = new System.Windows.Forms.Button();
            this.buttonReturnTicket = new System.Windows.Forms.Button();
            this.labelTicketAmountOfPurchasedTicket = new System.Windows.Forms.Label();
            this.labelEventDateOfPurchasedTicket = new System.Windows.Forms.Label();
            this.labelTicketCostOfPurchasedTicket = new System.Windows.Forms.Label();
            this.labelEventNameOfPurchasedTicket = new System.Windows.Forms.Label();
            this.listBoxWithPurchasedTickets = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelEndSum = new System.Windows.Forms.Label();
            this.checkBoxBuySeveral = new System.Windows.Forms.CheckBox();
            this.labelAmountOfAdditionalTickets = new System.Windows.Forms.Label();
            this.textBoxNumberOfTickets = new System.Windows.Forms.TextBox();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.labelTicketAmount = new System.Windows.Forms.Label();
            this.labelEventDate = new System.Windows.Forms.Label();
            this.labelTicketCost = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.listBoxWithAllEvents = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelReturnMoney = new System.Windows.Forms.Label();
            this.textBoxReturnMoney = new System.Windows.Forms.TextBox();
            this.labelAddMoney = new System.Windows.Forms.Label();
            this.textBoxAddMoney = new System.Windows.Forms.TextBox();
            this.buttonReturnMoney = new System.Windows.Forms.Button();
            this.buttonAddMoney = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.tabPage3.Controls.Add(this.buttonCancelReservation);
            this.tabPage3.Controls.Add(this.buttonReturnTicket);
            this.tabPage3.Controls.Add(this.labelTicketAmountOfPurchasedTicket);
            this.tabPage3.Controls.Add(this.labelEventDateOfPurchasedTicket);
            this.tabPage3.Controls.Add(this.labelTicketCostOfPurchasedTicket);
            this.tabPage3.Controls.Add(this.labelEventNameOfPurchasedTicket);
            this.tabPage3.Controls.Add(this.listBoxWithPurchasedTickets);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(953, 394);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ЛИЧНЫЙ КАБИНЕТ";
            // 
            // buttonCancelReservation
            // 
            this.buttonCancelReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonCancelReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelReservation.Location = new System.Drawing.Point(713, 213);
            this.buttonCancelReservation.Name = "buttonCancelReservation";
            this.buttonCancelReservation.Size = new System.Drawing.Size(233, 58);
            this.buttonCancelReservation.TabIndex = 34;
            this.buttonCancelReservation.Text = "ОТМЕНИТЬ БРОНЬ";
            this.buttonCancelReservation.UseVisualStyleBackColor = false;
            this.buttonCancelReservation.Click += new System.EventHandler(this.buttonCancelReservation_Click);
            // 
            // buttonReturnTicket
            // 
            this.buttonReturnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonReturnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnTicket.Location = new System.Drawing.Point(464, 213);
            this.buttonReturnTicket.Name = "buttonReturnTicket";
            this.buttonReturnTicket.Size = new System.Drawing.Size(233, 58);
            this.buttonReturnTicket.TabIndex = 33;
            this.buttonReturnTicket.Text = "ВЕРНУТЬ ДЕНЬГИ";
            this.buttonReturnTicket.UseVisualStyleBackColor = false;
            this.buttonReturnTicket.Click += new System.EventHandler(this.buttonReturnTicket_Click);
            // 
            // labelTicketAmountOfPurchasedTicket
            // 
            this.labelTicketAmountOfPurchasedTicket.AutoSize = true;
            this.labelTicketAmountOfPurchasedTicket.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicketAmountOfPurchasedTicket.Location = new System.Drawing.Point(460, 143);
            this.labelTicketAmountOfPurchasedTicket.Name = "labelTicketAmountOfPurchasedTicket";
            this.labelTicketAmountOfPurchasedTicket.Size = new System.Drawing.Size(291, 22);
            this.labelTicketAmountOfPurchasedTicket.TabIndex = 32;
            this.labelTicketAmountOfPurchasedTicket.Text = "Количество купленных билетов";
            // 
            // labelEventDateOfPurchasedTicket
            // 
            this.labelEventDateOfPurchasedTicket.AutoSize = true;
            this.labelEventDateOfPurchasedTicket.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventDateOfPurchasedTicket.Location = new System.Drawing.Point(460, 79);
            this.labelEventDateOfPurchasedTicket.Name = "labelEventDateOfPurchasedTicket";
            this.labelEventDateOfPurchasedTicket.Size = new System.Drawing.Size(51, 22);
            this.labelEventDateOfPurchasedTicket.TabIndex = 31;
            this.labelEventDateOfPurchasedTicket.Text = "Дата";
            // 
            // labelTicketCostOfPurchasedTicket
            // 
            this.labelTicketCostOfPurchasedTicket.AutoSize = true;
            this.labelTicketCostOfPurchasedTicket.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicketCostOfPurchasedTicket.Location = new System.Drawing.Point(460, 110);
            this.labelTicketCostOfPurchasedTicket.Name = "labelTicketCostOfPurchasedTicket";
            this.labelTicketCostOfPurchasedTicket.Size = new System.Drawing.Size(100, 22);
            this.labelTicketCostOfPurchasedTicket.TabIndex = 30;
            this.labelTicketCostOfPurchasedTicket.Text = "Стоимость";
            // 
            // labelEventNameOfPurchasedTicket
            // 
            this.labelEventNameOfPurchasedTicket.AutoSize = true;
            this.labelEventNameOfPurchasedTicket.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventNameOfPurchasedTicket.Location = new System.Drawing.Point(575, 42);
            this.labelEventNameOfPurchasedTicket.Name = "labelEventNameOfPurchasedTicket";
            this.labelEventNameOfPurchasedTicket.Size = new System.Drawing.Size(253, 26);
            this.labelEventNameOfPurchasedTicket.TabIndex = 29;
            this.labelEventNameOfPurchasedTicket.Text = "Название мероприятия";
            // 
            // listBoxWithPurchasedTickets
            // 
            this.listBoxWithPurchasedTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.listBoxWithPurchasedTickets.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxWithPurchasedTickets.FormattingEnabled = true;
            this.listBoxWithPurchasedTickets.ItemHeight = 18;
            this.listBoxWithPurchasedTickets.Location = new System.Drawing.Point(0, 0);
            this.listBoxWithPurchasedTickets.Name = "listBoxWithPurchasedTickets";
            this.listBoxWithPurchasedTickets.Size = new System.Drawing.Size(454, 394);
            this.listBoxWithPurchasedTickets.TabIndex = 28;
            this.listBoxWithPurchasedTickets.SelectedIndexChanged += new System.EventHandler(this.listBoxWithPurchasedTickets_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.tabPage1.Controls.Add(this.labelEndSum);
            this.tabPage1.Controls.Add(this.checkBoxBuySeveral);
            this.tabPage1.Controls.Add(this.labelAmountOfAdditionalTickets);
            this.tabPage1.Controls.Add(this.textBoxNumberOfTickets);
            this.tabPage1.Controls.Add(this.buttonReserve);
            this.tabPage1.Controls.Add(this.buttonBuyTicket);
            this.tabPage1.Controls.Add(this.labelTicketAmount);
            this.tabPage1.Controls.Add(this.labelEventDate);
            this.tabPage1.Controls.Add(this.labelTicketCost);
            this.tabPage1.Controls.Add(this.labelEventName);
            this.tabPage1.Controls.Add(this.listBoxWithAllEvents);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(953, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // labelEndSum
            // 
            this.labelEndSum.AutoSize = true;
            this.labelEndSum.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndSum.Location = new System.Drawing.Point(453, 279);
            this.labelEndSum.Name = "labelEndSum";
            this.labelEndSum.Size = new System.Drawing.Size(182, 22);
            this.labelEndSum.TabIndex = 27;
            this.labelEndSum.Text = "Итоговая стоимость";
            this.labelEndSum.Visible = false;
            // 
            // checkBoxBuySeveral
            // 
            this.checkBoxBuySeveral.AutoSize = true;
            this.checkBoxBuySeveral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBuySeveral.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxBuySeveral.Location = new System.Drawing.Point(457, 223);
            this.checkBoxBuySeveral.Name = "checkBoxBuySeveral";
            this.checkBoxBuySeveral.Size = new System.Drawing.Size(187, 26);
            this.checkBoxBuySeveral.TabIndex = 26;
            this.checkBoxBuySeveral.Text = "Купить несколько";
            this.checkBoxBuySeveral.UseVisualStyleBackColor = true;
            this.checkBoxBuySeveral.CheckedChanged += new System.EventHandler(this.checkBoxBuySeveral_CheckedChanged);
            // 
            // labelAmountOfAdditionalTickets
            // 
            this.labelAmountOfAdditionalTickets.AutoSize = true;
            this.labelAmountOfAdditionalTickets.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAmountOfAdditionalTickets.Location = new System.Drawing.Point(453, 252);
            this.labelAmountOfAdditionalTickets.Name = "labelAmountOfAdditionalTickets";
            this.labelAmountOfAdditionalTickets.Size = new System.Drawing.Size(195, 22);
            this.labelAmountOfAdditionalTickets.TabIndex = 23;
            this.labelAmountOfAdditionalTickets.Text = "Количество билетов:";
            this.labelAmountOfAdditionalTickets.Visible = false;
            // 
            // textBoxNumberOfTickets
            // 
            this.textBoxNumberOfTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxNumberOfTickets.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberOfTickets.Location = new System.Drawing.Point(699, 246);
            this.textBoxNumberOfTickets.Name = "textBoxNumberOfTickets";
            this.textBoxNumberOfTickets.Size = new System.Drawing.Size(96, 28);
            this.textBoxNumberOfTickets.TabIndex = 22;
            this.textBoxNumberOfTickets.Visible = false;
            this.textBoxNumberOfTickets.TextChanged += new System.EventHandler(this.textBoxNumberOfTickets_TextChanged);
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserve.Location = new System.Drawing.Point(706, 324);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(233, 58);
            this.buttonReserve.TabIndex = 21;
            this.buttonReserve.Text = "ЗАБРОНИРОВАТЬ";
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuyTicket.Location = new System.Drawing.Point(457, 324);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(233, 58);
            this.buttonBuyTicket.TabIndex = 20;
            this.buttonBuyTicket.Text = "КУПИТЬ";
            this.buttonBuyTicket.UseVisualStyleBackColor = false;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // labelTicketAmount
            // 
            this.labelTicketAmount.AutoSize = true;
            this.labelTicketAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicketAmount.Location = new System.Drawing.Point(453, 143);
            this.labelTicketAmount.Name = "labelTicketAmount";
            this.labelTicketAmount.Size = new System.Drawing.Size(187, 22);
            this.labelTicketAmount.TabIndex = 19;
            this.labelTicketAmount.Text = "Количество билетов";
            // 
            // labelEventDate
            // 
            this.labelEventDate.AutoSize = true;
            this.labelEventDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventDate.Location = new System.Drawing.Point(453, 79);
            this.labelEventDate.Name = "labelEventDate";
            this.labelEventDate.Size = new System.Drawing.Size(51, 22);
            this.labelEventDate.TabIndex = 18;
            this.labelEventDate.Text = "Дата";
            // 
            // labelTicketCost
            // 
            this.labelTicketCost.AutoSize = true;
            this.labelTicketCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTicketCost.Location = new System.Drawing.Point(453, 110);
            this.labelTicketCost.Name = "labelTicketCost";
            this.labelTicketCost.Size = new System.Drawing.Size(100, 22);
            this.labelTicketCost.TabIndex = 17;
            this.labelTicketCost.Text = "Стоимость";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventName.Location = new System.Drawing.Point(568, 42);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(253, 26);
            this.labelEventName.TabIndex = 15;
            this.labelEventName.Text = "Название мероприятия";
            // 
            // listBoxWithAllEvents
            // 
            this.listBoxWithAllEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.listBoxWithAllEvents.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxWithAllEvents.FormattingEnabled = true;
            this.listBoxWithAllEvents.ItemHeight = 18;
            this.listBoxWithAllEvents.Location = new System.Drawing.Point(3, 3);
            this.listBoxWithAllEvents.Name = "listBoxWithAllEvents";
            this.listBoxWithAllEvents.Size = new System.Drawing.Size(444, 388);
            this.listBoxWithAllEvents.TabIndex = 0;
            this.listBoxWithAllEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxWithAllEvents_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.tabPage2.Controls.Add(this.labelReturnMoney);
            this.tabPage2.Controls.Add(this.textBoxReturnMoney);
            this.tabPage2.Controls.Add(this.labelAddMoney);
            this.tabPage2.Controls.Add(this.textBoxAddMoney);
            this.tabPage2.Controls.Add(this.buttonReturnMoney);
            this.tabPage2.Controls.Add(this.buttonAddMoney);
            this.tabPage2.Controls.Add(this.labelBalance);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(953, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "КОШЕЛЁК";
            // 
            // labelReturnMoney
            // 
            this.labelReturnMoney.AutoSize = true;
            this.labelReturnMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReturnMoney.Location = new System.Drawing.Point(288, 158);
            this.labelReturnMoney.Name = "labelReturnMoney";
            this.labelReturnMoney.Size = new System.Drawing.Size(391, 22);
            this.labelReturnMoney.TabIndex = 28;
            this.labelReturnMoney.Text = "Введите сумму и снова нажмите на кнопку";
            this.labelReturnMoney.Visible = false;
            // 
            // textBoxReturnMoney
            // 
            this.textBoxReturnMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxReturnMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxReturnMoney.Location = new System.Drawing.Point(711, 152);
            this.textBoxReturnMoney.Name = "textBoxReturnMoney";
            this.textBoxReturnMoney.Size = new System.Drawing.Size(96, 28);
            this.textBoxReturnMoney.TabIndex = 27;
            this.textBoxReturnMoney.Visible = false;
            // 
            // labelAddMoney
            // 
            this.labelAddMoney.AutoSize = true;
            this.labelAddMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddMoney.Location = new System.Drawing.Point(288, 94);
            this.labelAddMoney.Name = "labelAddMoney";
            this.labelAddMoney.Size = new System.Drawing.Size(391, 22);
            this.labelAddMoney.TabIndex = 26;
            this.labelAddMoney.Text = "Введите сумму и снова нажмите на кнопку";
            this.labelAddMoney.Visible = false;
            // 
            // textBoxAddMoney
            // 
            this.textBoxAddMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxAddMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAddMoney.Location = new System.Drawing.Point(711, 88);
            this.textBoxAddMoney.Name = "textBoxAddMoney";
            this.textBoxAddMoney.Size = new System.Drawing.Size(96, 28);
            this.textBoxAddMoney.TabIndex = 24;
            this.textBoxAddMoney.Visible = false;
            // 
            // buttonReturnMoney
            // 
            this.buttonReturnMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonReturnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturnMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturnMoney.Location = new System.Drawing.Point(23, 122);
            this.buttonReturnMoney.Name = "buttonReturnMoney";
            this.buttonReturnMoney.Size = new System.Drawing.Size(233, 58);
            this.buttonReturnMoney.TabIndex = 23;
            this.buttonReturnMoney.Text = "ВЕРНУТЬ СРЕДСТВА";
            this.buttonReturnMoney.UseVisualStyleBackColor = false;
            this.buttonReturnMoney.Click += new System.EventHandler(this.buttonReturnMoney_Click);
            // 
            // buttonAddMoney
            // 
            this.buttonAddMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonAddMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddMoney.Location = new System.Drawing.Point(23, 58);
            this.buttonAddMoney.Name = "buttonAddMoney";
            this.buttonAddMoney.Size = new System.Drawing.Size(233, 58);
            this.buttonAddMoney.TabIndex = 22;
            this.buttonAddMoney.Text = "ПОПОЛНИТЬ БАЛАНС";
            this.buttonAddMoney.UseVisualStyleBackColor = false;
            this.buttonAddMoney.Click += new System.EventHandler(this.buttonAddMoney_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBalance.Location = new System.Drawing.Point(19, 17);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(115, 22);
            this.labelBalance.TabIndex = 19;
            this.labelBalance.Text = "Баланс: 0р.";
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(961, 425);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UserPanel";
            this.Text = "ИмяПользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserPanel_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.UserPanel_VisibleChanged);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonCancelReservation;
        private System.Windows.Forms.Button buttonReturnTicket;
        private System.Windows.Forms.Label labelTicketAmountOfPurchasedTicket;
        private System.Windows.Forms.Label labelEventDateOfPurchasedTicket;
        private System.Windows.Forms.Label labelTicketCostOfPurchasedTicket;
        private System.Windows.Forms.Label labelEventNameOfPurchasedTicket;
        private System.Windows.Forms.ListBox listBoxWithPurchasedTickets;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelEndSum;
        private System.Windows.Forms.CheckBox checkBoxBuySeveral;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.Label labelTicketAmount;
        private System.Windows.Forms.Label labelEventDate;
        private System.Windows.Forms.Label labelTicketCost;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.ListBox listBoxWithAllEvents;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonReturnMoney;
        private System.Windows.Forms.Button buttonAddMoney;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelAmountOfAdditionalTickets;
        private System.Windows.Forms.TextBox textBoxNumberOfTickets;
        private System.Windows.Forms.Label labelReturnMoney;
        private System.Windows.Forms.TextBox textBoxReturnMoney;
        private System.Windows.Forms.Label labelAddMoney;
        private System.Windows.Forms.TextBox textBoxAddMoney;
    }
}