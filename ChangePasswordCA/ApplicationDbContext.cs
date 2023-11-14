using Microsoft.EntityFrameworkCore;

namespace ChangePasswordCA;

public class ApplicationDbContext : DbContext
{
    DbSet<PasswordChange> passwords { get; set; }

}
