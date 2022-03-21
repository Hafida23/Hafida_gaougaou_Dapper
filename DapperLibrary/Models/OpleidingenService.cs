using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLibrary.Models
{
    public class OpleidingenService
    {
        public IEnumerable<Campus> GetCampus()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
                var campus = connection.Query<Campus>("spGetAllCampussen", commandType: CommandType.StoredProcedure).ToList();
                return campus;
            }
        }
        public IEnumerable<Docent> GetDocentenByCampus()
        {
            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {

                var docent = connection.Query<Docent>("spGetAllDocenten", commandType: CommandType.StoredProcedure).ToList();
                return docent;
            }
        }

        public void AddDocent(Docent docent)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Voornaam", docent.Voornaam);
            param.Add("@Familienaam", docent.Familienaam);
            param.Add("@Wedde", docent.Wedde);
            param.Add("@CampusNr", docent.CampusNr);

            using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
            {
               
                    connection.Execute("spAddDocent", param, commandType: CommandType.StoredProcedure);
               
            }
        }
        //public IEnumerable<Dct_Docent> GetDocentByCampus(int id)
        //{
        //    DynamicParameters param = new DynamicParameters();
        //    param.Add("@id", id);

        //    using (IDbConnection connection = new SqlConnection(OpleidingenDbManager.GetConnection("Opleidingen")))
        //    {
        //        var campusen = connection.Query<Dct_Docent, Campus, Dct_Docent>("spGetDocentPerCampus",
        //            (dctCampus, campus) =>
        //            {
        //                dctCampus.Campus = campus;
        //                return dctCampus;
        //            },
        //            param, commandType: CommandType.StoredProcedure).ToList();
        //        return campusen;
        //    }
        //}

    }
}
