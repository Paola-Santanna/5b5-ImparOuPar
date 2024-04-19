// 1.Faça um algorítmo que leia um número e informe de ele é par ou ímpar.

int numero;

Console.WriteLine("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é PAR!");
} else
{
    Console.WriteLine($"O número {numero} é ÍMPAR!");
}