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
        label28 = new Label();
        teamSearchTextBox = new TextBox();
        teamGettingButton = new Button();
        sponsorIDTeamComboBox = new ComboBox();
        teamDeleteButton = new Button();
        teamUpdateButton = new Button();
        teamAddButton = new Button();
        label1 = new Label();
        label2 = new Label();
        teamNameTextBox = new TextBox();
        tableTeams = new DataGridView();
        tabPage3 = new TabPage();
        resultTeam2TextBox = new TextBox();
        resultTeam1TextBox = new TextBox();
        label27 = new Label();
        label26 = new Label();
        label25 = new Label();
        textBox2 = new TextBox();
        matchGettingButton = new Button();
        tableMatches = new DataGridView();
        stadiumIDTeamComboBox = new ComboBox();
        team2IDMatchComboBox = new ComboBox();
        team1IDMatchComboBox = new ComboBox();
        matchAddButton = new Button();
        matchUpdateButton = new Button();
        matchDeleteButton = new Button();
        DateTimePickerMatch = new DateTimePicker();
        label10 = new Label();
        label9 = new Label();
        label8 = new Label();
        label7 = new Label();
        tabPage4 = new TabPage();
        isUseForMatchesCheckBox = new CheckBox();
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
        tabPage6 = new TabPage();
        button3 = new Button();
        tablePlayerCountMatchesDataGridView = new DataGridView();
        menuStrip1 = new MenuStrip();
        logoutMenuStrip = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)tablePlayers).BeginInit();
        Tabs.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableTeams).BeginInit();
        tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableMatches).BeginInit();
        tabPage4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableStadiums).BeginInit();
        tabPage5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableSponsors).BeginInit();
        tabPage6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tablePlayerCountMatchesDataGridView).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // playerDeleteButton
        // 
        playerDeleteButton.Location = new Point(259, 175);
        playerDeleteButton.Margin = new Padding(3, 2, 3, 2);
        playerDeleteButton.Name = "playerDeleteButton";
        playerDeleteButton.Size = new Size(82, 22);
        playerDeleteButton.TabIndex = 2;
        playerDeleteButton.Text = "Удалить";
        playerDeleteButton.UseVisualStyleBackColor = true;
        playerDeleteButton.Click += DeletePlayers_Click;
        // 
        // tablePlayers
        // 
        tablePlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayers.Location = new Point(359, 4);
        tablePlayers.Margin = new Padding(3, 2, 3, 2);
        tablePlayers.Name = "tablePlayers";
        tablePlayers.RowHeadersWidth = 51;
        tablePlayers.RowTemplate.Height = 29;
        tablePlayers.Size = new Size(592, 401);
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
        Tabs.Controls.Add(tabPage6);
        Tabs.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Tabs.Location = new Point(5, 20);
        Tabs.Margin = new Padding(3, 2, 3, 2);
        Tabs.Name = "Tabs";
        Tabs.SelectedIndex = 0;
        Tabs.Size = new Size(995, 441);
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
        tabPage1.Location = new Point(4, 25);
        tabPage1.Margin = new Padding(3, 2, 3, 2);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3, 2, 3, 2);
        tabPage1.Size = new Size(987, 412);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Игроки";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // playerNumberTetBox
        // 
        playerNumberTetBox.Location = new Point(74, 92);
        playerNumberTetBox.Margin = new Padding(3, 2, 3, 2);
        playerNumberTetBox.Name = "playerNumberTetBox";
        playerNumberTetBox.Size = new Size(267, 23);
        playerNumberTetBox.TabIndex = 32;
        playerNumberTetBox.KeyPress += playerNumberTextBox;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(5, 96);
        label19.Name = "label19";
        label19.Size = new Size(46, 16);
        label19.TabIndex = 31;
        label19.Text = "Номер";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(111, 217);
        label18.Name = "label18";
        label18.Size = new Size(53, 16);
        label18.TabIndex = 30;
        label18.Text = "Фильтр";
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(7, 251);
        label17.Name = "label17";
        label17.Size = new Size(92, 16);
        label17.TabIndex = 29;
        label17.Text = "Строка поиска";
        // 
        // searchTeamComboBox
        // 
        searchTeamComboBox.FormattingEnabled = true;
        searchTeamComboBox.Location = new Point(74, 271);
        searchTeamComboBox.Margin = new Padding(3, 2, 3, 2);
        searchTeamComboBox.Name = "searchTeamComboBox";
        searchTeamComboBox.Size = new Size(267, 24);
        searchTeamComboBox.TabIndex = 28;
        searchTeamComboBox.DropDown += searchTeamComboBox_DropDown;
        searchTeamComboBox.Enter += ButtonGettingPlayers_Click;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(7, 273);
        label15.Name = "label15";
        label15.Size = new Size(59, 16);
        label15.TabIndex = 27;
        label15.Text = "Команда";
        // 
        // searchRoleComboBox
        // 
        searchRoleComboBox.FormattingEnabled = true;
        searchRoleComboBox.Location = new Point(74, 296);
        searchRoleComboBox.Margin = new Padding(3, 2, 3, 2);
        searchRoleComboBox.Name = "searchRoleComboBox";
        searchRoleComboBox.Size = new Size(267, 24);
        searchRoleComboBox.TabIndex = 26;
        searchRoleComboBox.DropDown += searchRoleComboBox_DropDown;
        searchRoleComboBox.Enter += ButtonGettingPlayers_Click;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(7, 298);
        label16.Name = "label16";
        label16.Size = new Size(36, 16);
        label16.TabIndex = 25;
        label16.Text = "Роль";
        // 
        // teamIDPlayerComboBox
        // 
        teamIDPlayerComboBox.FormattingEnabled = true;
        teamIDPlayerComboBox.Location = new Point(74, 142);
        teamIDPlayerComboBox.Margin = new Padding(3, 2, 3, 2);
        teamIDPlayerComboBox.Name = "teamIDPlayerComboBox";
        teamIDPlayerComboBox.Size = new Size(267, 24);
        teamIDPlayerComboBox.TabIndex = 24;
        teamIDPlayerComboBox.DropDown += searchTeamComboBox_DropDown;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(7, 145);
        label14.Name = "label14";
        label14.Size = new Size(59, 16);
        label14.TabIndex = 23;
        label14.Text = "Команда";
        // 
        // playerPatronymicTetBox
        // 
        playerPatronymicTetBox.Location = new Point(74, 67);
        playerPatronymicTetBox.Margin = new Padding(3, 2, 3, 2);
        playerPatronymicTetBox.Name = "playerPatronymicTetBox";
        playerPatronymicTetBox.Size = new Size(267, 23);
        playerPatronymicTetBox.TabIndex = 22;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(5, 72);
        label3.Name = "label3";
        label3.Size = new Size(63, 16);
        label3.TabIndex = 21;
        label3.Text = "Отчество";
        // 
        // playerGettingButton
        // 
        playerGettingButton.Location = new Point(259, 322);
        playerGettingButton.Margin = new Padding(3, 2, 3, 2);
        playerGettingButton.Name = "playerGettingButton";
        playerGettingButton.Size = new Size(82, 22);
        playerGettingButton.TabIndex = 20;
        playerGettingButton.Text = "Получить";
        playerGettingButton.UseVisualStyleBackColor = true;
        playerGettingButton.Click += ButtonGettingPlayers_Click;
        // 
        // playerSearchTextBox
        // 
        playerSearchTextBox.Location = new Point(111, 246);
        playerSearchTextBox.Margin = new Padding(3, 2, 3, 2);
        playerSearchTextBox.Name = "playerSearchTextBox";
        playerSearchTextBox.Size = new Size(231, 23);
        playerSearchTextBox.TabIndex = 19;
        playerSearchTextBox.Enter += ButtonGettingPlayers_Click;
        playerSearchTextBox.KeyDown += ButtonGettingPlayers_Click;
        // 
        // roleIDPlayerComboBox
        // 
        roleIDPlayerComboBox.FormattingEnabled = true;
        roleIDPlayerComboBox.Location = new Point(74, 117);
        roleIDPlayerComboBox.Margin = new Padding(3, 2, 3, 2);
        roleIDPlayerComboBox.Name = "roleIDPlayerComboBox";
        roleIDPlayerComboBox.Size = new Size(267, 24);
        roleIDPlayerComboBox.TabIndex = 18;
        roleIDPlayerComboBox.DropDown += searchRoleComboBox_DropDown;
        // 
        // playerAddButton
        // 
        playerAddButton.Location = new Point(83, 175);
        playerAddButton.Margin = new Padding(3, 2, 3, 2);
        playerAddButton.Name = "playerAddButton";
        playerAddButton.Size = new Size(82, 22);
        playerAddButton.TabIndex = 10;
        playerAddButton.Text = "Добавить";
        playerAddButton.UseVisualStyleBackColor = true;
        playerAddButton.Click += addPlayerButton_Click;
        // 
        // playerUpdateButton
        // 
        playerUpdateButton.Location = new Point(172, 175);
        playerUpdateButton.Margin = new Padding(3, 2, 3, 2);
        playerUpdateButton.Name = "playerUpdateButton";
        playerUpdateButton.Size = new Size(82, 22);
        playerUpdateButton.TabIndex = 11;
        playerUpdateButton.Text = "Обновить";
        playerUpdateButton.UseVisualStyleBackColor = true;
        playerUpdateButton.Click += updatePlayerButton_Click;
        // 
        // playerSurnameTextBox
        // 
        playerSurnameTextBox.Location = new Point(74, 42);
        playerSurnameTextBox.Margin = new Padding(3, 2, 3, 2);
        playerSurnameTextBox.Name = "playerSurnameTextBox";
        playerSurnameTextBox.Size = new Size(267, 23);
        playerSurnameTextBox.TabIndex = 16;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(5, 20);
        label4.Name = "label4";
        label4.Size = new Size(32, 16);
        label4.TabIndex = 12;
        label4.Text = "Имя";
        // 
        // playerNameTextBox
        // 
        playerNameTextBox.Location = new Point(74, 17);
        playerNameTextBox.Margin = new Padding(3, 2, 3, 2);
        playerNameTextBox.Name = "playerNameTextBox";
        playerNameTextBox.Size = new Size(267, 23);
        playerNameTextBox.TabIndex = 15;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(5, 47);
        label5.Name = "label5";
        label5.Size = new Size(62, 16);
        label5.TabIndex = 13;
        label5.Text = "Фамилия";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(7, 119);
        label6.Name = "label6";
        label6.Size = new Size(36, 16);
        label6.TabIndex = 14;
        label6.Text = "Роль";
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(label28);
        tabPage2.Controls.Add(teamSearchTextBox);
        tabPage2.Controls.Add(teamGettingButton);
        tabPage2.Controls.Add(sponsorIDTeamComboBox);
        tabPage2.Controls.Add(teamDeleteButton);
        tabPage2.Controls.Add(teamUpdateButton);
        tabPage2.Controls.Add(teamAddButton);
        tabPage2.Controls.Add(label1);
        tabPage2.Controls.Add(label2);
        tabPage2.Controls.Add(teamNameTextBox);
        tabPage2.Controls.Add(tableTeams);
        tabPage2.Location = new Point(4, 25);
        tabPage2.Margin = new Padding(3, 2, 3, 2);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3, 2, 3, 2);
        tabPage2.Size = new Size(987, 412);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Комнады";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // label28
        // 
        label28.AutoSize = true;
        label28.Location = new Point(6, 265);
        label28.Name = "label28";
        label28.Size = new Size(92, 16);
        label28.TabIndex = 37;
        label28.Text = "Строка поиска";
        // 
        // teamSearchTextBox
        // 
        teamSearchTextBox.Location = new Point(124, 263);
        teamSearchTextBox.Margin = new Padding(3, 2, 3, 2);
        teamSearchTextBox.Name = "teamSearchTextBox";
        teamSearchTextBox.Size = new Size(240, 23);
        teamSearchTextBox.TabIndex = 36;
        // 
        // teamGettingButton
        // 
        teamGettingButton.Location = new Point(375, 384);
        teamGettingButton.Margin = new Padding(3, 2, 3, 2);
        teamGettingButton.Name = "teamGettingButton";
        teamGettingButton.Size = new Size(82, 22);
        teamGettingButton.TabIndex = 26;
        teamGettingButton.Text = "Получить";
        teamGettingButton.UseVisualStyleBackColor = true;
        teamGettingButton.Click += teamGettingButton_Click;
        // 
        // sponsorIDTeamComboBox
        // 
        sponsorIDTeamComboBox.FormattingEnabled = true;
        sponsorIDTeamComboBox.Location = new Point(103, 38);
        sponsorIDTeamComboBox.Margin = new Padding(3, 2, 3, 2);
        sponsorIDTeamComboBox.Name = "sponsorIDTeamComboBox";
        sponsorIDTeamComboBox.Size = new Size(267, 24);
        sponsorIDTeamComboBox.TabIndex = 25;
        sponsorIDTeamComboBox.DropDown += sponsorIDTeamComboBox_DropDown;
        // 
        // teamDeleteButton
        // 
        teamDeleteButton.Location = new Point(869, 384);
        teamDeleteButton.Margin = new Padding(3, 2, 3, 2);
        teamDeleteButton.Name = "teamDeleteButton";
        teamDeleteButton.Size = new Size(82, 22);
        teamDeleteButton.TabIndex = 19;
        teamDeleteButton.Text = "Удалить";
        teamDeleteButton.UseVisualStyleBackColor = true;
        teamDeleteButton.Click += teamDeleteButton_Click;
        // 
        // teamUpdateButton
        // 
        teamUpdateButton.Location = new Point(781, 384);
        teamUpdateButton.Margin = new Padding(3, 2, 3, 2);
        teamUpdateButton.Name = "teamUpdateButton";
        teamUpdateButton.Size = new Size(82, 22);
        teamUpdateButton.TabIndex = 18;
        teamUpdateButton.Text = "Обновить";
        teamUpdateButton.UseVisualStyleBackColor = true;
        teamUpdateButton.Click += teamUpdateButton_Click;
        // 
        // teamAddButton
        // 
        teamAddButton.Location = new Point(694, 384);
        teamAddButton.Margin = new Padding(3, 2, 3, 2);
        teamAddButton.Name = "teamAddButton";
        teamAddButton.Size = new Size(82, 22);
        teamAddButton.TabIndex = 17;
        teamAddButton.Text = "Добавить";
        teamAddButton.UseVisualStyleBackColor = true;
        teamAddButton.Click += teamAddButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(5, 13);
        label1.Name = "label1";
        label1.Size = new Size(64, 16);
        label1.TabIndex = 15;
        label1.Text = "Название";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(5, 40);
        label2.Name = "label2";
        label2.Size = new Size(56, 16);
        label2.TabIndex = 16;
        label2.Text = "Спонсор";
        // 
        // teamNameTextBox
        // 
        teamNameTextBox.Location = new Point(103, 13);
        teamNameTextBox.Margin = new Padding(3, 2, 3, 2);
        teamNameTextBox.Name = "teamNameTextBox";
        teamNameTextBox.Size = new Size(267, 23);
        teamNameTextBox.TabIndex = 1;
        // 
        // tableTeams
        // 
        tableTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableTeams.Location = new Point(375, 4);
        tableTeams.Margin = new Padding(3, 2, 3, 2);
        tableTeams.Name = "tableTeams";
        tableTeams.RowHeadersWidth = 51;
        tableTeams.RowTemplate.Height = 29;
        tableTeams.Size = new Size(576, 375);
        tableTeams.TabIndex = 0;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(resultTeam2TextBox);
        tabPage3.Controls.Add(resultTeam1TextBox);
        tabPage3.Controls.Add(label27);
        tabPage3.Controls.Add(label26);
        tabPage3.Controls.Add(label25);
        tabPage3.Controls.Add(textBox2);
        tabPage3.Controls.Add(matchGettingButton);
        tabPage3.Controls.Add(tableMatches);
        tabPage3.Controls.Add(stadiumIDTeamComboBox);
        tabPage3.Controls.Add(team2IDMatchComboBox);
        tabPage3.Controls.Add(team1IDMatchComboBox);
        tabPage3.Controls.Add(matchAddButton);
        tabPage3.Controls.Add(matchUpdateButton);
        tabPage3.Controls.Add(matchDeleteButton);
        tabPage3.Controls.Add(DateTimePickerMatch);
        tabPage3.Controls.Add(label10);
        tabPage3.Controls.Add(label9);
        tabPage3.Controls.Add(label8);
        tabPage3.Controls.Add(label7);
        tabPage3.Location = new Point(4, 25);
        tabPage3.Margin = new Padding(3, 2, 3, 2);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3, 2, 3, 2);
        tabPage3.Size = new Size(987, 412);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Матчи";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // resultTeam2TextBox
        // 
        resultTeam2TextBox.Location = new Point(149, 206);
        resultTeam2TextBox.Name = "resultTeam2TextBox";
        resultTeam2TextBox.Size = new Size(100, 23);
        resultTeam2TextBox.TabIndex = 42;
        // 
        // resultTeam1TextBox
        // 
        resultTeam1TextBox.Location = new Point(149, 177);
        resultTeam1TextBox.Name = "resultTeam1TextBox";
        resultTeam1TextBox.Size = new Size(100, 23);
        resultTeam1TextBox.TabIndex = 41;
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(11, 212);
        label27.Name = "label27";
        label27.Size = new Size(132, 16);
        label27.TabIndex = 40;
        label27.Text = "Результат команды 2";
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(11, 180);
        label26.Name = "label26";
        label26.Size = new Size(132, 16);
        label26.TabIndex = 39;
        label26.Text = "Результат команды 1";
        // 
        // label25
        // 
        label25.AutoSize = true;
        label25.Location = new Point(3, 292);
        label25.Name = "label25";
        label25.Size = new Size(92, 16);
        label25.TabIndex = 38;
        label25.Text = "Строка поиска";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(121, 290);
        textBox2.Margin = new Padding(3, 2, 3, 2);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(273, 23);
        textBox2.TabIndex = 37;
        // 
        // matchGettingButton
        // 
        matchGettingButton.Location = new Point(312, 333);
        matchGettingButton.Margin = new Padding(3, 2, 3, 2);
        matchGettingButton.Name = "matchGettingButton";
        matchGettingButton.Size = new Size(82, 22);
        matchGettingButton.TabIndex = 36;
        matchGettingButton.Text = "Получить";
        matchGettingButton.UseVisualStyleBackColor = true;
        matchGettingButton.Click += matchGettingButton_Click;
        // 
        // tableMatches
        // 
        tableMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableMatches.Location = new Point(413, 4);
        tableMatches.Margin = new Padding(3, 2, 3, 2);
        tableMatches.Name = "tableMatches";
        tableMatches.RowHeadersWidth = 51;
        tableMatches.RowTemplate.Height = 29;
        tableMatches.Size = new Size(538, 397);
        tableMatches.TabIndex = 24;
        // 
        // stadiumIDTeamComboBox
        // 
        stadiumIDTeamComboBox.FormattingEnabled = true;
        stadiumIDTeamComboBox.Location = new Point(100, 130);
        stadiumIDTeamComboBox.Margin = new Padding(3, 2, 3, 2);
        stadiumIDTeamComboBox.Name = "stadiumIDTeamComboBox";
        stadiumIDTeamComboBox.Size = new Size(169, 24);
        stadiumIDTeamComboBox.TabIndex = 23;
        stadiumIDTeamComboBox.DropDown += stadiumIDTeamComboBox_DropDown;
        // 
        // team2IDMatchComboBox
        // 
        team2IDMatchComboBox.FormattingEnabled = true;
        team2IDMatchComboBox.Location = new Point(100, 96);
        team2IDMatchComboBox.Margin = new Padding(3, 2, 3, 2);
        team2IDMatchComboBox.Name = "team2IDMatchComboBox";
        team2IDMatchComboBox.Size = new Size(169, 24);
        team2IDMatchComboBox.TabIndex = 22;
        team2IDMatchComboBox.DropDown += team2IDMatchComboBox_DropDown;
        // 
        // team1IDMatchComboBox
        // 
        team1IDMatchComboBox.FormattingEnabled = true;
        team1IDMatchComboBox.Location = new Point(100, 63);
        team1IDMatchComboBox.Margin = new Padding(3, 2, 3, 2);
        team1IDMatchComboBox.Name = "team1IDMatchComboBox";
        team1IDMatchComboBox.Size = new Size(169, 24);
        team1IDMatchComboBox.TabIndex = 21;
        team1IDMatchComboBox.DropDown += team1IDMatchComboBox_DropDown;
        // 
        // matchAddButton
        // 
        matchAddButton.Location = new Point(302, 63);
        matchAddButton.Margin = new Padding(3, 2, 3, 2);
        matchAddButton.Name = "matchAddButton";
        matchAddButton.Size = new Size(82, 22);
        matchAddButton.TabIndex = 19;
        matchAddButton.Text = "Добавить";
        matchAddButton.UseVisualStyleBackColor = true;
        matchAddButton.Click += matchAddButton_Click;
        // 
        // matchUpdateButton
        // 
        matchUpdateButton.Location = new Point(302, 96);
        matchUpdateButton.Margin = new Padding(3, 2, 3, 2);
        matchUpdateButton.Name = "matchUpdateButton";
        matchUpdateButton.Size = new Size(82, 22);
        matchUpdateButton.TabIndex = 20;
        matchUpdateButton.Text = "Обновить";
        matchUpdateButton.UseVisualStyleBackColor = true;
        matchUpdateButton.Click += matchUpdateButton_Click;
        // 
        // matchDeleteButton
        // 
        matchDeleteButton.Location = new Point(302, 130);
        matchDeleteButton.Margin = new Padding(3, 2, 3, 2);
        matchDeleteButton.Name = "matchDeleteButton";
        matchDeleteButton.Size = new Size(82, 22);
        matchDeleteButton.TabIndex = 18;
        matchDeleteButton.Text = "Удалить";
        matchDeleteButton.UseVisualStyleBackColor = true;
        matchDeleteButton.Click += matchDeleteButton_Click;
        // 
        // DateTimePickerMatch
        // 
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.Location = new Point(100, 25);
        DateTimePickerMatch.Margin = new Padding(3, 2, 3, 2);
        DateTimePickerMatch.Name = "DateTimePickerMatch";
        DateTimePickerMatch.Size = new Size(285, 23);
        DateTimePickerMatch.TabIndex = 17;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(11, 130);
        label10.Name = "label10";
        label10.Size = new Size(57, 16);
        label10.TabIndex = 16;
        label10.Text = "Стадион";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(11, 96);
        label9.Name = "label9";
        label9.Size = new Size(68, 16);
        label9.TabIndex = 15;
        label9.Text = "Команда 2";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(11, 63);
        label8.Name = "label8";
        label8.Size = new Size(68, 16);
        label8.TabIndex = 14;
        label8.Text = "Команда 1";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(11, 25);
        label7.Name = "label7";
        label7.Size = new Size(76, 16);
        label7.TabIndex = 13;
        label7.Text = "Дата матча";
        // 
        // tabPage4
        // 
        tabPage4.Controls.Add(isUseForMatchesCheckBox);
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
        tabPage4.Location = new Point(4, 25);
        tabPage4.Margin = new Padding(3, 2, 3, 2);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3, 2, 3, 2);
        tabPage4.Size = new Size(987, 412);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Стадионы";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // isUseForMatchesCheckBox
        // 
        isUseForMatchesCheckBox.AutoSize = true;
        isUseForMatchesCheckBox.Location = new Point(12, 321);
        isUseForMatchesCheckBox.Margin = new Padding(3, 2, 3, 2);
        isUseForMatchesCheckBox.Name = "isUseForMatchesCheckBox";
        isUseForMatchesCheckBox.Size = new Size(293, 20);
        isUseForMatchesCheckBox.TabIndex = 37;
        isUseForMatchesCheckBox.Text = "Получить матчи на которых проходили матчи";
        isUseForMatchesCheckBox.UseVisualStyleBackColor = true;
        // 
        // selectLocationComboBox
        // 
        selectLocationComboBox.FormattingEnabled = true;
        selectLocationComboBox.Location = new Point(83, 88);
        selectLocationComboBox.Margin = new Padding(3, 2, 3, 2);
        selectLocationComboBox.Name = "selectLocationComboBox";
        selectLocationComboBox.Size = new Size(188, 24);
        selectLocationComboBox.TabIndex = 36;
        selectLocationComboBox.DropDown += selectLocationComboBox_DropDown;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(12, 291);
        label24.Name = "label24";
        label24.Size = new Size(92, 16);
        label24.TabIndex = 35;
        label24.Text = "Строка поиска";
        // 
        // stadiumSearchTextBox
        // 
        stadiumSearchTextBox.Location = new Point(130, 289);
        stadiumSearchTextBox.Margin = new Padding(3, 2, 3, 2);
        stadiumSearchTextBox.Name = "stadiumSearchTextBox";
        stadiumSearchTextBox.Size = new Size(273, 23);
        stadiumSearchTextBox.TabIndex = 34;
        // 
        // buttonGettingStadiums
        // 
        buttonGettingStadiums.Location = new Point(319, 359);
        buttonGettingStadiums.Margin = new Padding(3, 2, 3, 2);
        buttonGettingStadiums.Name = "buttonGettingStadiums";
        buttonGettingStadiums.Size = new Size(82, 22);
        buttonGettingStadiums.TabIndex = 33;
        buttonGettingStadiums.Text = "Получить";
        buttonGettingStadiums.UseVisualStyleBackColor = true;
        buttonGettingStadiums.Click += buttonGettingStadiums_Click;
        // 
        // stadiumVolumeTextBox
        // 
        stadiumVolumeTextBox.Location = new Point(161, 58);
        stadiumVolumeTextBox.Margin = new Padding(3, 2, 3, 2);
        stadiumVolumeTextBox.Name = "stadiumVolumeTextBox";
        stadiumVolumeTextBox.Size = new Size(110, 23);
        stadiumVolumeTextBox.TabIndex = 25;
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(12, 60);
        label23.Name = "label23";
        label23.Size = new Size(109, 16);
        label23.TabIndex = 24;
        label23.Text = "Размер стадиона";
        // 
        // stadiumAddButton
        // 
        stadiumAddButton.Location = new Point(332, 22);
        stadiumAddButton.Margin = new Padding(3, 2, 3, 2);
        stadiumAddButton.Name = "stadiumAddButton";
        stadiumAddButton.Size = new Size(82, 22);
        stadiumAddButton.TabIndex = 22;
        stadiumAddButton.Text = "Добавить";
        stadiumAddButton.UseVisualStyleBackColor = true;
        stadiumAddButton.Click += stadiumAddButton_Click;
        // 
        // button11
        // 
        button11.Location = new Point(332, 60);
        button11.Margin = new Padding(3, 2, 3, 2);
        button11.Name = "button11";
        button11.Size = new Size(82, 22);
        button11.TabIndex = 23;
        button11.Text = "Обновить";
        button11.UseVisualStyleBackColor = true;
        // 
        // DeleteStadium_Button
        // 
        DeleteStadium_Button.Location = new Point(332, 94);
        DeleteStadium_Button.Margin = new Padding(3, 2, 3, 2);
        DeleteStadium_Button.Name = "DeleteStadium_Button";
        DeleteStadium_Button.Size = new Size(82, 22);
        DeleteStadium_Button.TabIndex = 21;
        DeleteStadium_Button.Text = "Удалить";
        DeleteStadium_Button.UseVisualStyleBackColor = true;
        DeleteStadium_Button.Click += DeleteStadium_Button_Click;
        // 
        // stadiumNameTextBox
        // 
        stadiumNameTextBox.Location = new Point(161, 23);
        stadiumNameTextBox.Margin = new Padding(3, 2, 3, 2);
        stadiumNameTextBox.Name = "stadiumNameTextBox";
        stadiumNameTextBox.Size = new Size(110, 23);
        stadiumNameTextBox.TabIndex = 17;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(12, 94);
        label12.Name = "label12";
        label12.Size = new Size(42, 16);
        label12.TabIndex = 16;
        label12.Text = "Город";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(12, 26);
        label11.Name = "label11";
        label11.Size = new Size(122, 16);
        label11.TabIndex = 15;
        label11.Text = "Название стадиона";
        // 
        // tableStadiums
        // 
        tableStadiums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableStadiums.Location = new Point(436, 4);
        tableStadiums.Margin = new Padding(3, 2, 3, 2);
        tableStadiums.Name = "tableStadiums";
        tableStadiums.RowHeadersWidth = 51;
        tableStadiums.RowTemplate.Height = 29;
        tableStadiums.Size = new Size(528, 404);
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
        tabPage5.Location = new Point(4, 25);
        tabPage5.Margin = new Padding(3, 2, 3, 2);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3, 2, 3, 2);
        tabPage5.Size = new Size(987, 412);
        tabPage5.TabIndex = 4;
        tabPage5.Text = "Спонсоры";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(168, 250);
        label21.Name = "label21";
        label21.Size = new Size(53, 16);
        label21.TabIndex = 33;
        label21.Text = "Фильтр";
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Location = new Point(5, 293);
        label22.Name = "label22";
        label22.Size = new Size(92, 16);
        label22.TabIndex = 32;
        label22.Text = "Строка поиска";
        // 
        // sponsorSearchTextBox
        // 
        sponsorSearchTextBox.Location = new Point(122, 291);
        sponsorSearchTextBox.Margin = new Padding(3, 2, 3, 2);
        sponsorSearchTextBox.Name = "sponsorSearchTextBox";
        sponsorSearchTextBox.Size = new Size(273, 23);
        sponsorSearchTextBox.TabIndex = 31;
        // 
        // buttonGettingSponsors
        // 
        buttonGettingSponsors.Location = new Point(312, 328);
        buttonGettingSponsors.Margin = new Padding(3, 2, 3, 2);
        buttonGettingSponsors.Name = "buttonGettingSponsors";
        buttonGettingSponsors.Size = new Size(82, 22);
        buttonGettingSponsors.TabIndex = 29;
        buttonGettingSponsors.Text = "Получить";
        buttonGettingSponsors.UseVisualStyleBackColor = true;
        buttonGettingSponsors.Click += buttonGettingSponsors_Click;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(5, 60);
        label20.Name = "label20";
        label20.Size = new Size(64, 16);
        label20.TabIndex = 28;
        label20.Text = "Описание";
        // 
        // descriptionNameTextBox
        // 
        descriptionNameTextBox.Location = new Point(94, 60);
        descriptionNameTextBox.Margin = new Padding(3, 2, 3, 2);
        descriptionNameTextBox.Name = "descriptionNameTextBox";
        descriptionNameTextBox.Size = new Size(202, 23);
        descriptionNameTextBox.TabIndex = 27;
        // 
        // sposorAddButton
        // 
        sposorAddButton.Location = new Point(330, 24);
        sposorAddButton.Margin = new Padding(3, 2, 3, 2);
        sposorAddButton.Name = "sposorAddButton";
        sposorAddButton.Size = new Size(82, 22);
        sposorAddButton.TabIndex = 25;
        sposorAddButton.Text = "Добавить";
        sposorAddButton.UseVisualStyleBackColor = true;
        sposorAddButton.Click += sponsorAddButton_Click;
        // 
        // button14
        // 
        button14.Location = new Point(330, 60);
        button14.Margin = new Padding(3, 2, 3, 2);
        button14.Name = "button14";
        button14.Size = new Size(82, 22);
        button14.TabIndex = 26;
        button14.Text = "Обновить";
        button14.UseVisualStyleBackColor = true;
        // 
        // DeleteSponsors_Button
        // 
        DeleteSponsors_Button.Location = new Point(330, 96);
        DeleteSponsors_Button.Margin = new Padding(3, 2, 3, 2);
        DeleteSponsors_Button.Name = "DeleteSponsors_Button";
        DeleteSponsors_Button.Size = new Size(82, 22);
        DeleteSponsors_Button.TabIndex = 24;
        DeleteSponsors_Button.Text = "Удалить";
        DeleteSponsors_Button.UseVisualStyleBackColor = true;
        DeleteSponsors_Button.Click += DeleteSponsors_Button_Click;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(5, 26);
        label13.Name = "label13";
        label13.Size = new Size(152, 16);
        label13.TabIndex = 20;
        label13.Text = "Наименование спонсора";
        // 
        // sponsorNameTextBox
        // 
        sponsorNameTextBox.Location = new Point(186, 26);
        sponsorNameTextBox.Margin = new Padding(3, 2, 3, 2);
        sponsorNameTextBox.Name = "sponsorNameTextBox";
        sponsorNameTextBox.Size = new Size(110, 23);
        sponsorNameTextBox.TabIndex = 18;
        // 
        // tableSponsors
        // 
        tableSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableSponsors.Location = new Point(427, 4);
        tableSponsors.Margin = new Padding(3, 2, 3, 2);
        tableSponsors.Name = "tableSponsors";
        tableSponsors.RowHeadersWidth = 51;
        tableSponsors.RowTemplate.Height = 29;
        tableSponsors.Size = new Size(528, 412);
        tableSponsors.TabIndex = 3;
        // 
        // tabPage6
        // 
        tabPage6.Controls.Add(button3);
        tabPage6.Controls.Add(tablePlayerCountMatchesDataGridView);
        tabPage6.Location = new Point(4, 25);
        tabPage6.Margin = new Padding(3, 2, 3, 2);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3, 2, 3, 2);
        tabPage6.Size = new Size(987, 412);
        tabPage6.TabIndex = 5;
        tabPage6.Text = "Кол-во матчей у игроков";
        tabPage6.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(22, 16);
        button3.Margin = new Padding(3, 2, 3, 2);
        button3.Name = "button3";
        button3.Size = new Size(362, 175);
        button3.TabIndex = 30;
        button3.Text = "Получить список игроков с кол-воматчей в которых они учавствовали";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // tablePlayerCountMatchesDataGridView
        // 
        tablePlayerCountMatchesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayerCountMatchesDataGridView.Location = new Point(425, 4);
        tablePlayerCountMatchesDataGridView.Margin = new Padding(3, 2, 3, 2);
        tablePlayerCountMatchesDataGridView.Name = "tablePlayerCountMatchesDataGridView";
        tablePlayerCountMatchesDataGridView.RowHeadersWidth = 51;
        tablePlayerCountMatchesDataGridView.RowTemplate.Height = 29;
        tablePlayerCountMatchesDataGridView.Size = new Size(528, 401);
        tablePlayerCountMatchesDataGridView.TabIndex = 4;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { logoutMenuStrip });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(5, 2, 0, 2);
        menuStrip1.Size = new Size(972, 24);
        menuStrip1.TabIndex = 11;
        menuStrip1.Text = "menuStrip1";
        // 
        // logoutMenuStrip
        // 
        logoutMenuStrip.Name = "logoutMenuStrip";
        logoutMenuStrip.Size = new Size(54, 20);
        logoutMenuStrip.Text = "Выход";
        logoutMenuStrip.Click += LogoutMenuStrip_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(972, 457);
        Controls.Add(Tabs);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 2, 3, 2);
        Name = "Form1";
        Text = "Курсач";
        FormClosed += Form1_FormClosed;
        ((System.ComponentModel.ISupportInitialize)tablePlayers).EndInit();
        Tabs.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage1.PerformLayout();
        tabPage2.ResumeLayout(false);
        tabPage2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tableTeams).EndInit();
        tabPage3.ResumeLayout(false);
        tabPage3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tableMatches).EndInit();
        tabPage4.ResumeLayout(false);
        tabPage4.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tableStadiums).EndInit();
        tabPage5.ResumeLayout(false);
        tabPage5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)tableSponsors).EndInit();
        tabPage6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tablePlayerCountMatchesDataGridView).EndInit();
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
    private TextBox teamNameTextBox;
    private DataGridView tableTeams;
    private Label label1;
    private Label label2;
    private Label label7;
    private Label label10;
    private Label label9;
    private Label label8;
    private Button matchAddButton;
    private Button matchUpdateButton;
    private Button matchDeleteButton;
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
    private ComboBox stadiumIDTeamComboBox;
    private ComboBox team2IDMatchComboBox;
    private ComboBox team1IDMatchComboBox;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
    private ComboBox teamIDPlayerComboBox;
    private Label label14;
    private TextBox playerPatronymicTetBox;
    private Label label3;
    private Button playerGettingButton;
    private TextBox playerSearchTextBox;
    private Button teamDeleteButton;
    private Button teamUpdateButton;
    private Button teamAddButton;
    private Label label18;
    private Label label17;
    private ComboBox searchTeamComboBox;
    private Label label15;
    private ComboBox searchRoleComboBox;
    private Label label16;
    private Button teamGettingButton;
    private ComboBox sponsorIDTeamComboBox;
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
    private CheckBox isUseForMatchesCheckBox;
    private TabPage tabPage6;
    private Button button3;
    private DataGridView tablePlayerCountMatchesDataGridView;
    private DataGridView tableMatches;
    private Label label25;
    private TextBox textBox2;
    private Button matchGettingButton;
    private Label label27;
    private Label label26;
    private TextBox resultTeam2TextBox;
    private TextBox resultTeam1TextBox;
    private Label label28;
    private TextBox teamSearchTextBox;
}
