using ESFCustomersData.Data;
using ESFCustomersData.Repositories;
using ESFCustomersData.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;

namespace BlazorApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            // builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddDbContext<CustomersDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddHttpClient();
            builder.Services.AddSyncfusionBlazor();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt/QHRqVVhjVFpFdEBBXHxAd1p/VWJYdVt5flBPcDwsT3RfQF5jSHxQdk1gW3xdcX1SQA==;Mgo+DSMBPh8sVXJ0S0J+XE9HflRDX3xKf0x/TGpQb19xflBPallYVBYiSV9jS31Td0dgWXddcndWRGFVUA==;ORg4AjUWIQA/Gnt2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhWn9Wc3ZWRWJfUkU=;OTg5MjgyQDMyMzAyZTM0MmUzMEh4eHZHYTBUR3RJZHB5UWdyKzBQSUpFQXNBNW05Q2lES295Q1RsUDVrQTA9;OTg5Mjg1QDMyMzAyZTM0MmUzMEx0WWNFQ2wwem1iT1RUNU1FNjBwSUJ6ZWZIRHUzNnBBc1djc2NVamFLYWs9;NRAiBiAaIQQuGjN/V0Z+WE9EaFxKVmJLYVB3WmpQdldgdVRMZVVbQX9PIiBoS35RdUViW3xeeHdXRWNYU010;OTg5Mjg3QDMyMzAyZTM0MmUzMFpQTzdMcWxSMUtFdEZRYU5IMDBFM1Z2OVBXbEE4NkpCaGZydEg1Y1hBMXM9;OTg5Mjg4QDMyMzAyZTM0MmUzMGJLeVNtaGMzTHRUZThyUEgvQWFLbzMydG8zWUhPUDdTcjZqZFk3S0pJc289;Mgo+DSMBMAY9C3t2VVhkQlFadVdJXGFWfVJpTGpQdk5xdV9DaVZUTWY/P1ZhSXxQdkRhWn9Wc3ZWRWRVVUY=;OTg5MjkxQDMyMzAyZTM0MmUzMEJVSEl5UzNvbU5ibU40OUdROHlCWnpBYnRORm1QWXRScXNLUXFEckx2Kzg9;OTg5MjkyQDMyMzAyZTM0MmUzMG5IdXNHNzJlVEVEMGEzc0xLY2JFdnRNelVUODBkMWQrcnRwNGIwVGdhZUE9;OTg5MjkzQDMyMzAyZTM0MmUzMFpQTzdMcWxSMUtFdEZRYU5IMDBFM1Z2OVBXbEE4NkpCaGZydEg1Y1hBMXM9");
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();
            app.MapControllers();
            app.MapDefaultControllerRoute();
            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}