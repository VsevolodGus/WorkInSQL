using Npgsql;
using System.Text;

namespace KursachMasha.DAL.Roles;
public class RoleRepository :
    SqlWorker<Role>
    , ISqlWorkerEntity<Role, RoleFilter>
{
    protected override string Table => "roles";

    public void Add(Role sponsor)
    {
        throw new NotImplementedException();
    }

    public Role[] GetArray(RoleFilter filter)
    {
        if (filter is null)
            filter = new RoleFilter();

        var stringBuilder = new StringBuilder($"SELECT " +
            $"r.id, r.name, r.description" +
            $"\r\n\tFROM public.{Table} r" +
            $"\r\n\twhere 1 = 1");

        if (!string.IsNullOrEmpty(filter.Search))
            stringBuilder.Append($"\nand name like '%{filter.Search}%'");

        stringBuilder.Append(';');
        var sql = stringBuilder.ToString();
        return ExecuteGetArrayQuery(sql);
    }

    public Role GetByID(int id)
    {
        var query = $"SELECT " +
            $"r.id, r.name, r.description" +
            $"\r\n\tFROM public.{Table} r" +
            $"\r\n\twhere r.id = {id}";

        return base.ExecuteGetQuery(query);
    }

    public void Update(Role sponsor)
    {
        throw new NotImplementedException();
    }

    protected override Role Map(NpgsqlDataReader reader)
    {
        return new Role() 
        {
            ID = reader.GetInt32(0),
            Name= reader.GetString(1),
            Description = reader.GetString(2)
        };
    }
}
