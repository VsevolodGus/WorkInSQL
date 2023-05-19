using KursachMasha.DAL.Users;

namespace KursachMasha;

public partial class LoginForm : Form
{
    private readonly UserRepository userRepository;

    public LoginForm()
    {
        InitializeComponent();
        userRepository = new UserRepository();
        inputPassword.PasswordChar = '*';
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var user = userRepository.GetByLoginAndPassword(inputLogin.Text, inputPassword.Text);
        if (user is null)
        {
            MessageBox.Show("Был введет не правильно пароль или логин!");
            return;
        }

        Global.CurrentUser = user;
        new Form1(this).Show();
        inputLogin.Clear(); 
        inputPassword.Clear();
        Hide();
    }
}
