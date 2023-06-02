using KursachMasha.DAL.Classes;
using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;
using KursachMasha.Extensions;

namespace KursachMasha.Forms;

public partial class MatchesForm : Form
{
    private readonly TeamRepository _teamRepository;
    private readonly StadiumRepository _stadiumRepository;
    private readonly MatchRepository _matchRepository;

    public MatchesForm()
    {
        InitializeComponent();

        _teamRepository = new TeamRepository();
        _stadiumRepository = new StadiumRepository();
        _matchRepository = new MatchRepository();

        tableMatches.Configuration<Match>();
        FillingTableMatch();


        if (!Global.CurrentUser.IsAdmin)
        {
            matchAddButton.Enabled = false;
            matchUpdateButton.Enabled = false;
            matchDeleteButton.Enabled = false;

            DateTimePickerMatch.Enabled = false;

            team1IDMatchComboBox.Enabled = false;
            team2IDMatchComboBox.Enabled = false;
            stadiumIDComboBox.Enabled = false;

            resultTeam1TextBox.Enabled = false;
            resultTeam2TextBox.Enabled = false;
        }

        team1ComboBox.ValueMember = nameof(Team.ID);
        team1ComboBox.DisplayMember = nameof(Team.Name);
        
        team2ComboBox.ValueMember = nameof(Team.ID);
        team2ComboBox.DisplayMember = nameof(Team.Name);

        stadiumСomboBox.ValueMember = nameof(Stadium.ID);
        stadiumСomboBox.DisplayMember = nameof(Stadium.Name);


        team1IDMatchComboBox.ValueMember = nameof(Team.ID);
        team1IDMatchComboBox.DisplayMember = nameof(Team.Name);

        team2IDMatchComboBox.ValueMember = nameof(Team.ID);
        team2IDMatchComboBox.DisplayMember = nameof(Team.Name);

        stadiumIDComboBox.ValueMember = nameof(Stadium.ID);
        stadiumIDComboBox.DisplayMember = nameof(Stadium.Name);
    }

    private void matchAddButton_Click(object sender, EventArgs e)
    {
        
        if (!IsSelectValue(team1IDMatchComboBox, "Не выбрана первая команда")
            || !IsSelectValue(team2IDMatchComboBox, "Не выбрана вторая команда")
            || !IsSelectValue(team2IDMatchComboBox, "Не выбран стадион"))
        {
            return;
        }

        var match = new Match()
        {
            DateTime = DateTimePickerMatch.Value,
            Team1ID = (int)team1IDMatchComboBox.SelectedValue,
            Team2ID = (int)team2IDMatchComboBox.SelectedValue,
            StadiumID = (int)stadiumIDComboBox.SelectedValue,
            ResultTeam1 = string.IsNullOrEmpty(resultTeam1TextBox.Text) ? null : int.Parse(resultTeam1TextBox.Text),
            ResultTeam2 = string.IsNullOrEmpty(resultTeam2TextBox.Text) ? null : int.Parse(resultTeam2TextBox.Text),
        };

        _matchRepository.Add(match);

        matchGettingButton_Click(sender, e);
    }

    private bool IsSelectValue(ComboBox comboBox, string message)
    {
        if (comboBox.SelectedValue is not null)
            return true;

        MessageBox.Show(message);
        return false;
    }

    private void matchUpdateButton_Click(object sender, EventArgs e)
    {
        var id = (int)tableMatches.SelectedRows[0].Cells[0].Value;
        var oldMatch = _matchRepository.GetByID(id);

        int team1ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team1ID);
        int team2ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team2ID);
        int stadiumID = (int)(stadiumIDComboBox.SelectedValue ?? oldMatch.StadiumID);

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
        resultTeam1TextBox.Text = string.Empty;
        resultTeam2TextBox.Text = string.Empty;

        matchGettingButton_Click(sender, e);
    }

    private void matchDeleteButton_Click(object sender, EventArgs e)
    {
        tableMatches.DeleteObject(_matchRepository);
        matchGettingButton_Click(sender, e);
    }

    private void matchGettingButton_Click(object sender, EventArgs e)
    {
        FillingTableMatch(new MatchFilter
        {
            Team1ID = (int?)team1ComboBox.SelectedValue,
            Team2ID = (int?)team2ComboBox.SelectedValue,
            StadiumID = (int?)stadiumСomboBox.SelectedValue,
        });
    }

    private void teamMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void stadiumMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _stadiumRepository.GetArray(new StadiumFilter()
        {
            Search = thisComboBox.Text,
        });
    }


    private void FillingTableMatch(MatchFilter filter = null)
    {
        tableMatches.Rows.Clear();
        foreach (var match in _matchRepository.GetArray(filter))
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

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBoxExtensions.OnlyDigits_TextBoxChange(e);
    }

    private void tableMatches_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        DateTimePickerMatch.Value = DateTime.Now;

        team1IDMatchComboBox.SelectedItem = new object();
        team1IDMatchComboBox.SelectedValue = new object();
        team1IDMatchComboBox.Text = string.Empty;

        team2IDMatchComboBox.SelectedItem = new object();
        team2IDMatchComboBox.SelectedValue = new object();
        team2IDMatchComboBox.Text = string.Empty;

        stadiumIDComboBox.SelectedItem = new object();
        stadiumIDComboBox.SelectedValue = new object();
        stadiumIDComboBox.Text = string.Empty;

        if (e.StateChanged != DataGridViewElementStates.Selected)
            return;

        var row = tableMatches.Rows[e.Row.Index];

        var match = _matchRepository.GetByID((int)row.Cells[0].Value);
        DateTimePickerMatch.Value = match.DateTime;
        resultTeam1TextBox.Text = match.ResultTeam1.ToString();
        resultTeam2TextBox.Text = match.ResultTeam2.ToString();
        
        var teamFirst = _teamRepository.GetByID(match.Team1ID);
        team1IDMatchComboBox.SelectedItem = teamFirst;
        team1IDMatchComboBox.SelectedValue = teamFirst.ID;
        team1IDMatchComboBox.SelectedText = teamFirst.Name;

        var teamSecond = _teamRepository.GetByID(match.Team2ID);
        team2IDMatchComboBox.SelectedItem = teamSecond;
        team2IDMatchComboBox.SelectedValue = teamSecond.ID;
        team2IDMatchComboBox.SelectedText = teamSecond.Name;

        var stadium = _stadiumRepository.GetByID(match.StadiumID);
        stadiumIDComboBox.SelectedItem = stadium;
        stadiumIDComboBox.SelectedValue = stadium.ID;
        stadiumIDComboBox.SelectedText = stadium.Name;

        teamMatchComboBox_DropDown(team1IDMatchComboBox, e);
        teamMatchComboBox_DropDown(team2IDMatchComboBox, e);
        stadiumMatchComboBox_DropDown(stadiumIDComboBox, e);
    }
}
