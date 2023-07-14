using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICandidatesRepo
    {
        IEnumerable<Candidate> GetCandidates();
        void Create(Candidate candidate);
        void Update(Candidate candidate);
        void Delete(Candidate candidate);
    }
}
