using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate;
using FluentNHibernate.Mapping;

namespace JakeBladt.GalleryTools.DAC
{
    public class Subject
    {
        public virtual int Id { get; set; }
        public virtual string FilePrefix { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual int FileCount { get; set; }
        public virtual DateTime AddedAt { get; set; }
    }

    public class SubjectMap : ClassMap<Subject>
    {
        public SubjectMap()
        {
            Id(x => x.Id);
            Map(x => x.FilePrefix);
            Map(x => x.DisplayName);
            Map(x => x.FileCount);
            Map(x => x.AddedAt);
        }
    }

}
