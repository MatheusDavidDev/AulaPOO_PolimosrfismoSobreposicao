using System;
namespace Polimorfismo_2.classes
{
    public class Secretario : Taxa
    {
        public string turma;

        public override void ValeRefeicao(){
            
            base.ValeRefeicao();
        }
    }
}