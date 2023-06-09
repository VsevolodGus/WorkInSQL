using KursachMasha.DAL.Locations;
using KursachMasha.DAL.Stadiums;
using KursachMasha.Extensions;

namespace KursachMasha;

public partial class StadiumsEditForm : Form
{
    private readonly bool _isAdd;
    private readonly StadiumsForm _parentForm;
    private readonly Stadium _currentStadium;
    private readonly StadiumRepository _stadiumRepository;
    private readonly LocationRepository _locationRepository;
    public StadiumsEditForm(StadiumsForm parentForm, int? id, bool isAdd)
    {
        InitializeComponent();
        _isAdd = isAdd;
        _parentForm = parentForm;
        _stadiumRepository = new StadiumRepository();
        _locationRepository = new LocationRepository();

        if (id.HasValue)
            _currentStadium = _stadiumRepository.GetByID(id.Value);
        else
            _currentStadium = new Stadium();

        stadiumNameTextBox.Text = _currentStadium.Name;
        stadiumVolumeTextBox.Text = _currentStadium.Volume.ToString();

        selectLocationComboBox.ValueMember = nameof(MyLocation.ID);
        selectLocationComboBox.DisplayMember = nameof(MyLocation.Name);
        var locations = _locationRepository.GetArray(null);
        selectLocationComboBox.DataSource = locations;
        selectLocationComboBox.SelectedItem = locations.FirstOrDefault(c => c.ID == _currentStadium.LocationID);
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

        _parentForm.buttonGettingStadiums_Click(sender, e);
        this.Close();
    }

    public void Add()
    {
        if (!stadiumNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        if (!int.TryParse(stadiumVolumeTextBox.Text, out int volume))
        {
            MessageBox.Show("Введено некорректное значение вместимости");
            return;
        }

        var stadium = new Stadium
        {
            Name = stadiumNameTextBox.Text,
            Volume = volume,
            LocationID = (int?)selectLocationComboBox.SelectedValue
        };

        _stadiumRepository.Add(stadium);
    }

    public void Update()
    {
        if (!stadiumNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        if (!int.TryParse(stadiumVolumeTextBox.Text, out int volume))
        {
            MessageBox.Show("Введено некорректное значение вместимости");
            return;
        }

        var id = _currentStadium.ID;
        var oldTeam = _stadiumRepository.GetByID(id);
        var locationID = (int?)(selectLocationComboBox.SelectedValue ?? oldTeam.LocationID);

        var stadium = new Stadium()
        {
            ID = id,
            Name = stadiumNameTextBox.Text,
            Volume = volume,
            LocationID = locationID,
        };
        _stadiumRepository.Update(stadium);
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
