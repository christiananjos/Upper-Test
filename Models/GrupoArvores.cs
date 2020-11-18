using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class GrupoArvores
    {
        public int IdGrupoArvores { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public List<Arvore> Arvores { get; set; }
    }
}
