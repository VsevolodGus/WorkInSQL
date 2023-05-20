using KursachMasha.DAL;
using KursachMasha.DAL.Players;
using KursachMasha.DAL.Teams;
using System.Reflection;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;
    private readonly PlayerRepository _playerRepository;
    private readonly TeamRepository _teamRepository;

    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _playerRepository = new PlayerRepository();
        _teamRepository = new TeamRepository();

        InitializeComponent();
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.CustomFormat = "MM.dd.yyyy hh:mm:ss";

        if (!Global.CurrentUser.IsAdmin)
        {
            var buttons = this.Descendants<Button>().ToArray();
            foreach (var button in buttons)
                button.Enabled = false;

            var textBoxes = this.Descendants<TextBox>().ToArray();
            foreach (var textBox in textBoxes)
                textBox.Enabled = false;
        }


        ConfigDataGried<Player>(tablePlayers);
        FillingTablePlayers();

        searchTeamComboBox.ValueMember = nameof(Team.ID);
        searchTeamComboBox.DisplayMember = nameof(Team.Name);
    }

    private void ConfigDataGried<T>(DataGridView table)
    {
        table.AutoGenerateColumns = false;
        var properties = typeof(T).GetProperties();
        foreach (var column in properties)
        {
            var attributes = column.GetCustomAttribute<ColumnAttribute>();
            if (attributes is not null || !column.PropertyType.IsClass)
            {
                string columnsName = column.Name;
                if (attributes is not null)
                    columnsName = attributes.Name;

                table.Columns.Add(column.Name, columnsName);

                if (column.Name.ToLower().Contains("id"))
                    table.Columns[column.Name].Visible = false;
            }
        }
    }

    private void LogoutMenuStrip_Click(object sender, EventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Hide();
    }

    private void FillingTablePlayers(PlayerFilter filter = null)
    {
        tablePlayers.Rows.Clear();
        foreach (var player in _playerRepository.GetArray(filter))
            tablePlayers.Rows.Add(player.ID
                , player.Name
                , player.Surname
                , player.Patronymic
                , player.Number
                , player.TeamID
                , player.TeamName
                , player.RoleID
                , player.RoleName);
    }



    private void ButtonGettingPlayers_Click(object sender, EventArgs e)
    {
        var eventKey = e as KeyEventArgs;
        if (e is KeyEventArgs && eventKey.KeyCode != Keys.Enter)
            return;


        FillingTablePlayers(new PlayerFilter
        {
            Search = playerSearchTextBox.Text,
            TeamID = (searchTeamComboBox.SelectedItem as Team)?.ID,
            //RoleID = (searchTeamComboBox.SelectedItem as Team)?.ID,
        });
    }

    private void searchTeamComboBox_DropDown(object sender, EventArgs e)
    {
        searchTeamComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = searchTeamComboBox.Text,
        });
    }

    private void DeletePlayers_Click(object sender, EventArgs e)
    {

    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        _loginForm.Close();
    }
}
