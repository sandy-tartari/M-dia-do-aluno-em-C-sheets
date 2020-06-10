    using System;

    namespace Somadoisnumeros
    {
        class Program
        {
            static void Main(string[] args)
            {
            // Algoritmo 3 - leia as duas notas do aluno, faca a media e escreva se o aluno tirou acima de 7, aprovado
            // e caso o contrario, escreva reprovado.
                double n1, n2, media;
                Console.WriteLine("Escreva a primeira nota do aluno: (e tecle ENTER)");
                n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Escreva a segunda nota do aluno: (e tecle ENTER)");
                n2 = double.Parse(Console.ReadLine());
                
                media = (n1 + n2) / 2;
                
                if (media > 6){
                    Console.WriteLine("Aprovado");
                } else {
                    Console.WriteLine("Reprovado");
                }
            }
        }
    }
