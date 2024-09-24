using template_net_9.Entities;
using template_net_9.Entities.Curencies;
using template_net_9.Entities.Employees;
using template_net_9.Entities.Permissions;
using template_net_9.Entities.Projects;
using template_net_9.Entities.Tickets;
using template_net_9.Entities.Timetrack;
using template_net_9.Entities.Updates;
using template_net_9.Entities.Users;
using template_net_9.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace template_net_9
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<LegacyUser>().Property(l => l.Id)
                .HasIdentityOptions(startValue: 1270);
            builder.Entity<Employee>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 558);
            builder.Entity<Provider>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 168);
            builder.Entity<BusinessUnit>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 25);
            builder.Entity<PeriodUpdate>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 1432);
            builder.Entity<Company>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 392);
            builder.Entity<Account>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 495);
            builder.Entity<Proposal>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 3165);
            builder.Entity<Project>().Property(l => l.Id)
            .HasIdentityOptions(startValue: 1567);
            builder.Entity<TimetrackItem>().Property(l => l.Id)
              .HasIdentityOptions(startValue: 275223);
            builder.Entity<ProjectLegacyUser>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 8408);
            builder.Entity<Tasktype>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 20);
            builder.Entity<Group>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 16);
            builder.Entity<Permission>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 69);
            builder.Entity<GroupPermission>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 282);
            builder.Entity<GroupLegacyUser>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 1304);
            builder.Entity<LegacyUpdate>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 14061);
            builder.Entity<UpdateType>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 31);
            builder.Entity<Currency>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 6);
            builder.Entity<Position>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 23);
            builder.Entity<BasicUpdate>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 518);
            builder.Entity<MonetaryUpdate>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 9310);
            builder.Entity<ResignationUpdate>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 60);
            builder.Entity<WorkAccidentUpdate>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 3);
            builder.Entity<DateChangeUpdate>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 238);
            builder.Entity<City>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 37);
            builder.Entity<Country>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 250);
            builder.Entity<MedicalCoverage>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 6);
            builder.Entity<CurrencyExchange>().Property(l => l.Id)
             .HasIdentityOptions(startValue: 1259);

            builder.Entity<LegacyUser>()
                .HasMany(u => u.AssignedTickets)
                .WithMany(u => u.Assignees)
                .UsingEntity(j => j.ToTable("TicketAssignees"));

            builder.Entity<LegacyUser>()
                .HasMany(u => u.FollowedTickets)
                .WithMany(u => u.Followers)
                .UsingEntity(j => j.ToTable("TicketFollowers"));

            builder.Entity<LegacyUser>()
                .HasMany(u => u.RequestedTickets)
                .WithOne(u => u.Requester)
                .HasForeignKey(u => u.RequesterId);

            builder.Entity<Ticket>()
                .HasMany(p => p.Messages)
                .WithOne(c => c.Ticket)
                .OnDelete(DeleteBehavior.Cascade);

            foreach (var entity in builder.Model.GetEntityTypes())
            {
              foreach (var property in entity.GetProperties())
              {
                if (property.ClrType == typeof(DateTime))
                {
                  property.SetValueConverter(new DateTimeToDateTimeOffsetConverter());
                }
              }
            }
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<BasicUpdate> BasicUpdates { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyExchange> CurrenciesExchanges { get; set; }
        public DbSet<DateChangeUpdate> DateChangeUpdates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupLegacyUser> GroupsLegacyUsers { get; set; }
        public DbSet<GroupPermission> GroupsPermissions { get; set; }
        public DbSet<IndirectCost> IndirectCosts { get; set; }
        public DbSet<LegacyUser> LegacyUsers { get; set; }
        public DbSet<LegacyUpdate> LegacyUpdates { get; set; }
        public DbSet<MedicalCoverage> MedicalCoverages { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MonetaryUpdate> MonetaryUpdates { get; set; }
        public DbSet<PeriodUpdate> PeriodUpdates { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectIncomes> ProjectIncomes { get; set; }
        public DbSet<ProjectLegacyUser> ProjectsLegacyUsers { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ResignationUpdate> ResignationUpdates { get; set; }
        public DbSet<SOWContract> SOWContracts { get; set; }
        public DbSet<StructureUpdate> StructureUpdates { get; set; }
        public DbSet<Tasktype> Tasktypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TimetrackItem> TimetrackItems { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<UpdateType> UpdateTypes { get; set; }
        public DbSet<WorkAccidentUpdate> WorkAccidentUpdates { get; set; }
    }
}
