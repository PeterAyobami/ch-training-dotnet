using Microsoft.EntityFrameworkCore;

namespace Luigis.Web.Server
{
    /// <summary>
    /// The database representational model
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// The subscribers table
        /// </summary>
        public DbSet<SubscribersDataModel> Subscribers { get; set; }

        /// <summary>
        /// The messages table
        /// </summary>
        public DbSet<MessagesDataModel> Messages { get; set; }
    }
}
