using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Services
{
    public class DuAnService
    {
        private ApplicationDbContext _context;
        private string _connectionString;

        public DuAnService()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            _context = new ApplicationDbContext(connection, false);
        }
    }
}