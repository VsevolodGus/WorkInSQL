using KursachMasha.Forms;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        InitializeComponent();

        if (!Global.CurrentUser.IsAdmin)
        {
            var buttons = this.Descendants<Button>().Where(c => !c.Name.ToLower().Contains("search")).ToArray();
            foreach (var button in buttons)
                button.Enabled = false;

            var textBoxes = this.Descendants<TextBox>().Where(c => !c.Name.ToLower().Contains("search")).ToArray();
            foreach (var textBox in textBoxes)
                textBox.Enabled = false;
        }

    }

    private void LogoutMenuStrip_Click(object sender, EventArgs e)
    {
        //TODO закрытие остальных окон
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Hide();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Close();
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

    private void onlyDigits_TextBoxChange(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }


}