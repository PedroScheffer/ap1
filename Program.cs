while (true)
{
    Console.WriteLine("Digite a sua altura (em centimetros) ou 'sair' para encerrar o programa: ");
    string input = Console.ReadLine();
    
    if (input.ToLower() == "sair")
    break;

    double altura;

    if (Double.TryParse(input, out altura)) 
    {
        altura = altura /100;
    }

    else 
    {
        Console.WriteLine("Digite um número válido!");
    }
    
    Console.WriteLine("Digite o seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a sua idade: ");
    int idade = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Digite o seu nome: ");
    var nome = Console.ReadLine();
   
    double imc = peso / (altura * altura);

    if (imc < 18.5)
    {
        Console.WriteLine($"{nome} | {idade} anos, está abaixo do peso ideal!");
    }
    else if (imc >= 18.5 && imc < 24.9)
    {
        Console.WriteLine($"{nome} | {idade} anos, está no peso ideal!");
    }
    else if (imc >= 25.0 && imc < 29.9)
    {
        Console.WriteLine($"{nome} | {idade} anos, está acima do peso ideal!");
    }

    else
    {
        Console.WriteLine($"{nome} | {idade} anos, está obeso!");
    }

}