using KursachMasha.DAL.Sponsors;
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
    }

    private void sponsorAddButton_Click(object sender, EventArgs e)
    {
        var sponsor = new Sponsor();
        sponsor.Name = sponsorNameTextBox.Text;
        sponsor.Description = descriptionNameTextBox.Text;

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

    private void button14_Click(object sender, EventArgs e)
    {

    }
}
