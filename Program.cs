//escrevaa mensagem "informe um numero: "
Console.Write("Informe um numero: ");
// Cria a variavelQueSalvaUmNumero,
// leia o que o usuario vai digitar
// e transforma o valor lido de texto para inteiro (int.Parse) 
int variavelQueSalvaUmNumero = int.Parse(Console.ReadLine()!);

//verifica se o valor de variavelQueSalvaUmNumero é par
if (variavelQueSalvaUmNumero % 2 == 0)
{
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é par");
}
else
{
    Console.WriteLine($"Número {variavelQueSalvaUmNumero} é impar");
}

// Contador de 1 a 5
for (int i =1; i<=5; i++)
{
    Console.WriteLine(i);
}
    
