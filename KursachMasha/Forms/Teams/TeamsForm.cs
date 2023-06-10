using Kursach.DAL.Sponsors;
using Kursach.DAL.Teams;
using Kursach.Extensions;

namespace Kursach;
public partial class TeamsForm : Form
{
    private readonly TeamRepository _teamRepository;
    private readonly SponsorRepository _sponsorRepository;

    public TeamsForm()
    {
        InitializeComponent();

        _teamRepository = new TeamRepository();
        _sponsorRepository = new SponsorRepository();

        tableTeams.Configuration<Team>();
        FillingTableTeam();

        filterSponsorComboBox.ValueMember = nameof(Sponsor.ID);
        filterSponsorComboBox.DisplayMember = nameof(Sponsor.Name);


        if (!Global.CurrentUser.IsAdmin)
        {
            teamAddButton.Enabled = false;
            teamDeleteButton.Enabled = false;
            teamUpdateButton.Enabled = false;

        }
    }

    private void teamAddButton_Click(object sender, EventArgs e)
    {
        var currentID = (int?)(tableTeams.SelectedRows.Count != 0
                    ? tableTeams.SelectedRows[0].Cells[0].Value
                    : null);

        new TeamsEditForm(this, currentID, true).Show();
        Hide();
    }


    private void teamUpdateButton_Click(object sender, EventArgs e)
    {
        if (tableTeams.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не был выбран элемент для обновления");
            return;
        }

        new TeamsEditForm(this, (int?)tableTeams.SelectedRows[0].Cells[0].Value, false).Show();
        Hide();
    }


    public void GetTeamsButton_Click(object sender, EventArgs e)
    {
        FillingTableTeam(new TeamFilter
        {
            Search = teamSearchTextBox.Text
        });
    }

    private void teamDeleteButton_Click(object sender, EventArgs e)
    {
        tableTeams.DeleteObject(_teamRepository);
        GetTeamsButton_Click(sender, e);
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
