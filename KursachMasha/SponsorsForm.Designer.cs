namespace KursachMasha;

partial class SponsorsForm
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
        label21 = new Label();
        label22 = new Label();
        sponsorSearchTextBox = new TextBox();
        buttonGettingSponsors = new Button();
        label20 = new Label();
        descriptionNameTextBox = new TextBox();
        sposorAddButton = new Button();
        button14 = new Button();
        DeleteSponsors_Button = new Button();
        label13 = new Label();
        sponsorNameTextBox = new TextBox();
        tableSponsors = new DataGridView();
        ((System.ComponentModel.ISupportInitialize)tableSponsors).BeginInit();
        SuspendLayout();
        // 
        // label21
        // 
        label21.AutoSize = true;
        label21.Location = new Point(204, 340);
        label21.Name = "label21";
        label21.Size = new Size(60, 20);
        label21.TabIndex = 45;
        label21.Text = "Фильтр";
        // 
        // label22
        // 
        label22.AutoSize = true;
        label22.Location = new Point(18, 398);
        label22.Name = "label22";
        label22.Size = new Size(110, 20);
        label22.TabIndex = 44;
        label22.Text = "Строка поиска";
        // 
        // sponsorSearchTextBox
        // 
        sponsorSearchTextBox.Location = new Point(151, 395);
        sponsorSearchTextBox.Name = "sponsorSearchTextBox";
        sponsorSearchTextBox.Size = new Size(332, 27);
        sponsorSearchTextBox.TabIndex = 43;
        // 
        // buttonGettingSponsors
        // 
        buttonGettingSponsors.Location = new Point(369, 444);
        buttonGettingSponsors.Name = "buttonGettingSponsors";
        buttonGettingSponsors.Size = new Size(94, 29);
        buttonGettingSponsors.TabIndex = 42;
        buttonGettingSponsors.Text = "Получить";
        buttonGettingSponsors.UseVisualStyleBackColor = true;
        buttonGettingSponsors.Click += buttonGettingSponsors_Click;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Location = new Point(18, 87);
        label20.Name = "label20";
        label20.Size = new Size(79, 20);
        label20.TabIndex = 41;
        label20.Text = "Описание";
        // 
        // descriptionNameTextBox
        // 
        descriptionNameTextBox.Location = new Point(119, 87);
        descriptionNameTextBox.Name = "descriptionNameTextBox";
        descriptionNameTextBox.Size = new Size(264, 27);
        descriptionNameTextBox.TabIndex = 40;
        // 
        // sposorAddButton
        // 
        sposorAddButton.Location = new Point(389, 39);
        sposorAddButton.Name = "sposorAddButton";
        sposorAddButton.Size = new Size(94, 29);
        sposorAddButton.TabIndex = 38;
        sposorAddButton.Text = "Добавить";
        sposorAddButton.UseVisualStyleBackColor = true;
        sposorAddButton.Click += sponsorAddButton_Click;
        // 
        // button14
        // 
        button14.Location = new Point(389, 87);
        button14.Name = "button14";
        button14.Size = new Size(94, 29);
        button14.TabIndex = 39;
        button14.Text = "Обновить";
        button14.UseVisualStyleBackColor = true;
        button14.Click += button14_Click;
        // 
        // DeleteSponsors_Button
        // 
        DeleteSponsors_Button.Location = new Point(389, 135);
        DeleteSponsors_Button.Name = "DeleteSponsors_Button";
        DeleteSponsors_Button.Size = new Size(94, 29);
        DeleteSponsors_Button.TabIndex = 37;
        DeleteSponsors_Button.Text = "Удалить";
        DeleteSponsors_Button.UseVisualStyleBackColor = true;
        DeleteSponsors_Button.Click += DeleteSponsors_Button_Click;
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Location = new Point(18, 42);
        label13.Name = "label13";
        label13.Size = new Size(187, 20);
        label13.TabIndex = 36;
        label13.Text = "Наименование спонсора";
        // 
        // sponsorNameTextBox
        // 
        sponsorNameTextBox.Location = new Point(225, 42);
        sponsorNameTextBox.Name = "sponsorNameTextBox";
        sponsorNameTextBox.Size = new Size(158, 27);
        sponsorNameTextBox.TabIndex = 35;
        // 
        // tableSponsors
        // 
        tableSponsors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tableSponsors.Location = new Point(500, 12);
        tableSponsors.Name = "tableSponsors";
        tableSponsors.RowHeadersWidth = 51;
        tableSponsors.RowTemplate.Height = 29;
        tableSponsors.Size = new Size(603, 549);
        tableSponsors.TabIndex = 34;
        // 
        // SponsorsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1112, 567);
        Controls.Add(label21);
        Controls.Add(label22);
        Controls.Add(sponsorSearchTextBox);
        Controls.Add(buttonGettingSponsors);
        Controls.Add(label20);
        Controls.Add(descriptionNameTextBox);
        Controls.Add(sposorAddButton);
        Controls.Add(button14);
        Controls.Add(DeleteSponsors_Button);
        Controls.Add(label13);
        Controls.Add(sponsorNameTextBox);
        Controls.Add(tableSponsors);
        Name = "SponsorsForm";
        Text = "SponsorsForm";
        ((System.ComponentModel.ISupportInitialize)tableSponsors).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label21;
    private Label label22;
    private TextBox sponsorSearchTextBox;
    private Button buttonGettingSponsors;
    private Label label20;
    private TextBox descriptionNameTextBox;
    private Button sposorAddButton;
    private Button button14;
    private Button DeleteSponsors_Button;
    private Label label13;
    private TextBox sponsorNameTextBox;
    private DataGridView tableSponsors;
}