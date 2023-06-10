using Kursach.DAL.Sponsors;
using Kursach.Extensions;

namespace Kursach;

public partial class SponsorsEditForm : Form
{
    private readonly SponsorRepository _sponsorRepository;
    private readonly SponsorsForm _parentForm;
    private readonly Sponsor _currentSponsor;
    private readonly bool _isAdd;

    public SponsorsEditForm(SponsorsForm sponsorsForm, int? id, bool isAdd)
    {
        InitializeComponent();

        _isAdd = isAdd;
        _parentForm = sponsorsForm;
        _sponsorRepository = new SponsorRepository();

        if (id.HasValue)
            _currentSponsor = _sponsorRepository.GetByID(id.Value);
        else
            _currentSponsor = new Sponsor();

        sponsorNameTextBox.Text = _currentSponsor.Name;
        sponsorDescriptionTextBox.Text = _currentSponsor.Description;

    }


    private void button1_Click(object sender, EventArgs e)
    {
        if (_isAdd)
        {
            Add();
        }
        else
        {
            Update();
        }

        _parentForm.ButtonGettingSponsors_Click(sender, e);
        this.Close();
    }
    private void SponsorsEditForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        _parentForm.Show();
        Hide();
    }

    private void Add()
    {
        if (!sponsorNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var sponsor = new Sponsor()
        {
            Name = sponsorNameTextBox.Text,
            Description = sponsorDescriptionTextBox.Text
        };

        _sponsorRepository.Add(sponsor);
    }

    private void Update()
    {
        if (!sponsorNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var id = _currentSponsor.ID;

        var team = new Sponsor()
        {
            ID = id,
            Name = sponsorNameTextBox.Text,
            Description = sponsorDescriptionTextBox.Text,
        };
        _sponsorRepository.Update(team);

    }
}
