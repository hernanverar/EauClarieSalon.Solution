using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models;
{
public class HairSalonContextModel
    {
    public dbSet<Client> Clients { get; set; }
    public DbSet<Stylist> Stylists { get; set; }

    public HairSalonContextModel(DbContextOptions options) : base(options) { }
    }
}
