using System;
using System.Globalization;

namespace MinutosJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int HoraInicio  = int.Parse(valores[0]);
            int MinutoInicio  = int.Parse(valores[1]);
            int HoraFinal  = int.Parse(valores[2]);
            int MinutoFinal  = int.Parse(valores[3]);

            int Inicio = HoraInicio * 60 + MinutoInicio;
            int Final = HoraFinal * 60 + MinutoFinal;

            int TempoJogo;

            if( Inicio < Final)
            {
                TempoJogo = Final - Inicio;
            }
            else
            {
                TempoJogo = (24 * 60 - Inicio) + Final;
            }

            int duracaoHoras = TempoJogo / 60;
            int duracaoMinutos = TempoJogo % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
           
        }
    }
}
