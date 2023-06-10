namespace Kursach;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new Button();
        button2 = new Button();
        button6 = new Button();
        button4 = new Button();
        button5 = new Button();
        menuStrip1 = new MenuStrip();
        logoutMenuStrip = new ToolStripMenuItem();
        button3 = new Button();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        button7 = new Button();
        menuStrip1.SuspendLayout();
        tabControl1.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(303, 167);
        button1.Margin = new Padding(3, 2, 3, 2);
        button1.Name = "button1";
        button1.Size = new Size(180, 110);
        button1.TabIndex = 0;
        button1.Text = "Игроки";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(17, 54);
        button2.Margin = new Padding(3, 2, 3, 2);
        button2.Name = "button2";
        button2.Size = new Size(180, 110);
        button2.TabIndex = 1;
        button2.Text = "Команды";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button6
        // 
        button6.Location = new Point(203, 54);
        button6.Margin = new Padding(3, 2, 3, 2);
        button6.Name = "button6";
        button6.Size = new Size(180, 110);
        button6.TabIndex = 0;
        button6.Text = "Матчи";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button4
        // 
        button4.Location = new Point(389, 54);
        button4.Margin = new Padding(3, 2, 3, 2);
        button4.Name = "button4";
        button4.Size = new Size(177, 110);
        button4.TabIndex = 0;
        button4.Text = "Стадионы";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new Point(117, 167);
        button5.Margin = new Padding(3, 2, 3, 2);
        button5.Name = "button5";
        button5.Size = new Size(180, 110);
        button5.TabIndex = 0;
        button5.Text = "Спонсоры";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { logoutMenuStrip });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(5, 2, 0, 2);
        menuStrip1.Size = new Size(638, 24);
        menuStrip1.TabIndex = 11;
        menuStrip1.Text = "menuStrip1";
        // 
        // logoutMenuStrip
        // 
        logoutMenuStrip.Name = "logoutMenuStrip";
        logoutMenuStrip.Size = new Size(54, 20);
        logoutMenuStrip.Text = "Выход";
        logoutMenuStrip.Click += LogoutMenuStrip_Click;
        // 
        // button3
        // 
        button3.Location = new Point(17, 19);
        button3.Margin = new Padding(3, 2, 3, 2);
        button3.Name = "button3";
        button3.Size = new Size(177, 112);
        button3.TabIndex = 12;
        button3.Text = "Кол-во матчей в которых участвовали игроки";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(12, 27);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(598, 378);
        tabControl1.TabIndex = 13;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button6);
        tabPage1.Controls.Add(button1);
        tabPage1.Controls.Add(button5);
        tabPage1.Controls.Add(button2);
        tabPage1.Controls.Add(button4);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(590, 350);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Таблицы";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(button7);
        tabPage2.Controls.Add(button3);
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(590, 350);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Запросы";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // button7
        // 
        button7.Location = new Point(224, 19);
        button7.Name = "button7";
        button7.Size = new Size(177, 112);
        button7.TabIndex = 13;
        button7.Text = "Вывод команд, где есть запасные игроки";
        button7.UseVisualStyleBackColor = true;
        button7.Click += button7_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(638, 417);
        Controls.Add(tabControl1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 2, 3, 2);
        Name = "Form1";
        Text = "Курсач";
        FormClosed += Form1_FormClosed;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tabControl1.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
    private Button button1;
    private Button button2;
    private Button button4;
    private Button button5;
    private Button button6;
    private Button button3;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Button button7;
}
