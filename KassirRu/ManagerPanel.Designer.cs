
namespace KassirRu
{
    partial class ManagerPanel
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
            this.tabPageContracts = new System.Windows.Forms.TabPage();
            this.labelContractEventName = new System.Windows.Forms.Label();
            this.labelContractUser = new System.Windows.Forms.Label();
            this.labelContractDate = new System.Windows.Forms.Label();
            this.labelContractMoney = new System.Windows.Forms.Label();
            this.labelContractId = new System.Windows.Forms.Label();
            this.listBoxWithContracts = new System.Windows.Forms.ListBox();
            this.tabPageStocks = new System.Windows.Forms.TabPage();
            this.textBoxStockPercent = new System.Windows.Forms.TextBox();
            this.textBoxStockDateEnd = new System.Windows.Forms.TextBox();
            this.textBoxStockDateStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBoxWithStocks = new System.Windows.Forms.ListBox();
            this.tabPageManagerPanel = new System.Windows.Forms.TabPage();
            this.buttonChangeTickets = new System.Windows.Forms.Button();
            this.textBoxTicketAmount = new System.Windows.Forms.TextBox();
            this.textBoxTicketCost = new System.Windows.Forms.TextBox();
            this.textBoxEventDate = new System.Windows.Forms.TextBox();
            this.textBoxEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteTickets = new System.Windows.Forms.Button();
            this.buttonAddTickets = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxWithAllEvents = new System.Windows.Forms.ListBox();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.buttonChangeStock = new System.Windows.Forms.Button();
            this.buttonDeleteStock = new System.Windows.Forms.Button();
            this.buttonAddStock = new System.Windows.Forms.Button();
            this.textBoxStockEventID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageContracts.SuspendLayout();
            this.tabPageStocks.SuspendLayout();
            this.tabPageManagerPanel.SuspendLayout();
            this.tabControlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageContracts
            // 
            this.tabPageContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.tabPageContracts.Controls.Add(this.labelContractEventName);
            this.tabPageContracts.Controls.Add(this.labelContractUser);
            this.tabPageContracts.Controls.Add(this.labelContractDate);
            this.tabPageContracts.Controls.Add(this.labelContractMoney);
            this.tabPageContracts.Controls.Add(this.labelContractId);
            this.tabPageContracts.Controls.Add(this.listBoxWithContracts);
            this.tabPageContracts.Location = new System.Drawing.Point(4, 27);
            this.tabPageContracts.Name = "tabPageContracts";
            this.tabPageContracts.Size = new System.Drawing.Size(959, 330);
            this.tabPageContracts.TabIndex = 2;
            this.tabPageContracts.Text = "ДОГОВОРА";
            // 
            // labelContractEventName
            // 
            this.labelContractEventName.AutoSize = true;
            this.labelContractEventName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractEventName.Location = new System.Drawing.Point(477, 157);
            this.labelContractEventName.Name = "labelContractEventName";
            this.labelContractEventName.Size = new System.Drawing.Size(214, 22);
            this.labelContractEventName.TabIndex = 25;
            this.labelContractEventName.Text = "Название мероприятия";
            // 
            // labelContractUser
            // 
            this.labelContractUser.AutoSize = true;
            this.labelContractUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractUser.Location = new System.Drawing.Point(477, 126);
            this.labelContractUser.Name = "labelContractUser";
            this.labelContractUser.Size = new System.Drawing.Size(113, 22);
            this.labelContractUser.TabIndex = 23;
            this.labelContractUser.Text = "Покупатель";
            // 
            // labelContractDate
            // 
            this.labelContractDate.AutoSize = true;
            this.labelContractDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractDate.Location = new System.Drawing.Point(477, 62);
            this.labelContractDate.Name = "labelContractDate";
            this.labelContractDate.Size = new System.Drawing.Size(166, 22);
            this.labelContractDate.TabIndex = 22;
            this.labelContractDate.Text = "Дата оформления";
            // 
            // labelContractMoney
            // 
            this.labelContractMoney.AutoSize = true;
            this.labelContractMoney.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractMoney.Location = new System.Drawing.Point(477, 93);
            this.labelContractMoney.Name = "labelContractMoney";
            this.labelContractMoney.Size = new System.Drawing.Size(66, 22);
            this.labelContractMoney.TabIndex = 21;
            this.labelContractMoney.Text = "Сумма";
            // 
            // labelContractId
            // 
            this.labelContractId.AutoSize = true;
            this.labelContractId.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContractId.Location = new System.Drawing.Point(622, 22);
            this.labelContractId.Name = "labelContractId";
            this.labelContractId.Size = new System.Drawing.Size(177, 26);
            this.labelContractId.TabIndex = 20;
            this.labelContractId.Text = "Номер договора";
            // 
            // listBoxWithContracts
            // 
            this.listBoxWithContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.listBoxWithContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxWithContracts.FormattingEnabled = true;
            this.listBoxWithContracts.ItemHeight = 18;
            this.listBoxWithContracts.Location = new System.Drawing.Point(0, 0);
            this.listBoxWithContracts.Name = "listBoxWithContracts";
            this.listBoxWithContracts.Size = new System.Drawing.Size(463, 330);
            this.listBoxWithContracts.TabIndex = 1;
            // 
            // tabPageStocks
            // 
            this.tabPageStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.tabPageStocks.Controls.Add(this.textBoxStockEventID);
            this.tabPageStocks.Controls.Add(this.label5);
            this.tabPageStocks.Controls.Add(this.buttonChangeStock);
            this.tabPageStocks.Controls.Add(this.buttonDeleteStock);
            this.tabPageStocks.Controls.Add(this.buttonAddStock);
            this.tabPageStocks.Controls.Add(this.textBoxStockPercent);
            this.tabPageStocks.Controls.Add(this.textBoxStockDateEnd);
            this.tabPageStocks.Controls.Add(this.textBoxStockDateStart);
            this.tabPageStocks.Controls.Add(this.label6);
            this.tabPageStocks.Controls.Add(this.label7);
            this.tabPageStocks.Controls.Add(this.label8);
            this.tabPageStocks.Controls.Add(this.listBoxWithStocks);
            this.tabPageStocks.Location = new System.Drawing.Point(4, 27);
            this.tabPageStocks.Name = "tabPageStocks";
            this.tabPageStocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStocks.Size = new System.Drawing.Size(959, 330);
            this.tabPageStocks.TabIndex = 1;
            this.tabPageStocks.Text = "АКЦИИ";
            // 
            // textBoxStockPercent
            // 
            this.textBoxStockPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxStockPercent.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStockPercent.Location = new System.Drawing.Point(689, 85);
            this.textBoxStockPercent.Name = "textBoxStockPercent";
            this.textBoxStockPercent.Size = new System.Drawing.Size(258, 28);
            this.textBoxStockPercent.TabIndex = 43;
            // 
            // textBoxStockDateEnd
            // 
            this.textBoxStockDateEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxStockDateEnd.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStockDateEnd.Location = new System.Drawing.Point(689, 51);
            this.textBoxStockDateEnd.Name = "textBoxStockDateEnd";
            this.textBoxStockDateEnd.Size = new System.Drawing.Size(258, 28);
            this.textBoxStockDateEnd.TabIndex = 42;
            // 
            // textBoxStockDateStart
            // 
            this.textBoxStockDateStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxStockDateStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStockDateStart.Location = new System.Drawing.Point(689, 17);
            this.textBoxStockDateStart.Name = "textBoxStockDateStart";
            this.textBoxStockDateStart.Size = new System.Drawing.Size(258, 28);
            this.textBoxStockDateStart.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(461, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 36;
            this.label6.Text = "Скидка (в %):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(461, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Дата начала:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(461, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 22);
            this.label8.TabIndex = 34;
            this.label8.Text = "Дата окончания:";
            // 
            // listBoxWithStocks
            // 
            this.listBoxWithStocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.listBoxWithStocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxWithStocks.FormattingEnabled = true;
            this.listBoxWithStocks.ItemHeight = 18;
            this.listBoxWithStocks.Location = new System.Drawing.Point(3, 3);
            this.listBoxWithStocks.Name = "listBoxWithStocks";
            this.listBoxWithStocks.Size = new System.Drawing.Size(444, 324);
            this.listBoxWithStocks.TabIndex = 33;
            this.listBoxWithStocks.SelectedIndexChanged += new System.EventHandler(this.listBoxWithStocks_SelectedIndexChanged);
            // 
            // tabPageManagerPanel
            // 
            this.tabPageManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(237)))), ((int)(((byte)(231)))));
            this.tabPageManagerPanel.Controls.Add(this.buttonChangeTickets);
            this.tabPageManagerPanel.Controls.Add(this.textBoxTicketAmount);
            this.tabPageManagerPanel.Controls.Add(this.textBoxTicketCost);
            this.tabPageManagerPanel.Controls.Add(this.textBoxEventDate);
            this.tabPageManagerPanel.Controls.Add(this.textBoxEventName);
            this.tabPageManagerPanel.Controls.Add(this.label2);
            this.tabPageManagerPanel.Controls.Add(this.buttonDeleteTickets);
            this.tabPageManagerPanel.Controls.Add(this.buttonAddTickets);
            this.tabPageManagerPanel.Controls.Add(this.label4);
            this.tabPageManagerPanel.Controls.Add(this.label1);
            this.tabPageManagerPanel.Controls.Add(this.label3);
            this.tabPageManagerPanel.Controls.Add(this.listBoxWithAllEvents);
            this.tabPageManagerPanel.Location = new System.Drawing.Point(4, 27);
            this.tabPageManagerPanel.Name = "tabPageManagerPanel";
            this.tabPageManagerPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagerPanel.Size = new System.Drawing.Size(959, 330);
            this.tabPageManagerPanel.TabIndex = 0;
            this.tabPageManagerPanel.Text = "ПАНЕЛЬ МЕНЕДЖЕРА";
            // 
            // buttonChangeTickets
            // 
            this.buttonChangeTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonChangeTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeTickets.Location = new System.Drawing.Point(706, 251);
            this.buttonChangeTickets.Name = "buttonChangeTickets";
            this.buttonChangeTickets.Size = new System.Drawing.Size(233, 58);
            this.buttonChangeTickets.TabIndex = 32;
            this.buttonChangeTickets.Text = "ИЗМЕНИТЬ БИЛЕТЫ";
            this.buttonChangeTickets.UseVisualStyleBackColor = false;
            this.buttonChangeTickets.Click += new System.EventHandler(this.buttonChangeTickets_Click);
            // 
            // textBoxTicketAmount
            // 
            this.textBoxTicketAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxTicketAmount.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTicketAmount.Location = new System.Drawing.Point(681, 110);
            this.textBoxTicketAmount.Name = "textBoxTicketAmount";
            this.textBoxTicketAmount.Size = new System.Drawing.Size(258, 28);
            this.textBoxTicketAmount.TabIndex = 31;
            // 
            // textBoxTicketCost
            // 
            this.textBoxTicketCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxTicketCost.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTicketCost.Location = new System.Drawing.Point(681, 76);
            this.textBoxTicketCost.Name = "textBoxTicketCost";
            this.textBoxTicketCost.Size = new System.Drawing.Size(258, 28);
            this.textBoxTicketCost.TabIndex = 30;
            // 
            // textBoxEventDate
            // 
            this.textBoxEventDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxEventDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEventDate.Location = new System.Drawing.Point(681, 42);
            this.textBoxEventDate.Name = "textBoxEventDate";
            this.textBoxEventDate.Size = new System.Drawing.Size(258, 28);
            this.textBoxEventDate.TabIndex = 29;
            // 
            // textBoxEventName
            // 
            this.textBoxEventName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxEventName.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEventName.Location = new System.Drawing.Point(681, 8);
            this.textBoxEventName.Name = "textBoxEventName";
            this.textBoxEventName.Size = new System.Drawing.Size(258, 28);
            this.textBoxEventName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(453, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Название мероприятия:";
            // 
            // buttonDeleteTickets
            // 
            this.buttonDeleteTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonDeleteTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteTickets.Location = new System.Drawing.Point(457, 251);
            this.buttonDeleteTickets.Name = "buttonDeleteTickets";
            this.buttonDeleteTickets.Size = new System.Drawing.Size(233, 58);
            this.buttonDeleteTickets.TabIndex = 21;
            this.buttonDeleteTickets.Text = "УДАЛИТЬ БИЛЕТЫ";
            this.buttonDeleteTickets.UseVisualStyleBackColor = false;
            this.buttonDeleteTickets.Click += new System.EventHandler(this.buttonDeleteTickets_Click);
            // 
            // buttonAddTickets
            // 
            this.buttonAddTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonAddTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddTickets.Location = new System.Drawing.Point(457, 187);
            this.buttonAddTickets.Name = "buttonAddTickets";
            this.buttonAddTickets.Size = new System.Drawing.Size(482, 58);
            this.buttonAddTickets.TabIndex = 20;
            this.buttonAddTickets.Text = "ДОБАВИТЬ БИЛЕТЫ";
            this.buttonAddTickets.UseVisualStyleBackColor = false;
            this.buttonAddTickets.Click += new System.EventHandler(this.buttonAddTickets_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(453, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Количество билетов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(453, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(453, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Стоимость";
            // 
            // listBoxWithAllEvents
            // 
            this.listBoxWithAllEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(219)))), ((int)(((byte)(211)))));
            this.listBoxWithAllEvents.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxWithAllEvents.FormattingEnabled = true;
            this.listBoxWithAllEvents.ItemHeight = 18;
            this.listBoxWithAllEvents.Location = new System.Drawing.Point(3, 3);
            this.listBoxWithAllEvents.Name = "listBoxWithAllEvents";
            this.listBoxWithAllEvents.Size = new System.Drawing.Size(444, 324);
            this.listBoxWithAllEvents.TabIndex = 0;
            this.listBoxWithAllEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxWithAllEvents_SelectedIndexChanged);
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPageManagerPanel);
            this.tabControlManager.Controls.Add(this.tabPageStocks);
            this.tabControlManager.Controls.Add(this.tabPageContracts);
            this.tabControlManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlManager.Location = new System.Drawing.Point(0, 0);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(967, 361);
            this.tabControlManager.TabIndex = 1;
            // 
            // buttonChangeStock
            // 
            this.buttonChangeStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonChangeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeStock.Location = new System.Drawing.Point(714, 257);
            this.buttonChangeStock.Name = "buttonChangeStock";
            this.buttonChangeStock.Size = new System.Drawing.Size(233, 58);
            this.buttonChangeStock.TabIndex = 46;
            this.buttonChangeStock.Text = "ИЗМЕНИТЬ АКЦИЮ";
            this.buttonChangeStock.UseVisualStyleBackColor = false;
            this.buttonChangeStock.Click += new System.EventHandler(this.buttonChangeStock_Click);
            // 
            // buttonDeleteStock
            // 
            this.buttonDeleteStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonDeleteStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteStock.Location = new System.Drawing.Point(465, 257);
            this.buttonDeleteStock.Name = "buttonDeleteStock";
            this.buttonDeleteStock.Size = new System.Drawing.Size(233, 58);
            this.buttonDeleteStock.TabIndex = 45;
            this.buttonDeleteStock.Text = "УДАЛИТЬ АКЦИЮ";
            this.buttonDeleteStock.UseVisualStyleBackColor = false;
            this.buttonDeleteStock.Click += new System.EventHandler(this.buttonDeleteStock_Click);
            // 
            // buttonAddStock
            // 
            this.buttonAddStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.buttonAddStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddStock.Location = new System.Drawing.Point(465, 193);
            this.buttonAddStock.Name = "buttonAddStock";
            this.buttonAddStock.Size = new System.Drawing.Size(482, 58);
            this.buttonAddStock.TabIndex = 44;
            this.buttonAddStock.Text = "ДОБАВИТЬ АКЦИЮ";
            this.buttonAddStock.UseVisualStyleBackColor = false;
            this.buttonAddStock.Click += new System.EventHandler(this.buttonAddStock_Click);
            // 
            // textBoxStockEventID
            // 
            this.textBoxStockEventID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(211)))), ((int)(((byte)(193)))));
            this.textBoxStockEventID.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStockEventID.Location = new System.Drawing.Point(689, 119);
            this.textBoxStockEventID.Name = "textBoxStockEventID";
            this.textBoxStockEventID.Size = new System.Drawing.Size(258, 28);
            this.textBoxStockEventID.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(461, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 22);
            this.label5.TabIndex = 47;
            this.label5.Text = "ID мероприятия:";
            // 
            // ManagerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(162)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(967, 361);
            this.Controls.Add(this.tabControlManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ManagerPanel";
            this.Text = "ИмяПользователя";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerPanel_FormClosed);
            this.VisibleChanged += new System.EventHandler(this.ManagerPanel_VisibleChanged);
            this.tabPageContracts.ResumeLayout(false);
            this.tabPageContracts.PerformLayout();
            this.tabPageStocks.ResumeLayout(false);
            this.tabPageStocks.PerformLayout();
            this.tabPageManagerPanel.ResumeLayout(false);
            this.tabPageManagerPanel.PerformLayout();
            this.tabControlManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageContracts;
        private System.Windows.Forms.ListBox listBoxWithContracts;
        private System.Windows.Forms.TabPage tabPageStocks;
        private System.Windows.Forms.TextBox textBoxStockPercent;
        private System.Windows.Forms.TextBox textBoxStockDateEnd;
        private System.Windows.Forms.TextBox textBoxStockDateStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBoxWithStocks;
        private System.Windows.Forms.TabPage tabPageManagerPanel;
        private System.Windows.Forms.Button buttonChangeTickets;
        private System.Windows.Forms.TextBox textBoxTicketAmount;
        private System.Windows.Forms.TextBox textBoxTicketCost;
        private System.Windows.Forms.TextBox textBoxEventDate;
        private System.Windows.Forms.TextBox textBoxEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDeleteTickets;
        private System.Windows.Forms.Button buttonAddTickets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxWithAllEvents;
        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.Label labelContractEventName;
        private System.Windows.Forms.Label labelContractUser;
        private System.Windows.Forms.Label labelContractDate;
        private System.Windows.Forms.Label labelContractMoney;
        private System.Windows.Forms.Label labelContractId;
        private System.Windows.Forms.TextBox textBoxStockEventID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonChangeStock;
        private System.Windows.Forms.Button buttonDeleteStock;
        private System.Windows.Forms.Button buttonAddStock;
    }
}