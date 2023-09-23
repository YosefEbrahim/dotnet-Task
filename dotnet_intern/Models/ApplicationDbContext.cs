using dotnet_task;
using Microsoft.EntityFrameworkCore;
namespace dotnet_intern.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<ProgramDetails> ProgramDetails { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<Cover> Covers { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Qeustion> Qeustions { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Choises> Choises { get; set; }
        public DbSet<WorkFlow> WorkFlows { get; set; }
        public DbSet<StageDetails> StageDetails { get; set; }

    }
}
