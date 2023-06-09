namespace KursachMasha;

partial class StadiumsForm
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
        isUseForMatchesCheckBox = new CheckBox();
        label24 = new Label();
        stadiumSearchTextBox = new TextBox();
        buttonGettingStadiums = new Button();
        stadiumAddButton = new Button();
        stadiumUpdateButton = new Button();
        stadiumDeleteButton = new Button();
        tableStadiums = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)tableStadiums).BeginInit();
        SuspendLayout();
        // 
        // isUseForMatchesCheckBox
        // 
        isUseForMatchesCheckBox.AutoSize = true;
        isUseForMatchesCheckBox.Location = new Point(26, 435);
        isUseForMatchesCheckBox.Name = "isUseForMatchesCheckBox";
        isUseForMatchesCheckBox.Size = new Size(353, 24);
        isUseForMatchesCheckBox.TabIndex = 51;
        isUseForMatchesCheckBox.Text = "Получить матчи на которых проходили матчи";
        isUseForMatchesCheckBox.UseVisualStyleBackColor = true;
        // 
        // label24
        // 
        label24.AutoSize = true;
        label24.Location = new Point(26, 395);
        label24.Name = "label24";
        label24.Size = new Size(110, 20);
        label24.TabIndex = 49;
        label24.Text = "Строка поиска";
        // 
        // stadiumSearchTextBox
        // 
        stadiumSearchTextBox.Location = new Point(161, 392);
        stadiumSearchTextBox.Name = "stadiumSearchTextBox";
        stadiumSearchTextBox.Size = new Size(311, 27);
        stadiumSearchTextBox.TabIndex = 48;
        // 
        // buttonGettingStadiums
        // 
        buttonGettingStadiums.Location = new Point(391, 510);
        buttonGettingStadiums.Name = "buttonGettingStadiums";
        buttonGettingStadiums.Size = new Size(94, 29);
        buttonGettingStadiums.TabIndex = 47;
        buttonGettingStadiums.Text = "Получить";
        buttonGettingStadiums.UseVisualStyleBackColor = true;
        buttonGettingStadiums.Click += buttonGettingStadiums_Click;
        // 
        // stadiumAddButton
        // 
        stadiumAddButton.Location = new Point(12, 12);
        stadiumAddButton.Name = "stadiumAddButton";
        stadiumAddButton.Size = new Size(150, 157);
        stadiumAddButton.TabIndex = 43;
        stadiumAddButton.Text = "Добавить";
        stadiumAddButton.UseVisualStyleBackColor = true;
        stadiumAddButton.Click += stadiumAddButton_Click;
        // 
        // stadiumUpdateButton
        // 
        stadiumUpdateButton.Location = new Point(183, 12);
        stadiumUpdateButton.Name = "stadiumUpdateButton";
        stadiumUpdateButton.Size = new Size(146, 157);
        stadiumUpdateButton.TabIndex = 44;
        stadiumUpdateButton.Text = "Обновить";
        stadiumUpdateButton.UseVisualStyleBackColor = true;
        stadiumUpdateButton.Click += stadiumUpdateButton_Click;
        // 
        // stadiumDeleteButton
        // 
        stadiumDeleteButton.Location = new Point(347, 12);
        stadiumDeleteButton.Name = "stadiumDeleteButton";
        stadiumDeleteButton.Size = new Size(138, 157);
        stadiumDeleteButton.TabIndex = 42;
        stadiumDeleteButton.Text = "Удалить";
        stadiumDeleteButton.UseVisualStyleBackColor = true;
        stadiumDeleteButton.Click += DeleteStadium_Button_Click;
        // 
        // tableStadiums
        // 
        tableStadiums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableStadiums.Location = new Point(510, 12);
        tableStadiums.Name = "tableStadiums";
        tableStadiums.RowHeadersWidth = 51;
        tableStadiums.RowTemplate.Height = 29;
        tableStadiums.Size = new Size(603, 539);
        tableStadiums.TabIndex = 38;
        // 
        // StadiumsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1122, 560);
        Controls.Add(isUseForMatchesCheckBox);
        Controls.Add(label24);
        Controls.Add(stadiumSearchTextBox);
        Controls.Add(buttonGettingStadiums);
        Controls.Add(stadiumAddButton);
        Controls.Add(stadiumUpdateButton);
        Controls.Add(stadiumDeleteButton);
        Controls.Add(tableStadiums);
        Name = "StadiumsForm";
        Text = "StadiumsForm";
        ((System.ComponentModel.ISupportInitialize)tableStadiums).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox isUseForMatchesCheckBox;
    private Label label24;
    private TextBox stadiumSearchTextBox;
    private Button buttonGettingStadiums;
    private Button stadiumAddButton;
    private Button stadiumUpdateButton;
    private Button stadiumDeleteButton;
    private DataGridView tableStadiums;
}