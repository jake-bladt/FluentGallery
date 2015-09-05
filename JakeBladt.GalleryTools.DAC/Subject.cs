using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
