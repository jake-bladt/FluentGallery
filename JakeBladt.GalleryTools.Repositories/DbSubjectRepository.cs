using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Linq;
using JakeBladt.GalleryTools.DAC;

namespace JakeBladt.GalleryTools.Repositories
{
    public class DbSubjectRepository : DbRepositoryBase, ISubjectRepository
    {
        protected int _Count;

        public int SubjectCount
        {
            get
            {
                if (-1 == _Count) SetCount();
                return _Count;
            }
            protected set
            {
                _Count = value;
            }
        }

        private void SetCount()
        {
            using (var session = DatabaseManager.CreateSessionFactory().OpenSession())
            {
                SubjectCount = session.QueryOver<Subject>().RowCount();
            }
        }

        public DbSubjectRepository(string cnStr) : base(cnStr)
        {
            SubjectCount = -1;
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
            using (var session = DatabaseManager.CreateSessionFactory().OpenSession())
            {
                _Subjects = session.Query<Subject>().ToList();
            }
            return this;
        }

    }
}
