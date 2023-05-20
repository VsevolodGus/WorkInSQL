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
        button3 = new Button();
        tablePlayers = new DataGridView();
        Tabs = new TabControl();
        tabPage1 = new TabPage();
        label18 = new Label();
        label17 = new Label();
        searchTeamComboBox = new ComboBox();
        label15 = new Label();
        searchRoleComboBox = new ComboBox();
        label16 = new Label();
        SelectTeamPlayerComboBox = new ComboBox();
        label14 = new Label();
        textBox4 = new TextBox();
        label3 = new Label();
        buttonGettingPlayers = new Button();
        playerSearchTextBox = new TextBox();
        propertyPlayerRoleComboBox = new ComboBox();
        button4 = new Button();
        button5 = new Button();
        textBox5 = new TextBox();
        label4 = new Label();
        textBox6 = new TextBox();
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
        button10 = new Button();
        button11 = new Button();
        button12 = new Button();
        textBox11 = new TextBox();
        textBox7 = new TextBox();
        label12 = new Label();
        label11 = new Label();
        dataGridView4 = new DataGridView();
        tabPage5 = new TabPage();
        button13 = new Button();
        button14 = new Button();
        button15 = new Button();
        label13 = new Label();
        textBox12 = new TextBox();
        dataGridView5 = new DataGridView();
        menuStrip1 = new MenuStrip();
        logoutMenuStrip = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)tablePlayers).BeginInit();
        Tabs.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
        tabPage3.SuspendLayout();
        tabPage4.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
        tabPage5.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // button3
        // 
        button3.Location = new Point(296, 204);
        button3.Name = "button3";
        button3.Size = new Size(94, 29);
        button3.TabIndex = 2;
        button3.Text = "Удалить";
        button3.UseVisualStyleBackColor = true;
        button3.Click += DeletePlayers_Click;
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
        tabPage1.Controls.Add(label18);
        tabPage1.Controls.Add(label17);
        tabPage1.Controls.Add(searchTeamComboBox);
        tabPage1.Controls.Add(label15);
        tabPage1.Controls.Add(searchRoleComboBox);
        tabPage1.Controls.Add(label16);
        tabPage1.Controls.Add(SelectTeamPlayerComboBox);
        tabPage1.Controls.Add(label14);
        tabPage1.Controls.Add(textBox4);
        tabPage1.Controls.Add(label3);
        tabPage1.Controls.Add(buttonGettingPlayers);
        tabPage1.Controls.Add(playerSearchTextBox);
        tabPage1.Controls.Add(propertyPlayerRoleComboBox);
        tabPage1.Controls.Add(button4);
        tabPage1.Controls.Add(button5);
        tabPage1.Controls.Add(textBox5);
        tabPage1.Controls.Add(label4);
        tabPage1.Controls.Add(textBox6);
        tabPage1.Controls.Add(label5);
        tabPage1.Controls.Add(label6);
        tabPage1.Controls.Add(tablePlayers);
        tabPage1.Controls.Add(button3);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1129, 555);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Игроки";
        tabPage1.UseVisualStyleBackColor = true;
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
        // SelectTeamPlayerComboBox
        // 
        SelectTeamPlayerComboBox.FormattingEnabled = true;
        SelectTeamPlayerComboBox.Location = new Point(85, 122);
        SelectTeamPlayerComboBox.Name = "SelectTeamPlayerComboBox";
        SelectTeamPlayerComboBox.Size = new Size(305, 28);
        SelectTeamPlayerComboBox.TabIndex = 24;
        SelectTeamPlayerComboBox.DropDown += searchTeamComboBox_DropDown;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(8, 125);
        label14.Name = "label14";
        label14.Size = new Size(72, 20);
        label14.TabIndex = 23;
        label14.Text = "Команда";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(85, 89);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(305, 27);
        textBox4.TabIndex = 22;
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
        // buttonGettingPlayers
        // 
        buttonGettingPlayers.Location = new Point(296, 429);
        buttonGettingPlayers.Name = "buttonGettingPlayers";
        buttonGettingPlayers.Size = new Size(94, 29);
        buttonGettingPlayers.TabIndex = 20;
        buttonGettingPlayers.Text = "Получить";
        buttonGettingPlayers.UseVisualStyleBackColor = true;
        buttonGettingPlayers.Click += ButtonGettingPlayers_Click;
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
        // propertyPlayerRoleComboBox
        // 
        propertyPlayerRoleComboBox.FormattingEnabled = true;
        propertyPlayerRoleComboBox.Location = new Point(85, 156);
        propertyPlayerRoleComboBox.Name = "propertyPlayerRoleComboBox";
        propertyPlayerRoleComboBox.Size = new Size(305, 28);
        propertyPlayerRoleComboBox.TabIndex = 18;
        propertyPlayerRoleComboBox.DropDown += searchRoleComboBox_DropDown;
        // 
        // button4
        // 
        button4.Location = new Point(96, 204);
        button4.Name = "button4";
        button4.Size = new Size(94, 29);
        button4.TabIndex = 10;
        button4.Text = "Добавить";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(196, 204);
        button5.Name = "button5";
        button5.Size = new Size(94, 29);
        button5.TabIndex = 11;
        button5.Text = "Обновить";
        button5.UseVisualStyleBackColor = true;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(85, 56);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(305, 27);
        textBox5.TabIndex = 16;
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
        // textBox6
        // 
        textBox6.Location = new Point(85, 23);
        textBox6.Name = "textBox6";
        textBox6.Size = new Size(305, 27);
        textBox6.TabIndex = 15;
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
        tabPage4.Controls.Add(button10);
        tabPage4.Controls.Add(button11);
        tabPage4.Controls.Add(button12);
        tabPage4.Controls.Add(textBox11);
        tabPage4.Controls.Add(textBox7);
        tabPage4.Controls.Add(label12);
        tabPage4.Controls.Add(label11);
        tabPage4.Controls.Add(dataGridView4);
        tabPage4.ForeColor = Color.Black;
        tabPage4.Location = new Point(4, 29);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(1129, 555);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Стадионы";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // button10
        // 
        button10.Location = new Point(380, 29);
        button10.Name = "button10";
        button10.Size = new Size(94, 29);
        button10.TabIndex = 22;
        button10.Text = "Добавить";
        button10.UseVisualStyleBackColor = true;
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
        // button12
        // 
        button12.Location = new Point(380, 125);
        button12.Name = "button12";
        button12.Size = new Size(94, 29);
        button12.TabIndex = 21;
        button12.Text = "Удалить";
        button12.UseVisualStyleBackColor = true;
        // 
        // textBox11
        // 
        textBox11.Location = new Point(184, 70);
        textBox11.Name = "textBox11";
        textBox11.Size = new Size(125, 27);
        textBox11.TabIndex = 18;
        // 
        // textBox7
        // 
        textBox7.Location = new Point(184, 31);
        textBox7.Name = "textBox7";
        textBox7.Size = new Size(125, 27);
        textBox7.TabIndex = 17;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(14, 70);
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
        // dataGridView4
        // 
        dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView4.Location = new Point(492, 17);
        dataGridView4.Name = "dataGridView4";
        dataGridView4.RowHeadersWidth = 51;
        dataGridView4.RowTemplate.Height = 29;
        dataGridView4.Size = new Size(603, 539);
        dataGridView4.TabIndex = 2;
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(button13);
        tabPage5.Controls.Add(button14);
        tabPage5.Controls.Add(button15);
        tabPage5.Controls.Add(label13);
        tabPage5.Controls.Add(textBox12);
        tabPage5.Controls.Add(dataGridView5);
        tabPage5.Location = new Point(4, 29);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(1129, 555);
        tabPage5.TabIndex = 4;
        tabPage5.Text = "Спонсоры";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // button13
        // 
        button13.Location = new Point(377, 32);
        button13.Name = "button13";
        button13.Size = new Size(94, 29);
        button13.TabIndex = 25;
        button13.Text = "Добавить";
        button13.UseVisualStyleBackColor = true;
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
        // button15
        // 
        button15.Location = new Point(377, 128);
        button15.Name = "button15";
        button15.Size = new Size(94, 29);
        button15.TabIndex = 24;
        button15.Text = "Удалить";
        button15.UseVisualStyleBackColor = true;
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
        // textBox12
        // 
        textBox12.Location = new Point(212, 34);
        textBox12.Name = "textBox12";
        textBox12.Size = new Size(125, 27);
        textBox12.TabIndex = 18;
        // 
        // dataGridView5
        // 
        dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView5.Location = new Point(488, 6);
        dataGridView5.Name = "dataGridView5";
        dataGridView5.RowHeadersWidth = 51;
        dataGridView5.RowTemplate.Height = 29;
        dataGridView5.Size = new Size(603, 550);
        dataGridView5.TabIndex = 3;
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
        ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
        tabPage5.ResumeLayout(false);
        tabPage5.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button button3;
    private DataGridView tablePlayers;
    private TabControl Tabs;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Button button4;
    private Button button5;
    private TextBox textBox5;
    private Label label4;
    private TextBox textBox6;
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
    private Button button10;
    private Button button11;
    private Button button12;
    private TextBox textBox11;
    private TextBox textBox7;
    private Label label12;
    private Label label11;
    private DataGridView dataGridView4;
    private TabPage tabPage5;
    private Label label13;
    private TextBox textBox12;
    private DataGridView dataGridView5;
    private Button button13;
    private Button button14;
    private Button button15;
    private ComboBox propertyPlayerRoleComboBox;
    private ComboBox comboBox4;
    private ComboBox comboBox3;
    private ComboBox comboBox2;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
    private ComboBox SelectTeamPlayerComboBox;
    private Label label14;
    private TextBox textBox4;
    private Label label3;
    private Button buttonGettingPlayers;
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
}
