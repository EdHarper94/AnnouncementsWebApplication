﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnnouncementWebApplication_V1._0.Startup))]
namespace AnnouncementWebApplication_V1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
