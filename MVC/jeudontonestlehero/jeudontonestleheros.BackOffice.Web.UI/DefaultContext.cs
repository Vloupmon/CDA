using jeudontonestleheros.Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace jeudontonestleheros.BackOffice.Web.UI {

    public class DefaultContext : DbContext {

        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options) {
        }

        public DbSet<Adventure> Adventures { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Response> Responses { get; set; }
    }
}