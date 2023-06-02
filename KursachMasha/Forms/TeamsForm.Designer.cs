namespace KursachMasha;

partial class TeamsForm
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
        filterSponsorComboBox = new ComboBox();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)tableTeams).BeginInit();
        SuspendLayout();
        // 
        // label28
        // 
        label28.AutoSize = true;
        label28.Location = new Point(15, 361);
        label28.Name = "label28";
        label28.Size = new Size(110, 20);
        label28.TabIndex = 48;
        label28.Text = "Строка поиска";
        // 
        // teamSearchTextBox
        // 
        teamSearchTextBox.Location = new Point(127, 358);
        teamSearchTextBox.Name = "teamSearchTextBox";
        teamSearchTextBox.Size = new Size(298, 27);
        teamSearchTextBox.TabIndex = 47;
        // 
        // teamGettingButton
        // 
        teamGettingButton.Location = new Point(331, 439);
        teamGettingButton.Name = "teamGettingButton";
        teamGettingButton.Size = new Size(94, 29);
        teamGettingButton.TabIndex = 46;
        teamGettingButton.Text = "Получить";
        teamGettingButton.UseVisualStyleBackColor = true;
        // 
        // sponsorIDTeamComboBox
        // 
        sponsorIDTeamComboBox.FormattingEnabled = true;
        sponsorIDTeamComboBox.Location = new Point(127, 58);
        sponsorIDTeamComboBox.Name = "sponsorIDTeamComboBox";
        sponsorIDTeamComboBox.Size = new Size(298, 28);
        sponsorIDTeamComboBox.TabIndex = 45;
        sponsorIDTeamComboBox.DropDown += sponsorIDTeamComboBox_DropDown;
        // 
        // teamDeleteButton
        // 
        teamDeleteButton.Location = new Point(331, 92);
        teamDeleteButton.Name = "teamDeleteButton";
        teamDeleteButton.Size = new Size(94, 29);
        teamDeleteButton.TabIndex = 44;
        teamDeleteButton.Text = "Удалить";
        teamDeleteButton.UseVisualStyleBackColor = true;
        teamDeleteButton.Click += teamDeleteButton_Click;
        // 
        // teamUpdateButton
        // 
        teamUpdateButton.Location = new Point(231, 92);
        teamUpdateButton.Name = "teamUpdateButton";
        teamUpdateButton.Size = new Size(94, 29);
        teamUpdateButton.TabIndex = 43;
        teamUpdateButton.Text = "Обновить";
        teamUpdateButton.UseVisualStyleBackColor = true;
        teamUpdateButton.Click += teamUpdateButton_Click;
        // 
        // teamAddButton
        // 
        teamAddButton.Location = new Point(131, 92);
        teamAddButton.Name = "teamAddButton";
        teamAddButton.Size = new Size(94, 29);
        teamAddButton.TabIndex = 42;
        teamAddButton.Text = "Добавить";
        teamAddButton.UseVisualStyleBackColor = true;
        teamAddButton.Click += teamAddButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(15, 24);
        label1.Name = "label1";
        label1.Size = new Size(77, 20);
        label1.TabIndex = 40;
        label1.Text = "Название";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(15, 60);
        label2.Name = "label2";
        label2.Size = new Size(70, 20);
        label2.TabIndex = 41;
        label2.Text = "Спонсор";
        // 
        // teamNameTextBox
        // 
        teamNameTextBox.Location = new Point(127, 24);
        teamNameTextBox.Name = "teamNameTextBox";
        teamNameTextBox.Size = new Size(298, 27);
        teamNameTextBox.TabIndex = 39;
        // 
        // tableTeams
        // 
        tableTeams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableTeams.Location = new Point(431, 11);
        tableTeams.Name = "tableTeams";
        tableTeams.RowHeadersWidth = 51;
        tableTeams.RowTemplate.Height = 29;
        tableTeams.Size = new Size(658, 457);
        tableTeams.TabIndex = 38;
        tableTeams.RowStateChanged += tableTeams_RowStateChanged;
        // 
        // filterSponsorComboBox
        // 
        filterSponsorComboBox.FormattingEnabled = true;
        filterSponsorComboBox.Location = new Point(127, 391);
        filterSponsorComboBox.Name = "filterSponsorComboBox";
        filterSponsorComboBox.Size = new Size(298, 28);
        filterSponsorComboBox.TabIndex = 50;
        filterSponsorComboBox.DropDown += sponsorIDTeamComboBox_DropDown;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(15, 391);
        label3.Name = "label3";
        label3.Size = new Size(70, 20);
        label3.TabIndex = 49;
        label3.Text = "Спонсор";
        // 
        // TeamsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1098, 480);
        Controls.Add(filterSponsorComboBox);
        Controls.Add(label3);
        Controls.Add(label28);
        Controls.Add(teamSearchTextBox);
        Controls.Add(teamGettingButton);
        Controls.Add(sponsorIDTeamComboBox);
        Controls.Add(teamDeleteButton);
        Controls.Add(teamUpdateButton);
        Controls.Add(teamAddButton);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(teamNameTextBox);
        Controls.Add(tableTeams);
        Name = "TeamsForm";
        Text = "TeamsForm";
        ((System.ComponentModel.ISupportInitialize)tableTeams).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label28;
    private TextBox teamSearchTextBox;
    private Button teamGettingButton;
    private ComboBox sponsorIDTeamComboBox;
    private Button teamDeleteButton;
    private Button teamUpdateButton;
    private Button teamAddButton;
    private Label label1;
    private Label label2;
    private TextBox teamNameTextBox;
    private DataGridView tableTeams;
    private ComboBox filterSponsorComboBox;
    private Label label3;
}