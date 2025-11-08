using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.CRUD
{
     class connection
    {
        static string dbPath = @"C:\Users\Crystal\Desktop\Employee\EmployeeManagementSystem\EMSS.mdb";
        public static string conString = $"Provider=Microsoft.JET.OLEDB.4.0;Data Source ={dbPath};";

        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(conString);
        }
        public static OleDbConnection con = mysqldb();
    }
}
