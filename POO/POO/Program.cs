﻿using System;

Console.WriteLine("Digite o número do Exercício:");
int selecionador = Int32.Parse(Console.ReadLine());

switch (selecionador)
{
    case 1:
        Console.WriteLine("Exercício 1 - Calculadora selecionado!\n");

        string selecionadorCal = "";
        while (selecionadorCal != "0")
        {
            Console.WriteLine("\nSelecione a operação a ser realizada:");
            Console.WriteLine("1:Somar \n2:Subtrair \n3:Multiplicar \n4:Dividir \n0:Sair");
            selecionadorCal = Console.ReadLine();
            
            if(selecionadorCal != "0") {  
            Console.WriteLine("Digite o primeiro número:");
            double valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double valor2 = double.Parse(Console.ReadLine());

                switch (selecionadorCal)
                {
                    case "1":
                        double soma = valor1 + valor2;
                        Console.WriteLine($"O resultado da soma é {soma}");
                        break;

                    case "2":
                        double subtracao = valor1 - valor2;
                        Console.WriteLine($"O resultado da subtração é {subtracao}");
                        break;

                    case "3":
                        double multiplicacao = valor1 * valor2;
                        Console.WriteLine($"O resultado da multiplicação é {multiplicacao}");
                        break;

                    case "4":
                        if (valor2 != 0)
                        {
                            double divicao = valor1 / valor2;
                            Console.WriteLine($"O resultado da divição é {divicao}");
                        }
                        else
                            Console.WriteLine("Não é possível realizar a divisão!");
                        break;
                }
            }
        }
        break;

    case 2:
        Console.WriteLine("Exercício 2 - Soma e Média selecionado!\n");
        Console.WriteLine("Quantos números deseja informar? (de 3 a 10)");
        int numInformados = Int32.Parse(Console.ReadLine());
        double media = 0;
        for(int i = 1;i <= numInformados;i++)
        {
            Console.WriteLine($"Informe o {i}º número:");
            double temp = double.Parse(Console.ReadLine());
            media += temp;
        }
        media = media / numInformados;
        Console.WriteLine($"A média é de {media}");
    break;

    case 3:
        Console.WriteLine("Exercício 3 - Jogar Dados selecionado!\n");
    break;

    case 4:
        Console.WriteLine("Exercício 4 - Datas selecionado!\n");
    break;

    case 5:
        Console.WriteLine("Exercício 5 - Conversão de Moedas selecionado!\n");
    break;

    case 6:
        Console.WriteLine("Exercício 6 - Jogo da Forca selecionado!\n");
    break;
}
 