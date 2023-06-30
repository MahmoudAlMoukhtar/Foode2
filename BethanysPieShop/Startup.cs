using BethanysPieShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

namespace BethanysPieShop
{
    public class Startup
    {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)            
        {
            services.AddDbContext<ProductsShopDbContext>(options => {
                options.UseSqlServer(

                    Configuration.GetConnectionString("ProductsShopDbContextConnection"));
            });
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<ProductsShopDbContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICartItemsRepository, CartItemsRepository>(sp=>CartItemsRepository.GetCart(sp));
            services.AddSession();
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();


            services.AddHttpContextAccessor();
            services.AddRazorPages();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            };
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            DbInitializer.Seed(app);
            app.UseEndpoints(endpoints =>
            {
                // Map controller routes
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "ProductDetail",
                    pattern: "product/{id}",
                    defaults: new { controller = "Product", action = "Detail" }
                );
                endpoints.MapControllerRoute(
                    name: "add-to-cart",
                    pattern: "cart/add/{id}",
                    defaults: new { controller = "Cart", action = "AddToCart" });

                // Map Razor Pages routes (if you are using Razor Pages)
                endpoints.MapRazorPages();

                // Map Blazor Hub routes (if you are using Blazor)
                //endpoints.MapBlazorHub();

                // Map fallback routes
                endpoints.MapFallbackToPage("/app/{*catchall}", "/App/Index");
                endpoints.MapFallbackToFile("/app/{*path:nonfile}", "App/Index.html");
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
