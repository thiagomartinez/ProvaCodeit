using System;
using System.Collections.Generic;
using System.Text;

namespace ProvaCode.Model
{
    public enum TipoPessoa { Piloto, Oficial, ChefeServico, Comissaria, Policial, Presidiario };
    public class Pessoa
    {
        public Pessoa(string nome, TipoPessoa tipo)
        {
            Nome = nome;
            Tipo = tipo;
        }

        public String Nome { get; set; }

        public TipoPessoa Tipo { get; set; }
    }

}
