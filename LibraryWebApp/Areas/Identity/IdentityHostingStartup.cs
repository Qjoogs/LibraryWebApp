using System;
using LibraryWebApp.Areas.Identity.Data;
using LibraryWebApp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LibraryWebApp.Areas.Identity.IdentityHostingStartup))]
namespace LibraryWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LibraryDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("LibraryDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<LibraryDBContext>();
            });
        }
    }
}