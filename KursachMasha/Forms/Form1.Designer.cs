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
        Tabs = new TabControl();
        tabPage1 = new TabPage();
        button1 = new Button();
        tabPage2 = new TabPage();
        button2 = new Button();
        tabPage3 = new TabPage();
        tabPage4 = new TabPage();
        button4 = new Button();
        tabPage5 = new TabPage();
        button5 = new Button();
        tabPage6 = new TabPage();
        button3 = new Button();
        tablePlayerCountMatchesDataGridView = new DataGridView();
        menuStrip1 = new MenuStrip();
        logoutMenuStrip = new ToolStripMenuItem();
        button6 = new Button();
        Tabs.SuspendLayout();
        tabPage1.SuspendLayout();
        tabPage2.SuspendLayout();
        tabPage3.SuspendLayout();
        tabPage4.SuspendLayout();
        tabPage5.SuspendLayout();
        tabPage6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tablePlayerCountMatchesDataGridView).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // Tabs
        // 
        Tabs.Controls.Add(tabPage1);
        Tabs.Controls.Add(tabPage2);
        Tabs.Controls.Add(tabPage3);
        Tabs.Controls.Add(tabPage4);
        Tabs.Controls.Add(tabPage5);
        Tabs.Controls.Add(tabPage6);
        Tabs.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
        Tabs.Location = new Point(6, 27);
        Tabs.Name = "Tabs";
        Tabs.SelectedIndex = 0;
        Tabs.Size = new Size(1165, 625);
        Tabs.TabIndex = 10;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(button1);
        tabPage1.Location = new Point(4, 29);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(1157, 592);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Игроки";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(492, 92);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 0;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // tabPage2
        // 
        tabPage2.Controls.Add(button2);
        tabPage2.Location = new Point(4, 29);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(1157, 592);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Комнады";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(439, 184);
        button2.Name = "button2";
        button2.Size = new Size(98, 48);
        button2.TabIndex = 1;
        button2.Text = "button2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // tabPage3
        // 
        tabPage3.Controls.Add(button6);
        tabPage3.Location = new Point(4, 29);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(1157, 592);
        tabPage3.TabIndex = 2;
        tabPage3.Text = "Матчи";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // tabPage4
        // 
        tabPage4.Controls.Add(button4);
        tabPage4.ForeColor = Color.Black;
        tabPage4.Location = new Point(4, 29);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(1157, 592);
        tabPage4.TabIndex = 3;
        tabPage4.Text = "Стадионы";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(333, 152);
        button4.Name = "button4";
        button4.Size = new Size(186, 99);
        button4.TabIndex = 0;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // tabPage5
        // 
        tabPage5.Controls.Add(button5);
        tabPage5.Location = new Point(4, 29);
        tabPage5.Name = "tabPage5";
        tabPage5.Padding = new Padding(3);
        tabPage5.Size = new Size(1157, 592);
        tabPage5.TabIndex = 4;
        tabPage5.Text = "Спонсоры";
        tabPage5.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(468, 148);
        button5.Name = "button5";
        button5.Size = new Size(205, 130);
        button5.TabIndex = 0;
        button5.Text = "button5";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // tabPage6
        // 
        tabPage6.Controls.Add(button3);
        tabPage6.Controls.Add(tablePlayerCountMatchesDataGridView);
        tabPage6.Location = new Point(4, 29);
        tabPage6.Name = "tabPage6";
        tabPage6.Padding = new Padding(3);
        tabPage6.Size = new Size(1157, 592);
        tabPage6.TabIndex = 5;
        tabPage6.Text = "Кол-во матчей у игроков";
        tabPage6.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Location = new Point(25, 21);
        button3.Name = "button3";
        button3.Size = new Size(414, 233);
        button3.TabIndex = 30;
        button3.Text = "Получить список игроков с кол-воматчей в которых они учавствовали";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // tablePlayerCountMatchesDataGridView
        // 
        tablePlayerCountMatchesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tablePlayerCountMatchesDataGridView.Location = new Point(486, 5);
        tablePlayerCountMatchesDataGridView.Name = "tablePlayerCountMatchesDataGridView";
        tablePlayerCountMatchesDataGridView.RowHeadersWidth = 51;
        tablePlayerCountMatchesDataGridView.RowTemplate.Height = 29;
        tablePlayerCountMatchesDataGridView.Size = new Size(603, 535);
        tablePlayerCountMatchesDataGridView.TabIndex = 4;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { logoutMenuStrip });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(6, 3, 0, 3);
        menuStrip1.Size = new Size(1189, 30);
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
        // button6
        // 
        button6.Location = new Point(430, 103);
        button6.Name = "button6";
        button6.Size = new Size(94, 29);
        button6.TabIndex = 0;
        button6.Text = "button6";
        button6.UseVisualStyleBackColor = true;
        button6.Click += button6_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1189, 667);
        Controls.Add(Tabs);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        Text = "Курсач";
        FormClosed += Form1_FormClosed;
        Tabs.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        tabPage2.ResumeLayout(false);
        tabPage3.ResumeLayout(false);
        tabPage4.ResumeLayout(false);
        tabPage5.ResumeLayout(false);
        tabPage6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tablePlayerCountMatchesDataGridView).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TabControl Tabs;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TabPage tabPage5;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem logoutMenuStrip;
    private TabPage tabPage6;
    private Button button3;
    private DataGridView tablePlayerCountMatchesDataGridView;
    private Button button1;
    private Button button2;
    private Button button4;
    private Button button5;
    private Button button6;
}
