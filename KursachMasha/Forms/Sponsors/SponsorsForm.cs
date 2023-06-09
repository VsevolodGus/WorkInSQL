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
        }
    }

    private void sponsorAddButton_Click(object sender, EventArgs e)
    {
        var currentID = (int?)(tableSponsors.SelectedRows.Count != 0
                    ? tableSponsors.SelectedRows[0].Cells[0].Value
                    : null);

        new SponsorsEditForm(this, currentID, true).Show();
        Hide();
    }

    private void DeleteSponsors_Button_Click(object sender, EventArgs e)
    {
        tableSponsors.DeleteObject(_sponsorRepository);
        ButtonGettingSponsors_Click(sender, e);
    }

    public void ButtonGettingSponsors_Click(object sender, EventArgs e)
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
        if (tableSponsors.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не был выбран элемент для обновления");
            return;
        }

        new SponsorsEditForm(this, (int?)tableSponsors.SelectedRows[0].Cells[0].Value, false).Show();
        Hide();
    }
}
