﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Notes.ApplicationCore.Interface;
using Notes.Infrastructure.Data;

namespace Notes.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];

            services.AddDbContext<NotesDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });

            services.AddScoped<INotesDbContext>(provider =>
                provider.GetService<NotesDbContext>());

            return services;
        }
    }
}
