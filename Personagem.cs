namespace Primeiro_POO
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public float vida = 100.0f;
        public double dinheiro = 0.987;
        public bool pulando = false;

        public string Correr(float velocidade){
            return "o personagem está correndo a "+velocidade+"km/h";
        }
        public float Atacar(float forca){
            float ForcaAtaque = 0;
            if(pulando == false){
                ForcaAtaque = forca;
            }
            return ForcaAtaque;
        }
    }
}