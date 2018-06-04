using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using OracleDataAccessExample.Dados.Entities;

namespace OracleDataAccessExample.Dados
{
    public class HRContext : DbContext
    {
        public HRContext(OracleConnection conexao)
            : base(conexao, true)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
