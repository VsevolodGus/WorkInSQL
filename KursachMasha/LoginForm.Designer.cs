namespace KursachMasha;

partial class LoginForm
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
        button1 = new Button();
        inputLogin = new TextBox();
        inputPassword = new TextBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(89, 266);
        button1.Name = "button1";
        button1.Size = new Size(211, 62);
        button1.TabIndex = 0;
        button1.Text = "Войти";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // inputLogin
        // 
        inputLogin.Location = new Point(89, 119);
        inputLogin.Name = "inputLogin";
        inputLogin.Size = new Size(226, 27);
        inputLogin.TabIndex = 1;
        // 
        // inputPassword
        // 
        inputPassword.Location = new Point(89, 205);
        inputPassword.Name = "inputPassword";
        inputPassword.Size = new Size(226, 27);
        inputPassword.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(89, 174);
        label1.Name = "label1";
        label1.Size = new Size(81, 28);
        label1.TabIndex = 3;
        label1.Text = "Пароль";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(89, 81);
        label2.Name = "label2";
        label2.Size = new Size(69, 28);
        label2.TabIndex = 4;
        label2.Text = "Логин";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(92, 9);
        label3.Name = "label3";
        label3.Size = new Size(223, 46);
        label3.TabIndex = 5;
        label3.Text = "Авторизация";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(446, 444);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(inputPassword);
        Controls.Add(inputLogin);
        Controls.Add(button1);
        Name = "LoginForm";
        Text = "LoginForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private TextBox inputLogin;
    private TextBox inputPassword;
    private Label label1;
    private Label label2;
    private Label label3;
}