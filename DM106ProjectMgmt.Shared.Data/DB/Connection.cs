using DM106ProjectMgmt.Shared.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM106ProjectMgmt.Shared.Data.DB
{
    public class Connection
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DM106ProjectMgmt_DB_V0;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public SqlConnection Connect() 
        { 
            return new SqlConnection(connectionString);
        }
    }
}