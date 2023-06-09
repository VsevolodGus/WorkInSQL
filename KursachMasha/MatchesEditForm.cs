using KursachMasha.DAL.Classes;
using KursachMasha.DAL.Stadiums;
using KursachMasha.DAL.Teams;
using KursachMasha.Extensions;
using KursachMasha.Forms;

namespace KursachMasha;
public partial class MatchesEditForm : Form
{
    private readonly bool _isAdd;
    private readonly Match _currentMath;
    private readonly MatchesForm _parentForm;
    private readonly TeamRepository _teamRepository;
    private readonly MatchRepository _matchRepository;
    private readonly StadiumRepository _stadiumRepository;
    public MatchesEditForm(MatchesForm parentForm, int? id, bool isAdd)
    {
        InitializeComponent();


        _isAdd = isAdd;
        _parentForm = parentForm;
        _teamRepository = new TeamRepository();
        _matchRepository = new MatchRepository();
        _stadiumRepository = new StadiumRepository();

        



        if (id.HasValue)
        {
            _currentMath = _matchRepository.GetByID(id.Value);
        }
        else
        {
            _currentMath = new Match();
        }

        DateTimePickerMatch.Value = _currentMath.DateTime;
        resultTeam1TextBox.Text = _currentMath.ResultTeam1.ToString();
        resultTeam2TextBox.Text = _currentMath.ResultTeam2.ToString();

        var teams = _teamRepository.GetArray(null);

        team1IDMatchComboBox.ValueMember = nameof(Team.ID);
        team1IDMatchComboBox.DisplayMember = nameof(Team.Name);
        team1IDMatchComboBox.DataSource = teams;
        team1IDMatchComboBox.SelectedItem = teams.FirstOrDefault(c=> c.ID == _currentMath.Team1ID);

        team2IDMatchComboBox.ValueMember = nameof(Team.ID);
        team2IDMatchComboBox.DisplayMember = nameof(Team.Name);
        team2IDMatchComboBox.DataSource = teams;
        team2IDMatchComboBox.SelectedItem = teams.FirstOrDefault(c => c.ID == _currentMath.Team2ID);


        stadiumIDComboBox.ValueMember = nameof(Stadium.ID);
        stadiumIDComboBox.DisplayMember = nameof(Stadium.Name);
        var stadiums = _stadiumRepository.GetArray(null);
        stadiumIDComboBox.DataSource = stadiums;
        stadiumIDComboBox.SelectedItem = stadiums.FirstOrDefault(c=> c.ID == _currentMath.StadiumID);



    }
    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        _parentForm.Show();
        Hide();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (_isAdd)
            Add();
        else
            Update();

        _parentForm.matchGettingButton_Click(sender, e);
        Close();
    }

    private void Add()
    {
        if (!IsSelectValue(team1IDMatchComboBox, "Не выбрана первая команда")
            || !IsSelectValue(team2IDMatchComboBox, "Не выбрана вторая команда")
            || !IsSelectValue(stadiumIDComboBox, "Не выбран стадион"))
        {
            return;
        }

        var match = new Match()
        {
            DateTime = DateTimePickerMatch.Value,
            Team1ID = (int)team1IDMatchComboBox.SelectedValue,
            Team2ID = (int)team2IDMatchComboBox.SelectedValue,
            StadiumID = (int)stadiumIDComboBox.SelectedValue,
            ResultTeam1 = string.IsNullOrEmpty(resultTeam1TextBox.Text) ? null : int.Parse(resultTeam1TextBox.Text),
            ResultTeam2 = string.IsNullOrEmpty(resultTeam2TextBox.Text) ? null : int.Parse(resultTeam2TextBox.Text),
        };

        _matchRepository.Add(match);
    }

    private void Update()
    {
        var id = _currentMath.ID;
        var oldMatch = _matchRepository.GetByID(id);

        int team1ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team1ID);
        int team2ID = (int)(team1IDMatchComboBox.SelectedValue ?? oldMatch.Team2ID);
        int stadiumID = (int)(stadiumIDComboBox.SelectedValue ?? oldMatch.StadiumID);

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
    }

    private bool IsSelectValue(ComboBox comboBox, string message)
    {
        if (comboBox.SelectedValue is not null)
            return true;

        MessageBox.Show(message);
        return false;
    }

    private void teamMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _teamRepository.GetArray(new TeamFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void stadiumMatchComboBox_DropDown(object sender, EventArgs e)
    {
        var thisComboBox = sender as ComboBox;
        thisComboBox.DataSource = _stadiumRepository.GetArray(new StadiumFilter()
        {
            Search = thisComboBox.Text,
        });
    }

    private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        TextBoxExtensions.OnlyDigits_TextBoxChange(e);
    }
}
