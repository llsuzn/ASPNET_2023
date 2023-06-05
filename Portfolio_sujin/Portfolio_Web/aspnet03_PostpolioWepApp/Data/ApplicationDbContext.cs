using aspnet02_boardapp.Models;
using aspnet03_PortfolioWepApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace aspnet02_boardapp.Data
{
    public class ApplicationDbContext : IdentityDbContext       // 1. ASP.NET Identity : DbContext -> IdentityContext ... 결국 DbContext 쓰는 것과 같음
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Board> Boards { get; set; }
        
        // 포트폴리오를 DB로 관리하기 위한 모델
        public DbSet<PortfolioModel> Portfolios { get; set; }
    }
}
