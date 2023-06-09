using KursachMasha.DAL.Sponsors;
using KursachMasha.DAL.Teams;
using KursachMasha.Extensions;

namespace KursachMasha;
public partial class SponsorsForm : Form
{
    private readonly SponsorRepository _sponsorRepository;

    public SponsorsForm()
    {
        InitializeComponent();

        _sponsorRepository = new SponsorRepository();

        tableSponsors.Configuration<Sponsor>();
        FillingTableSponsors();


        if (!Global.CurrentUser.IsAdmin)
        {
            sposorAddButton.Enabled = false;
            sposorUpdateButton.Enabled = false;
            sponsorDeleteButton.Enabled = false;

            sponsorNameTextBox.Enabled = false;
            sponsorDescriptionTextBox.Enabled = false;
        }
    }

    private void sponsorAddButton_Click(object sender, EventArgs e)
    {
        if (!sponsorNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var sponsor = new Sponsor()
        {
            Name = sponsorNameTextBox.Text,
            Description = sponsorDescriptionTextBox.Text
        };

        _sponsorRepository.Add(sponsor);

        buttonGettingSponsors_Click(sender, e);
    }

    private void DeleteSponsors_Button_Click(object sender, EventArgs e)
    {
        tableSponsors.DeleteObject(_sponsorRepository);
        buttonGettingSponsors_Click(sender, e);
    }

    private void buttonGettingSponsors_Click(object sender, EventArgs e)
    {
        FillingTableSponsors(new SponsorFilter
        {
            Search = sponsorSearchTextBox.Text
        });
    }

    private void FillingTableSponsors(SponsorFilter filter = null)
    {
        tableSponsors.Rows.Clear();
        foreach (var sponsor in _sponsorRepository.GetArray(filter))
            tableSponsors.Rows.Add(sponsor.ID
                , sponsor.Name
                , sponsor.Description);
    }

    private void sponsorUpdate_Button(object sender, EventArgs e)
    {
        if (!sponsorNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var id = (int)tableSponsors.SelectedRows[0].Cells[0].Value;

        var team = new Sponsor()
        {
            ID = id,
            Name = sponsorNameTextBox.Text,
            Description = sponsorDescriptionTextBox.Text,
        };
        _sponsorRepository.Update(team);

        buttonGettingSponsors_Click(sender, e);
    }

    private void tableSponsors_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        sponsorNameTextBox.Text = string.Empty;
        sponsorDescriptionTextBox.Text = string.Empty;

        if (e.StateChanged != DataGridViewElementStates.Selected)
            return;

        var row = tableSponsors.Rows[e.Row.Index];

        var team = _sponsorRepository.GetByID((int)row.Cells[0].Value);
        sponsorNameTextBox.Text = team.Name;
        sponsorDescriptionTextBox.Text = team.Description;
    }
}
