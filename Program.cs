double salario, fgts;

Console.Write("Insira seu salário (R$): ");
salario = Convert.ToDouble(Console.ReadLine()!);

fgts = (salario * 8) / 100;

Console.WriteLine($"\nFGTS: {fgts:C}");