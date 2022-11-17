using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno a1 = new Aluno();
            a1.setNome("Brenda");
            a1.setMatricula(234);
            a1.setEmail("brenda.lima1@uscsonline.com.br");

            Aluno a2 = new Aluno("Lima");
            a2.setMatricula(789);
            a2.setEmail("lima_11@xy.com");

            Aluno a3 = new Aluno("André", 989, "andre@yahoo.com");

            a1.imprimir();
            a2.imprimir();
            a3.imprimir();

            Console.ReadKey();
        }
    }
}