using Kursach.DAL.Queries;
using Kursach.Extensions;
using static Kursach.DAL.Queries.GetNoReservePlayersTeamQuery;

namespace Kursach;

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
