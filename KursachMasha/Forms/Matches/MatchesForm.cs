using KursachMasha.DAL.Mathes;
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
        }

        team1ComboBox.ValueMember = nameof(Team.ID);
        team1ComboBox.DisplayMember = nameof(Team.Name);

        team2ComboBox.ValueMember = nameof(Team.ID);
        team2ComboBox.DisplayMember = nameof(Team.Name);

        stadiumСomboBox.ValueMember = nameof(Stadium.ID);
        stadiumСomboBox.DisplayMember = nameof(Stadium.Name);
    }

    private void matchAddButton_Click(object sender, EventArgs e)
    {
        var currentID = (int?)(tableMatches.SelectedRows.Count != 0
                            ? tableMatches.SelectedRows[0].Cells[0].Value 
                            : null);

        new MatchesEditForm(this, currentID, true).Show();
        Hide();
    }

    private void matchUpdateButton_Click(object sender, EventArgs e)
    {
        if (tableMatches.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не был выбран элемент для обновления");
            return;
        }

        new MatchesEditForm(this, (int?)tableMatches.SelectedRows[0].Cells[0].Value, false).Show();
        Hide();
    }

    private void matchDeleteButton_Click(object sender, EventArgs e)
    {
        tableMatches.DeleteObject(_matchRepository);
        matchGettingButton_Click(sender, e);
    }

    public void matchGettingButton_Click(object sender, EventArgs e)
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


}
