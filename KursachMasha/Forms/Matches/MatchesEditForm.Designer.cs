namespace Kursach;

partial class MatchesEditForm
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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        resultTeam1TextBox = new TextBox();
        resultTeam2TextBox = new TextBox();
        team1IDMatchComboBox = new ComboBox();
        team2IDMatchComboBox = new ComboBox();
        stadiumIDComboBox = new ComboBox();
        DateTimePickerMatch = new DateTimePicker();
        button1 = new Button();
        label8 = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(71, 98);
        label1.Name = "label1";
        label1.Size = new Size(86, 20);
        label1.TabIndex = 0;
        label1.Text = "Дата матча";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(71, 136);
        label2.Name = "label2";
        label2.Size = new Size(83, 20);
        label2.TabIndex = 1;
        label2.Text = "Команда 1";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(71, 181);
        label3.Name = "label3";
        label3.Size = new Size(83, 20);
        label3.TabIndex = 2;
        label3.Text = "Команда 2";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(71, 217);
        label4.Name = "label4";
        label4.Size = new Size(67, 20);
        label4.TabIndex = 3;
        label4.Text = "Стадион";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(71, 257);
        label5.Name = "label5";
        label5.Size = new Size(154, 20);
        label5.TabIndex = 4;
        label5.Text = "Результат команды 1";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(71, 299);
        label6.Name = "label6";
        label6.Size = new Size(154, 20);
        label6.TabIndex = 5;
        label6.Text = "Результат команды 2";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(54, 329);
        label7.Name = "label7";
        label7.Size = new Size(0, 20);
        label7.TabIndex = 6;
        // 
        // resultTeam1TextBox
        // 
        resultTeam1TextBox.Location = new Point(251, 250);
        resultTeam1TextBox.Name = "resultTeam1TextBox";
        resultTeam1TextBox.Size = new Size(190, 27);
        resultTeam1TextBox.TabIndex = 8;
        resultTeam1TextBox.KeyPress += TextBox_KeyPress;
        // 
        // resultTeam2TextBox
        // 
        resultTeam2TextBox.Location = new Point(251, 292);
        resultTeam2TextBox.Name = "resultTeam2TextBox";
        resultTeam2TextBox.Size = new Size(190, 27);
        resultTeam2TextBox.TabIndex = 9;
        resultTeam2TextBox.KeyPress += TextBox_KeyPress;
        // 
        // team1IDMatchComboBox
        // 
        team1IDMatchComboBox.FormattingEnabled = true;
        team1IDMatchComboBox.Location = new Point(251, 128);
        team1IDMatchComboBox.Name = "team1IDMatchComboBox";
        team1IDMatchComboBox.Size = new Size(190, 28);
        team1IDMatchComboBox.TabIndex = 10;
        team1IDMatchComboBox.DropDown += teamMatchComboBox_DropDown;
        // 
        // team2IDMatchComboBox
        // 
        team2IDMatchComboBox.FormattingEnabled = true;
        team2IDMatchComboBox.Location = new Point(251, 173);
        team2IDMatchComboBox.Name = "team2IDMatchComboBox";
        team2IDMatchComboBox.Size = new Size(190, 28);
        team2IDMatchComboBox.TabIndex = 11;
        team2IDMatchComboBox.DropDown += teamMatchComboBox_DropDown;
        // 
        // stadiumIDComboBox
        // 
        stadiumIDComboBox.FormattingEnabled = true;
        stadiumIDComboBox.Location = new Point(251, 209);
        stadiumIDComboBox.Name = "stadiumIDComboBox";
        stadiumIDComboBox.Size = new Size(190, 28);
        stadiumIDComboBox.TabIndex = 12;
        stadiumIDComboBox.DropDown += stadiumMatchComboBox_DropDown;
        // 
        // DateTimePickerMatch
        // 
        DateTimePickerMatch.Location = new Point(251, 91);
        DateTimePickerMatch.Name = "DateTimePickerMatch";
        DateTimePickerMatch.Size = new Size(190, 27);
        DateTimePickerMatch.TabIndex = 13;
        // 
        // button1
        // 
        button1.AutoEllipsis = true;
        button1.Location = new Point(162, 375);
        button1.Name = "button1";
        button1.Size = new Size(156, 29);
        button1.TabIndex = 14;
        button1.Text = "Сохранить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(219, 40);
        label8.Name = "label8";
        label8.Size = new Size(44, 20);
        label8.TabIndex = 16;
        label8.Text = "Матч";
        // 
        // MatchesEditForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(525, 450);
        Controls.Add(label8);
        Controls.Add(button1);
        Controls.Add(DateTimePickerMatch);
        Controls.Add(stadiumIDComboBox);
        Controls.Add(team2IDMatchComboBox);
        Controls.Add(team1IDMatchComboBox);
        Controls.Add(resultTeam2TextBox);
        Controls.Add(resultTeam1TextBox);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "MatchesEditForm";
        Text = "MatchesEditForm";
        FormClosed += Form1_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private TextBox resultTeam1TextBox;
    private TextBox resultTeam2TextBox;
    private ComboBox team1IDMatchComboBox;
    private ComboBox team2IDMatchComboBox;
    private ComboBox stadiumIDComboBox;
    private DateTimePicker DateTimePickerMatch;
    private Button button1;
    private Label label8;
}