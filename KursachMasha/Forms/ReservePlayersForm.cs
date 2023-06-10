using KursachMasha.DAL.Queries;
using KursachMasha.Extensions;
using static KursachMasha.DAL.Queries.GetNoReservePlayersTeamQuery;

namespace KursachMasha;

public partial class ReservePlayersForm : Form
{
    private readonly GetNoReservePlayersTeamQuery _noReservePlayersTeam;
    public ReservePlayersForm()
    {
        InitializeComponent();
        _noReservePlayersTeam = new GetNoReservePlayersTeamQuery();
        tableNoReservePlayersTeamDataGridView.Configuration<NoReservePlayersTeam>();
    }

    private void GetReservePlayersButton_Click(object sender, EventArgs e)
    {
        tableNoReservePlayersTeamDataGridView.Rows.Clear();

        foreach (var team in _noReservePlayersTeam.Execute())
            tableNoReservePlayersTeamDataGridView.Rows.Add(team.ID
                , team.TeamName);
    }
}
