using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace JakeBladt.GalleryTools.DAC
{
    public static class DbManager
    {
        public static ISessionFactory CreateSessionFactory(string cnStr)
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration
                .MsSql2012.ConnectionString(cnStr))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Subject>())
                .BuildSessionFactory();
        }
    }
}
