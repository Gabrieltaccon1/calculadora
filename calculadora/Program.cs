using System;
using System.Globalization;


namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
        INICIO:
            // declaração das variaveis e seus tipos 
            //             VV 

            double numero1, numero2, resultado = 0, x = 0;
            string operação;


            do
            {

                Console.WriteLine("SEJA BEM VINDO A MINHA PRIMEIRA CALCULADORA EM C# !," + "DIGITE O PRIMEIRO NUMERO ou O VALOR DE PROCETAGEM QUE DESEJA SABER ");

                numero1 = double.Parse(Console.ReadLine());
                // = SIGNIFICA QUE ESTOU FAZENDO A LEITURA DO SINTAXE DEFININO O QUE ELA VAI ARMAZENAR

                Console.WriteLine("DIGITE A OPERAÇÃO DESEJADA");
                operação = Console.ReadLine();
                // console.readline retorna STRING

                Console.WriteLine("DIGITE O SEGUNDO NUMERO ou O VALOR TOTAL SOBRE A PORCETAGEM");
                numero2 = double.Parse(Console.ReadLine());

                // AGORA PODERIA USAR O " IF " MAS EM C# O SWITCH se torna mais facil

                switch (operação) // USANDO PARA DEFINIR QUAL OPERAÇÂO SERÀ FEITA 
                {
                    // caso operação capture o simbolo + ele calcula automaticamente n1+n2
                    //                 VV

                    case "+":
                        resultado = numero1 + numero2;
                        break;


                    // caso operação capture o simbolo - ele calcula automaticamente n1-n2
                    //                    VV

                    case "-":
                        resultado = numero1 - numero2;
                        break;


                    // caso operação capture o simbolo * ele calcula automaticamente n1*n2
                    //                    VV
                    case "*":
                        resultado = numero1 * numero2;
                        break;


                    // caso operação capture o simbolo / ele calcula automaticamente n1/n2
                    //                VV

                    case "/":
                        resultado = numero1 / numero2;
                        break;


                    // caso operação capturo o simbolo % 

                    case "%":
                        resultado = numero1 * numero2 / 100;
                        break;


                    case "^":
                        resultado = Math.Pow(numero1, numero2);
                        break;

                    default:
                        Console.WriteLine("NENHUMA DAS OPERAÇÕES ATENDIDAS FORAM DIGITADAS");
                        break;
                }


                Console.WriteLine("O RESULTADO É " + resultado);
                Console.ReadLine();

            } while (x < 5);    
             





            Console.Clear(); // para limpar o console
            goto INICIO; // retornar para inicio 




        }

    }
}

