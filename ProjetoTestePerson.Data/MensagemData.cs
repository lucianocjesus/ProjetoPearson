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
    public class MensagemData
    {
        private readonly SqlConnection _objSqlConnection;

        public MensagemData()
        {
            _objSqlConnection = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()
            };
        }

        public string GravaMensagemData(Mensagens mensagens)
        {
            string retorno = null;

            using (_objSqlConnection)
            {
                try
                {
                    const string strSql = "Pearson_DB_SP_AdicionaMensagem";
                    var cmd = new SqlCommand(strSql, _objSqlConnection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    _objSqlConnection.Open();

                    cmd.Parameters.Add(new SqlParameter("@pIdAssunto", mensagens.IdAssunto));
                    cmd.Parameters.Add(new SqlParameter("@pNome", mensagens.Nome));
                    cmd.Parameters.Add(new SqlParameter("@pEmail", mensagens.Email));
                    cmd.Parameters.Add(new SqlParameter("@pDDD", mensagens.Ddd));
                    cmd.Parameters.Add(new SqlParameter("@pTelefone", mensagens.Telefone));
                    cmd.Parameters.Add(new SqlParameter("@pMensagem", mensagens.Mensagem));
                    //cmd.Parameters.Add(new SqlParameter("@pData", mensagens.Data));
                    cmd.ExecuteNonQuery();
                    retorno = "Mensagem adicionada com sucesso.";
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao tentar inserir a mensagem " + mensagens.Mensagem + ". Erro: " + ex.Message);
                }
                finally
                {
                    _objSqlConnection.Close();
                }
            }
            return retorno;
        }
    }
}
