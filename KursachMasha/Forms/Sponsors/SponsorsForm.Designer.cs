﻿namespace KursachMasha;

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
        sponsorDescriptionTextBox = new TextBox();
        sposorAddButton = new Button();
        sposorUpdateButton = new Button();
        sponsorDeleteButton = new Button();
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
        buttonGettingSponsors.Click += ButtonGettingSponsors_Click;
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
        // sponsorDescriptionTextBox
        // 
        sponsorDescriptionTextBox.Location = new Point(119, 87);
        sponsorDescriptionTextBox.Name = "sponsorDescriptionTextBox";
        sponsorDescriptionTextBox.Size = new Size(264, 27);
        sponsorDescriptionTextBox.TabIndex = 40;
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
        // sposorUpdateButton
        // 
        sposorUpdateButton.Location = new Point(389, 87);
        sposorUpdateButton.Name = "sposorUpdateButton";
        sposorUpdateButton.Size = new Size(94, 29);
        sposorUpdateButton.TabIndex = 39;
        sposorUpdateButton.Text = "Обновить";
        sposorUpdateButton.UseVisualStyleBackColor = true;
        sposorUpdateButton.Click += sponsorUpdate_Button;
        // 
        // sponsorDeleteButton
        // 
        sponsorDeleteButton.Location = new Point(389, 135);
        sponsorDeleteButton.Name = "sponsorDeleteButton";
        sponsorDeleteButton.Size = new Size(94, 29);
        sponsorDeleteButton.TabIndex = 37;
        sponsorDeleteButton.Text = "Удалить";
        sponsorDeleteButton.UseVisualStyleBackColor = true;
        sponsorDeleteButton.Click += DeleteSponsors_Button_Click;
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
        Controls.Add(sponsorDescriptionTextBox);
        Controls.Add(sposorAddButton);
        Controls.Add(sposorUpdateButton);
        Controls.Add(sponsorDeleteButton);
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
    private TextBox sponsorDescriptionTextBox;
    private Button sposorAddButton;
    private Button sposorUpdateButton;
    private Button sponsorDeleteButton;
    private Label label13;
    private TextBox sponsorNameTextBox;
    private DataGridView tableSponsors;
}