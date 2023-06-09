namespace KursachMasha;

partial class PlayersEditForm
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
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        comboBox1 = new ComboBox();
        comboBox2 = new ComboBox();
        label7 = new Label();
        button1 = new Button();
        button2 = new Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Location = new Point(230, 97);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(189, 27);
        textBox1.TabIndex = 0;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(230, 139);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(189, 27);
        textBox2.TabIndex = 1;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(230, 183);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(189, 27);
        textBox3.TabIndex = 2;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(230, 228);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(189, 27);
        textBox4.TabIndex = 3;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(113, 104);
        label1.Name = "label1";
        label1.Size = new Size(39, 20);
        label1.TabIndex = 5;
        label1.Text = "Имя";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(110, 146);
        label2.Name = "label2";
        label2.Size = new Size(73, 20);
        label2.TabIndex = 6;
        label2.Text = "Фамилия";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(111, 190);
        label3.Name = "label3";
        label3.Size = new Size(72, 20);
        label3.TabIndex = 7;
        label3.Text = "Отчество";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(112, 235);
        label4.Name = "label4";
        label4.Size = new Size(57, 20);
        label4.TabIndex = 8;
        label4.Text = "Номер";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(112, 277);
        label5.Name = "label5";
        label5.Size = new Size(42, 20);
        label5.TabIndex = 9;
        label5.Text = "Роль";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(113, 316);
        label6.Name = "label6";
        label6.Size = new Size(71, 20);
        label6.TabIndex = 10;
        label6.Text = "Команда";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(230, 269);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(189, 28);
        comboBox1.TabIndex = 11;
        // 
        // comboBox2
        // 
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(230, 308);
        comboBox2.Name = "comboBox2";
        comboBox2.Size = new Size(189, 28);
        comboBox2.TabIndex = 12;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(209, 51);
        label7.Name = "label7";
        label7.Size = new Size(51, 20);
        label7.TabIndex = 13;
        label7.Text = "Игрок";
        // 
        // button1
        // 
        button1.Location = new Point(111, 368);
        button1.Name = "button1";
        button1.Size = new Size(127, 29);
        button1.TabIndex = 14;
        button1.Text = "Сохранить";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(294, 368);
        button2.Name = "button2";
        button2.Size = new Size(125, 29);
        button2.TabIndex = 15;
        button2.Text = "Обновить";
        button2.UseVisualStyleBackColor = true;
        // 
        // PlayersEditForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(525, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label7);
        Controls.Add(comboBox2);
        Controls.Add(comboBox1);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textBox4);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Name = "PlayersEditForm";
        Text = "PlayersEditForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private TextBox textBox4;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private ComboBox comboBox1;
    private ComboBox comboBox2;
    private Label label7;
    private Button button1;
    private Button button2;
}