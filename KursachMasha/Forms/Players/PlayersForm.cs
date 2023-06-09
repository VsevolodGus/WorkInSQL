using KursachMasha.DAL.Players;
using KursachMasha.DAL.Roles;
using KursachMasha.DAL.Teams;
using KursachMasha.Extensions;

namespace KursachMasha;
public partial class PlayersForm : Form
{
    private readonly PlayerRepository _playerRepository;
    private readonly TeamRepository _teamRepository;
    private readonly RoleRepository _roleRepository;

    public PlayersForm()
    {
        _playerRepository = new PlayerRepository();
        _teamRepository = new TeamRepository();
        _roleRepository = new RoleRepository();

        InitializeComponent();

        tablePlayers.Configuration<Player>();
        FillingTablePlayers();

        searchTeamComboBox.ValueMember = nameof(Team.ID);
        searchTeamComboBox.DisplayMember = nameof(Team.Name);

        teamIDPlayerComboBox.ValueMember = nameof(Team.ID);
        teamIDPlayerComboBox.DisplayMember = nameof(Team.Name);

        searchRoleComboBox.ValueMember = nameof(Role.ID);
        searchRoleComboBox.DisplayMember = nameof(Role.Name);

        roleIDPlayerComboBox.ValueMember = nameof(Role.ID);
        roleIDPlayerComboBox.DisplayMember = nameof(Role.Name);


        if (!Global.CurrentUser.IsAdmin)
        {
            playerAddButton.Enabled = false;
            playerDeleteButton.Enabled = false;
            playerUpdateButton.Enabled = false;

            teamIDPlayerComboBox.Enabled = false;
            roleIDPlayerComboBox.Enabled = false;

            playerNameTextBox.Enabled = false;
            playerSurnameTextBox.Enabled = false;
            playerPatronymicTextBox.Enabled = false;
            playerNumberTextBox.Enabled = false;
        }
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

        FillingTablePlayers(new PlayerFilter
        {
            Search = playerSearchTextBox.Text,
            TeamID = (int?)searchTeamComboBox.SelectedValue,
            RoleID = (int?)searchRoleComboBox.SelectedValue,
        });
    }


    private void tablePlayers_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
    {
        #region Обнуление полей с данными
        playerNameTextBox.Text = string.Empty;
        playerSurnameTextBox.Text = string.Empty;
        playerPatronymicTextBox.Text = string.Empty;
        playerNumberTextBox.Text = string.Empty;

        teamIDPlayerComboBox.SelectedItem = new object();
        teamIDPlayerComboBox.SelectedValue = new object();
        teamIDPlayerComboBox.Text = null;

        roleIDPlayerComboBox.SelectedItem = new object();
        roleIDPlayerComboBox.SelectedValue = new object();
        roleIDPlayerComboBox.Text = null;
        #endregion

        if (e.StateChanged != DataGridViewElementStates.Selected)
            return;

        var row = tablePlayers.Rows[e.Row.Index];

        var player = _playerRepository.GetByID((int)row.Cells[0].Value);
        playerNameTextBox.Text = player.Name;
        playerSurnameTextBox.Text = player.Surname;
        playerPatronymicTextBox.Text = player.Patronymic;
        playerNumberTextBox.Text = player.Number.ToString();

        var team = _teamRepository.GetByID(player.TeamID);
        teamIDPlayerComboBox.SelectedItem = team;
        teamIDPlayerComboBox.SelectedValue = team.ID;
        teamIDPlayerComboBox.SelectedText = team.Name;

        var role = _roleRepository.GetByID(player.RoleID);
        roleIDPlayerComboBox.SelectedItem = role;
        roleIDPlayerComboBox.SelectedValue = role.ID;
        roleIDPlayerComboBox.SelectedText = role.Name;

        searchRoleComboBox_DropDown(roleIDPlayerComboBox, e);
        searchTeamComboBox_DropDown(teamIDPlayerComboBox, e);
    }

    private void addPlayerButton_Click(object sender, EventArgs e)
    {
        if (!playerNameTextBox.ShowMessageBoxIfNoCorrect("Имя не заполнено")
                || !playerSurnameTextBox.ShowMessageBoxIfNoCorrect("Фамилия не заполнено"))
            return;


        //TODO решить проблему с невыбранными полями при добавление, почему-то Select поля не заполняются
        var teamID = (int)teamIDPlayerComboBox.SelectedValue;
        if (!IsCorrectNumber(teamID))
            return;

        var player = new Player()
        {
            Name = playerNameTextBox.Text,
            Surname = playerSurnameTextBox.Text,
            Patronymic = playerPatronymicTextBox.Text,
            Number = int.Parse(playerNumberTextBox.Text),
            TeamID = teamID,
            RoleID = (int)roleIDPlayerComboBox.SelectedValue,
        };

        _playerRepository.Add(player);

        ButtonGettingPlayers_Click(sender, e);
    }

    private void updatePlayerButton_Click(object sender, EventArgs e)
    {
        if (!playerNameTextBox.ShowMessageBoxIfNoCorrect("Имя не заполнено")
                || !playerSurnameTextBox.ShowMessageBoxIfNoCorrect("Фамилия не заполнено"))
            return;

        var id = (int)tablePlayers.SelectedRows[0].Cells[0].Value;
        var oldPlayer = _playerRepository.GetByID(id);

        int teamID = (int)(searchTeamComboBox.SelectedValue ?? oldPlayer.TeamID);
        int roleID = (int)(searchRoleComboBox.SelectedValue ?? oldPlayer.RoleID);

        if (!IsCorrectNumber(teamID, id))
            return;

        var player = new Player()
        {
            ID = id,
            Name = playerNameTextBox.Text,
            Surname = playerSurnameTextBox.Text,
            Patronymic = playerPatronymicTextBox.Text,
            Number = int.Parse(playerNumberTextBox.Text),
            TeamID = teamID,
            RoleID = roleID,
        };
        _playerRepository.Update(player);

        ButtonGettingPlayers_Click(sender, e);
    }

    private bool IsCorrectNumber(int teamID, int? id = null)
    {
        if (!playerNameTextBox.ShowMessageBoxIfNoCorrect("Номер не заполнен"))
            return false;


        var number = int.Parse(playerNumberTextBox.Text);
        var playersInTeam = _playerRepository.GetArray(new PlayerFilter { TeamID = teamID });

        if (playersInTeam.Any(c => c.Number == number && (!id.HasValue || c.ID != id)))
        {
            MessageBox.Show("Введенный номер уже есть в данной команде");
            return false;
        }

        return true;
    }


    private void searchRoleComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _roleRepository.GetArray(new RoleFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void searchTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void playerNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBoxExtensions.OnlyDigits_TextBoxChange(e);
    }

    private void playerGettingButton_Click(object sender, EventArgs e)
    {

    }
}
