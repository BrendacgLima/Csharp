using System;

class Program
{
    static void Main(string[] args)
    {

        Fun[] garage = {
new Fun(&quot; Brenda & quot;, 11111, 3500.00),
new Fun(&quot; Claudio & quot;, 22222, 5200.00),
new Fun(&quot; Fefis & quot;, 33333, 9500.00)
}

foreach (Fun Funcionario in garage) {
Console.WriteLine(Funcionario.name);
Console.WriteLine(Funcionario.matricula);
Console.WriteLine(Funcionario.salario);
}

Console.ReadKey();
}
}