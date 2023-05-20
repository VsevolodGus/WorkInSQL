﻿using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Players;
public class PlayerRepository :
    SqlWorker<Player>
    , ISqlWorkerEntity<Player, PlayerFilter>
{
    public PlayerRepository() : base()
    { }

    protected override string Table => "players";

    public void Update(Player obj)
    {
        var query = $"update from {Table} " +
                        $"set " +
                        $"Name = {obj.Name}" +
                        $", team_id = {obj.TeamID}" +
                    $"where id = {obj.ID};";

        ExecuteQuery(query);
    }

    

    public void Add(Player obj)
    {
        var query = $"insert into {Table} (name, team_id)" +
            $"values ({obj.Name}, {obj.TeamID});";

        ExecuteQuery(query);
    }

    public Player[] GetArray(PlayerFilter filter)
    {
        if(filter is null)
            filter = new PlayerFilter();

        var stringBuilder = new StringBuilder($"SELECT " +
            $"p.id, p.name, p.surname, p.patronymic, p.number_in_team, p.team_id, p.role_id, t.name, r.name" +
            $"\r\n\tFROM public.players p" +
            $"\r\n\tINNER JOIN public.role_players r ON r.id = p.role_id" +
            $"\r\n\tINNER JOIN public.teams t ON t.id = p.team_id" +
            $"\r\n\twhere 1 = 1");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\nand name like '%{filter.Search}%'");

        if (filter.TeamID.HasValue)
            stringBuilder.Append($"\nand team_id = {filter.TeamID}");

        stringBuilder.Append(';');
        var sql = stringBuilder.ToString();
        return ExecuteGettingQuery(sql);
    }

    protected override Player Map(NpgsqlDataReader sqlDataReader)
    {
        return new Player()
        {
            ID = sqlDataReader.GetInt32(0),
            Name = sqlDataReader.GetString(1),
            Surname = sqlDataReader.GetString(2),
            Patronymic = sqlDataReader.GetString(3),
            Number = sqlDataReader.GetInt32(4),
            TeamID = sqlDataReader.GetInt32(5),
            RoleID= sqlDataReader.GetInt32(6),
            TeamName = sqlDataReader.GetString(7),
            RoleName = sqlDataReader.GetString(8),
        };
    }
}
