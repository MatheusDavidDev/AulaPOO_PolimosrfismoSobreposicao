using System;
namespace Polimorfismo_2.classes
{
    public class Coordenador : Taxa
    {
        public string turma;

        public override void ValeRefeicao(){
            base.ValeRefeicao();
            Console.WriteLine($"A taxa do coordenador e de 30%");
        }
    }
}