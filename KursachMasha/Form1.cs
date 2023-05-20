using KursachMasha.DAL;
using KursachMasha.DAL.Players;
using KursachMasha.DAL.Teams;
using System.Windows.Forms;

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

        tablePlayers.ConfigColumns<Player>();
        FillingTablePlayers();

        searchTeamComboBox.ValueMember = nameof(Team.ID);
        searchTeamComboBox.DisplayMember = nameof(Team.Name);
        SelectTeamPlayerComboBox.ValueMember = nameof(Team.ID);
        SelectTeamPlayerComboBox.DisplayMember = nameof(Team.Name);
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
        _loginForm.Close();
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
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void DeletePlayers_Click(object sender, EventArgs e)
    {
        DeleteObject(tablePlayers, _playerRepository);
        //var countDeletePlayers = tablePlayers.SelectedRows.Count;
        //var playersID = new List<int>(countDeletePlayers);
        //for (int i = 0; i < countDeletePlayers; i++)
        //{
        //    var playerID = (int)tablePlayers.SelectedRows[i].Cells[0].Value;
        //    playersID.Add(playerID);
        //}

        //_playerRepository.Delete(playersID.ToArray());
        ButtonGettingPlayers_Click(sender, e);
    }

    #endregion
    private void DeleteObject<T>(DataGridView dataGriedView, ISqlWorkerEntityManipulation<T> repository) 
        where T : class
    {
        var countDeletePlayers = dataGriedView.SelectedRows.Count;
        var playersID = new List<int>(countDeletePlayers);
        for (int i = 0; i < countDeletePlayers; i++)
        {
            var playerID = (int)dataGriedView.SelectedRows[i].Cells[0].Value;
            playersID.Add(playerID);
        }

        repository.Delete(playersID.ToArray());
    }






    private void searchTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
