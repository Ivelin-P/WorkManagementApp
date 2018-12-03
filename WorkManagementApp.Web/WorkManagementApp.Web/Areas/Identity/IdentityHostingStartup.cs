using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorkManagementApp.Web.Areas.Identity.Data;
using WorkManagementApp.Web.Models;

[assembly: HostingStartup(typeof(WorkManagementApp.Web.Areas.Identity.IdentityHostingStartup))]
namespace WorkManagementApp.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}