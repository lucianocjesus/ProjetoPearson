﻿using ProjetoTestePerson.Data;
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
