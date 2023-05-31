using Backend.Common;
using Backend.Interface;
using Backend.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Backend.Services
{
    public class JabatanService : IJabatan
    {
        Jabatan _oJabatan = new Jabatan();
        List<Jabatan> _oJabatans = new List<Jabatan>();
        public string Delete(string kodejabatan)
        {
            throw new NotImplementedException();
        }

        public Jabatan Get(string kodejabatan)
        {
            throw new NotImplementedException();
        }

        public int GetKodeJabatan()
        {
            throw new NotImplementedException();
        }

        public List<Jabatan> Gets()
        {
            //throw new NotImplementedException();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();
                var oJabatans = con.Query<Jabatan>("Select * from Jabatan").ToList();
                if (oJabatans != null && oJabatans.Count() > 0)
                {
                    _oJabatans = oJabatans;
                }
            }
            return _oJabatans;
        }

        public Jabatan Save(Jabatan oJabatan)
        {
            throw new NotImplementedException();
        }

        public Jabatan Update(Jabatan oJabatan)
        {
            throw new NotImplementedException();
        }
    }
}
