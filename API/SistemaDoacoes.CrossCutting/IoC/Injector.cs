using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Repositories;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Interfaces.Services;
using SistemaDoacoes.Core.Aggregates.AuthAgg.Services;
using SistemaDoacoes.Core.SharedKernel;
using SistemaDoacoes.Infra.Data;
using SistemaDoacoes.Infra.Data.Repositories;
using SistemaDoacoes.Infra.Data.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.CrossCutting.IoC
{
    public static class Injector
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Entity Framework
            services.AddScoped<DataContext>();

            services.AddDbContext<DataContext>(x =>
                x.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Unity Of Work
            services.AddScoped<IUnityOfWork, UnityOfWork>();

            // Services
            services.AddScoped<IAssistedInstitutionService, AssistedInstitutionService>();
            services.AddScoped<IAssistedService, AssistedService>();
            services.AddScoped<IDonationService, DonationService>();
            services.AddScoped<IDonorService, DonorService>();
            services.AddScoped<IDonorInstitutionService, DonorInstitutionService>();

            // Repositories
            services.AddScoped<IAssistedInstitutionRepository, AssistedInstitutionRepository>();
            services.AddScoped<IAssistedRepository, AssistedRepository>();
            services.AddScoped<IDonationRepository, DonationRepository>();
            services.AddScoped<IDonorRepository, DonorRepository>();
            services.AddScoped<IDonorInstitutionRepository, DonorInstitutionRepository>();

            // Validators
            services.AddTransient<IValidator<EventForRegisterDto>, EventValidator>();
            services.AddTransient<IValidator<EventForEditDto>, EventEditValidator>();
            services.AddTransient<IValidator<ProfileForRegisterDto>, ProfileValidator>();
            services.AddTransient<IValidator<ProfileForEditDto>, ProfileEditValidator>();

            // Configuration

        }
    }
}
