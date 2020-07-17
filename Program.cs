using System;

namespace _11_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular jogador = new Calcular();

            Console.WriteLine(jogador.calculo("Crash"," Bandicoot"));
            Console.WriteLine(jogador.calculo("Crash",5));
            Console.WriteLine(jogador.calculo("Crash",5,3));
            Console.WriteLine(jogador.calculoo("Crash",8,9));
        }
    }
}
