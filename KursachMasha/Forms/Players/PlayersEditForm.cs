using Kursach.DAL.Players;
using Kursach.DAL.Roles;
using Kursach.DAL.Teams;
using Kursach.Extensions;

namespace Kursach;
public partial class PlayersEditForm : Form
{

    private readonly bool _isAdd;
    private readonly Player _currentPlayer;
    private readonly PlayersForm _parentForm;
    private readonly PlayerRepository _playerRepository;
    private readonly TeamRepository _teamRepository;
    private readonly RoleRepository _roleRepository;


    public PlayersEditForm(PlayersForm parentForm, int? id, bool isAdd)
    {
        InitializeComponent();

        _isAdd = isAdd;
        _parentForm = parentForm;
        _playerRepository = new PlayerRepository();
        _teamRepository = new TeamRepository();
        _roleRepository = new RoleRepository();

        if (id.HasValue)
            _currentPlayer = _playerRepository.GetByID(id.Value);
        else
            _currentPlayer = new Player();

        playerNameTextBox.Text = _currentPlayer.Name;
        playerSurnameTextBox.Text = _currentPlayer.Surname;
        playerPatronymicTextBox.Text = _currentPlayer.Patronymic;
        playerNumberTextBox.Text = _currentPlayer.Number.ToString();

        teamIDPlayerComboBox.ValueMember = nameof(Team.ID);
        teamIDPlayerComboBox.DisplayMember = nameof(Team.Name);
        var teams = _teamRepository.GetArray(null);
        teamIDPlayerComboBox.DataSource = teams;
        teamIDPlayerComboBox.SelectedItem = teams.FirstOrDefault(c => c.ID == _currentPlayer.TeamID);


        roleIDPlayerComboBox.ValueMember = nameof(Role.ID);
        roleIDPlayerComboBox.DisplayMember = nameof(Role.Name);
        var roles = _roleRepository.GetArray(null);
        roleIDPlayerComboBox.DataSource = roles;
        roleIDPlayerComboBox.SelectedItem = roles.FirstOrDefault(c => c.ID == _currentPlayer.RoleID);

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (_isAdd)
            Add();
        else
            Update();

        _parentForm.ButtonGettingPlayers_Click(sender, e);
        this.Close();
    }



    private void Add()
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
    }

    private void Update()
    {
        if (!playerNameTextBox.ShowMessageBoxIfNoCorrect("Имя не заполнено")
                || !playerSurnameTextBox.ShowMessageBoxIfNoCorrect("Фамилия не заполнено"))
            return;

        var id = _currentPlayer.ID;
        var oldPlayer = _playerRepository.GetByID(id);

        int teamID = (int)(teamIDPlayerComboBox.SelectedValue ?? oldPlayer.TeamID);
        int roleID = (int)(roleIDPlayerComboBox.SelectedValue ?? oldPlayer.RoleID);

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

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        _parentForm.Show();
        Hide();
    }

    private void playerNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBoxExtensions.OnlyDigits_TextBoxChange(e);
    }
}
