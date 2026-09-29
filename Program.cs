int opcao;

do
{
    Console.WriteLine("Sistema Empresarial:");
    Console.WriteLine("1 - Novo salário");
    Console.WriteLine("2 - Férias");
    Console.WriteLine("3 - Décimo terceiro");
    Console.WriteLine("4 - Sair");
    Console.Write("Digite a opção: ");

    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.Write("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        if (salario <= 350)
        {
            salario = salario + salario * 0.15;
        }
        else if (salario <= 600)
        {
            salario = salario + salario * 0.10;
        }
        else
        {
            salario = salario + salario * 0.05;
        }

        Console.WriteLine("Novo salário: " + salario);
    }
    else if (opcao == 2)
    {
        Console.Write("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        double ferias = salario + salario / 2;

        Console.WriteLine("Valor das férias: " + ferias);
    }
    else if (opcao == 3)
    {
        Console.Write("Digite o salário: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Digite os meses trabalhados: ");
        int meses = int.Parse(Console.ReadLine());

        double decimo = salario * meses / 12;

        Console.WriteLine("Décimo terceiro: " + decimo);
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Programa encerrado!");
    }
    else
    {
        Console.WriteLine("Opção inválida!");
    }

} while (opcao != 4);

