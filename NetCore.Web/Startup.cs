using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Netcore.Services.Implements;
using Netcore.Services.Interfaces;
using Swashbuckle.AspNetCore.Swagger;

namespace NetCore.Web
{

    /// <summary>
    /// tech you how to setting up swagger UI
    /// https://dev.to/lucas0707/how-to-quickly-install-swagger-in-a-net-core-application-jkc
    /// </summary>
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            #region swagger UI

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });


            #endregion


            #region token register

            services.AddSingleton<IService>(factory => {
                var service = new MyService();
                return service;
            });
            //权限管理
            services.AddAuthorization(options =>
            {
                //options.AddPolicy("",);
            });
            #endregion

            //var builder = new ContainerBuilder();
            //#region dll 注入
            //var assemblysServices = Assembly.Load("Blog.Core.Services");//要记得!!!这个注入的是实现类层，不是接口层！不是 IServices
            //builder.RegisterAssemblyTypes(assemblysServices).AsImplementedInterfaces();//指定已扫描程序集中的类型注册为提

            //#endregion

            //#region autofac

            ////实例化 AutoFac  容器   

            ////注册要通过反射创建的组件
            //builder.RegisterType<MyService>().As<IService>();

            ////将services填充到Autofac容器生成器中
            //builder.Populate(services);

            ////使用已进行的组件登记创建新容器
            //var ApplicationContainer = builder.Build();

            //new AutofacServiceProvider(ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API V1");
            });

        }
    }
}
