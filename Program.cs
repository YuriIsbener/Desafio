using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Qual a sua idade? ");
            idade = int.Parse(Console.ReadLine());
        
            if (idade<=4)
            {
              Console.WriteLine("Você é muito novo para competir ;-;");  
            }else
            {
                if (idade>=5)
                {
                    Console.WriteLine("Seja bem vindo mais novo competidor da categoria infantil A");
                }else
                {
                    if (idade>7)
                    {
                        Console.WriteLine("Seja bem vindo mais novo competidor da categoria infantil B");
                    }else
                    {
                        if (idade>10)
                        {
                          Console.WriteLine("Seja bem vindo mais novo competidor da categoria juvenil A");  
                        }else
                        {
                            if (idade>13)
                            {
                               Console.WriteLine("Seja bem vindo mais novo competidor da categoria juvenil B"); 
                            }else
                            {
                                if (idade>18)
                                {
                                   Console.WriteLine("Seja bem vindo mais novo competidor da categoria Sênior"); 
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
