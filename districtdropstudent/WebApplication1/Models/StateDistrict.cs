using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1.Models
{
    public class StateDistrict
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["TestConn"].ConnectionString;
        private SqlConnection con;

        public StateDistrict()
        {
            con = new SqlConnection(ConnectionString);
        }

        public List<stClass> selectStates()
        {
            var getdata = new List<stClass>();
            SqlCommand cmd = new SqlCommand("sp_states", con);
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var obc = new stClass
                    {
                        Sid = Convert.ToInt32(dr["sid"]),
                        statename = dr["statename"].ToString()
                    };
                    getdata.Add(obc);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                // Logging recommended
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return getdata;
        }

        public List<disClass> selectDistrict(int sid)
        {
            var getdata = new List<disClass>();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_district", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sid", sid);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var o = new disClass
                    {
                        Did = Convert.ToInt32(sdr["Did"]),
                        Sid = Convert.ToInt32(sdr["Sid"]),
                        Districtname = sdr["Districtname"].ToString()
                    };
                    getdata.Add(o);
                }
                sdr.Close();
            }
            return getdata;
        }

    }
}
