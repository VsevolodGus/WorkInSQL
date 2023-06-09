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
        selectLocationComboBox = new ComboBox();
        label24 = new Label();
        stadiumSearchTextBox = new TextBox();
        buttonGettingStadiums = new Button();
        stadiumVolumeTextBox = new TextBox();
        label23 = new Label();
        stadiumAddButton = new Button();
        stadiumUpdateButton = new Button();
        stadiumDeleteButton = new Button();
        stadiumNameTextBox = new TextBox();
        label12 = new Label();
        label11 = new Label();
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
        // selectLocationComboBox
        // 
        selectLocationComboBox.FormattingEnabled = true;
        selectLocationComboBox.Location = new Point(107, 124);
        selectLocationComboBox.Name = "selectLocationComboBox";
        selectLocationComboBox.Size = new Size(272, 28);
        selectLocationComboBox.TabIndex = 50;
        selectLocationComboBox.DropDown += selectLocationComboBox_DropDown;
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
        // stadiumVolumeTextBox
        // 
        stadiumVolumeTextBox.Location = new Point(176, 84);
        stadiumVolumeTextBox.Name = "stadiumVolumeTextBox";
        stadiumVolumeTextBox.Size = new Size(203, 27);
        stadiumVolumeTextBox.TabIndex = 46;
        // 
        // label23
        // 
        label23.AutoSize = true;
        label23.Location = new Point(26, 87);
        label23.Name = "label23";
        label23.Size = new Size(128, 20);
        label23.TabIndex = 45;
        label23.Text = "Размер стадиона";
        // 
        // stadiumAddButton
        // 
        stadiumAddButton.Location = new Point(391, 36);
        stadiumAddButton.Name = "stadiumAddButton";
        stadiumAddButton.Size = new Size(94, 29);
        stadiumAddButton.TabIndex = 43;
        stadiumAddButton.Text = "Добавить";
        stadiumAddButton.UseVisualStyleBackColor = true;
        stadiumAddButton.Click += stadiumAddButton_Click;
        // 
        // stadiumUpdateButton
        // 
        stadiumUpdateButton.Location = new Point(391, 78);
        stadiumUpdateButton.Name = "stadiumUpdateButton";
        stadiumUpdateButton.Size = new Size(94, 29);
        stadiumUpdateButton.TabIndex = 44;
        stadiumUpdateButton.Text = "Обновить";
        stadiumUpdateButton.UseVisualStyleBackColor = true;
        stadiumUpdateButton.Click += stadiumUpdateButton_Click;
        // 
        // stadiumDeleteButton
        // 
        stadiumDeleteButton.Location = new Point(391, 123);
        stadiumDeleteButton.Name = "stadiumDeleteButton";
        stadiumDeleteButton.Size = new Size(94, 29);
        stadiumDeleteButton.TabIndex = 42;
        stadiumDeleteButton.Text = "Удалить";
        stadiumDeleteButton.UseVisualStyleBackColor = true;
        stadiumDeleteButton.Click += DeleteStadium_Button_Click;
        // 
        // stadiumNameTextBox
        // 
        stadiumNameTextBox.Location = new Point(177, 38);
        stadiumNameTextBox.Name = "stadiumNameTextBox";
        stadiumNameTextBox.Size = new Size(202, 27);
        stadiumNameTextBox.TabIndex = 41;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(26, 132);
        label12.Name = "label12";
        label12.Size = new Size(51, 20);
        label12.TabIndex = 40;
        label12.Text = "Город";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(26, 42);
        label11.Name = "label11";
        label11.Size = new Size(145, 20);
        label11.TabIndex = 39;
        label11.Text = "Название стадиона";
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
        tableStadiums.RowStateChanged += tableStadiums_RowStateChanged;
        // 
        // StadiumsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1122, 560);
        Controls.Add(isUseForMatchesCheckBox);
        Controls.Add(selectLocationComboBox);
        Controls.Add(label24);
        Controls.Add(stadiumSearchTextBox);
        Controls.Add(buttonGettingStadiums);
        Controls.Add(stadiumVolumeTextBox);
        Controls.Add(label23);
        Controls.Add(stadiumAddButton);
        Controls.Add(stadiumUpdateButton);
        Controls.Add(stadiumDeleteButton);
        Controls.Add(stadiumNameTextBox);
        Controls.Add(label12);
        Controls.Add(label11);
        Controls.Add(tableStadiums);
        Name = "StadiumsForm";
        Text = "StadiumsForm";
        ((System.ComponentModel.ISupportInitialize)tableStadiums).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox isUseForMatchesCheckBox;
    private ComboBox selectLocationComboBox;
    private Label label24;
    private TextBox stadiumSearchTextBox;
    private Button buttonGettingStadiums;
    private TextBox stadiumVolumeTextBox;
    private Label label23;
    private Button stadiumAddButton;
    private Button stadiumUpdateButton;
    private Button stadiumDeleteButton;
    private TextBox stadiumNameTextBox;
    private Label label12;
    private Label label11;
    private DataGridView tableStadiums;
}