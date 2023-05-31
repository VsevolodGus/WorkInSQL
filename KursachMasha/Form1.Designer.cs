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
        button2 = new Button();
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
        button4 = new Button();
        tabPage5 = new TabPage();
        tabPage6 = new TabPage();
        button3 = new Button();
        tablePlayerCountMatchesDataGridView = new DataGridView();
        menuStrip1 = new MenuStrip();
        logoutMenuStrip = new ToolStripMenuItem();
        button5 = new Button();
        Tabs.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        tabPage3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tableMatches).BeginInit();
        tabPage4.SuspendLayout();
        tabPage5.SuspendLayout();
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
        Tabs.Size = new Size(1165, 625);
        Tabs.TabIndex = 10;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button1);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1157, 592);
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
        tabPage2.Size = new Size(1360, 678);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Комнады";
        tabPage2.UseVisualStyleBackColor = true;
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
        tabPage3.Size = new Size(1157, 592);
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
        tabPage4.Controls.Add(button4);
        tabPage4.ForeColor = Color.Black;
        tabPage4.Location = new Point(4, 29);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(1157, 592);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Стадионы";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(333, 152);
        button4.Name = "button4";
        button4.Size = new Size(186, 99);
        button4.TabIndex = 0;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(button5);
        tabPage5.Location = new Point(4, 29);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(1157, 592);
        tabPage5.TabIndex = 4;
        tabPage5.Text = "Спонсоры";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // tabPage6
        // 
        tabPage6.Controls.Add(button3);
        tabPage6.Controls.Add(tablePlayerCountMatchesDataGridView);
        tabPage6.Location = new Point(4, 29);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3);
        tabPage6.Size = new Size(1360, 678);
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
        menuStrip1.Size = new Size(1189, 30);
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
        // button5
        // 
        button5.Location = new Point(468, 148);
        button5.Name = "button5";
        button5.Size = new Size(205, 130);
        button5.TabIndex = 0;
        button5.Text = "button5";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1189, 667);
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
        tabPage5.ResumeLayout(false);
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
    private TabPage tabPage5;
    private ComboBox stadiumIDTeamComboBox;
    private ComboBox team2IDMatchComboBox;
    private ComboBox team1IDMatchComboBox;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
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
    private Button button4;
    private Button button5;
}
