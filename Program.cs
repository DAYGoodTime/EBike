using EBike.DBContext;
using EBike.Services.IServices;
using EBike.Services.ServicesImp;
//using EBike.Services.ServeicesImpl;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace EBike
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            // add DbContext
            builder.Services.AddDbContext<EBikeContext>(opt =>
            {
                string connStr = builder.Configuration.GetConnectionString("MySQLConnection");
                var ver = ServerVersion.AutoDetect(connStr);
                opt.UseMySql(connStr, ver);
            });

            //Add Serverices
            //builder.Services.AddScoped<AdminUserService>();
            builder.Services.AddScoped<IUserService,UserService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}