using KursachMasha.DAL.Locations;
using KursachMasha.DAL.Stadiums;
using KursachMasha.Extensions;

namespace KursachMasha;
public partial class StadiumsForm : Form
{
    private readonly StadiumRepository _stadiumRepository;
    private readonly LocationRepository _locationRepository;

    public StadiumsForm()
    {
        InitializeComponent();

        _stadiumRepository = new StadiumRepository();
        _locationRepository = new LocationRepository();

        tableStadiums.Configuration<Stadium>();
        FillingTableStadiums();

        selectLocationComboBox.ValueMember = nameof(MyLocation.ID);
        selectLocationComboBox.DisplayMember = nameof(MyLocation.Name);
    }

    private void FillingTableStadiums(StadiumFilter filter = null)
    {
        tableStadiums.Rows.Clear();
        foreach (var stadium in _stadiumRepository.GetArray(filter))
            tableStadiums.Rows.Add(stadium.ID
                , stadium.Name
                , stadium.Volume
                , stadium.Size
                , stadium.Popular
                , stadium.LocationID
                , stadium.LocationName);
    }

    private void stadiumAddButton_Click(object sender, EventArgs e)
    {
        var stadium = new Stadium();
        stadium.Name = stadiumNameTextBox.Text;
        stadium.Volume = int.Parse(stadiumVolumeTextBox.Text);
        stadium.LocationID = (int)selectLocationComboBox.SelectedValue;

        _stadiumRepository.Add(stadium);

        buttonGettingStadiums_Click(sender, e);

    }

    private void buttonGettingStadiums_Click(object sender, EventArgs e)
    {
        FillingTableStadiums(new StadiumFilter
        {
            Search = stadiumSearchTextBox.Text,
            IsUseForStadions = isUseForMatchesCheckBox.Checked
        });
    }

    private void DeleteStadium_Button_Click(object sender, EventArgs e)
    {
        tableStadiums.DeleteObject(_stadiumRepository);
        buttonGettingStadiums_Click(sender, e);
    }
    private void selectLocationComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _locationRepository.GetArray(new LocationFilter()
        {
            Search = thisComboBox.Text
        });
    }
}
