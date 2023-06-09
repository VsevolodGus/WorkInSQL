using KursachMasha.DAL.Classes;
using KursachMasha.DAL.Locations;
using KursachMasha.DAL.Players;
using KursachMasha.DAL.Queries;
using KursachMasha.DAL.Roles;
using KursachMasha.DAL.Sponsors;
using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;
using System.Globalization;

namespace KursachMasha;

public partial class Form1 : Form
{
    private readonly LoginForm _loginForm;

    private readonly PlayerRepository _playerRepository;
    private readonly TeamRepository _teamRepository;
    private readonly RoleRepository _roleRepository;
    private readonly SponsorRepository _sponsorRepository;
    private readonly StadiumRepository _stadiumRepository;
    private readonly LocationRepository _locationRepository;
    private readonly DataPlayersMatchesQuery _playersMatchesQuery;
    private readonly MatchRepository _matchRepository;

    public Form1(LoginForm loginForm)
    {
        _loginForm = loginForm;

        _playerRepository = new PlayerRepository();
        _teamRepository = new TeamRepository();
        _roleRepository = new RoleRepository();
        _sponsorRepository = new SponsorRepository();
        _stadiumRepository = new StadiumRepository();
        _locationRepository = new LocationRepository();
        _playersMatchesQuery = new DataPlayersMatchesQuery();
        _matchRepository = new MatchRepository();


        InitializeComponent();
        DateTimePickerMatch.Format = DateTimePickerFormat.Custom;
        DateTimePickerMatch.CustomFormat = "MM.dd.yyyy hh:mm:ss";

        if (!Global.CurrentUser.IsAdmin)
        {
            var buttons = this.Descendants<Button>().Where(c => !c.Name.ToLower().Contains("search")).ToArray();
            foreach (var button in buttons)
                button.Enabled = false;

            var textBoxes = this.Descendants<TextBox>().Where(c => !c.Name.ToLower().Contains("search")).ToArray();
            foreach (var textBox in textBoxes)
                textBox.Enabled = false;
        }

        tablePlayerCountMatchesDataGridView.Configuration<PlayerMatches>();

        tablePlayers.Configuration<Player>();
        FillingTablePlayers();

        tableSponsors.Configuration<Sponsor>();
        FillingTableSponsors();

        tableStadiums.Configuration<Stadium>();
        FillingTableStadiums();

        tableTeams.Configuration<Team>();
        FillingTableTeam();

        tableMatches.Configuration<Match>();
        FillingTableMatch();

        searchTeamComboBox.ValueMember = nameof(Team.ID);
        searchTeamComboBox.DisplayMember = nameof(Team.Name);

        teamIDPlayerComboBox.ValueMember = nameof(Team.ID);
        teamIDPlayerComboBox.DisplayMember = nameof(Team.Name);

        searchRoleComboBox.ValueMember = nameof(Role.ID);
        searchRoleComboBox.DisplayMember = nameof(Role.Name);
        roleIDPlayerComboBox.ValueMember = nameof(Role.ID);
        roleIDPlayerComboBox.DisplayMember = nameof(Role.Name);

        selectLocationComboBox.ValueMember = nameof(MyLocation.ID);
        selectLocationComboBox.DisplayMember = nameof(MyLocation.Name);

        sponsorIDTeamComboBox.ValueMember = nameof(Sponsor.ID);
        sponsorIDTeamComboBox.DisplayMember = nameof(Sponsor.Name);

        team1IDMatchComboBox.ValueMember = nameof(Team.ID);
        team1IDMatchComboBox.DisplayMember = nameof(Team.Name);

        team2IDMatchComboBox.ValueMember = nameof(Team.ID);
        team2IDMatchComboBox.DisplayMember = nameof(Team.Name);

        stadiumIDTeamComboBox.ValueMember = nameof(Stadium.ID);
        stadiumIDTeamComboBox.DisplayMember = nameof(Stadium.Name);

    }

    #region �����
    private void LogoutMenuStrip_Click(object sender, EventArgs e)
    {
        Global.CurrentUser = null;
        _loginForm.Show();
        this.Hide();
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Close();
    }

    private void onlyDigits_TextBoxChange(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
        {
            e.Handled = true;
        }
    }
    #endregion


    #region ������ � ��������
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
        #region ��������� ����� � �������
        playerNameTextBox.Text = string.Empty;
        playerSurnameTextBox.Text = string.Empty;
        playerPatronymicTetBox.Text = string.Empty;
        playerNumberTetBox.Text = string.Empty;

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
        playerPatronymicTetBox.Text = player.Patronymic;
        playerNumberTetBox.Text = player.Number.ToString();

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
        ShowMessageBoxIfTextEmpty(playerNameTextBox, "��� �� ���������");
        ShowMessageBoxIfTextEmpty(playerSurnameTextBox, "������� �� ���������");

        //TODO ������ �������� � ������������ ������ ��� ����������, ������-�� Select ���� �� �����������
        var teamID = (int)teamIDPlayerComboBox.SelectedValue;
        if (!IsCorrectNumber(teamID))
            return;

        var player = new Player()
        {
            Name = playerNameTextBox.Text,
            Surname = playerSurnameTextBox.Text,
            Patronymic = playerPatronymicTetBox.Text,
            Number = int.Parse(playerNumberTetBox.Text),
            TeamID = teamID,
            RoleID = (int)roleIDPlayerComboBox.SelectedValue,
        };

        _playerRepository.Add(player);

        ButtonGettingPlayers_Click(sender, e);
    }

    private void updatePlayerButton_Click(object sender, EventArgs e)
    {
        ShowMessageBoxIfTextEmpty(playerNameTextBox, "��� �� ���������");
        ShowMessageBoxIfTextEmpty(playerSurnameTextBox, "������� �� ���������");

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
            Patronymic = playerPatronymicTetBox.Text,
            Number = int.Parse(playerNumberTetBox.Text),
            TeamID = teamID,
            RoleID = roleID,
        };
        _playerRepository.Update(player);

        ButtonGettingPlayers_Click(sender, e);
    }

    private bool IsCorrectNumber(int teamID, int? id = null)
    {
        ShowMessageBoxIfTextEmpty(playerNameTextBox, "����� �� ��������");
        var number = int.Parse(playerNumberTetBox.Text);
        var playersInTeam = _playerRepository.GetArray(new PlayerFilter { TeamID = teamID });

        if (playersInTeam.Any(c => c.Number == number && (!id.HasValue || c.ID != id)))
        {
            MessageBox.Show("��������� ����� ��� ���� � ������ �������");
            return false;
        }

        return true;
    }
    #endregion


    #region ������ � ���������
    private void searchTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }
    #endregion


    #region ������ � ������
    private void searchRoleComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _roleRepository.GetArray(new RoleFilter()
        {
            Search = thisComboBox.Text,
        });
    }
    #endregion


    #region ������ �� ����������
    private void sponsorAddButton_Click(object sender, EventArgs e)
    {
        Sponsor sponsor = new Sponsor();
        sponsor.Name = sponsorNameTextBox.Text;
        sponsor.Description = descriptionNameTextBox.Text;

        _sponsorRepository.Add(sponsor);

        buttonGettingSponsors_Click(sender, e);
    }

    private void DeleteSponsors_Button_Click(object sender, EventArgs e)
    {
        tableSponsors.DeleteObject(_sponsorRepository);
        buttonGettingSponsors_Click(sender, e);
    }

    private void buttonGettingSponsors_Click(object sender, EventArgs e)
    {
        FillingTableSponsors(new SponsorFilter
        {
            Search = sponsorSearchTextBox.Text

        });
    }

    private void FillingTableSponsors(SponsorFilter filter = null)
    {
        tableSponsors.Rows.Clear();
        foreach (var sponsor in _sponsorRepository.GetArray(filter))

            tableSponsors.Rows.Add(sponsor.ID
                , sponsor.Name
                , sponsor.Description);
    }

    #endregion


    #region ������ �� ����������

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

    #endregion


    private void ShowMessageBoxIfTextEmpty(TextBox textBox, string messageBoxText)
    {
        if (string.IsNullOrEmpty(textBox.Text))
            MessageBox.Show(messageBoxText);
    }

    private void button3_Click(object sender, EventArgs e)
    {
        tablePlayerCountMatchesDataGridView.Rows.Clear();
        foreach (var player in _playersMatchesQuery.Execute())
            tablePlayerCountMatchesDataGridView.Rows.Add(player.ID
                , player.Name
                , player.Surname
                , player.Patronymic
                , player.CountMatches);
    }

    #region ������ � ���������

    private void FillingTableTeam(TeamFilter filter = null)
    {
        tableTeams.Rows.Clear();
        foreach (var team in _teamRepository.GetArray(filter))
            tableTeams.Rows.Add(team.ID
                , team.Name
                , team.SponsorID
                , team.SponsorName);
    }

    private void teamAddButton_Click(object sender, EventArgs e)
    {
        ShowMessageBoxIfTextEmpty(teamNameTextBox, "�������� �� ���������");
        // TODO ������� ���������� ��� ��������(��-�� ���������� ������ ���� ��� �������)


        var team = new Team()
        {
            Name = teamNameTextBox.Text,
            SponsorID = (int)sponsorIDTeamComboBox.SelectedValue,
        };

        _teamRepository.Add(team);

        teamGettingButton_Click(sender, e);
    }


    private void teamUpdateButton_Click(object sender, EventArgs e)
    {
        var id = (int)tableTeams.SelectedRows[0].Cells[0].Value;
        var oldTeam = _teamRepository.GetByID(id);

        int sponsorID = (int)(sponsorIDTeamComboBox.SelectedValue ?? oldTeam.SponsorID);

        if (!IsCorrectNumber(sponsorID, id))
            return;

        var team = new Team()
        {
            ID = id,
            Name = teamNameTextBox.Text,
            SponsorID = sponsorID,
        };
        _teamRepository.Update(team);

        teamGettingButton_Click(sender, e);
    }


    private void teamGettingButton_Click(object sender, EventArgs e)
    {
        FillingTableTeam(new TeamFilter
        {
            Search = teamSearchTextBox.Text
        });

    }

    private void teamDeleteButton_Click(object sender, EventArgs e)
    {
        tableTeams.DeleteObject(_teamRepository);
        teamGettingButton_Click(sender, e);
    }

    private void Delete_Button_Click(object sender, EventArgs e)
    {
        tableStadiums.DeleteObject(_stadiumRepository);
        buttonGettingStadiums_Click(sender, e);
    }
    #endregion


    private void sponsorIDTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _sponsorRepository.GetArray(new SponsorFilter()
        {
            Search = thisComboBox.Text,
        });
    }




    #region ������ c �������

    private void FillingTableMatch()
    {
        tableMatches.Rows.Clear();
        foreach (var match in _matchRepository.GetArray(null))
            tableMatches.Rows.Add(match.ID
                , match.DateTime
                , match.Team1ID
                , match.Team1Name
                , match.Team2ID
                , match.Team2Name
                , match.StadiumID
                , match.StadiumName
                , match.ResultTeam1
                , match.ResultTeam2);
    }
    private void matchAddButton_Click(object sender, EventArgs e)
    {
        //TODO ������� ���������� ��� �� ��������� ���-��
        var match = new Match()
        {
            DateTime = DateTimePickerMatch.Value,
            Team1ID = (int)team1IDMatchComboBox.SelectedValue,
            Team2ID = (int)team2IDMatchComboBox.SelectedValue,
            StadiumID = (int)stadiumIDTeamComboBox.SelectedValue,
            ResultTeam1 = int.Parse(resultTeam1TextBox.Text),
            ResultTeam2 = int.Parse(resultTeam2TextBox.Text),
        };

        _matchRepository.Add(match);

        matchGettingButton_Click(sender, e);
    }

    private void matchUpdateButton_Click(object sender, EventArgs e)
    {
        var id = (int)tableMatches.SelectedRows[0].Cells[0].Value;
        var oldMatch = _matchRepository.GetByID(id);

        int team1ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team1ID);
        int team2ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team2ID);
        int stadiumID = (int)(stadiumIDTeamComboBox.SelectedValue ?? oldMatch.StadiumID);

        var match = new Match()
        {
            ID = id,
            DateTime = DateTimePickerMatch.Value,
            Team1ID = team1ID,
            Team2ID = team2ID,
            StadiumID = stadiumID,
            ResultTeam1 = int.Parse(resultTeam1TextBox.Text),
            ResultTeam2 = int.Parse(resultTeam2TextBox.Text),
        };

        _matchRepository.Update(match);

        matchGettingButton_Click(sender, e);
    }

    private void matchDeleteButton_Click(object sender, EventArgs e)
    {
        tableMatches.DeleteObject(_matchRepository);
        matchGettingButton_Click(sender, e);
    }

    private void matchGettingButton_Click(object sender, EventArgs e)
    {
        FillingTableMatch();
    }

    private void team1IDMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void team2IDMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void stadiumIDTeamComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _stadiumRepository.GetArray(new StadiumFilter()
        {
            Search = thisComboBox.Text,
        });
    }
    #endregion



    /*  private void searchTeamComboBox_DropDown(object sender, EventArgs e)
      {
          var thisComboBox = sender as ComboBox;
          thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
          {
              Search = thisComboBox.Text,
          });
      }*/

    /*
     private void teamUpdateButton_Click(object sender, EventArgs e)
    {
        var id = (int)tableTeams.SelectedRows[0].Cells[0].Value;
        var oldTeam = _teamRepository.GetByID(id);

        int sponsorID = (int)();

        if (!IsCorrectNumber(sponsorID, id))
            return;

        var team = new Team()
        {
            ID = id,
            Name = teamNameTextBox.Text,
            SponsorID = sponsorID,
        };
        _teamRepository.Update(team);

        teamGettingButton_Click(sender, e);
    }


    private void teamGettingButton_Click(object sender, EventArgs e)
    {
        FillingTableTeam(new TeamFilter
        {
            Search = teamSearchTextBox.Text
        });

    }

    private void teamDeleteButton_Click(object sender, EventArgs e)
    {
        tableTeams.DeleteObject(_teamRepository);
        teamGettingButton_Click(sender, e);
    }

     
     */
}