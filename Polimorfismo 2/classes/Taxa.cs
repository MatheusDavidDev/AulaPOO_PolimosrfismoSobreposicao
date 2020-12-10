using System;
namespace Polimorfismo_2.classes
{
    public abstract class Taxa
    {
        public float valor;

        //metodos

        public virtual void ValeRefeicao(){
            
            Console.WriteLine($"Valor da taxa normal do funcionario é de 5%");
        }
    }
}