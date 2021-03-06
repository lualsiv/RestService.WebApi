﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(RestService.WebApi.Startup))]

namespace RestService.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ConfigureAutoFac(app);
        }
    }
}
