using BronzeLeagueHeroes.Classes;
using BronzeLeagueHeroes.Interfaces;
using Ninject;
using Ninject.Modules;
using NLog;
using System;
using System.Configuration;

namespace BronzeLeagueHeroes
{
    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            string connectionString = "";
            try
            {
                connectionString = ConfigurationManager.AppSettings["OracleConnection"];
            }
            catch (Exception ex)
            {

            }
            Bind(typeof(IApp)).To(typeof(App));
            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });

        }
    }
}
