using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace nypproje1
{
    class Connection
    {
        public SqlConnection connect { get; set; }
        public SqlCommand cmd { get; set; }
        public Connection()
        {
            connect = new SqlConnection("Integrated Security=SSPI;" + "Initial Catalog = nesneproje;" + "Data Source=localhost;");
            cmd = new SqlCommand();
        }
    }
}
