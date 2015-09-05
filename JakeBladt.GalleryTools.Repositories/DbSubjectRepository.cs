using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
