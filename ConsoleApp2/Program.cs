using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int menuescolha, opcao, carro, garantia;
            double valorcarro = 0, garantiacarro = 0, valornota = 0;
            string nomecarro = "", confirmacaogarantia = "";
            Console.WriteLine("DESEJA INICIAR O PROGRAMA?\n1- SIM\t2-NÃO");
            menuescolha = int.Parse(Console.ReadLine());
            Console.Clear();
            while (menuescolha != 1 && menuescolha != 2)
            {
                Console.WriteLine("CÓDIGO INVÁLIDO  !!!  DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                Console.WriteLine("\n 1- INICIAR PROGRAMA\n 2- FECHAR");
                menuescolha = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            while (menuescolha == 1)
            {
                Console.WriteLine("BEM VINDO À CONCESSIONÁRIA CALHAMBEQUE.");

                Console.WriteLine("\n ESCOLHA UMA OPÇÃO:  \n 1 - COMPRAR CARRO\n 2 - NOTA FISCAL");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                while (opcao != 1 && opcao != 2)
                {
                    Console.WriteLine("CÓDIGO INVÁLIDO  !!!  DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");

                    Console.WriteLine(" \nESCOLHA UMA OPÇÃO: \n 1 - COMPRAR CARRO\n 2 - NOTA FISCAL");

                    opcao = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("QUAL CARRO DESEJA COMPRAR?");

                        Console.WriteLine("\n 1 - CIVIC 2020 R$ 90.000 \n 2 - COROLA 2020 R$ 95.000 \n 3 - KWID R$ 60.000 \n 4 - PALIO FIRE R$ 45.000");
                        carro = int.Parse(Console.ReadLine());
                        Console.Clear();
                        while (carro != 1 && carro != 2 && carro != 3 && carro != 4)
                        {
                            Console.WriteLine("CÓDIGO INVÁLIDO  !!!  DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");
                            Console.WriteLine();

                            Console.WriteLine("QUAL CARRO DESEJA COMPRAR?");

                            Console.WriteLine("\n 1 - CIVIC 2020 R$ 90.000 \n 2 - COROLA 2020 R$ 95.000 \n 3 - KWID R$ 60.000 \n 4 - PALIO FIRE R$ 45.000");
                            carro = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        switch (carro)
                        {
                            case 1:
                                valorcarro = 90000;
                                nomecarro = "CIVIC 2020";
                                break;
                            case 2:
                                valorcarro = 95000;
                                nomecarro = "COROLA 2020";
                                break;
                            case 3:
                                valorcarro = 60000;
                                nomecarro = "KWID";
                                break;
                            case 4:
                                valorcarro = 45000;
                                nomecarro = "PALIO FIRE";
                                break;
                        }
                        Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? \n 1- SIM \n 2- NÃO");
                        garantia = int.Parse(Console.ReadLine());
                        Console.Clear();
                        while (garantia != 1 && garantia != 2)
                        {
                            Console.WriteLine("CÓDIGO INVÁLIDO  !!!  DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");

                            Console.WriteLine();
                            Console.WriteLine("DESEJA INCLUIR GARANTIA ESTENDIDA? \n 1- SIM \t 2- NÃO");
                            garantia = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        if (garantia == 1)
                        {
                            garantiacarro = valorcarro * 0.1;
                            valornota = valorcarro + garantiacarro;
                            confirmacaogarantia = "SIM";

                        }
                        else
                        {
                            confirmacaogarantia = "NÃO";
                            garantiacarro = 0;
                            valornota = valorcarro + garantiacarro;
                        }
                        Console.WriteLine("OBRIGADO PELA COMPRA !!!!");
                        Console.WriteLine();
                        Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL?\n1 - SIM\n2 - NÃO");
                        menuescolha = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("NOTA FISCAL DE PRODUTO \nO produto comprado foi: " + nomecarro);
                        Console.WriteLine("O valor do carro foi: " + valorcarro);
                        Console.WriteLine("Possui garantia estendida? " + confirmacaogarantia);
                        Console.WriteLine("O valor da garantia estendida é: R$ " + garantiacarro);
                        Console.WriteLine("Valor total da nota: R$ " + valornota);
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? \n1 - SIM \t2 - NÃO");
                        menuescolha = int.Parse(Console.ReadLine());
                        Console.Clear();
                        while (menuescolha != 1 && menuescolha != 2)
                        {
                            Console.WriteLine("CÓDIGO INVÁLIDO  !!!  DIGITE NOVAMENTE UM CÓDIGO VÁLIDO");

                            Console.WriteLine("DESEJA VOLTAR PARA O MENU INICIAL? \n1 - SIM \t2 - NÃO");
                            menuescolha = int.Parse(Console.ReadLine());
                            Console.Clear();
                        }
                        break;
                }
            }
            Console.WriteLine("OBRIGADO POR COMPRAR COM A CONCESSIONÁRIA CALHAMBEQUE");
            Console.ReadKey();
        }
    }
}