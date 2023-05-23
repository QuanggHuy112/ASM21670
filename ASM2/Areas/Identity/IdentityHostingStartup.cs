using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASM2.Areas.Identity.Data;
using ASM2.Data;
using ASM2.Models;

[assembly: HostingStartup(typeof(ASM2.Areas.Identity.IdentityHostingStartup))]
namespace ASM2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddIdentity<User, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
                    .AddDefaultUI()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

                services.AddScoped<IUserClaimsPrincipalFactory<User>,
                    ApplicationUserClaimsPrincipalFactory
                    >();
            });
        }
    }
    
}

