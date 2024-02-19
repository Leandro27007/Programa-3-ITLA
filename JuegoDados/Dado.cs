namespace JuegoDados
{
    public class Dado
    {


        public int numeroGanador;

        public void Girar()
        {

            Random rnd = new Random();

            this.numeroGanador =  rnd.Next(1, 6);

        }

    }
}
