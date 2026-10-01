using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_06.Exercicios
{
    internal class Exercicio_D
    {
        public static void Executar()
        {
            Console.Write("Digite uma data (dd/mm/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
            {
                if (EhFeriadoNacional(data, out string nomeFeriado))
                {
                    Console.WriteLine($"\n{data:dd/MM/yyyy} É um feriado nacional: {nomeFeriado}.");
                }
                else
                {
                    Console.WriteLine($"\n{data:dd/MM/yyyy} NÃO é um feriado nacional.");
                }
            }
            else
            {
                Console.WriteLine("Data inválida. Use o formato dd/mm/yyyy.");
            }
        }

        static bool EhFeriadoNacional(DateTime data, out string nomeFeriado)
        {
            int ano = data.Year;

            // Feriados Móveis (Baseados no cálculo da Páscoa)
            DateTime pascoa = CalcularPascoa(ano);
            DateTime sextaFeiraSanta = pascoa.AddDays(-2);
            DateTime carnaval = pascoa.AddDays(-47);
            DateTime corpusChristi = pascoa.AddDays(60);

            // Dicionário com Feriados Nacionais (Fixos e Móveis)
            var feriados = new Dictionary<DateTime, string>
        {
            // Feriados Fixos
            { new DateTime(ano, 1, 1), "Confraternização Universal (Ano Novo)" },
            { new DateTime(ano, 4, 21), "Tiradentes" },
            { new DateTime(ano, 5, 1), "Dia Mundial do Trabalho" },
            { new DateTime(ano, 9, 7), "Independência do Brasil" },
            { new DateTime(ano, 10, 12), "Nossa Senhora Aparecida" },
            { new DateTime(ano, 11, 2), "Finados" },
            { new DateTime(ano, 11, 15), "Proclamação da República" },
            { new DateTime(ano, 11, 20), "Dia Nacional de Zumbi e da Consciência Negra" },
            { new DateTime(ano, 12, 25), "Natal" },

            // Feriados Móveis
            { carnaval, "Carnaval" },
            { sextaFeiraSanta, "Sexta-feira Santa" },
            { pascoa, "Páscoa" },
            { corpusChristi, "Corpus Christi" }
        };

            // Verifica se a data consultada existe na lista de feriados (ignorando o horário)
            return feriados.TryGetValue(data.Date, out nomeFeriado);
        }

        // Algoritmo de Meeus/Jones/Butcher para calcular a data da Páscoa
        static DateTime CalcularPascoa(int ano)
        {
            int a = ano % 19;
            int b = ano / 100;
            int c = ano % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;
            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int l = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * l) / 451;
            int mes = (h + l - 7 * m + 114) / 31;
            int dia = ((h + l - 7 * m + 114) % 31) + 1;

            return new DateTime(ano, mes, dia);
        }
    }
}
