using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Arvore
    {
        public int IdArvore { get; set; }
        public string Descricao { get; set; }
        public int Idade { get; set; }
        
        public int EspecieId { get; set; }
        public Especie Especie { get; set; }

        public Arvore(string descricao, int idade, Especie especie)
        {
            Descricao = descricao;
            Idade = idade;
            Especie = especie;

        }
    }
}
