string input;
do
{
    Console.WriteLine("Digite a sua altura (em centimetros): ");
    input = Console.ReadLine();
    
    double altura;

    if (Double.TryParse(input, out altura)) 
    {
        altura = altura /100;
    }

    else 
    {
        Console.WriteLine("Digite um número válido!");
        continue;
    }
    
    Console.WriteLine("Digite o seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a sua idade: ");
    int idade = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Digite o seu nome: ");
    var nome = Console.ReadLine();
   
    double imc = peso / (altura * altura);

    string faixaEtaria = "";

    if (idade < 10)
    {
        faixaEtaria = "Criança";
    }

    else if (idade >= 10 && idade < 20)
    {
        faixaEtaria = "Adolescente";
    }

    else if (idade >= 20 && idade < 60)
    {
        faixaEtaria = "Adulto";
    }
    else
    {
        faixaEtaria = "Idoso";
    }

    if (imc < 18.5)
    {
        Console.WriteLine($"\nNome: {nome} \nFaixa etária: {faixaEtaria} \nEstá abaixo do peso ideal!");
    }
    else if (imc >= 18.5 && imc < 24.9)
    {
        Console.WriteLine($"\nNome: {nome} \nFaixa etária: {faixaEtaria} \nEstá no peso ideal!");
    }
    else if (imc >= 25.0 && imc < 29.9)
    {
        Console.WriteLine($"\nNome: {nome} \nFaixa etária: {faixaEtaria} \nEstá acima do peso ideal!");
    }

    else
    {
        Console.WriteLine("\nNome:" + nome + "\nFaixa etária:" + faixaEtaria + "\nEstá obeso!");
    }

    Console.WriteLine("\nDigite 'sair' para encerrar o programa ou pressione Enter para continuar: ");
    input = Console.ReadLine();
    
} while (input.ToLower() != "sair");
