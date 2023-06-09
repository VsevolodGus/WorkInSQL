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
        label18 = new Label();
        label17 = new Label();
        searchTeamComboBox = new ComboBox();
        label15 = new Label();
        searchRoleComboBox = new ComboBox();
        label16 = new Label();
        playerGettingButton = new Button();
        playerSearchTextBox = new TextBox();
        playerAddButton = new Button();
        playerUpdateButton = new Button();
        tablePlayers = new DataGridView();
        playerDeleteButton = new Button();
        ((System.ComponentModel.ISupportInitialize)tablePlayers).BeginInit();
        SuspendLayout();
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
        // playerGettingButton
        // 
        playerGettingButton.Location = new Point(302, 456);
        playerGettingButton.Name = "playerGettingButton";
        playerGettingButton.Size = new Size(94, 29);
        playerGettingButton.TabIndex = 44;
        playerGettingButton.Text = "Получить";
        playerGettingButton.UseVisualStyleBackColor = true;
        playerGettingButton.Click += playerGettingButton_Click;
        // 
        // playerSearchTextBox
        // 
        playerSearchTextBox.Location = new Point(133, 335);
        playerSearchTextBox.Name = "playerSearchTextBox";
        playerSearchTextBox.Size = new Size(263, 27);
        playerSearchTextBox.TabIndex = 43;
        // 
        // playerAddButton
        // 
        playerAddButton.Location = new Point(12, 12);
        playerAddButton.Name = "playerAddButton";
        playerAddButton.Size = new Size(130, 168);
        playerAddButton.TabIndex = 35;
        playerAddButton.Text = "Добавить";
        playerAddButton.UseVisualStyleBackColor = true;
        playerAddButton.Click += addPlayerButton_Click;
        // 
        // playerUpdateButton
        // 
        playerUpdateButton.Location = new Point(148, 12);
        playerUpdateButton.Name = "playerUpdateButton";
        playerUpdateButton.Size = new Size(132, 168);
        playerUpdateButton.TabIndex = 36;
        playerUpdateButton.Text = "Обновить";
        playerUpdateButton.UseVisualStyleBackColor = true;
        playerUpdateButton.Click += updatePlayerButton_Click;
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
        playerDeleteButton.Location = new Point(286, 12);
        playerDeleteButton.Name = "playerDeleteButton";
        playerDeleteButton.Size = new Size(124, 168);
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
        Controls.Add(label18);
        Controls.Add(label17);
        Controls.Add(searchTeamComboBox);
        Controls.Add(label15);
        Controls.Add(searchRoleComboBox);
        Controls.Add(label16);
        Controls.Add(playerGettingButton);
        Controls.Add(playerSearchTextBox);
        Controls.Add(playerAddButton);
        Controls.Add(playerUpdateButton);
        Controls.Add(tablePlayers);
        Controls.Add(playerDeleteButton);
        Name = "PlayersForm";
        Text = "PlayersForm";
        ((System.ComponentModel.ISupportInitialize)tablePlayers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label18;
    private Label label17;
    private ComboBox searchTeamComboBox;
    private Label label15;
    private ComboBox searchRoleComboBox;
    private Label label16;
    private Button playerGettingButton;
    private TextBox playerSearchTextBox;
    private Button playerAddButton;
    private Button playerUpdateButton;
    private DataGridView tablePlayers;
    private Button playerDeleteButton;
}