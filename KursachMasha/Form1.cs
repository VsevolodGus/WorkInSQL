using KursachMasha.DAL.Classes;
using KursachMasha.DAL.Queries;
using KursachMasha.DAL.Roles;
using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    private readonly TeamRepository _teamRepository;
    private readonly StadiumRepository _stadiumRepository;
    private readonly DataPlayersMatchesQuery _playersMatchesQuery;
    private readonly MatchRepository _matchRepository;

    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _teamRepository = new TeamRepository();
        _stadiumRepository = new StadiumRepository();
        _playersMatchesQuery = new DataPlayersMatchesQuery();
        _matchRepository = new MatchRepository();

        InitializeComponent();

        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.CustomFormat = "MM.dd.yyyy hh:mm:ss";

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
        tableMatches.Configuration<Match>();
        FillingTableMatch();


        team1IDMatchComboBox.ValueMember = nameof(Team.ID);
        team1IDMatchComboBox.DisplayMember = nameof(Team.Name);

        team2IDMatchComboBox.ValueMember = nameof(Team.ID);
        team2IDMatchComboBox.DisplayMember = nameof(Team.Name);

        stadiumIDTeamComboBox.ValueMember = nameof(Stadium.ID);
        stadiumIDTeamComboBox.DisplayMember = nameof(Stadium.Name);
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

    private void onlyDigits_TextBoxChange(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
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


    #region Логика c матчами

    private void FillingTableMatch()
    {
        tableMatches.Rows.Clear();
        foreach (var match in _matchRepository.GetArray(null))
            tableMatches.Rows.Add(match.ID
                , match.DateTime
                , match.Team1ID
                , match.Team1Name
                , match.Team2ID
                , match.Team2Name
                , match.StadiumID
                , match.StadiumName
                , match.ResultTeam1
                , match.ResultTeam2);
    }
    private void matchAddButton_Click(object sender, EventArgs e)
    {
        //TODO сделать оповещение что не заполнено что-то
        var match = new Match()
        {
            DateTime = DateTimePickerMatch.Value,
            Team1ID = (int)team1IDMatchComboBox.SelectedValue,
            Team2ID = (int)team2IDMatchComboBox.SelectedValue,
            StadiumID = (int)stadiumIDTeamComboBox.SelectedValue,
            ResultTeam1 = int.Parse(resultTeam1TextBox.Text),
            ResultTeam2 = int.Parse(resultTeam2TextBox.Text),
        };

        _matchRepository.Add(match);

        matchGettingButton_Click(sender, e);
    }

    private void matchUpdateButton_Click(object sender, EventArgs e)
    {
        var id = (int)tableMatches.SelectedRows[0].Cells[0].Value;
        var oldMatch = _matchRepository.GetByID(id);

        int team1ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team1ID);
        int team2ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team2ID);
        int stadiumID = (int)(stadiumIDTeamComboBox.SelectedValue ?? oldMatch.StadiumID);

        var match = new Match()
        {
            ID = id,
            DateTime = DateTimePickerMatch.Value,
            Team1ID = team1ID,
            Team2ID = team2ID,
            StadiumID = stadiumID,
            ResultTeam1 = int.Parse(resultTeam1TextBox.Text),
            ResultTeam2 = int.Parse(resultTeam2TextBox.Text),
        };

        _matchRepository.Update(match);

        matchGettingButton_Click(sender, e);
    }

    private void matchDeleteButton_Click(object sender, EventArgs e)
    {
        tableMatches.DeleteObject(_matchRepository);
        matchGettingButton_Click(sender, e);
    }

    private void matchGettingButton_Click(object sender, EventArgs e)
    {
        FillingTableMatch();
    }

    private void team1IDMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void team2IDMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void stadiumIDTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _stadiumRepository.GetArray(new StadiumFilter()
        {
            Search = thisComboBox.Text,
        });
    }




    #endregion



}