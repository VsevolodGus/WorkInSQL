namespace KursachMasha;

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
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new Point(224, 185);
        button1.Name = "button1";
        button1.Size = new Size(206, 150);
        button1.TabIndex = 0;
        button1.Text = "Игроки";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new Point(12, 33);
        button2.Name = "button2";
        button2.Size = new Size(206, 146);
        button2.TabIndex = 1;
        button2.Text = "Команды";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button6
        // 
        button6.Location = new Point(224, 33);
        button6.Name = "button6";
        button6.Size = new Size(206, 146);
        button6.TabIndex = 0;
        button6.Text = "Матчи";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // button4
        // 
        button4.Location = new Point(436, 33);
        button4.Name = "button4";
        button4.Size = new Size(202, 146);
        button4.TabIndex = 0;
        button4.Text = "Стадионы";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button5
        // 
        button5.Location = new Point(12, 189);
        button5.Name = "button5";
        button5.Size = new Size(206, 146);
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
        menuStrip1.Padding = new Padding(6, 3, 0, 3);
        menuStrip1.Size = new Size(650, 30);
        menuStrip1.TabIndex = 11;
        menuStrip1.Text = "menuStrip1";
        // 
        // logoutMenuStrip
        // 
        logoutMenuStrip.Name = "logoutMenuStrip";
        logoutMenuStrip.Size = new Size(67, 24);
        logoutMenuStrip.Text = "Выход";
        logoutMenuStrip.Click += LogoutMenuStrip_Click;
        // 
        // button3
        // 
        button3.Location = new Point(436, 185);
        button3.Name = "button3";
        button3.Size = new Size(202, 150);
        button3.TabIndex = 12;
        button3.Text = "Кол-во матчей в которых участвовали игроки";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(650, 351);
        Controls.Add(button3);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button6);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Курсач";
        FormClosed += Form1_FormClosed;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
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
}
