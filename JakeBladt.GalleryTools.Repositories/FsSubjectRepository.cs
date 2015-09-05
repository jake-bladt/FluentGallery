using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakeBladt.GalleryTools.Repositories
{
    public class FsSubjectRepository : FsRepositoryBase, ISubjectRepository
    {
        public FsSubjectRepository(string rootPath) : base(rootPath)
        {

        }

        protected void SetCount()
        {
            SubjectCount = RootDirectory.GetDirectories().Length;
        }

        protected int _Count = -1;
        public int SubjectCount
        {
            get
            {
                if (_Count == -1) SetCount();
                return _Count;
            }
            protected set
            {
                _Count = value;
            }
        }
    }
}
