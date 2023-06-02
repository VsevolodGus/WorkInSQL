using KursachMasha.DAL.Locations;
using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;
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


        if (!Global.CurrentUser.IsAdmin)
        {
            stadiumAddButton.Enabled = false;
            stadiumUpdateButton.Enabled = false;
            stadiumDeleteButton.Enabled = false;

            stadiumNameTextBox.Enabled = false;
            stadiumVolumeTextBox.Enabled = false;

            selectLocationComboBox.Enabled = false;
        }
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

        var stadium = new Stadium
        {
            Name = stadiumNameTextBox.Text,
            Volume = int.Parse(stadiumVolumeTextBox.Text),
            LocationID = (int)selectLocationComboBox.SelectedValue
        };

        _stadiumRepository.Add(stadium);

        buttonGettingStadiums_Click(sender, e);

    }

    private void buttonGettingStadiums_Click(object sender, EventArgs e)
    {
        FillingTableStadiums(new StadiumFilter
        {
            Search = stadiumSearchTextBox.Text,
            IsUse = isUseForMatchesCheckBox.Checked
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

    private void stadiumUpdateButton_Click(object sender, EventArgs e)
    {
        if (!stadiumNameTextBox.ShowMessageBoxIfNoCorrect("Название не заполнено"))
            return;

        var id = (int)tableStadiums.SelectedRows[0].Cells[0].Value;
        var oldTeam = _stadiumRepository.GetByID(id);

        var locationID = (int?)(selectLocationComboBox.SelectedValue ?? oldTeam.LocationID);

        var stadium = new Stadium()
        {
            ID = id,
            Name = stadiumNameTextBox.Text,
            LocationID = locationID,
        };
        _stadiumRepository.Update(stadium);

        buttonGettingStadiums_Click(sender, e);
    }

    private void tableStadiums_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        #region Обнуление полей с данными
        stadiumNameTextBox.Text = string.Empty;
        stadiumVolumeTextBox.Text = string.Empty;

        selectLocationComboBox.SelectedItem = new object();
        selectLocationComboBox.SelectedValue = new object();
        selectLocationComboBox.Text = null;
        #endregion

        if (e.StateChanged != DataGridViewElementStates.Selected)
            return;
        var row = tableStadiums.Rows[e.Row.Index];

        var stadium = _stadiumRepository.GetByID((int)row.Cells[0].Value);
        stadiumNameTextBox.Text = stadium.Name;
        stadiumVolumeTextBox.Text = stadium.Volume.ToString();

        if (stadium.LocationID.HasValue )
        {
            var sponsor = _locationRepository.GetByID(stadium.LocationID.Value);
            selectLocationComboBox.SelectedItem = sponsor;
            selectLocationComboBox.SelectedValue = sponsor.ID;
            selectLocationComboBox.SelectedText = sponsor.Name;
        }


        selectLocationComboBox_DropDown(selectLocationComboBox, e);
    }
}
