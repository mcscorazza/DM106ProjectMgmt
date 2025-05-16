//using DM106ProjectMgmt.Shared.Models;
//using Microsoft.Data.SqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DM106ProjectMgmt.Shared.Data.DB.old
//{
//    public class MachineDesignDAL
//    {
//        public void Create(MachineDesign design)
//        {
//            using var connection = new DM106ProjectMgmtContext().Connect();
//            connection.Open();
//            string sql = "INSERT INTO MachineDesign (Name, DrawingCode, Client) VALUES (@Name, @DrawingCode, @Client)";
//            SqlCommand cmd = new SqlCommand(sql, connection);
//            cmd.Parameters.AddWithValue("@Name", design.Name);
//            cmd.Parameters.AddWithValue("@DrawingCode", design.DrawingCode);
//            cmd.Parameters.AddWithValue("@Client", design.Client);
//            int cmdReturn = cmd.ExecuteNonQuery();
//            Console.WriteLine($"Linhas afetadas: {cmdReturn}");
//        }
//        public void Update(MachineDesign design, int Id)
//        {
//            using var connection = new DM106ProjectMgmtContext().Connect();
//            connection.Open();
//            string sql = "UPDATE MachineDesign SET Name = @Name, DrawingCode = @DrawingCode, Client = @Client WHERE Id = @id";
//            SqlCommand cmd = new SqlCommand(sql, connection);
//            cmd.Parameters.AddWithValue("@Name", design.Name);
//            cmd.Parameters.AddWithValue("@DrawingCode", design.DrawingCode);
//            cmd.Parameters.AddWithValue("@Client", design.Client);
//            cmd.Parameters.AddWithValue("@id", Id);
//            int cmdReturn = cmd.ExecuteNonQuery();
//            Console.WriteLine($"Linhas afetadas: {cmdReturn}");
//        }
//        public void Delete(int Id)
//        {
//            using var connection = new DM106ProjectMgmtContext().Connect();
//            connection.Open();
//            string sql = "DELETE FROM MachineDesign WHERE Id = @id";
//            SqlCommand cmd = new SqlCommand(sql, connection);
//            cmd.Parameters.AddWithValue("@id", Id);
//            int cmdReturn = cmd.ExecuteNonQuery();
//            Console.WriteLine($"Linhas afetadas: {cmdReturn}");
//        }
//        public IEnumerable<MachineDesign> Read()
//        {
//            var list = new List<MachineDesign>();

//            using var connection = new DM106ProjectMgmtContext().Connect();
//            connection.Open();
//            string sql = "SELECT * FROM MachineDesign";
//            SqlCommand cmd = new SqlCommand(sql, connection);

//            using SqlDataReader reader = cmd.ExecuteReader();

//            while (reader.Read())
//            {
//                string name = reader["Name"].ToString();
//                string drawingCode = reader["DrawingCode"].ToString();
//                string client = reader["Client"].ToString();
//                MachineDesign Design = new MachineDesign(name, drawingCode, client);
//                list.Add(Design);
//            }

//            return list;
//        }
//    }
//}

