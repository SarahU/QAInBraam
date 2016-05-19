using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(QAinBraam.Startup))]

namespace QAinBraam
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
       
        }      
    }
}
