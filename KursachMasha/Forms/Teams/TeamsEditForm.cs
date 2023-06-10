using Kursach.DAL.Locations;
using Kursach.DAL.Sponsors;
using Kursach.DAL.Teams;
using Kursach.Extensions;

namespace Kursach;

public partial class TeamsEditForm : Form
{
    private readonly bool _isAdd;
    private readonly TeamRepository _teamRepository;
    private readonly SponsorRepository _sponsorRepository;
    private readonly TeamsForm _parentForm;
    private readonly Team _team;


    public TeamsEditForm(TeamsForm parentForm, int? id, bool isAdd)
    {
        InitializeComponent();

        _isAdd = isAdd;
        _parentForm = parentForm;
        _teamRepository = new TeamRepository();
        _sponsorRepository = new SponsorRepository();

        if (id.HasValue)
            _team = _teamRepository.GetByID(id.Value);
        else
            _team = new Team();

        teamNameTextBox.Text = _team.Name;

        sponsorIDTeamComboBox.ValueMember = nameof(MyLocation.ID);
        sponsorIDTeamComboBox.DisplayMember = nameof(MyLocation.Name);
        var sponsors = _sponsorRepository.GetArray(null);
        sponsorIDTeamComboBox.DataSource = sponsors;
        sponsorIDTeamComboBox.SelectedItem = sponsors.FirstOrDefault(c => c.ID == _team.SponsorID);
    }
    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        _parentForm.Show();
        Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (_isAdd)
            Add();
        else
            Update();

        _parentForm.GetTeamsButton_Click(sender, e);
        Close();
    }

    public void Add()
    {
        if (!teamNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var team = new Team()
        {
            Name = teamNameTextBox.Text,
            SponsorID = (int)sponsorIDTeamComboBox.SelectedValue,
        };

        _teamRepository.Add(team);
    }

    public void Update()
    {
        if (!teamNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var team = new Team()
        {
            ID = _team.ID,
            Name = teamNameTextBox.Text,
            SponsorID = (int)sponsorIDTeamComboBox.SelectedValue,
        };
        _teamRepository.Update(team);
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
