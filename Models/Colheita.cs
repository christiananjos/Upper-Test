using System;
using System.Collections.Generic;

namespace Models
{
    public class Colheita
    {
        public int IdColheita { get; set; }
        public string Informações { get; set; }
        public DateTime DataColheita { get; set; }
        public double PesoBruto { get; set; }
        public List<Arvore> Arvores { get; set; }

        //public Colheita(string informacoes, DateTime dataColheita, double pesoBruto, List<Arvore> arvores)
        //{
        //    Informações = informacoes;
        //    DataColheita = dataColheita;
        //    PesoBruto = pesoBruto;
        //    Arvores = arvores;
        //}
    }
}
