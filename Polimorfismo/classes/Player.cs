namespace Polimorfismo.classes
{
    public abstract class Player
    {
        //Atributos
        private float velocidade;

        private float forcaPulo;

        //metodos

        // Para o polimorfimos colocamos o virual no metodo da superclasse
        // para consegir subistiuir nas classes filhas
        // em outra classe colocar override
        public virtual string Correr(){
            return "Correndo em velocidade de 1x";
        }

        public virtual string Pular(){
            return "Pulando na altura de 1 metro";
        }   
    }
}