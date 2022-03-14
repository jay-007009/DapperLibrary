using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperLibrary.ConnectionString
{
    public class Connection
    {
        public string connectionstring()
        {
            var connectionString = "Data Source=.;Initial Catalog=lms_db;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;";
            return connectionString;

        }
    }
}




