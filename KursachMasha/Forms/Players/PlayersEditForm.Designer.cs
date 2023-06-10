namespace Kursach;

partial class PlayersEditForm
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
        playerNameTextBox = new TextBox();
        playerSurnameTextBox = new TextBox();
        playerPatronymicTextBox = new TextBox();
        playerNumberTextBox = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        roleIDPlayerComboBox = new ComboBox();
        teamIDPlayerComboBox = new ComboBox();
        label7 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // playerNameTextBox
        // 
        playerNameTextBox.Location = new Point(230, 97);
        playerNameTextBox.Name = "playerNameTextBox";
        playerNameTextBox.Size = new Size(189, 27);
        playerNameTextBox.TabIndex = 0;
        // 
        // playerSurnameTextBox
        // 
        playerSurnameTextBox.Location = new Point(230, 139);
        playerSurnameTextBox.Name = "playerSurnameTextBox";
        playerSurnameTextBox.Size = new Size(189, 27);
        playerSurnameTextBox.TabIndex = 1;
        // 
        // playerPatronymicTextBox
        // 
        playerPatronymicTextBox.Location = new Point(230, 183);
        playerPatronymicTextBox.Name = "playerPatronymicTextBox";
        playerPatronymicTextBox.Size = new Size(189, 27);
        playerPatronymicTextBox.TabIndex = 2;
        // 
        // playerNumberTextBox
        // 
        playerNumberTextBox.Location = new Point(230, 228);
        playerNumberTextBox.Name = "playerNumberTextBox";
        playerNumberTextBox.Size = new Size(189, 27);
        playerNumberTextBox.TabIndex = 3;
        playerNumberTextBox.KeyPress += playerNumberTextBox_KeyPress;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(113, 104);
        label1.Name = "label1";
        label1.Size = new Size(39, 20);
        label1.TabIndex = 5;
        label1.Text = "Имя";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(110, 146);
        label2.Name = "label2";
        label2.Size = new Size(73, 20);
        label2.TabIndex = 6;
        label2.Text = "Фамилия";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(111, 190);
        label3.Name = "label3";
        label3.Size = new Size(72, 20);
        label3.TabIndex = 7;
        label3.Text = "Отчество";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(112, 235);
        label4.Name = "label4";
        label4.Size = new Size(57, 20);
        label4.TabIndex = 8;
        label4.Text = "Номер";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(112, 277);
        label5.Name = "label5";
        label5.Size = new Size(42, 20);
        label5.TabIndex = 9;
        label5.Text = "Роль";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(113, 316);
        label6.Name = "label6";
        label6.Size = new Size(71, 20);
        label6.TabIndex = 10;
        label6.Text = "Команда";
        // 
        // roleIDPlayerComboBox
        // 
        roleIDPlayerComboBox.FormattingEnabled = true;
        roleIDPlayerComboBox.Location = new Point(230, 269);
        roleIDPlayerComboBox.Name = "roleIDPlayerComboBox";
        roleIDPlayerComboBox.Size = new Size(189, 28);
        roleIDPlayerComboBox.TabIndex = 11;
        roleIDPlayerComboBox.DropDown += searchRoleComboBox_DropDown;
        // 
        // teamIDPlayerComboBox
        // 
        teamIDPlayerComboBox.FormattingEnabled = true;
        teamIDPlayerComboBox.Location = new Point(230, 308);
        teamIDPlayerComboBox.Name = "teamIDPlayerComboBox";
        teamIDPlayerComboBox.Size = new Size(189, 28);
        teamIDPlayerComboBox.TabIndex = 12;
        teamIDPlayerComboBox.DropDown += searchTeamComboBox_DropDown;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(209, 51);
        label7.Name = "label7";
        label7.Size = new Size(51, 20);
        label7.TabIndex = 13;
        label7.Text = "Игрок";
        // 
        // button1
        // 
        button1.Location = new Point(185, 362);
        button1.Name = "button1";
        button1.Size = new Size(127, 29);
        button1.TabIndex = 14;
        button1.Text = "Сохранить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // PlayersEditForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(525, 450);
        Controls.Add(button1);
        Controls.Add(label7);
        Controls.Add(teamIDPlayerComboBox);
        Controls.Add(roleIDPlayerComboBox);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(playerNumberTextBox);
        Controls.Add(playerPatronymicTextBox);
        Controls.Add(playerSurnameTextBox);
        Controls.Add(playerNameTextBox);
        Name = "PlayersEditForm";
        Text = "PlayersEditForm";
        FormClosed += Form1_FormClosed;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox playerNameTextBox;
    private TextBox playerSurnameTextBox;
    private TextBox playerPatronymicTextBox;
    private TextBox playerNumberTextBox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private ComboBox roleIDPlayerComboBox;
    private ComboBox teamIDPlayerComboBox;
    private Label label7;
    private Button button1;
}