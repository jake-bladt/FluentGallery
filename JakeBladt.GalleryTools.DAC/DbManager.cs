using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace JakeBladt.GalleryTools.DAC
{
    public class DbManager
    {
        protected string _cnStr;

        public DbManager(string cnStr)
        {
            _cnStr = cnStr;
        }

        public ISessionFactory CreateSessionFactory()
        {
            return GetDBConfig().BuildSessionFactory();
        }

        public FluentConfiguration GetDBConfig()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration
                .MsSql2012.ConnectionString(_cnStr))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Subject>());
        }

        public void CreateDatabase()
        {
            GetDBConfig().ExposeConfiguration(c => new SchemaUpdate(c).Execute(true, true)).BuildSessionFactory();
        }

    }
}
