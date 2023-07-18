using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CandidatesRepo : ICandidatesRepo
    {
        public void Create(Candidate candidate) => CandidatesDAO.Instance.Create(candidate);

        public void Delete(Candidate candidate) => CandidatesDAO.Instance.Delete(candidate);

        public IEnumerable<Candidate> GetCandidates() => CandidatesDAO.Instance.GetCandidates();

        public void Update(Candidate candidate) => CandidatesDAO.Instance.Update(candidate);
    }
}
