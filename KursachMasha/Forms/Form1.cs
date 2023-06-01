using KursachMasha.Forms;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        InitializeComponent();
    }

    private void LogoutMenuStrip_Click(object sender, EventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Hide();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new PlayersForm().Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        new TeamsForm().Show();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        new StadiumsForm().Show();
    }

    private void button5_Click(object sender, EventArgs e)
    {
        new SponsorsForm().Show();
    }


    private void button6_Click(object sender, EventArgs e)
    {
        new MatchesForm().Show();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        new PlayerMatchCountForm().Show();
    }
}