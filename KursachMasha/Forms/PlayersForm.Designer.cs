namespace KursachMasha;

partial class PlayersForm
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
        tablePlayers = new DataGridView();
        playerDeleteButton = new Button();
        ((System.ComponentModel.ISupportInitialize)tablePlayers).BeginInit();
        SuspendLayout();
        // 
        // playerNumberTetBox
        // 
        playerNumberTetBox.Location = new Point(91, 130);
        playerNumberTetBox.Name = "playerNumberTetBox";
        playerNumberTetBox.Size = new Size(305, 27);
        playerNumberTetBox.TabIndex = 56;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new Point(12, 135);
        label19.Name = "label19";
        label19.Size = new Size(57, 20);
        label19.TabIndex = 55;
        label19.Text = "Номер";
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new Point(133, 296);
        label18.Name = "label18";
        label18.Size = new Size(60, 20);
        label18.TabIndex = 54;
        label18.Text = "Фильтр";
        // 
        // label17
        // 
        label17.AutoSize = true;
        label17.Location = new Point(14, 342);
        label17.Name = "label17";
        label17.Size = new Size(110, 20);
        label17.TabIndex = 53;
        label17.Text = "Строка поиска";
        // 
        // searchTeamComboBox
        // 
        searchTeamComboBox.FormattingEnabled = true;
        searchTeamComboBox.Location = new Point(91, 402);
        searchTeamComboBox.Name = "searchTeamComboBox";
        searchTeamComboBox.Size = new Size(305, 28);
        searchTeamComboBox.TabIndex = 52;
        searchTeamComboBox.DropDown += searchTeamComboBox_DropDown;
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new Point(14, 410);
        label15.Name = "label15";
        label15.Size = new Size(71, 20);
        label15.TabIndex = 51;
        label15.Text = "Команда";
        // 
        // searchRoleComboBox
        // 
        searchRoleComboBox.FormattingEnabled = true;
        searchRoleComboBox.Location = new Point(91, 368);
        searchRoleComboBox.Name = "searchRoleComboBox";
        searchRoleComboBox.Size = new Size(305, 28);
        searchRoleComboBox.TabIndex = 50;
        searchRoleComboBox.DropDown += searchRoleComboBox_DropDown;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Location = new Point(14, 376);
        label16.Name = "label16";
        label16.Size = new Size(42, 20);
        label16.TabIndex = 49;
        label16.Text = "Роль";
        // 
        // teamIDPlayerComboBox
        // 
        teamIDPlayerComboBox.FormattingEnabled = true;
        teamIDPlayerComboBox.Location = new Point(91, 196);
        teamIDPlayerComboBox.Name = "teamIDPlayerComboBox";
        teamIDPlayerComboBox.Size = new Size(305, 28);
        teamIDPlayerComboBox.TabIndex = 48;
        teamIDPlayerComboBox.DropDown += searchTeamComboBox_DropDown;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new Point(14, 200);
        label14.Name = "label14";
        label14.Size = new Size(71, 20);
        label14.TabIndex = 47;
        label14.Text = "Команда";
        // 
        // playerPatronymicTetBox
        // 
        playerPatronymicTetBox.Location = new Point(91, 96);
        playerPatronymicTetBox.Name = "playerPatronymicTetBox";
        playerPatronymicTetBox.Size = new Size(305, 27);
        playerPatronymicTetBox.TabIndex = 46;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 103);
        label3.Name = "label3";
        label3.Size = new Size(72, 20);
        label3.TabIndex = 45;
        label3.Text = "Отчество";
        // 
        // playerGettingButton
        // 
        playerGettingButton.Location = new Point(302, 456);
        playerGettingButton.Name = "playerGettingButton";
        playerGettingButton.Size = new Size(94, 29);
        playerGettingButton.TabIndex = 44;
        playerGettingButton.Text = "Получить";
        playerGettingButton.UseVisualStyleBackColor = true;
        // 
        // playerSearchTextBox
        // 
        playerSearchTextBox.Location = new Point(133, 335);
        playerSearchTextBox.Name = "playerSearchTextBox";
        playerSearchTextBox.Size = new Size(263, 27);
        playerSearchTextBox.TabIndex = 43;
        // 
        // roleIDPlayerComboBox
        // 
        roleIDPlayerComboBox.FormattingEnabled = true;
        roleIDPlayerComboBox.Location = new Point(91, 163);
        roleIDPlayerComboBox.Name = "roleIDPlayerComboBox";
        roleIDPlayerComboBox.Size = new Size(305, 28);
        roleIDPlayerComboBox.TabIndex = 42;
        roleIDPlayerComboBox.DropDown += searchRoleComboBox_DropDown;
        // 
        // playerAddButton
        // 
        playerAddButton.Location = new Point(101, 240);
        playerAddButton.Name = "playerAddButton";
        playerAddButton.Size = new Size(94, 29);
        playerAddButton.TabIndex = 35;
        playerAddButton.Text = "Добавить";
        playerAddButton.UseVisualStyleBackColor = true;
        playerAddButton.Click += addPlayerButton_Click;
        // 
        // playerUpdateButton
        // 
        playerUpdateButton.Location = new Point(203, 240);
        playerUpdateButton.Name = "playerUpdateButton";
        playerUpdateButton.Size = new Size(94, 29);
        playerUpdateButton.TabIndex = 36;
        playerUpdateButton.Text = "Обновить";
        playerUpdateButton.UseVisualStyleBackColor = true;
        playerUpdateButton.Click += updatePlayerButton_Click;
        // 
        // playerSurnameTextBox
        // 
        playerSurnameTextBox.Location = new Point(91, 63);
        playerSurnameTextBox.Name = "playerSurnameTextBox";
        playerSurnameTextBox.Size = new Size(305, 27);
        playerSurnameTextBox.TabIndex = 41;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 34);
        label4.Name = "label4";
        label4.Size = new Size(39, 20);
        label4.TabIndex = 37;
        label4.Text = "Имя";
        // 
        // playerNameTextBox
        // 
        playerNameTextBox.Location = new Point(91, 30);
        playerNameTextBox.Name = "playerNameTextBox";
        playerNameTextBox.Size = new Size(305, 27);
        playerNameTextBox.TabIndex = 40;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(12, 70);
        label5.Name = "label5";
        label5.Size = new Size(73, 20);
        label5.TabIndex = 38;
        label5.Text = "Фамилия";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(14, 166);
        label6.Name = "label6";
        label6.Size = new Size(42, 20);
        label6.TabIndex = 39;
        label6.Text = "Роль";
        // 
        // tablePlayers
        // 
        tablePlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayers.Location = new Point(416, 12);
        tablePlayers.Name = "tablePlayers";
        tablePlayers.RowHeadersWidth = 51;
        tablePlayers.RowTemplate.Height = 29;
        tablePlayers.Size = new Size(687, 539);
        tablePlayers.TabIndex = 34;
        // 
        // playerDeleteButton
        // 
        playerDeleteButton.Location = new Point(302, 240);
        playerDeleteButton.Name = "playerDeleteButton";
        playerDeleteButton.Size = new Size(94, 29);
        playerDeleteButton.TabIndex = 33;
        playerDeleteButton.Text = "Удалить";
        playerDeleteButton.UseVisualStyleBackColor = true;
        playerDeleteButton.Click += DeletePlayers_Click;
        // 
        // PlayersForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1115, 563);
        Controls.Add(playerNumberTetBox);
        Controls.Add(label19);
        Controls.Add(label18);
        Controls.Add(label17);
        Controls.Add(searchTeamComboBox);
        Controls.Add(label15);
        Controls.Add(searchRoleComboBox);
        Controls.Add(label16);
        Controls.Add(teamIDPlayerComboBox);
        Controls.Add(label14);
        Controls.Add(playerPatronymicTetBox);
        Controls.Add(label3);
        Controls.Add(playerGettingButton);
        Controls.Add(playerSearchTextBox);
        Controls.Add(roleIDPlayerComboBox);
        Controls.Add(playerAddButton);
        Controls.Add(playerUpdateButton);
        Controls.Add(playerSurnameTextBox);
        Controls.Add(label4);
        Controls.Add(playerNameTextBox);
        Controls.Add(label5);
        Controls.Add(label6);
        Controls.Add(tablePlayers);
        Controls.Add(playerDeleteButton);
        Name = "PlayersForm";
        Text = "PlayersForm";
        FormClosed += PlayersForm_FormClosed;
        ((System.ComponentModel.ISupportInitialize)tablePlayers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox playerNumberTetBox;
    private Label label19;
    private Label label18;
    private Label label17;
    private ComboBox searchTeamComboBox;
    private Label label15;
    private ComboBox searchRoleComboBox;
    private Label label16;
    private ComboBox teamIDPlayerComboBox;
    private Label label14;
    private TextBox playerPatronymicTetBox;
    private Label label3;
    private Button playerGettingButton;
    private TextBox playerSearchTextBox;
    private ComboBox roleIDPlayerComboBox;
    private Button playerAddButton;
    private Button playerUpdateButton;
    private TextBox playerSurnameTextBox;
    private Label label4;
    private TextBox playerNameTextBox;
    private Label label5;
    private Label label6;
    private DataGridView tablePlayers;
    private Button playerDeleteButton;
}