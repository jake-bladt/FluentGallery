using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JakeBladt.GalleryTools.DAC;

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

        protected IList<Subject> _Subjects;
        public IList<Subject> Subjects
        {
            get
            {
                if (null == _Subjects) Load();
                return _Subjects;
            }
            protected set
            {
                _Subjects = value;
            }
        }

        public ISubjectRepository Load()
        {
            return this;
        }

    }
}
