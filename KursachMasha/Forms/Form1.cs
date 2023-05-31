using KursachMasha.DAL.Classes;
using KursachMasha.DAL.Queries;
using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;
using KursachMasha.Extensions;
using KursachMasha.Forms;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    private readonly DataPlayersMatchesQuery _playersMatchesQuery;

    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _playersMatchesQuery = new DataPlayersMatchesQuery();

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

        tablePlayerCountMatchesDataGridView.Configuration<PlayerMatches>();
    }

    #region Общие
    private void LogoutMenuStrip_Click(object sender, EventArgs e)
    {
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

    private void onlyDigits_TextBoxChange(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }


    #endregion

    private void button3_Click(object sender, EventArgs e)
    {
        tablePlayerCountMatchesDataGridView.Rows.Clear();
        foreach (var player in _playersMatchesQuery.Execute())
            tablePlayerCountMatchesDataGridView.Rows.Add(player.ID
                , player.Name
                , player.Surname
                , player.Patronymic
                , player.CountMatches);
    }
}