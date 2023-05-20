using KursachMasha.DAL.Players;
using KursachMasha.DAL.Roles;
using KursachMasha.DAL.Teams;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    private readonly PlayerRepository _playerRepository;
    private readonly TeamRepository _teamRepository;
    private readonly RoleRepository _roleRepository;


    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _playerRepository = new PlayerRepository();
        _teamRepository = new TeamRepository();
        _roleRepository = new RoleRepository();

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

        tablePlayers.Configuration<Player>();
        FillingTablePlayers();

        searchTeamComboBox.ValueMember = nameof(Team.ID);
        searchTeamComboBox.DisplayMember = nameof(Team.Name);
        selectTeamPlayerComboBox.ValueMember = nameof(Team.ID);
        selectTeamPlayerComboBox.DisplayMember = nameof(Team.Name);

        searchRoleComboBox.ValueMember = nameof(Role.ID);
        searchRoleComboBox.DisplayMember = nameof(Role.Name);
        propertyPlayerRoleComboBox.ValueMember = nameof(Role.ID);
        propertyPlayerRoleComboBox.DisplayMember = nameof(Role.Name);
    }

    #region Общие
    private void LogoutMenuStrip_Click(object sender, EventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Hide();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        //_loginForm.Close();
        this.Close();
    }
    #endregion


    #region Логика с юзерами
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

    private void DeletePlayers_Click(object sender, EventArgs e)
    {
        tablePlayers.DeleteObject(_playerRepository);
        ButtonGettingPlayers_Click(sender, e);
    }

    private void ButtonGettingPlayers_Click(object sender, EventArgs e)
    {
        var eventKey = e as KeyEventArgs;
        if (e is KeyEventArgs && eventKey.KeyCode != Keys.Enter)
            return;

        //var asd = selectTeamPlayerComboBox.SelectedValue;

        FillingTablePlayers(new PlayerFilter
        {
            Search = playerSearchTextBox.Text,
            TeamID = (int?)searchTeamComboBox.SelectedValue,
            RoleID = (int?)searchRoleComboBox.SelectedValue,
        });
    }


    #endregion

    #region Логика с командами
    private void searchTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }
    #endregion


    #region Логика с ролями
    private void searchRoleComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _roleRepository.GetArray(new RoleFilter()
        {
            Search = thisComboBox.Text,
        });
    }
    #endregion


    private void tablePlayers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        #region Обнуление полей с данными
        playerNameTextBox.Text = string.Empty;
        playerSurnameTextBox.Text = string.Empty;
        playerPatronymicTetBox.Text = string.Empty;

        selectTeamPlayerComboBox.SelectedItem = null;
        selectTeamPlayerComboBox.SelectedValue = null;
        selectTeamPlayerComboBox.Text = null;

        propertyPlayerRoleComboBox.SelectedItem = null;
        propertyPlayerRoleComboBox.SelectedValue = null;
        propertyPlayerRoleComboBox.Text = null;
        #endregion

        if (e.StateChanged != DataGridViewElementStates.Selected)
            return;

        var row = tablePlayers.Rows[e.Row.Index];
        
        var player = _playerRepository.GetByID((int)row.Cells[0].Value);
        playerNameTextBox.Text = player.Name;
        playerSurnameTextBox.Text = player.Surname;
        playerPatronymicTetBox.Text = player.Patronymic;

        var team = _teamRepository.GetByID(player.TeamID);
        selectTeamPlayerComboBox.SelectedItem = team;
        selectTeamPlayerComboBox.SelectedValue = team.ID;
        selectTeamPlayerComboBox.SelectedText = team.Name;

        var role = _roleRepository.GetByID(player.RoleID);
        propertyPlayerRoleComboBox.SelectedItem = role;
        propertyPlayerRoleComboBox.SelectedValue = role.ID;
        propertyPlayerRoleComboBox.SelectedText = role.Name;
    }
}
