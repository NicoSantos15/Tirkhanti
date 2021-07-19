using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tirkhanti_R12.Data;
using Tirkhanti_R12.Models;
 

[assembly: HostingStartup(typeof(Tirkhanti_R12.Areas.Identity.IdentityHostingStartup))]
namespace Tirkhanti_R12.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Tirkhanti_R12Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Tirkhanti_R12ContextConnection")));
                services.AddDefaultIdentity<Tirkhanti_R12Users>(options =>
                { 
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<Tirkhanti_R12Context>();

            });

        }
    }
}