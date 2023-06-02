using KursachMasha.DAL.Sponsors;
using KursachMasha.DAL.Teams;
using KursachMasha.Extensions;

namespace KursachMasha;
public partial class TeamsForm : Form
{
    private readonly TeamRepository _teamRepository;
    private readonly SponsorRepository _sponsorRepository

    public TeamsForm()
    {
        InitializeComponent();

        _teamRepository = new TeamRepository();
        _sponsorRepository = new SponsorRepository();

        tableTeams.Configuration<Team>();
        FillingTableTeam();

        sponsorIDTeamComboBox.ValueMember = nameof(Sponsor.ID);
        sponsorIDTeamComboBox.DisplayMember = nameof(Sponsor.Name);

        filterSponsorComboBox.ValueMember = nameof(Sponsor.ID);
        filterSponsorComboBox.DisplayMember = nameof(Sponsor.Name);


        if (!Global.CurrentUser.IsAdmin)
        {
            teamAddButton.Enabled = false;
            teamDeleteButton.Enabled = false;
            teamUpdateButton.Enabled = false;

            teamNameTextBox.Enabled = false;
            sponsorIDTeamComboBox.Enabled = false;
        }
    }

    private void teamAddButton_Click(object sender, EventArgs e)
    {
        
        if(!teamNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var team = new Team()
        {
            Name = teamNameTextBox.Text,
            SponsorID = (int)sponsorIDTeamComboBox.SelectedValue,
        };

        _teamRepository.Add(team);

        teamGettingButton_Click(sender, e);
    }


    private void teamUpdateButton_Click(object sender, EventArgs e)
    {
        var id = (int)tableTeams.SelectedRows[0].Cells[0].Value;
        var oldTeam = _teamRepository.GetByID(id);

        int sponsorID = (int)(sponsorIDTeamComboBox.SelectedValue ?? oldTeam.SponsorID);

        var team = new Team()
        {
            ID = id,
            Name = teamNameTextBox.Text,
            SponsorID = sponsorID,
        };
        _teamRepository.Update(team);

        teamGettingButton_Click(sender, e);
    }


    private void teamGettingButton_Click(object sender, EventArgs e)
    {
        FillingTableTeam(new TeamFilter
        {
            Search = teamSearchTextBox.Text
        });

    }

    private void teamDeleteButton_Click(object sender, EventArgs e)
    {
        tableTeams.DeleteObject(_teamRepository);
        teamGettingButton_Click(sender, e);
    }

    private void FillingTableTeam(TeamFilter filter = null)
    {
        tableTeams.Rows.Clear();
        foreach (var team in _teamRepository.GetArray(filter))
            tableTeams.Rows.Add(team.ID
                , team.Name
                , team.SponsorID
                , team.SponsorName);
    }

    private void sponsorIDTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _sponsorRepository.GetArray(new SponsorFilter()
        {
            Search = thisComboBox.Text,
        });
    }
}
