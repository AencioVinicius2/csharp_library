using Microsoft.EntityFrameworkCore;

namespace webApidotnet.Data {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) {

        }

    }
}
