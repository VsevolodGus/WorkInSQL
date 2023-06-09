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

        searchRoleComboBox.ValueMember = nameof(Role.ID);
        searchRoleComboBox.DisplayMember = nameof(Role.Name);


        if (!Global.CurrentUser.IsAdmin)
        {
            playerAddButton.Enabled = false;
            playerDeleteButton.Enabled = false;
            playerUpdateButton.Enabled = false;
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

    public void ButtonGettingPlayers_Click(object sender, EventArgs e)
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

    private void addPlayerButton_Click(object sender, EventArgs e)
    {
        var currentID = (int?)(tablePlayers.SelectedRows.Count != 0
                            ? tablePlayers.SelectedRows[0].Cells[0].Value
                            : null);

        new PlayersEditForm(this, currentID, true).Show();
        Hide();

    }

    private void updatePlayerButton_Click(object sender, EventArgs e)
    {
        if (tablePlayers.SelectedRows.Count == 0)
        {
            MessageBox.Show("Не был выбран элемент для обновления");
            return;
        }

        new PlayersEditForm(this, (int?)tablePlayers.SelectedRows[0].Cells[0].Value, false).Show();
        Hide();
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
