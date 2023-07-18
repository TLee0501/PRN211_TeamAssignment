using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CandidatesDAO
    {
        // Singleton
        private static CandidatesDAO instance = null;
        private static readonly object instanceLock = new object();
        private CandidatesDAO() { }
        public static CandidatesDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CandidatesDAO();
                    }
                    return instance;
                }
            }
        }

        //--------------------------------------------------------------------
        public List<Candidate> GetCandidates()
        {
            List<Candidate> candidates = new List<Candidate>();
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                candidates = context.Candidates.ToList();
            }
            return candidates;

        }
        public void Create(Candidate candidate)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.Candidates.Add(candidate);
                context.SaveChanges();
            }
        }
        public void Update(Candidate candidate)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.Candidates.Update(candidate);
                context.SaveChanges();
            }
        }
        public void Delete(Candidate candidate)
        {
            using (var context = new PRN211_IT_HR_Management_SystemContext())
            {
                context.Candidates.Remove(candidate);
                context.SaveChanges();
            }
        }
    }
}