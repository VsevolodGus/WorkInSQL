namespace Kursach.Forms;

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
        matchGettingButton = new Button();
        tableMatches = new DataGridView();
        matchAddButton = new Button();
        matchUpdateButton = new Button();
        matchDeleteButton = new Button();
        stadiumСomboBox = new ComboBox();
        team2ComboBox = new ComboBox();
        team1ComboBox = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        ((System.ComponentModel.ISupportInitialize)tableMatches).BeginInit();
        SuspendLayout();
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
        // matchAddButton
        // 
        matchAddButton.Location = new Point(10, 25);
        matchAddButton.Name = "matchAddButton";
        matchAddButton.Size = new Size(139, 139);
        matchAddButton.TabIndex = 49;
        matchAddButton.Text = "Добавить";
        matchAddButton.UseVisualStyleBackColor = true;
        matchAddButton.Click += matchAddButton_Click;
        // 
        // matchUpdateButton
        // 
        matchUpdateButton.Location = new Point(164, 25);
        matchUpdateButton.Name = "matchUpdateButton";
        matchUpdateButton.Size = new Size(139, 139);
        matchUpdateButton.TabIndex = 50;
        matchUpdateButton.Text = "Обновить";
        matchUpdateButton.UseVisualStyleBackColor = true;
        matchUpdateButton.Click += matchUpdateButton_Click;
        // 
        // matchDeleteButton
        // 
        matchDeleteButton.Location = new Point(318, 25);
        matchDeleteButton.Name = "matchDeleteButton";
        matchDeleteButton.Size = new Size(139, 139);
        matchDeleteButton.TabIndex = 48;
        matchDeleteButton.Text = "Удалить";
        matchDeleteButton.UseVisualStyleBackColor = true;
        matchDeleteButton.Click += matchDeleteButton_Click;
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
        team2ComboBox.DropDown += teamMatchComboBox_DropDown;
        // 
        // team1ComboBox
        // 
        team1ComboBox.FormattingEnabled = true;
        team1ComboBox.Location = new Point(120, 370);
        team1ComboBox.Name = "team1ComboBox";
        team1ComboBox.Size = new Size(325, 28);
        team1ComboBox.TabIndex = 65;
        team1ComboBox.DropDown += teamMatchComboBox_DropDown;
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
        Controls.Add(matchGettingButton);
        Controls.Add(tableMatches);
        Controls.Add(matchAddButton);
        Controls.Add(matchUpdateButton);
        Controls.Add(matchDeleteButton);
        Name = "MatchesForm";
        Text = "MatchesForm";
        ((System.ComponentModel.ISupportInitialize)tableMatches).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button matchGettingButton;
    private DataGridView tableMatches;
    private Button matchAddButton;
    private Button matchUpdateButton;
    private Button matchDeleteButton;
    private ComboBox stadiumСomboBox;
    private ComboBox team2ComboBox;
    private ComboBox team1ComboBox;
    private Label label1;
    private Label label2;
    private Label label3;
}