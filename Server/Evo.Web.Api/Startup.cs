using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evo.Data.Common;
using Evo.Data.Repositories;
using Evo.Domain;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Evo.Core.EmailSenderContracts;
using Evo.Core.MailGunEmailSender;
using Microsoft.IdentityModel.Tokens;

namespace Evo.Web.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Add Bearer authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Audience = "http://localhost:5001/";
                    options.Authority = "http://localhost:5000/";
                });

            //add here Framework Services
            services.AddMvc();

            services.Configure<DbSettings>(options =>
            {
                options.ConnectionString = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database = Configuration.GetSection("MongoConnection:Database").Value;
            });

            //Repositories
            services.AddTransient<IAssessmentRepository, AssessmentRepository>();

            // Email Send Service
            services.AddTransient<IEmailSender, EmailSender>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //add Jwt configuration
            app.UseAuthentication();


            //app.UseJwtBearerAuthentication(new JwtBearerOptions
            //{
            //    AutomaticAuthenticate = true,
            //    AutomaticChallenge = true,
            //    TokenValidationParameters = new TokenValidationParameters
            //    {
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("AppConfiguration:Key").Value)),
            //        ValidAudience = Configuration.GetSection("AppConfiguration:SiteUrl").Value,
            //        ValidateIssuerSigningKey = true,
            //        ValidateLifetime = true,
            //        ValidIssuer = Configuration.GetSection("AppConfiguration:SiteUrl").Value
            //    }
            //});

            app.UseMvc();
        }
    }
}
