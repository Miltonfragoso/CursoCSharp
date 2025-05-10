using MétodosAbstratos.Entities.Enuns;

namespace MétodosAbstratos.Entities
{
    abstract class Figura
    {
        public Cor Cor {  get; set; }

        public  Figura( Cor cor)
        {
            this.Cor = Cor;
        }
        public abstract double Area();
    
    }
}

//Sem o construtor sem parametros nos obrigamos informar a cor ao instanciar a Figura