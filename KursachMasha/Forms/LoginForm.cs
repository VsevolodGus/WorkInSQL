using Kursach.DAL.Users;

namespace Kursach;

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
            MessageBox.Show("Был неправильно введен пароль или логин!");
            return;
        }

        Global.CurrentUser = user;
        new Form1(this).Show();
        Hide();
        inputLogin.Clear();
        inputPassword.Clear();
    }
}
