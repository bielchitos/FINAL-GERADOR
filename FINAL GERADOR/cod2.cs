﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINAL_GERADOR
{
    public class Lista
    {
        public int codigo { get; set; }
        public string? nomeList { get; set; }
        public string? nome { get; set; }
        public string? sobrenome { get; set; }
        public DateTime datanascimento { get; set; }
        public string? email { get; set; }
        public string? cpf { get; set; }
        public string? fone { get; set; }
        public string? sexo { get; set; }
        public string? estadocivil { get; set; }
        public string? Hobbie { get; set; }
        public int idade { get; set; }

        public void Add(Lista lista)
        {
            throw new NotImplementedException();
        }

    }
}

