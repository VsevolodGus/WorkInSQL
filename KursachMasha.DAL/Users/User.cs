using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachMasha.DAL.Users;
internal class User
{
    public Guid ID { get; init; }

    public string Login { get; set; }
    public string Password { get; set; }

    public bool IsAdmin { get; set; }
}
