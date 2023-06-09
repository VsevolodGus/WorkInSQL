namespace KursachMasha
{
    partial class StadiumsEditForm
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
            label3 = new Label();
            stadiumNameTextBox = new TextBox();
            stadiumVolumeTextBox = new TextBox();
            selectLocationComboBox = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 133);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Название стадиона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 183);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 1;
            label2.Text = "Размер стадиона";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 231);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 2;
            label3.Text = "Город";
            // 
            // stadiumNameTextBox
            // 
            stadiumNameTextBox.Location = new Point(226, 123);
            stadiumNameTextBox.Margin = new Padding(3, 4, 3, 4);
            stadiumNameTextBox.Name = "stadiumNameTextBox";
            stadiumNameTextBox.Size = new Size(114, 27);
            stadiumNameTextBox.TabIndex = 3;
            // 
            // stadiumVolumeTextBox
            // 
            stadiumVolumeTextBox.Location = new Point(226, 172);
            stadiumVolumeTextBox.Margin = new Padding(3, 4, 3, 4);
            stadiumVolumeTextBox.Name = "stadiumVolumeTextBox";
            stadiumVolumeTextBox.Size = new Size(114, 27);
            stadiumVolumeTextBox.TabIndex = 4;
            // 
            // selectLocationComboBox
            // 
            selectLocationComboBox.FormattingEnabled = true;
            selectLocationComboBox.Location = new Point(142, 220);
            selectLocationComboBox.Margin = new Padding(3, 4, 3, 4);
            selectLocationComboBox.Name = "selectLocationComboBox";
            selectLocationComboBox.Size = new Size(198, 28);
            selectLocationComboBox.TabIndex = 5;
            selectLocationComboBox.DropDown += selectLocationComboBox_DropDown;
            // 
            // button1
            // 
            button1.Location = new Point(51, 296);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(289, 49);
            button1.TabIndex = 6;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 61);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 8;
            label4.Text = "Стадион";
            // 
            // StadiumsEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 480);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(selectLocationComboBox);
            Controls.Add(stadiumVolumeTextBox);
            Controls.Add(stadiumNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            FormClosed += Form1_FormClosed;
            Name = "StadiumsEditForm";
            Text = "StadiumsEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox stadiumNameTextBox;
        private TextBox stadiumVolumeTextBox;
        private ComboBox selectLocationComboBox;
        private Button button1;
        private Label label4;
    }
}