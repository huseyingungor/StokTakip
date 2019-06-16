using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using StokTakip.Business.Abstract;
using StokTakip.Business.Concrete;
using StokTakip.DataAccess.Abstract;
using StokTakip.DataAccess.Concrete.EntityFramework;

namespace StokTakip.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUrunDal, EfUrunDal>();
            services.AddScoped<IKullaniciDal, EfKullaniciDal>();
            services.AddScoped<IKullaniciTipiDal, EfKullaniciTipiDal>();
            services.AddScoped<IUrunService, UrunManager>();
            services.AddMvc();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
