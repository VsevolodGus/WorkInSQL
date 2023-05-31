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
        Tabs = new TabControl();
        tabPage1 = new TabPage();
        button1 = new Button();
        tabPage2 = new TabPage();
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
        button2 = new Button();
        Tabs.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
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
        // Tabs
        // 
        Tabs.Controls.Add(tabPage1);
        Tabs.Controls.Add(tabPage2);
        Tabs.Controls.Add(tabPage3);
        Tabs.Controls.Add(tabPage4);
        Tabs.Controls.Add(tabPage5);
        Tabs.Controls.Add(tabPage6);
        Tabs.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Tabs.Location = new Point(6, 27);
        Tabs.Name = "Tabs";
        Tabs.SelectedIndex = 0;
        Tabs.Size = new Size(1137, 588);
        Tabs.TabIndex = 10;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button1);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1129, 555);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Игроки";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(492, 92);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(button2);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1129, 555);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Комнады";
        tabPage2.UseVisualStyleBackColor = true;
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
        tabPage3.Location = new Point(4, 29);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(1129, 555);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Матчи";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // resultTeam2TextBox
        // 
        resultTeam2TextBox.Location = new Point(170, 275);
        resultTeam2TextBox.Margin = new Padding(3, 4, 3, 4);
        resultTeam2TextBox.Name = "resultTeam2TextBox";
        resultTeam2TextBox.Size = new Size(114, 27);
        resultTeam2TextBox.TabIndex = 42;
        // 
        // resultTeam1TextBox
        // 
        resultTeam1TextBox.Location = new Point(170, 236);
        resultTeam1TextBox.Margin = new Padding(3, 4, 3, 4);
        resultTeam1TextBox.Name = "resultTeam1TextBox";
        resultTeam1TextBox.Size = new Size(114, 27);
        resultTeam1TextBox.TabIndex = 41;
        resultTeam1TextBox.KeyPress += onlyDigits_TextBoxChange;
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(13, 283);
        label27.Name = "label27";
        label27.Size = new Size(161, 20);
        label27.TabIndex = 40;
        label27.Text = "Результат команды 2";
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(13, 240);
        label26.Name = "label26";
        label26.Size = new Size(161, 20);
        label26.TabIndex = 39;
        label26.Text = "Результат команды 1";
        // 
        // label25
        // 
        label25.AutoSize = true;
        label25.Location = new Point(3, 389);
        label25.Name = "label25";
        label25.Size = new Size(113, 20);
        label25.TabIndex = 38;
        label25.Text = "Строка поиска";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(138, 387);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(311, 27);
        textBox2.TabIndex = 37;
        // 
        // matchGettingButton
        // 
        matchGettingButton.Location = new Point(357, 444);
        matchGettingButton.Name = "matchGettingButton";
        matchGettingButton.Size = new Size(94, 29);
        matchGettingButton.TabIndex = 36;
        matchGettingButton.Text = "Получить";
        matchGettingButton.UseVisualStyleBackColor = true;
        matchGettingButton.Click += matchGettingButton_Click;
        // 
        // tableMatches
        // 
        tableMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableMatches.Location = new Point(472, 5);
        tableMatches.Name = "tableMatches";
        tableMatches.RowHeadersWidth = 51;
        tableMatches.RowTemplate.Height = 29;
        tableMatches.Size = new Size(615, 529);
        tableMatches.TabIndex = 24;
        // 
        // stadiumIDTeamComboBox
        // 
        stadiumIDTeamComboBox.FormattingEnabled = true;
        stadiumIDTeamComboBox.Location = new Point(114, 173);
        stadiumIDTeamComboBox.Name = "stadiumIDTeamComboBox";
        stadiumIDTeamComboBox.Size = new Size(193, 28);
        stadiumIDTeamComboBox.TabIndex = 23;
        stadiumIDTeamComboBox.DropDown += stadiumIDTeamComboBox_DropDown;
        // 
        // team2IDMatchComboBox
        // 
        team2IDMatchComboBox.FormattingEnabled = true;
        team2IDMatchComboBox.Location = new Point(114, 128);
        team2IDMatchComboBox.Name = "team2IDMatchComboBox";
        team2IDMatchComboBox.Size = new Size(193, 28);
        team2IDMatchComboBox.TabIndex = 22;
        team2IDMatchComboBox.DropDown += team2IDMatchComboBox_DropDown;
        // 
        // team1IDMatchComboBox
        // 
        team1IDMatchComboBox.FormattingEnabled = true;
        team1IDMatchComboBox.Location = new Point(114, 84);
        team1IDMatchComboBox.Name = "team1IDMatchComboBox";
        team1IDMatchComboBox.Size = new Size(193, 28);
        team1IDMatchComboBox.TabIndex = 21;
        team1IDMatchComboBox.DropDown += team1IDMatchComboBox_DropDown;
        // 
        // matchAddButton
        // 
        matchAddButton.Location = new Point(345, 84);
        matchAddButton.Name = "matchAddButton";
        matchAddButton.Size = new Size(94, 29);
        matchAddButton.TabIndex = 19;
        matchAddButton.Text = "Добавить";
        matchAddButton.UseVisualStyleBackColor = true;
        matchAddButton.Click += matchAddButton_Click;
        // 
        // matchUpdateButton
        // 
        matchUpdateButton.Location = new Point(345, 128);
        matchUpdateButton.Name = "matchUpdateButton";
        matchUpdateButton.Size = new Size(94, 29);
        matchUpdateButton.TabIndex = 20;
        matchUpdateButton.Text = "Обновить";
        matchUpdateButton.UseVisualStyleBackColor = true;
        matchUpdateButton.Click += matchUpdateButton_Click;
        // 
        // matchDeleteButton
        // 
        matchDeleteButton.Location = new Point(345, 173);
        matchDeleteButton.Name = "matchDeleteButton";
        matchDeleteButton.Size = new Size(94, 29);
        matchDeleteButton.TabIndex = 18;
        matchDeleteButton.Text = "Удалить";
        matchDeleteButton.UseVisualStyleBackColor = true;
        matchDeleteButton.Click += matchDeleteButton_Click;
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
        label10.Location = new Point(13, 173);
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
        tabPage4.Location = new Point(4, 29);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(1129, 555);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Стадионы";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // isUseForMatchesCheckBox
        // 
        isUseForMatchesCheckBox.AutoSize = true;
        isUseForMatchesCheckBox.Location = new Point(14, 428);
        isUseForMatchesCheckBox.Name = "isUseForMatchesCheckBox";
        isUseForMatchesCheckBox.Size = new Size(352, 24);
        isUseForMatchesCheckBox.TabIndex = 37;
        isUseForMatchesCheckBox.Text = "Получить матчи на которых проходили матчи";
        isUseForMatchesCheckBox.UseVisualStyleBackColor = true;
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
        stadiumSearchTextBox.Location = new Point(149, 385);
        stadiumSearchTextBox.Name = "stadiumSearchTextBox";
        stadiumSearchTextBox.Size = new Size(311, 27);
        stadiumSearchTextBox.TabIndex = 34;
        // 
        // buttonGettingStadiums
        // 
        buttonGettingStadiums.Location = new Point(365, 479);
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
        stadiumAddButton.Location = new Point(379, 29);
        stadiumAddButton.Name = "stadiumAddButton";
        stadiumAddButton.Size = new Size(94, 29);
        stadiumAddButton.TabIndex = 22;
        stadiumAddButton.Text = "Добавить";
        stadiumAddButton.UseVisualStyleBackColor = true;
        stadiumAddButton.Click += stadiumAddButton_Click;
        // 
        // button11
        // 
        button11.Location = new Point(379, 80);
        button11.Name = "button11";
        button11.Size = new Size(94, 29);
        button11.TabIndex = 23;
        button11.Text = "Обновить";
        button11.UseVisualStyleBackColor = true;
        // 
        // DeleteStadium_Button
        // 
        DeleteStadium_Button.Location = new Point(379, 125);
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
        label11.Location = new Point(14, 35);
        label11.Name = "label11";
        label11.Size = new Size(145, 20);
        label11.TabIndex = 15;
        label11.Text = "Название стадиона";
        // 
        // tableStadiums
        // 
        tableStadiums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableStadiums.Location = new Point(498, 5);
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
        label21.Location = new Point(192, 333);
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
        sponsorSearchTextBox.Location = new Point(139, 388);
        sponsorSearchTextBox.Name = "sponsorSearchTextBox";
        sponsorSearchTextBox.Size = new Size(311, 27);
        sponsorSearchTextBox.TabIndex = 31;
        // 
        // buttonGettingSponsors
        // 
        buttonGettingSponsors.Location = new Point(357, 437);
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
        label13.Location = new Point(6, 35);
        label13.Name = "label13";
        label13.Size = new Size(182, 20);
        label13.TabIndex = 20;
        label13.Text = "Наименование спонсора";
        // 
        // sponsorNameTextBox
        // 
        sponsorNameTextBox.Location = new Point(213, 35);
        sponsorNameTextBox.Name = "sponsorNameTextBox";
        sponsorNameTextBox.Size = new Size(125, 27);
        sponsorNameTextBox.TabIndex = 18;
        // 
        // tableSponsors
        // 
        tableSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableSponsors.Location = new Point(488, 5);
        tableSponsors.Name = "tableSponsors";
        tableSponsors.RowHeadersWidth = 51;
        tableSponsors.RowTemplate.Height = 29;
        tableSponsors.Size = new Size(603, 549);
        tableSponsors.TabIndex = 3;
        // 
        // tabPage6
        // 
        tabPage6.Controls.Add(button3);
        tabPage6.Controls.Add(tablePlayerCountMatchesDataGridView);
        tabPage6.Location = new Point(4, 29);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3);
        tabPage6.Size = new Size(1129, 555);
        tabPage6.TabIndex = 5;
        tabPage6.Text = "Кол-во матчей у игроков";
        tabPage6.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(25, 21);
        button3.Name = "button3";
        button3.Size = new Size(414, 233);
        button3.TabIndex = 30;
        button3.Text = "Получить список игроков с кол-воматчей в которых они учавствовали";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // tablePlayerCountMatchesDataGridView
        // 
        tablePlayerCountMatchesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayerCountMatchesDataGridView.Location = new Point(486, 5);
        tablePlayerCountMatchesDataGridView.Name = "tablePlayerCountMatchesDataGridView";
        tablePlayerCountMatchesDataGridView.RowHeadersWidth = 51;
        tablePlayerCountMatchesDataGridView.RowTemplate.Height = 29;
        tablePlayerCountMatchesDataGridView.Size = new Size(603, 535);
        tablePlayerCountMatchesDataGridView.TabIndex = 4;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { logoutMenuStrip });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(6, 3, 0, 3);
        menuStrip1.Size = new Size(1111, 30);
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
        // button2
        // 
        button2.Location = new Point(439, 184);
        button2.Name = "button2";
        button2.Size = new Size(98, 48);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
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
        Tabs.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
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
    private TabControl Tabs;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
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
    private ComboBox stadiumIDTeamComboBox;
    private ComboBox team2IDMatchComboBox;
    private ComboBox team1IDMatchComboBox;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
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
    private Button button1;
    private Button button2;
}
