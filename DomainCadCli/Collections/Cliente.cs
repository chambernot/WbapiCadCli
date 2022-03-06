﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DomainCadCli.Collections
{
    public class Cliente: CollectionMongo
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }

        public string Nacionalidade { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Logradouro { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
