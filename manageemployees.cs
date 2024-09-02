using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace summer2
{
    internal class manageemployees
    {



        public static void Addemployee(string fn, string ln, int roleid, string phone, string email, DateTime hiredate, DateTime dob, byte[] photo)
        {
            string sql = "INSERT INTO employees (EFirstName, ELastName, ERoleId, EPhone, EEmail, EHireDate, dob, EPhotoURL, EStatus) VALUES (@efirstname, @elastname,@eroleid,@ephone,@eemail,@ehiredate,@dob, @photourl, @estatus)";
            var parameters = new Dictionary<string, object>
            {
                {"@efirstname", fn },
                {"@elastname", ln },
                {"@eroleid",roleid },
                {"@ephone", phone },
                {"@eemail",email },
                {"@ehiredate", hiredate},
                {"@dob",dob },
                {"@photourl", photo },
                {"@estatus",1 }
            };

            databaseconnection.ExecuteQuery(sql, parameters);
        }
        public static byte[] ConvertImageToByteArray(string imagePath)
        {
            return File.ReadAllBytes(imagePath);
        }

        public static DataTable GetActiveEmployees()
        {
            string sql = "SELECT EFirstName, ELastName, ERoleId, EPhone, EEmail, EHireDate, dob, EPhotoURL FROM employees WHERE EStatus = 1";

            // Retrieve the data from the database using a method that executes SQL and returns a DataTable
            return databaseconnection.GetData(sql);
        }
    }
}