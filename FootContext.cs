using Microsoft.EntityFrameworkCore;
namespace eframework;
using eframework.Models;

public class FootContext: DbContext
{
    // public DbSet<Club>Clubes {get;set;}
    public DbSet<Player>Players {get;set;}
    // public DbSet<NFT>NFTs {get;set;}
    public FootContext(DbContextOptions<FootContext>options):base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Player>playerInit = new List<Player>();
        playerInit.Add(new Player(){
            PlayerId = Guid.Parse("e2411a88-eb28-4ea5-a220-85d5e2d4fa71"),
            Name = "Juan ",
            LastName = "Foyd",
            Age = 24,
            Position = "LD",
            LastClub = "Tottenham Hotspur Football Club",
            CurrentClub = "Villarreal C.F. ",
            Image = "https://assets.laliga.com/squad/2022/t449/p234908/2048x2048/p234908_t449_2022_0_003_000.png"
        });
        modelBuilder.Entity<Player>(player =>
        {
            player.ToTable("Player");
            player.HasKey(p => p.PlayerId);

            player.Property(p=> p.Name).IsRequired().HasMaxLength(200);
            player.Property(p=> p.LastName).IsRequired().HasMaxLength(200);
            player.Property(p=> p.Age).IsRequired();
            player.Property(p=> p.Position).IsRequired();
            player.Property(p=> p.LastClub).IsRequired();
            player.Property(p=> p.CurrentClub).IsRequired();
            player.Property(p=> p.Image);

        });
    }
}