namespace KursachMasha;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        playerDeleteButton = new Button();
        tablePlayers = new DataGridView();
        Tabs = new TabControl();
        tabPage1 = new TabPage();
        playerNumberTetBox = new TextBox();
        label19 = new Label();
        label18 = new Label();
        label17 = new Label();
        searchTeamComboBox = new ComboBox();
        label15 = new Label();
        searchRoleComboBox = new ComboBox();
        label16 = new Label();
        teamIDPlayerComboBox = new ComboBox();
        label14 = new Label();
        playerPatronymicTetBox = new TextBox();
        label3 = new Label();
        playerGettingButton = new Button();
        playerSearchTextBox = new TextBox();
        roleIDPlayerComboBox = new ComboBox();
        playerAddButton = new Button();
        playerUpdateButton = new Button();
        playerSurnameTextBox = new TextBox();
        label4 = new Label();
        playerNameTextBox = new TextBox();
        label5 = new Label();
        label6 = new Label();
        tabPage2 = new TabPage();
        button2 = new Button();
        comboBox6 = new ComboBox();
        button1 = new Button();
        button17 = new Button();
        button16 = new Button();
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        dataGridView2 = new DataGridView();
        tabPage3 = new TabPage();
        comboBox4 = new ComboBox();
        comboBox3 = new ComboBox();
        comboBox2 = new ComboBox();
        button7 = new Button();
        button8 = new Button();
        button9 = new Button();
        DateTimePickerMatch = new DateTimePicker();
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        tabPage4 = new TabPage();
        selectLocationComboBox = new ComboBox();
        label24 = new Label();
        stadiumSearchTextBox = new TextBox();
        buttonGettingStadiums = new Button();
        stadiumVolumeTextBox = new TextBox();
        label23 = new Label();
        stadiumAddButton = new Button();
        button11 = new Button();
        DeleteStadium_Button = new Button();
        stadiumNameTextBox = new TextBox();
        label12 = new Label();
        label11 = new Label();
        tableStadiums = new DataGridView();
        tabPage5 = new TabPage();
        label21 = new Label();
        label22 = new Label();
        sponsorSearchTextBox = new TextBox();
        buttonGettingSponsors = new Button();
        label20 = new Label();
        descriptionNameTextBox = new TextBox();
        sposorAddButton = new Button();
        button14 = new Button();
        DeleteSponsors_Button = new Button();
        label13 = new Label();
        sponsorNameTextBox = new TextBox();
        tableSponsors = new DataGridView();
        menuStrip1 = new MenuStrip();
        logoutMenuStrip = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)tablePlayers).BeginInit();
        Tabs.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        tabPage3.SuspendLayout();
        tabPage4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableStadiums).BeginInit();
        tabPage5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableSponsors).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // playerDeleteButton
        // 
        playerDeleteButton.Location = new Point(296, 233);
        playerDeleteButton.Name = "playerDeleteButton";
        playerDeleteButton.Size = new Size(94, 29);
        playerDeleteButton.TabIndex = 2;
        playerDeleteButton.Text = "Удалить";
        playerDeleteButton.UseVisualStyleBackColor = true;
        playerDeleteButton.Click += DeletePlayers_Click;
        // 
        // tablePlayers
        // 
        tablePlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayers.Location = new Point(410, 6);
        tablePlayers.Name = "tablePlayers";
        tablePlayers.RowHeadersWidth = 51;
        tablePlayers.RowTemplate.Height = 29;
        tablePlayers.Size = new Size(677, 535);
        tablePlayers.TabIndex = 9;
        tablePlayers.RowStateChanged += tablePlayers_RowStateChanged;
        // 
        // Tabs
        // 
        Tabs.Controls.Add(tabPage1);
        Tabs.Controls.Add(tabPage2);
        Tabs.Controls.Add(tabPage3);
        Tabs.Controls.Add(tabPage4);
        Tabs.Controls.Add(tabPage5);
        Tabs.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Tabs.Location = new Point(6, 27);
        Tabs.Name = "Tabs";
        Tabs.SelectedIndex = 0;
        Tabs.Size = new Size(1137, 588);
        Tabs.TabIndex = 10;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(playerNumberTetBox);
        tabPage1.Controls.Add(label19);
        tabPage1.Controls.Add(label18);
        tabPage1.Controls.Add(label17);
        tabPage1.Controls.Add(searchTeamComboBox);
        tabPage1.Controls.Add(label15);
        tabPage1.Controls.Add(searchRoleComboBox);
        tabPage1.Controls.Add(label16);
        tabPage1.Controls.Add(teamIDPlayerComboBox);
        tabPage1.Controls.Add(label14);
        tabPage1.Controls.Add(playerPatronymicTetBox);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(playerGettingButton);
        tabPage1.Controls.Add(playerSearchTextBox);
        tabPage1.Controls.Add(roleIDPlayerComboBox);
        tabPage1.Controls.Add(playerAddButton);
        tabPage1.Controls.Add(playerUpdateButton);
        tabPage1.Controls.Add(playerSurnameTextBox);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(playerNameTextBox);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(tablePlayers);
        tabPage1.Controls.Add(playerDeleteButton);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1129, 555);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Игроки";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // playerNumberTetBox
        // 
        playerNumberTetBox.Location = new Point(85, 123);
        playerNumberTetBox.Name = "playerNumberTetBox";
        playerNumberTetBox.Size = new Size(305, 27);
        playerNumberTetBox.TabIndex = 32;
        playerNumberTetBox.KeyPress += playerNumberTextBox;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(6, 128);
        label19.Name = "label19";
        label19.Size = new Size(56, 20);
        label19.TabIndex = 31;
        label19.Text = "Номер";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(127, 289);
        label18.Name = "label18";
        label18.Size = new Size(62, 20);
        label18.TabIndex = 30;
        label18.Text = "Фильтр";
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(8, 335);
        label17.Name = "label17";
        label17.Size = new Size(113, 20);
        label17.TabIndex = 29;
        label17.Text = "Строка поиска";
        // 
        // searchTeamComboBox
        // 
        searchTeamComboBox.FormattingEnabled = true;
        searchTeamComboBox.Location = new Point(85, 361);
        searchTeamComboBox.Name = "searchTeamComboBox";
        searchTeamComboBox.Size = new Size(305, 28);
        searchTeamComboBox.TabIndex = 28;
        searchTeamComboBox.DropDown += searchTeamComboBox_DropDown;
        searchTeamComboBox.Enter += ButtonGettingPlayers_Click;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(8, 364);
        label15.Name = "label15";
        label15.Size = new Size(72, 20);
        label15.TabIndex = 27;
        label15.Text = "Команда";
        // 
        // searchRoleComboBox
        // 
        searchRoleComboBox.FormattingEnabled = true;
        searchRoleComboBox.Location = new Point(85, 395);
        searchRoleComboBox.Name = "searchRoleComboBox";
        searchRoleComboBox.Size = new Size(305, 28);
        searchRoleComboBox.TabIndex = 26;
        searchRoleComboBox.DropDown += searchRoleComboBox_DropDown;
        searchRoleComboBox.Enter += ButtonGettingPlayers_Click;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(8, 398);
        label16.Name = "label16";
        label16.Size = new Size(45, 20);
        label16.TabIndex = 25;
        label16.Text = "Роль";
        // 
        // teamIDPlayerComboBox
        // 
        teamIDPlayerComboBox.FormattingEnabled = true;
        teamIDPlayerComboBox.Location = new Point(85, 190);
        teamIDPlayerComboBox.Name = "teamIDPlayerComboBox";
        teamIDPlayerComboBox.Size = new Size(305, 28);
        teamIDPlayerComboBox.TabIndex = 24;
        teamIDPlayerComboBox.DropDown += searchTeamComboBox_DropDown;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(8, 193);
        label14.Name = "label14";
        label14.Size = new Size(72, 20);
        label14.TabIndex = 23;
        label14.Text = "Команда";
        // 
        // playerPatronymicTetBox
        // 
        playerPatronymicTetBox.Location = new Point(85, 89);
        playerPatronymicTetBox.Name = "playerPatronymicTetBox";
        playerPatronymicTetBox.Size = new Size(305, 27);
        playerPatronymicTetBox.TabIndex = 22;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(6, 96);
        label3.Name = "label3";
        label3.Size = new Size(76, 20);
        label3.TabIndex = 21;
        label3.Text = "Отчество";
        // 
        // playerGettingButton
        // 
        playerGettingButton.Location = new Point(296, 429);
        playerGettingButton.Name = "playerGettingButton";
        playerGettingButton.Size = new Size(94, 29);
        playerGettingButton.TabIndex = 20;
        playerGettingButton.Text = "Получить";
        playerGettingButton.UseVisualStyleBackColor = true;
        playerGettingButton.Click += ButtonGettingPlayers_Click;
        // 
        // playerSearchTextBox
        // 
        playerSearchTextBox.Location = new Point(127, 328);
        playerSearchTextBox.Name = "playerSearchTextBox";
        playerSearchTextBox.Size = new Size(263, 27);
        playerSearchTextBox.TabIndex = 19;
        playerSearchTextBox.Enter += ButtonGettingPlayers_Click;
        playerSearchTextBox.KeyDown += ButtonGettingPlayers_Click;
        // 
        // roleIDPlayerComboBox
        // 
        roleIDPlayerComboBox.FormattingEnabled = true;
        roleIDPlayerComboBox.Location = new Point(85, 156);
        roleIDPlayerComboBox.Name = "roleIDPlayerComboBox";
        roleIDPlayerComboBox.Size = new Size(305, 28);
        roleIDPlayerComboBox.TabIndex = 18;
        roleIDPlayerComboBox.DropDown += searchRoleComboBox_DropDown;
        // 
        // playerAddButton
        // 
        playerAddButton.Location = new Point(95, 233);
        playerAddButton.Name = "playerAddButton";
        playerAddButton.Size = new Size(94, 29);
        playerAddButton.TabIndex = 10;
        playerAddButton.Text = "Добавить";
        playerAddButton.UseVisualStyleBackColor = true;
        playerAddButton.Click += addPlayerButton_Click;
        // 
        // playerUpdateButton
        // 
        playerUpdateButton.Location = new Point(196, 233);
        playerUpdateButton.Name = "playerUpdateButton";
        playerUpdateButton.Size = new Size(94, 29);
        playerUpdateButton.TabIndex = 11;
        playerUpdateButton.Text = "Обновить";
        playerUpdateButton.UseVisualStyleBackColor = true;
        playerUpdateButton.Click += updatePlayerButton_Click;
        // 
        // playerSurnameTextBox
        // 
        playerSurnameTextBox.Location = new Point(85, 56);
        playerSurnameTextBox.Name = "playerSurnameTextBox";
        playerSurnameTextBox.Size = new Size(305, 27);
        playerSurnameTextBox.TabIndex = 16;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(6, 27);
        label4.Name = "label4";
        label4.Size = new Size(39, 20);
        label4.TabIndex = 12;
        label4.Text = "Имя";
        // 
        // playerNameTextBox
        // 
        playerNameTextBox.Location = new Point(85, 23);
        playerNameTextBox.Name = "playerNameTextBox";
        playerNameTextBox.Size = new Size(305, 27);
        playerNameTextBox.TabIndex = 15;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(6, 63);
        label5.Name = "label5";
        label5.Size = new Size(74, 20);
        label5.TabIndex = 13;
        label5.Text = "Фамилия";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(8, 159);
        label6.Name = "label6";
        label6.Size = new Size(45, 20);
        label6.TabIndex = 14;
        label6.Text = "Роль";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(button2);
        tabPage2.Controls.Add(comboBox6);
        tabPage2.Controls.Add(button1);
        tabPage2.Controls.Add(button17);
        tabPage2.Controls.Add(button16);
        tabPage2.Controls.Add(label1);
        tabPage2.Controls.Add(label2);
        tabPage2.Controls.Add(textBox1);
        tabPage2.Controls.Add(dataGridView2);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1129, 555);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Комнады";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(429, 512);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 26;
        button2.Text = "Получить";
        button2.UseVisualStyleBackColor = true;
        // 
        // comboBox6
        // 
        comboBox6.FormattingEnabled = true;
        comboBox6.Location = new Point(118, 50);
        comboBox6.Name = "comboBox6";
        comboBox6.Size = new Size(305, 28);
        comboBox6.TabIndex = 25;
        // 
        // button1
        // 
        button1.Location = new Point(993, 512);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 19;
        button1.Text = "Удалить";
        button1.UseVisualStyleBackColor = true;
        // 
        // button17
        // 
        button17.Location = new Point(893, 512);
        button17.Name = "button17";
        button17.Size = new Size(94, 29);
        button17.TabIndex = 18;
        button17.Text = "Обновить";
        button17.UseVisualStyleBackColor = true;
        // 
        // button16
        // 
        button16.Location = new Point(793, 512);
        button16.Name = "button16";
        button16.Size = new Size(94, 29);
        button16.TabIndex = 17;
        button16.Text = "Добавить";
        button16.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(6, 17);
        label1.Name = "label1";
        label1.Size = new Size(76, 20);
        label1.TabIndex = 15;
        label1.Text = "Название";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(6, 53);
        label2.Name = "label2";
        label2.Size = new Size(70, 20);
        label2.TabIndex = 16;
        label2.Text = "Спонсор";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(118, 17);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(305, 27);
        textBox1.TabIndex = 1;
        // 
        // dataGridView2
        // 
        dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView2.Location = new Point(429, 6);
        dataGridView2.Name = "dataGridView2";
        dataGridView2.RowHeadersWidth = 51;
        dataGridView2.RowTemplate.Height = 29;
        dataGridView2.Size = new Size(658, 500);
        dataGridView2.TabIndex = 0;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(comboBox4);
        tabPage3.Controls.Add(comboBox3);
        tabPage3.Controls.Add(comboBox2);
        tabPage3.Controls.Add(button7);
        tabPage3.Controls.Add(button8);
        tabPage3.Controls.Add(button9);
        tabPage3.Controls.Add(DateTimePickerMatch);
        tabPage3.Controls.Add(label10);
        tabPage3.Controls.Add(label9);
        tabPage3.Controls.Add(label8);
        tabPage3.Controls.Add(label7);
        tabPage3.Location = new Point(4, 29);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(1129, 555);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Матчи";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // comboBox4
        // 
        comboBox4.FormattingEnabled = true;
        comboBox4.Location = new Point(114, 174);
        comboBox4.Name = "comboBox4";
        comboBox4.Size = new Size(193, 28);
        comboBox4.TabIndex = 23;
        // 
        // comboBox3
        // 
        comboBox3.FormattingEnabled = true;
        comboBox3.Location = new Point(114, 128);
        comboBox3.Name = "comboBox3";
        comboBox3.Size = new Size(193, 28);
        comboBox3.TabIndex = 22;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(114, 84);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(193, 28);
        comboBox2.TabIndex = 21;
        // 
        // button7
        // 
        button7.Location = new Point(345, 84);
        button7.Name = "button7";
        button7.Size = new Size(94, 29);
        button7.TabIndex = 19;
        button7.Text = "Добавить";
        button7.UseVisualStyleBackColor = true;
        // 
        // button8
        // 
        button8.Location = new Point(345, 128);
        button8.Name = "button8";
        button8.Size = new Size(94, 29);
        button8.TabIndex = 20;
        button8.Text = "Обновить";
        button8.UseVisualStyleBackColor = true;
        // 
        // button9
        // 
        button9.Location = new Point(345, 174);
        button9.Name = "button9";
        button9.Size = new Size(94, 29);
        button9.TabIndex = 18;
        button9.Text = "Удалить";
        button9.UseVisualStyleBackColor = true;
        // 
        // DateTimePickerMatch
        // 
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.Location = new Point(114, 33);
        DateTimePickerMatch.Name = "DateTimePickerMatch";
        DateTimePickerMatch.Size = new Size(325, 27);
        DateTimePickerMatch.TabIndex = 17;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(13, 174);
        label10.Name = "label10";
        label10.Size = new Size(69, 20);
        label10.TabIndex = 16;
        label10.Text = "Стадион";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(13, 128);
        label9.Name = "label9";
        label9.Size = new Size(84, 20);
        label9.TabIndex = 15;
        label9.Text = "Команда 2";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(13, 84);
        label8.Name = "label8";
        label8.Size = new Size(84, 20);
        label8.TabIndex = 14;
        label8.Text = "Команда 1";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(13, 33);
        label7.Name = "label7";
        label7.Size = new Size(90, 20);
        label7.TabIndex = 13;
        label7.Text = "Дата матча";
        // 
        // tabPage4
        // 
        tabPage4.Controls.Add(selectLocationComboBox);
        tabPage4.Controls.Add(label24);
        tabPage4.Controls.Add(stadiumSearchTextBox);
        tabPage4.Controls.Add(buttonGettingStadiums);
        tabPage4.Controls.Add(stadiumVolumeTextBox);
        tabPage4.Controls.Add(label23);
        tabPage4.Controls.Add(stadiumAddButton);
        tabPage4.Controls.Add(button11);
        tabPage4.Controls.Add(DeleteStadium_Button);
        tabPage4.Controls.Add(stadiumNameTextBox);
        tabPage4.Controls.Add(label12);
        tabPage4.Controls.Add(label11);
        tabPage4.Controls.Add(tableStadiums);
        tabPage4.ForeColor = Color.Black;
        tabPage4.Location = new Point(4, 29);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(1129, 555);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Стадионы";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // selectLocationComboBox
        // 
        selectLocationComboBox.FormattingEnabled = true;
        selectLocationComboBox.Location = new Point(95, 117);
        selectLocationComboBox.Name = "selectLocationComboBox";
        selectLocationComboBox.Size = new Size(214, 28);
        selectLocationComboBox.TabIndex = 36;
        selectLocationComboBox.DropDown += selectLocationComboBox_DropDown;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(14, 388);
        label24.Name = "label24";
        label24.Size = new Size(113, 20);
        label24.TabIndex = 35;
        label24.Text = "Строка поиска";
        // 
        // stadiumSearchTextBox
        // 
        stadiumSearchTextBox.Location = new Point(148, 385);
        stadiumSearchTextBox.Name = "stadiumSearchTextBox";
        stadiumSearchTextBox.Size = new Size(311, 27);
        stadiumSearchTextBox.TabIndex = 34;
        // 
        // buttonGettingStadiums
        // 
        buttonGettingStadiums.Location = new Point(365, 435);
        buttonGettingStadiums.Name = "buttonGettingStadiums";
        buttonGettingStadiums.Size = new Size(94, 29);
        buttonGettingStadiums.TabIndex = 33;
        buttonGettingStadiums.Text = "Получить";
        buttonGettingStadiums.UseVisualStyleBackColor = true;
        buttonGettingStadiums.Click += buttonGettingStadiums_Click;
        // 
        // stadiumVolumeTextBox
        // 
        stadiumVolumeTextBox.Location = new Point(184, 77);
        stadiumVolumeTextBox.Name = "stadiumVolumeTextBox";
        stadiumVolumeTextBox.Size = new Size(125, 27);
        stadiumVolumeTextBox.TabIndex = 25;
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(14, 80);
        label23.Name = "label23";
        label23.Size = new Size(131, 20);
        label23.TabIndex = 24;
        label23.Text = "Размер стадиона";
        // 
        // stadiumAddButton
        // 
        stadiumAddButton.Location = new Point(380, 29);
        stadiumAddButton.Name = "stadiumAddButton";
        stadiumAddButton.Size = new Size(94, 29);
        stadiumAddButton.TabIndex = 22;
        stadiumAddButton.Text = "Добавить";
        stadiumAddButton.UseVisualStyleBackColor = true;
        stadiumAddButton.Click += stadiumAddButton_Click;
        // 
        // button11
        // 
        button11.Location = new Point(380, 80);
        button11.Name = "button11";
        button11.Size = new Size(94, 29);
        button11.TabIndex = 23;
        button11.Text = "Обновить";
        button11.UseVisualStyleBackColor = true;
        // 
        // DeleteStadium_Button
        // 
        DeleteStadium_Button.Location = new Point(380, 125);
        DeleteStadium_Button.Name = "DeleteStadium_Button";
        DeleteStadium_Button.Size = new Size(94, 29);
        DeleteStadium_Button.TabIndex = 21;
        DeleteStadium_Button.Text = "Удалить";
        DeleteStadium_Button.UseVisualStyleBackColor = true;
        DeleteStadium_Button.Click += DeleteStadium_Button_Click;
        // 
        // stadiumNameTextBox
        // 
        stadiumNameTextBox.Location = new Point(184, 31);
        stadiumNameTextBox.Name = "stadiumNameTextBox";
        stadiumNameTextBox.Size = new Size(125, 27);
        stadiumNameTextBox.TabIndex = 17;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(14, 125);
        label12.Name = "label12";
        label12.Size = new Size(53, 20);
        label12.TabIndex = 16;
        label12.Text = "Город";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(14, 34);
        label11.Name = "label11";
        label11.Size = new Size(145, 20);
        label11.TabIndex = 15;
        label11.Text = "Название стадиона";
        // 
        // tableStadiums
        // 
        tableStadiums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableStadiums.Location = new Point(498, 6);
        tableStadiums.Name = "tableStadiums";
        tableStadiums.RowHeadersWidth = 51;
        tableStadiums.RowTemplate.Height = 29;
        tableStadiums.Size = new Size(603, 539);
        tableStadiums.TabIndex = 2;
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(label21);
        tabPage5.Controls.Add(label22);
        tabPage5.Controls.Add(sponsorSearchTextBox);
        tabPage5.Controls.Add(buttonGettingSponsors);
        tabPage5.Controls.Add(label20);
        tabPage5.Controls.Add(descriptionNameTextBox);
        tabPage5.Controls.Add(sposorAddButton);
        tabPage5.Controls.Add(button14);
        tabPage5.Controls.Add(DeleteSponsors_Button);
        tabPage5.Controls.Add(label13);
        tabPage5.Controls.Add(sponsorNameTextBox);
        tabPage5.Controls.Add(tableSponsors);
        tabPage5.Location = new Point(4, 29);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(1129, 555);
        tabPage5.TabIndex = 4;
        tabPage5.Text = "Спонсоры";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(192, 334);
        label21.Name = "label21";
        label21.Size = new Size(62, 20);
        label21.TabIndex = 33;
        label21.Text = "Фильтр";
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Location = new Point(6, 391);
        label22.Name = "label22";
        label22.Size = new Size(113, 20);
        label22.TabIndex = 32;
        label22.Text = "Строка поиска";
        // 
        // sponsorSearchTextBox
        // 
        sponsorSearchTextBox.Location = new Point(140, 388);
        sponsorSearchTextBox.Name = "sponsorSearchTextBox";
        sponsorSearchTextBox.Size = new Size(311, 27);
        sponsorSearchTextBox.TabIndex = 31;
        // 
        // buttonGettingSponsors
        // 
        buttonGettingSponsors.Location = new Point(357, 438);
        buttonGettingSponsors.Name = "buttonGettingSponsors";
        buttonGettingSponsors.Size = new Size(94, 29);
        buttonGettingSponsors.TabIndex = 29;
        buttonGettingSponsors.Text = "Получить";
        buttonGettingSponsors.UseVisualStyleBackColor = true;
        buttonGettingSponsors.Click += buttonGettingSponsors_Click;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(6, 80);
        label20.Name = "label20";
        label20.Size = new Size(77, 20);
        label20.TabIndex = 28;
        label20.Text = "Описание";
        // 
        // descriptionNameTextBox
        // 
        descriptionNameTextBox.Location = new Point(107, 80);
        descriptionNameTextBox.Name = "descriptionNameTextBox";
        descriptionNameTextBox.Size = new Size(230, 27);
        descriptionNameTextBox.TabIndex = 27;
        // 
        // sposorAddButton
        // 
        sposorAddButton.Location = new Point(377, 32);
        sposorAddButton.Name = "sposorAddButton";
        sposorAddButton.Size = new Size(94, 29);
        sposorAddButton.TabIndex = 25;
        sposorAddButton.Text = "Добавить";
        sposorAddButton.UseVisualStyleBackColor = true;
        sposorAddButton.Click += sponsorAddButton_Click;
        // 
        // button14
        // 
        button14.Location = new Point(377, 80);
        button14.Name = "button14";
        button14.Size = new Size(94, 29);
        button14.TabIndex = 26;
        button14.Text = "Обновить";
        button14.UseVisualStyleBackColor = true;
        // 
        // DeleteSponsors_Button
        // 
        DeleteSponsors_Button.Location = new Point(377, 128);
        DeleteSponsors_Button.Name = "DeleteSponsors_Button";
        DeleteSponsors_Button.Size = new Size(94, 29);
        DeleteSponsors_Button.TabIndex = 24;
        DeleteSponsors_Button.Text = "Удалить";
        DeleteSponsors_Button.UseVisualStyleBackColor = true;
        DeleteSponsors_Button.Click += DeleteSponsors_Button_Click;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(6, 34);
        label13.Name = "label13";
        label13.Size = new Size(182, 20);
        label13.TabIndex = 20;
        label13.Text = "Наименование спонсора";
        // 
        // sponsorNameTextBox
        // 
        sponsorNameTextBox.Location = new Point(212, 34);
        sponsorNameTextBox.Name = "sponsorNameTextBox";
        sponsorNameTextBox.Size = new Size(125, 27);
        sponsorNameTextBox.TabIndex = 18;
        // 
        // tableSponsors
        // 
        tableSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableSponsors.Location = new Point(488, 6);
        tableSponsors.Name = "tableSponsors";
        tableSponsors.RowHeadersWidth = 51;
        tableSponsors.RowTemplate.Height = 29;
        tableSponsors.Size = new Size(603, 550);
        tableSponsors.TabIndex = 3;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { logoutMenuStrip });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1111, 28);
        menuStrip1.TabIndex = 11;
        menuStrip1.Text = "menuStrip1";
        // 
        // logoutMenuStrip
        // 
        logoutMenuStrip.Name = "logoutMenuStrip";
        logoutMenuStrip.Size = new Size(67, 24);
        logoutMenuStrip.Text = "Выход";
        logoutMenuStrip.Click += LogoutMenuStrip_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1111, 609);
        Controls.Add(Tabs);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Курсач";
        FormClosed += Form1_FormClosed;
        ((System.ComponentModel.ISupportInitialize)tablePlayers).EndInit();
        Tabs.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        tabPage4.ResumeLayout(false);
        tabPage4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tableStadiums).EndInit();
        tabPage5.ResumeLayout(false);
        tabPage5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tableSponsors).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button playerDeleteButton;
    private DataGridView tablePlayers;
    private TabControl Tabs;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Button playerAddButton;
    private Button playerUpdateButton;
    private TextBox playerSurnameTextBox;
    private Label label4;
    private TextBox playerNameTextBox;
    private Label label5;
    private Label label6;
    private TextBox textBox1;
    private DataGridView dataGridView2;
    private Label label1;
    private Label label2;
    private Label label7;
    private Label label10;
    private Label label9;
    private Label label8;
    private Button button7;
    private Button button8;
    private Button button9;
    private DateTimePicker DateTimePickerMatch;
    private Button stadiumAddButton;
    private Button button11;
    private Button DeleteStadium_Button;
    private TextBox stadiumNameTextBox;
    private Label label12;
    private Label label11;
    private DataGridView tableStadiums;
    private TabPage tabPage5;
    private Label label13;
    private TextBox sponsorNameTextBox;
    private DataGridView tableSponsors;
    private Button sposorAddButton;
    private Button button14;
    private Button DeleteSponsors_Button;
    private ComboBox roleIDPlayerComboBox;
    private ComboBox comboBox4;
    private ComboBox comboBox3;
    private ComboBox comboBox2;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
    private ComboBox teamIDPlayerComboBox;
    private Label label14;
    private TextBox playerPatronymicTetBox;
    private Label label3;
    private Button playerGettingButton;
    private TextBox playerSearchTextBox;
    private Button button1;
    private Button button17;
    private Button button16;
    private Label label18;
    private Label label17;
    private ComboBox searchTeamComboBox;
    private Label label15;
    private ComboBox searchRoleComboBox;
    private Label label16;
    private Button button2;
    private ComboBox comboBox6;
    private TextBox playerNumberTetBox;
    private Label label19;
    private Label label20;
    private TextBox descriptionNameTextBox;
    private Button buttonGettingSponsors;
    private Label label21;
    private Label label22;
    private TextBox sponsorSearchTextBox;
    private TextBox stadiumVolumeTextBox;
    private Label label23;
    private Label label24;
    private TextBox stadiumSearchTextBox;
    private Button buttonGettingStadiums;
    private ComboBox selectLocationComboBox;
}
