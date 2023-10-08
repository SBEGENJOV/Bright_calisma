using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İncelleme
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //hangi yakllaşımı kullanacagımızı kütüphaneler kullanarak ekliycez
            //mvc
            //identitycore
            //unitowork

        }
        //startup class içerisinde  uygulamada  hangi yöntem ve yaklaşımları belirnecegi alandır. Kısacası configrasyon ayarlarını yaptıgımız kısımdır.


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();//app.UseRRouting görülen kısımlar MİDLEWARE hangi alana gidecegini belirtir.

            app.UseEndpoints(endpoints =>  //end point: gidecegi nokta istek atılan yer
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
            //Kullanıcı midlleware gider ve giriş yapması gerekise giriş yapacak.
            //Middleware sıralaması önemlidir.


            //hangiara yazılımları kulllanacagımızı belirtigimiz kısımdır.
        }
    }
}
