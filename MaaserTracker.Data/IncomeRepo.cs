using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaaserTracker.Data
{
    public class IncomeRepo
    {
        private readonly string _connectionString;
        public IncomeRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddSource(IncomeSource source)
        {
            using var context = new MaaserDataContext(_connectionString);
            context.IncomeSources.Add(source);
            context.SaveChanges();
        }

        public List<IncomeSource> GetSources()
        {
            using var context = new MaaserDataContext(_connectionString);
            return context.IncomeSources.ToList();
        }
    }
}
