namespace Kursach
{
    partial class TeamsEditForm
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
            sponsorIDTeamComboBox = new ComboBox();
            teamNameTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 112);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 151);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Спонсор";
            // 
            // sponsorIDTeamComboBox
            // 
            sponsorIDTeamComboBox.FormattingEnabled = true;
            sponsorIDTeamComboBox.Location = new Point(130, 140);
            sponsorIDTeamComboBox.Margin = new Padding(3, 4, 3, 4);
            sponsorIDTeamComboBox.Name = "sponsorIDTeamComboBox";
            sponsorIDTeamComboBox.Size = new Size(229, 28);
            sponsorIDTeamComboBox.TabIndex = 2;
            sponsorIDTeamComboBox.DropDown += sponsorIDTeamComboBox_DropDown;
            // 
            // teamNameTextBox
            // 
            teamNameTextBox.Location = new Point(130, 101);
            teamNameTextBox.Margin = new Padding(3, 4, 3, 4);
            teamNameTextBox.Name = "teamNameTextBox";
            teamNameTextBox.Size = new Size(229, 27);
            teamNameTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(46, 212);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(314, 63);
            button1.TabIndex = 4;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 49);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 6;
            label3.Text = "Команда";
            // 
            // TeamsEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 480);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(teamNameTextBox);
            Controls.Add(sponsorIDTeamComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TeamsEditForm";
            Text = "TeamsEditForm";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox sponsorIDTeamComboBox;
        private TextBox teamNameTextBox;
        private Button button1;
        private Label label3;
    }
}