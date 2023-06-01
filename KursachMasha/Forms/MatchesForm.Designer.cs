namespace KursachMasha.Forms;

partial class MatchesForm
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
        resultTeam2TextBox = new TextBox();
        resultTeam1TextBox = new TextBox();
        label27 = new Label();
        label26 = new Label();
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
        stadiumСomboBox = new ComboBox();
        team2ComboBox = new ComboBox();
        team1ComboBox = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)tableMatches).BeginInit();
        SuspendLayout();
        // 
        // resultTeam2TextBox
        // 
        resultTeam2TextBox.Location = new Point(176, 282);
        resultTeam2TextBox.Margin = new Padding(3, 4, 3, 4);
        resultTeam2TextBox.Name = "resultTeam2TextBox";
        resultTeam2TextBox.Size = new Size(114, 27);
        resultTeam2TextBox.TabIndex = 61;
        resultTeam2TextBox.KeyPress += TextBox_KeyPress;
        // 
        // resultTeam1TextBox
        // 
        resultTeam1TextBox.Location = new Point(176, 243);
        resultTeam1TextBox.Margin = new Padding(3, 4, 3, 4);
        resultTeam1TextBox.Name = "resultTeam1TextBox";
        resultTeam1TextBox.Size = new Size(114, 27);
        resultTeam1TextBox.TabIndex = 60;
        resultTeam1TextBox.KeyPress += TextBox_KeyPress;
        // 
        // label27
        // 
        label27.AutoSize = true;
        label27.Location = new Point(19, 290);
        label27.Name = "label27";
        label27.Size = new Size(154, 20);
        label27.TabIndex = 59;
        label27.Text = "Результат команды 2";
        // 
        // label26
        // 
        label26.AutoSize = true;
        label26.Location = new Point(19, 247);
        label26.Name = "label26";
        label26.Size = new Size(154, 20);
        label26.TabIndex = 58;
        label26.Text = "Результат команды 1";
        // 
        // matchGettingButton
        // 
        matchGettingButton.Location = new Point(363, 511);
        matchGettingButton.Name = "matchGettingButton";
        matchGettingButton.Size = new Size(94, 29);
        matchGettingButton.TabIndex = 55;
        matchGettingButton.Text = "Получить";
        matchGettingButton.UseVisualStyleBackColor = true;
        matchGettingButton.Click += matchGettingButton_Click;
        // 
        // tableMatches
        // 
        tableMatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableMatches.Location = new Point(463, 12);
        tableMatches.Name = "tableMatches";
        tableMatches.RowHeadersWidth = 51;
        tableMatches.RowTemplate.Height = 29;
        tableMatches.Size = new Size(630, 528);
        tableMatches.TabIndex = 54;
        // 
        // stadiumIDTeamComboBox
        // 
        stadiumIDTeamComboBox.FormattingEnabled = true;
        stadiumIDTeamComboBox.Location = new Point(120, 180);
        stadiumIDTeamComboBox.Name = "stadiumIDTeamComboBox";
        stadiumIDTeamComboBox.Size = new Size(193, 28);
        stadiumIDTeamComboBox.TabIndex = 53;
        stadiumIDTeamComboBox.DropDown += stadiumIDTeamComboBox_DropDown;
        // 
        // team2IDMatchComboBox
        // 
        team2IDMatchComboBox.FormattingEnabled = true;
        team2IDMatchComboBox.Location = new Point(120, 135);
        team2IDMatchComboBox.Name = "team2IDMatchComboBox";
        team2IDMatchComboBox.Size = new Size(193, 28);
        team2IDMatchComboBox.TabIndex = 52;
        team2IDMatchComboBox.DropDown += team2IDMatchComboBox_DropDown;
        // 
        // team1IDMatchComboBox
        // 
        team1IDMatchComboBox.FormattingEnabled = true;
        team1IDMatchComboBox.Location = new Point(120, 91);
        team1IDMatchComboBox.Name = "team1IDMatchComboBox";
        team1IDMatchComboBox.Size = new Size(193, 28);
        team1IDMatchComboBox.TabIndex = 51;
        team1IDMatchComboBox.DropDown += team1IDMatchComboBox_DropDown;
        // 
        // matchAddButton
        // 
        matchAddButton.Location = new Point(351, 91);
        matchAddButton.Name = "matchAddButton";
        matchAddButton.Size = new Size(94, 29);
        matchAddButton.TabIndex = 49;
        matchAddButton.Text = "Добавить";
        matchAddButton.UseVisualStyleBackColor = true;
        matchAddButton.Click += matchAddButton_Click;
        // 
        // matchUpdateButton
        // 
        matchUpdateButton.Location = new Point(351, 135);
        matchUpdateButton.Name = "matchUpdateButton";
        matchUpdateButton.Size = new Size(94, 29);
        matchUpdateButton.TabIndex = 50;
        matchUpdateButton.Text = "Обновить";
        matchUpdateButton.UseVisualStyleBackColor = true;
        matchUpdateButton.Click += matchUpdateButton_Click;
        // 
        // matchDeleteButton
        // 
        matchDeleteButton.Location = new Point(351, 180);
        matchDeleteButton.Name = "matchDeleteButton";
        matchDeleteButton.Size = new Size(94, 29);
        matchDeleteButton.TabIndex = 48;
        matchDeleteButton.Text = "Удалить";
        matchDeleteButton.UseVisualStyleBackColor = true;
        matchDeleteButton.Click += matchDeleteButton_Click;
        // 
        // DateTimePickerMatch
        // 
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.Location = new Point(120, 40);
        DateTimePickerMatch.Name = "DateTimePickerMatch";
        DateTimePickerMatch.Size = new Size(325, 27);
        DateTimePickerMatch.TabIndex = 47;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Location = new Point(19, 180);
        label10.Name = "label10";
        label10.Size = new Size(67, 20);
        label10.TabIndex = 46;
        label10.Text = "Стадион";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(19, 135);
        label9.Name = "label9";
        label9.Size = new Size(83, 20);
        label9.TabIndex = 45;
        label9.Text = "Команда 2";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(19, 91);
        label8.Name = "label8";
        label8.Size = new Size(83, 20);
        label8.TabIndex = 44;
        label8.Text = "Команда 1";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(19, 40);
        label7.Name = "label7";
        label7.Size = new Size(86, 20);
        label7.TabIndex = 43;
        label7.Text = "Дата матча";
        // 
        // stadiumСomboBox
        // 
        stadiumСomboBox.FormattingEnabled = true;
        stadiumСomboBox.Location = new Point(118, 452);
        stadiumСomboBox.Name = "stadiumСomboBox";
        stadiumСomboBox.Size = new Size(327, 28);
        stadiumСomboBox.TabIndex = 67;
        // 
        // team2ComboBox
        // 
        team2ComboBox.FormattingEnabled = true;
        team2ComboBox.Location = new Point(118, 411);
        team2ComboBox.Name = "team2ComboBox";
        team2ComboBox.Size = new Size(327, 28);
        team2ComboBox.TabIndex = 66;
        team2ComboBox.DropDown += team2IDMatchComboBox_DropDown;
        // 
        // team1ComboBox
        // 
        team1ComboBox.FormattingEnabled = true;
        team1ComboBox.Location = new Point(120, 370);
        team1ComboBox.Name = "team1ComboBox";
        team1ComboBox.Size = new Size(325, 28);
        team1ComboBox.TabIndex = 65;
        team1ComboBox.DropDown += team1IDMatchComboBox_DropDown;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 455);
        label1.Name = "label1";
        label1.Size = new Size(67, 20);
        label1.TabIndex = 64;
        label1.Text = "Стадион";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(10, 414);
        label2.Name = "label2";
        label2.Size = new Size(83, 20);
        label2.TabIndex = 63;
        label2.Text = "Команда 2";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(10, 373);
        label3.Name = "label3";
        label3.Size = new Size(83, 20);
        label3.TabIndex = 62;
        label3.Text = "Команда 1";
        // 
        // MatchesForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1106, 552);
        Controls.Add(stadiumСomboBox);
        Controls.Add(team2ComboBox);
        Controls.Add(team1ComboBox);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(resultTeam2TextBox);
        Controls.Add(resultTeam1TextBox);
        Controls.Add(label27);
        Controls.Add(label26);
        Controls.Add(matchGettingButton);
        Controls.Add(tableMatches);
        Controls.Add(stadiumIDTeamComboBox);
        Controls.Add(team2IDMatchComboBox);
        Controls.Add(team1IDMatchComboBox);
        Controls.Add(matchAddButton);
        Controls.Add(matchUpdateButton);
        Controls.Add(matchDeleteButton);
        Controls.Add(DateTimePickerMatch);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Name = "MatchesForm";
        Text = "MatchesForm";
        ((System.ComponentModel.ISupportInitialize)tableMatches).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox resultTeam2TextBox;
    private TextBox resultTeam1TextBox;
    private Label label27;
    private Label label26;
    private Button matchGettingButton;
    private DataGridView tableMatches;
    private ComboBox stadiumIDTeamComboBox;
    private ComboBox team2IDMatchComboBox;
    private ComboBox team1IDMatchComboBox;
    private Button matchAddButton;
    private Button matchUpdateButton;
    private Button matchDeleteButton;
    private DateTimePicker DateTimePickerMatch;
    private Label label10;
    private Label label9;
    private Label label8;
    private Label label7;
    private ComboBox stadiumСomboBox;
    private ComboBox team2ComboBox;
    private ComboBox team1ComboBox;
    private Label label1;
    private Label label2;
    private Label label3;
}