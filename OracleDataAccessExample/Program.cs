using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using OracleDataAccessExample.Dados;

namespace OracleDataAccessExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ConectarBd();
        }

        private static void ConectarBd()
        {
            var stringConexao = System.Configuration.ConfigurationManager.ConnectionStrings["HRContext"].ConnectionString;
            var conexao = new OracleConnection(stringConexao);

            using (var contexto = new HRContext(conexao))
            {
                var empregado = contexto.Employees.Find(100);

                if (empregado == null)
                    Console.WriteLine("Empregado não existe.");

                Console.WriteLine("Dados do empregado: " + JsonConvert.SerializeObject(empregado));
            }

            Console.Read();
        }
    }
}
