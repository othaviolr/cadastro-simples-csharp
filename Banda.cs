using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    class Banda
    {
        string nome;
        int integrantes;
        int ranking;
        int genero;

        public string Nome { get => nome; set => nome = value; }
        public int Integrantes { get => integrantes; set => integrantes = value; }
        public int Ranking { get => ranking; set => ranking = value; }
        public int Genero { get => genero; set => genero = value; }
    }
}
