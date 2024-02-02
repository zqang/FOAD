namespace FOAD.Infrastructure.Data;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IUnitOfWork
{
    public DbSet<TodoList> TodoLists { get; set; }

    public DbSet<TodoItem> TodoItems { get; set; }

    public DbSet<Order> Orders { get; set; }
    //public DbSet<PaymentMethod> Payments { get; set; }
    //public DbSet<Buyer> Buyers { get; set; }
    //public DbSet<CardType> CardTypes { get; set; }
    public DbSet<OrderStatus> OrderStatus { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }

    public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        await base.SaveChangesAsync(cancellationToken);

        return true;
    }
}
