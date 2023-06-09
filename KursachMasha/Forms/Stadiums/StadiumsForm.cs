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

        if (!Global.CurrentUser.IsAdmin)
        {
            stadiumAddButton.Enabled = false;
            stadiumUpdateButton.Enabled = false;
            stadiumDeleteButton.Enabled = false;
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
        var currentID = (int?)(tableStadiums.SelectedRows.Count != 0
                    ? tableStadiums.SelectedRows[0].Cells[0].Value
                    : null);

        new StadiumsEditForm(this, currentID, true).Show();
        Hide();

    }

    public void buttonGettingStadiums_Click(object sender, EventArgs e)
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
        if (tableStadiums.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не был выбран элемент для обновления");
            return;
        }

        new StadiumsEditForm(this, (int?)tableStadiums.SelectedRows[0].Cells[0].Value, false).Show();
        Hide();
    }
}
