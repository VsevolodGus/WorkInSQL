namespace Kursach
{
    partial class SponsorsEditForm
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
            sponsorNameTextBox = new TextBox();
            sponsorDescriptionTextBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 124);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 0;
            label1.Text = "Наименование спонсора";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 171);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // sponsorNameTextBox
            // 
            sponsorNameTextBox.Location = new Point(224, 113);
            sponsorNameTextBox.Margin = new Padding(3, 4, 3, 4);
            sponsorNameTextBox.Name = "sponsorNameTextBox";
            sponsorNameTextBox.Size = new Size(158, 27);
            sponsorNameTextBox.TabIndex = 2;
            // 
            // sponsorDescriptionTextBox
            // 
            sponsorDescriptionTextBox.Location = new Point(121, 160);
            sponsorDescriptionTextBox.Margin = new Padding(3, 4, 3, 4);
            sponsorDescriptionTextBox.Multiline = true;
            sponsorDescriptionTextBox.Name = "sponsorDescriptionTextBox";
            sponsorDescriptionTextBox.Size = new Size(261, 95);
            sponsorDescriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 63);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Спонсор";
            // 
            // button1
            // 
            button1.Location = new Point(30, 296);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(353, 55);
            button1.TabIndex = 5;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SponsorsEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 480);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(sponsorDescriptionTextBox);
            Controls.Add(sponsorNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SponsorsEditForm";
            Text = "SponsorsEditForm";
            FormClosed += SponsorsEditForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox sponsorNameTextBox;
        private TextBox sponsorDescriptionTextBox;
        private Label label3;
        private Button button1;
    }
}