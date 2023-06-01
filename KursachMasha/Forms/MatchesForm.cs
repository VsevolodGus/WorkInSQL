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
            stadiumIDTeamComboBox.Enabled = false;
            resultTeam1TextBox.Enabled = false;
            resultTeam2TextBox.Enabled = false;
        }
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
        FillingTableMatch(new MatchFilter
        {
            Team1ID = (int?)team1ComboBox.SelectedValue,
            Team2ID = (int?)team2ComboBox.SelectedValue,
            StadiumID = (int?)stadiumСomboBox.SelectedValue,
        });
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
}
