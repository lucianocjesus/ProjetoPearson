﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTestePerson.Domain
{
    public class Mensagens
    {
        public int Id { get; set; }
        public int IdAssunto { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Ddd { get; set; }
        public int Telefone { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }
    }
}
