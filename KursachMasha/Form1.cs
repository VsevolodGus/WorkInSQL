using KursachMasha.DAL.Players;
using KursachMasha.DAL.Roles;
using KursachMasha.DAL.Sponsors;
using KursachMasha.DAL.Teams;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    private readonly PlayerRepository _playerRepository;
    private readonly TeamRepository _teamRepository;
    private readonly RoleRepository _roleRepository;
    private readonly SponsorRepository _sponsorRepository;


    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _playerRepository = new PlayerRepository();
        _teamRepository = new TeamRepository();
        _roleRepository = new RoleRepository();
        _sponsorRepository = new SponsorRepository();

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

        tableSponsors.Configuration<Sponsor>();
        FillingTableSponsors();

        searchTeamComboBox.ValueMember = nameof(Team.ID);
        searchTeamComboBox.DisplayMember = nameof(Team.Name);
        selectTeamPlayerComboBox.ValueMember = nameof(Team.ID);
        selectTeamPlayerComboBox.DisplayMember = nameof(Team.Name);

        searchRoleComboBox.ValueMember = nameof(Role.ID);
        searchRoleComboBox.DisplayMember = nameof(Role.Name);
        propertyPlayerRoleComboBox.ValueMember = nameof(Role.ID);
        propertyPlayerRoleComboBox.DisplayMember = nameof(Role.Name);
    }

    #region ќбщие
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

    #region Ћогика с юзерами
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

        //var asd = selectTeamPlayerComboBox.SelectedItem;
        //var qwe = selectTeamPlayerComboBox.SelectedValue;

        FillingTablePlayers(new PlayerFilter
        {
            Search = playerSearchTextBox.Text,
            TeamID = (int?)searchTeamComboBox.SelectedValue,
            RoleID = (int?)searchRoleComboBox.SelectedValue,
        });
    }

    private void playerNumberTextBox(object sender, KeyPressEventArgs e)
    {
        if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        {
            e.Handled = true;
        }
    }
    #endregion


    #region Ћогика с командами
    private void searchTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }
    #endregion


    #region Ћогика с рол€ми
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
        #region ќбнуление полей с данными
        playerNameTextBox.Text = string.Empty;
        playerSurnameTextBox.Text = string.Empty;
        playerPatronymicTetBox.Text = string.Empty;
        playerNumberTetBox.Text = string.Empty;

        selectTeamPlayerComboBox.SelectedItem = new object();
        selectTeamPlayerComboBox.SelectedValue = new object();
        selectTeamPlayerComboBox.Text = null;

        propertyPlayerRoleComboBox.SelectedItem = new object();
        propertyPlayerRoleComboBox.SelectedValue = new object();
        propertyPlayerRoleComboBox.Text = null;
        #endregion

        if (e.StateChanged != DataGridViewElementStates.Selected)
            return;

        var row = tablePlayers.Rows[e.Row.Index];

        var player = _playerRepository.GetByID((int)row.Cells[0].Value);
        playerNameTextBox.Text = player.Name;
        playerSurnameTextBox.Text = player.Surname;
        playerPatronymicTetBox.Text = player.Patronymic;
        playerNumberTetBox.Text = player.Number.ToString();

        var team = _teamRepository.GetByID(player.TeamID);
        selectTeamPlayerComboBox.SelectedItem = team;
        selectTeamPlayerComboBox.SelectedValue = team.ID;
        selectTeamPlayerComboBox.SelectedText = team.Name;

        var role = _roleRepository.GetByID(player.RoleID);
        propertyPlayerRoleComboBox.SelectedItem = role;
        propertyPlayerRoleComboBox.SelectedValue = role.ID;
        propertyPlayerRoleComboBox.SelectedText = role.Name;
    }

    private void playerAddButton_Click(object sender, EventArgs e)
    {

        Player player = new Player();
        player.Name = playerNameTextBox.Text;
        player.Surname = playerSurnameTextBox.Text;
        player.Patronymic = playerPatronymicTetBox.Text;
        player.Number = int.Parse(playerNumberTetBox.Text);
        player.TeamID = (int)selectTeamPlayerComboBox.SelectedValue;
        player.RoleID = (int)propertyPlayerRoleComboBox.SelectedValue;

        _playerRepository.Add(player); ;

        ButtonGettingPlayers_Click(sender, e);

        //Ќужно сделать добавление игрока
        //1) нужно собрать€ из полей модельку
        //  1.1) ѕолучить все пол€ из TextBox-ов
        //  1.1) ѕолучить ID роли и команды(смотри как работает получение игроков с фильтрацией)
        //2) написать скрипт в репозитории дл€ добавлени€ 
        //  2.1) определитьс€ с пол€ми, какие пол€ нужны, см.Ќастройки полей в Ѕƒ
        //  2.2) написать и протестировать в pgAdmin
        //  2.3) внедрить в репозиторий, сделать так чтобы добавл€емые пол€ могли динамически измен€тьс€ в строке, а не были статично захордкожены
        //3) нужно будет сделать проверки на корректноcть
        //  3.1) им€ не может быть пустой или null
        //  3.2) фамили€ не может быть пустой или null
        //  3.3) номер в команде должен быть уникальным
        //  3.4) игрок не может быть без роль и команды 
    }

    #region Ћогика со спонсорами
    private void FillingTableSponsors(SponsorFilter filter = null)
    {
        tableSponsors.Rows.Clear();
        foreach (var sponsor in _sponsorRepository.GetArray(filter))

            tableSponsors.Rows.Add(sponsor.ID
                , sponsor.Name
                , sponsor.Description);
    }


    private void sposorAddButton_Click(object sender, EventArgs e)
    {
        Sponsor sponsor = new Sponsor();
        sponsor.Name = sponsorNameTextBox.Text;
        sponsor.Description = descriptionNameTextBox.Text;

        _sponsorRepository.Add(sponsor);

        buttonGettingSponsors_Click(sender, e);
    }

    private void buttonGettingSponsors_Click(object sender, EventArgs e)
    {
        FillingTableSponsors(new SponsorFilter
        {
            Search = sponsorSearchTextBox.Text

        });
    }
    #endregion

    private void DeleteSponsors_Button_Click(object sender, EventArgs e)
    {
        tableSponsors.DeleteObject(_sponsorRepository);
        buttonGettingSponsors_Click(sender, e);
    }
}
