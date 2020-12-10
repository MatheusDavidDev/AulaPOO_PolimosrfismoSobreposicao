using System;
namespace Polimorfismo_2.classes
{
    public class Professor : Taxa
    {
        public string turma;

        public override void ValeRefeicao(){
            base.ValeRefeicao();
            Console.WriteLine($"A taxa do professor e de 10%");
        }
    }
}