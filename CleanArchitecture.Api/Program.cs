using CleanArchitecture.Api.Nucleo.Application.Services;
using CleanArchitecture.Api.Nucleo.Core.Interfaces;
using CleanArchitecture.Api.Nucleo.Infrastructure.Persistence;
using CleanArchitecture.Api.Nucleo.Infrastructure.Repositories;

namespace CleanArchitecture.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<MeuContextoEmMemoria>();
            builder.Services.AddScoped<IUsuarioRepositorioEmMemoria, UsuarioRepositorioEmMemoria>();
            builder.Services.AddScoped<UsuarioServico>();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
