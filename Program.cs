Console.Clear();

double salario = 0.0;
double horasTrabalhadas = 0.0;
double horasExtras = 0.0;

Console.WriteLine("--- Cálculo de horas extras ---");

Console.Write("Digite seu salário por hora: ");
salario = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o total de horas que você trabalhou: ");
horasTrabalhadas = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Digite o total de horas extras: ");
horasExtras = Convert.ToDouble(Console.ReadLine()!);

 Console.WriteLine($"O total de seu salário com horas extras é: {calculoSalario( salario, horasTrabalhadas, horasExtras):C}");

    static double calculoSalario(double salario, double horasTrabalhadas, double horasExtras)
        {
            double totalSalario = 0.0;
            double totalHoraExtra = 0.0;

            totalSalario = salario * horasTrabalhadas;

            totalHoraExtra = totalSalario + (salario * (horasExtras * 0.4));

            return totalHoraExtra;
        }
