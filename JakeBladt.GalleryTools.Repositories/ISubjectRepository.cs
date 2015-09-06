using System;
using System.Collections.Generic;
using JakeBladt.GalleryTools.DAC;

namespace JakeBladt.GalleryTools.Repositories
{
    public interface ISubjectRepository
    {
        int SubjectCount { get; }
        ISubjectRepository Load();
        IList<Subject> Subjects { get; }
    }
}
