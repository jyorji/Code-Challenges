using Coding_Challenge.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Challenge
{
    public class DataAccess
    {
        private readonly string connectionString = "Data Source =.;Initial Catalog=QBuildDB; Integrated Security=true";

        public IEnumerable<Bom> GetBom()
        {
            string query = @"select * from dbo.bom";

            DataTable table = new DataTable();
            string sqlDataSource = connectionString;
            SqlDataReader myReader;

            var boms = new List<Bom>();
            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand mycom = new SqlCommand(query, mycon))
                {
                    myReader = mycom.ExecuteReader();
                    table.Load(myReader);
                    var serializedMyObjects = JsonConvert.SerializeObject(table);
                    boms = (List<Bom>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Bom>));
                    myReader.Close();
                    mycon.Close();
                }
            }
            return boms;
        }
        public IEnumerable<Part> GetPart()
        {
            string query = @"select * from dbo.part";
            var parts = new List<Part>();
            DataTable table = new DataTable();
            string sqlDataSource = connectionString;
            SqlDataReader myReader;

            using (SqlConnection mycon = new SqlConnection(sqlDataSource))
            {
                mycon.Open();
                using (SqlCommand mycom = new SqlCommand(query, mycon))
                {
                    myReader = mycom.ExecuteReader();
                    table.Load(myReader);
                    var serializedMyObjects = JsonConvert.SerializeObject(table);
                    parts = (List<Part>)JsonConvert.DeserializeObject(serializedMyObjects, typeof(List<Part>));
                    myReader.Close();
                    mycon.Close();
                }
            }
            return parts;
        }
    }
}