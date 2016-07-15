using System;
using System.Collections.Generic;
using System.Web.UI;
using ProjetoTestePerson.Business;
using ProjetoTestePerson.Domain;

namespace ProjetoTestePerson.WebForms
{
    public partial class Mensagem : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                /*
                 André, infelismente não consegui fazer nada na parte de front-end, porem toda a estrutura para back-end esta pronta:
                 * 
                 *  - Criado projeto de dominio de acordo com banco de dados
                 *  - Criado projeto de dados separado entre as classes de assunto e mensagem
                 *  - Criado projeto de negocio para controlar as informações entre a camada de banco e camada de apresentação
                 *  
                 * 
                 *  - BANCO DE DADOS
                 *  Criei o relacionamento da tabela Assunto como FK na tabela Mensagem. 
                 *  Proc "[dbo].[Pearson_DB_SP_AdicionaMensagem]" e [dbo].[Pearson_DB_SP_ListagemAssunto]
                 *  
                 *                    
                 */
                CarregaListaAssuntos();
            }
        }

        private void CarregaListaAssuntos()
        {
            List<Assuntos> lsList = new AssuntoBo().ListaAssuntosBo();
            Assuntos assuntos = new Assuntos {Id = 0, Assunto = "Selecione..."};
            lsList.Insert(0, assuntos);

            ddlAssuntos.DataSource = lsList;
            ddlAssuntos.DataValueField = "Id";
            ddlAssuntos.DataTextField = "Assunto";
            ddlAssuntos.DataBind();
        }
    }
}