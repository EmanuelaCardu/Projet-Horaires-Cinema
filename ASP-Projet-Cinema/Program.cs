using Shared_Projet_Cinema.Repositories;
using BLL = BLL_Projet_Cinema;
using DAL =DAL_Projet_Cinema;

namespace ASP_Projet_Cinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IMovieRepository<BLL.Entities.Movie>, BLL.Services.MovieService>();
            builder.Services.AddScoped<IMovieRepository<DAL.Entities.Movie>, DAL.Services.MovieService>();
            builder.Services.AddScoped<ICinemaPlaceRepository<BLL.Entities.CinemaPlace>, BLL.Services.CinemaPlaceService>();
            builder.Services.AddScoped<ICinemaPlaceRepository<DAL.Entities.CinemaPlace>, DAL.Services.CinemaPlaceService>();
            builder.Services.AddScoped<IDiffusionRepository<BLL.Entities.Diffusion>, BLL.Services.DiffusionService>();
            builder.Services.AddScoped<IDiffusionRepository<DAL.Entities.Diffusion>, DAL.Services.DiffusionService>();
            builder.Services.AddScoped<ICinemaRoomRepository<BLL.Entities.CinemaRoom>, BLL.Services.CinemaRoomService>();
            builder.Services.AddScoped<ICinemaRoomRepository<DAL.Entities.CinemaRoom>, DAL.Services.CinemaRoomService>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}