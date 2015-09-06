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

        public static string FilePrefixToName(string filePrefix)
        {
            var chars = filePrefix.Replace('.', ' ').ToCharArray();
            StringBuilder retBuilder = new StringBuilder(chars[0].ToString().ToUpper());
            for(int i = 1; i < chars.Length; i++)
            {
                if(chars[i -1] == ' ')
                {
                    retBuilder.Append(chars[i].ToString().ToUpper());
                }
                else
                {
                    retBuilder.Append(chars[i]);
                }
            }
            if (chars[chars.Length - 1] == ' ') retBuilder.Append('.');
            return retBuilder.ToString();
        }
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
