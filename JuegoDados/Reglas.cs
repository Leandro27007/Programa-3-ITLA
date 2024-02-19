namespace JuegoDados
{
    public class Reglas
    {

        const string MENSAJE_GANADOR = "Usted ha ganado. Los dados que salieron fueron:";
        const string MENSAJE_PERDEDOR = "Perdio, intentelo de nuevo. Los dados que salieron fueron: ";
        public string DeterminarVictoria(int numero1, int numero2, int numero3)
        {
            if (numero1 ==  numero2 && numero3 == numero2)
                return MENSAJE_GANADOR + $"Dado 1: {numero1}, Dado 2: {numero2}, Dado 3: {numero3}";

            return MENSAJE_PERDEDOR;
        }

    }
}
