using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTestePerson.Data;
using ProjetoTestePerson.Domain;

namespace ProjetoTestePerson.Business
{
    public class MensagemBo
    {
        public string GravaMensagemBo(Mensagens mensagens)
        {
            return new MensagemData().GravaMensagemData(mensagens);
        }
    }
}
