using Microsoft.EntityFrameworkCore;
using WorkoutTrackerWeb.Models;

namespace WorkoutTrackerWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Strength> Strengths { get; set; }
        public DbSet<Cardio> Cardios { get; set; }
    }
}
