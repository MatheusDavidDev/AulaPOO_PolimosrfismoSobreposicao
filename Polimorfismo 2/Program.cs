using System;
using Polimorfismo_2.classes;

namespace Polimorfismo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            professor.ValeRefeicao();

            Secretario secretario = new Secretario();
            secretario.ValeRefeicao();

            Coordenador coordenador = new Coordenador();
            coordenador.ValeRefeicao();
        }
    }
}
