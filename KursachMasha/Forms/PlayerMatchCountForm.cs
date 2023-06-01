using KursachMasha.DAL.Queries;
using KursachMasha.Extensions;

namespace KursachMasha.Forms;
public partial class PlayerMatchCountForm : Form
{
    private readonly DataPlayersMatchesQuery _playersMatchesQuery;

    public PlayerMatchCountForm()
    {
        InitializeComponent();
    
        _playersMatchesQuery = new DataPlayersMatchesQuery();

        tablePlayerCountMatchesDataGridView.Configuration<PlayerMatches>();
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
}
