using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aATV
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] func = new Funcionario[4];

            /* for(int i = 0; i < 4; i++)
                 {
                     func[i] = new Funcionario();
                     func[i].nome = Console.ReadLine();
                     func[i].matricula = int.Parse(Console.ReadLine());
                     func[i].salario = int.Parse(Console.ReadLine());
                 }
            */

            func[0] = new Funcionario();
            func[0].nome = "Brenda";
            func[0].matricula = 1299;
            func[0].salario = 3500;

            func[1] = new Funcionario();
            func[1].nome = "Fefis";
            func[1].matricula = 1298;
            func[1].salario = 1500;

            func[2] = new Funcionario();
            func[2].nome = "Claudio";
            func[2].matricula = 1290;
            func[2].salario = 2700;

            func[3] = new Funcionario();
            func[3].nome = "Shoga";
            func[3].matricula = 1289;
            func[3].salario = 5000;

            int Soma = 0;

        for (int i = 0; i < 4;i++)
            {
                Soma += func[i].salario;
            }
            
        float Media = Soma / 4;

        for (int i = 0; i < 4; i++) 
            { 
                if (func[i].salario > Media)
                {
                    func[i].imprime();
                }
            }

            Console.ReadKey();
        }
    }
}