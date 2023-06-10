using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachMasha.DAL.Queries
{
    public class GetNoReservePlayersTeamQuery
    {
        private readonly DataBaseProvider provider;
        public GetNoReservePlayersTeamQuery()
        {
            provider = new DataBaseProvider();
        }
        public NoReservePlayersTeam[] Execute()
        {
            var query = "select " +
                "\r\n\tt.id" +
                 "\r\n\t, t.name" +
                 "\r\nfrom teams t " +
                  "\r\nwhere t.id IN " +
                  "\r\n\t( select team_id" +
                  "\r\n\tfrom players p" +
                  "\r\n\tinner join roles r ON r.id = p.role_id" +
                  "\r\n\twhere role_id <> 2 AND r.name <> 'тренер')";

            
            provider.SqlConnection.Open();
            var reader = new NpgsqlCommand(query, provider.SqlConnection).ExecuteReader();

            var result = new List<NoReservePlayersTeam>();
            while (reader.Read())
            {
                result.Add(new NoReservePlayersTeam
                {
                    ID = reader.GetInt32(0),
                    TeamName = reader.GetString(1)
                });
            }

            reader.Close();
            provider.SqlConnection.Close();

            return result.ToArray();
        }

        public class NoReservePlayersTeam
        {
            public int ID { get; init; }

            [ColumnHeadr("Имя")]
            public string TeamName { get; set; }
        }
    }

}

