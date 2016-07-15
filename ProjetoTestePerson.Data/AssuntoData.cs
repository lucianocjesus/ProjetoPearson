using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTestePerson.Domain;

namespace ProjetoTestePerson.Data
{
    public class AssuntoData
    {
        private readonly SqlConnection _objSqlConnection;

        public AssuntoData()
        {
            _objSqlConnection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()
            };
        }

        public List<Assuntos> ListaAssuntosData()
        {
            List<Assuntos> lstList = new List<Assuntos>();
            using (_objSqlConnection)
            {
                try
                {
                    const string strSql = "Pearson_DB_SP_ListagemAssunto";
                    var cmd = new SqlCommand(strSql, _objSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    _objSqlConnection.Open();

                    var oDr = cmd.ExecuteReader();
                    while (oDr.Read())
                    {
                        var assuntos = new Assuntos
                        {
                            Id = Convert.ToInt32(oDr["Id"]),
                            Assunto = oDr["Assunto"].ToString()
                        };
                        lstList.Add(assuntos);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao tentar listar os assuntos." + ex.Message);
                }
                finally
                {
                    _objSqlConnection.Close();
                }
            }
            return lstList;
        }
    }
}
