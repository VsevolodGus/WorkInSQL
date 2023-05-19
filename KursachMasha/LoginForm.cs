namespace KursachMasha;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var user = GetUserFromDB(inputLogin.Text, inputPassword.Text);
        if (user is not null)
        {
            new Form1().Show();
            Close();
        }
            
            //Application.Run(new Form1());

        MessageBox.Show("Был введет не правильно пароль или логин!");
    }

    public object GetUserFromDB(string login, string password)
    {
        return new object();
    }
}
