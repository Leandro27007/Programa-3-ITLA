
using JuegoDados;

Dado dado1 = new Dado();
Dado dado2 = new Dado();
Dado dado3 = new Dado();


do
{
    Console.WriteLine("---------------------------------------------");
    dado1.Girar();
    dado2.Girar();
    dado3.Girar();


    Reglas reglas = new Reglas();


    Console.WriteLine(reglas.DeterminarVictoria(dado1.numeroGanador, dado2.numeroGanador, dado3.numeroGanador));

    Console.WriteLine("-----------------------------");
    Console.WriteLine("Precione (S) dos veces si deseas lanzarlos otra vez o cualquier tecla para salir.");
} while (Console.ReadKey().KeyChar == 'S' || Console.ReadKey().KeyChar == 's');

