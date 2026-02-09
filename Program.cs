Console.Clear();

/*
Console.Write("digite o 1° número: ");
double a = double.Parse(Console.ReadLine());

Console.Write("digite o 2° número: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Soma: {a} + {b} = {a + b}\nSubtração: {a} - {b} = {a - b}\nMultiplicação: {a} x {b} = {a * b}\nDivisão: {a} / {b} = {a / b}");
*/


/*
Console.Write("digite o 1° número: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine($"o dobro de {a} é {a*2}. O triplo de {a} é {a*3}.");
*/


/*
Console.Write("digite seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Olá {nome}, seja bem-vindo.");
*/


/*
Console.Write("digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine($"em 10 anos vocÊ terá {idade + 10} anos.");
*/


/*
Console.Write("digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("é par.");
}
else
{
    Console.WriteLine("é ímpar.");
}
*/


/*
Console.Write("digite o 1° número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("digite o 2° número: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("o 1° número é maior.");
}
else if (n1 == n2)
{
    Console.WriteLine("os dois números são iguais.");
}
else
{
    Console.WriteLine("o 2° número é maior.");
}
*/


/*
double nota = 100;

while (nota > 10 || nota < 0)
{
    Console.Write("digite sua nota (1-10): ");
    nota = double.Parse(Console.ReadLine());
}

if (nota >= 7)
{
    Console.WriteLine("está aprovado.");
}
else if (nota >= 5)
{
    Console.WriteLine("está em recuperação.");
}
else
{
    Console.WriteLine("está reprovado.");
}
*/


/*
Console.Write("digite a idade da pessoa: ");
int idade = int.Parse(Console.ReadLine());

if (idade < 18)
{
    Console.WriteLine("menor de idade.");
}
else if (idade >= 18 && idade < 60)
{
    Console.WriteLine("adulta.");
}
else if (idade >= 60)
{
    Console.WriteLine("idosa");
}
*/


/*
Console.Write("digite um número: ");
int numero = int.Parse(Console.ReadLine());

if (numero < 0)
{
    Console.WriteLine("número negativo.");
}
else if (numero == 0)
{
    Console.WriteLine("zero");
}
else
{
    Console.WriteLine("número positivo.");
}
*/


/*
for(int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
*/


/*
for(int i = 1; i <= 50; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
///////////////////////////////
for(int i = 2; i <= 50; i += 2)
{
    Console.WriteLine(i);
}
*/


/*
Console.Write("digite um número: ");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} X {i} = {numero * i}");
}
*/


/*
int numero = 1;
int soma = 0;

while (numero != 0)
{
    Console.WriteLine("digite um número: ");
    numero = int.Parse(Console.ReadLine());

    soma += numero;
}

Console.WriteLine($"soma dos números = {soma}");
*/


/*
int[] numeros = new int[5];
int positivos = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"digite o {i + 1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    if (numeros[i] > 0)
    {
        positivos++;
    }
}

Console.WriteLine($"você digitou {positivos} números positivos.");
*/


/*
Console.Write("1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\nOpção escolhida: ");
int opcao = int.Parse(Console.ReadLine());

Console.Write("Digite o 1° número: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Digite o 2° número: ");
int b = int.Parse(Console.ReadLine());


switch (opcao)
{
    case 1:
        Console.WriteLine($"{a} + {b} = {a + b}");
        break;

    case 2:
        Console.WriteLine($"{a} - {b} = {a - b}");
        break;

    case 3:
        Console.WriteLine($"{a} x {b} = {a * b}");
        break;

    case 4:
        Console.WriteLine($"{a} / {b} = {a / b}");
        break;
}
*/


/*
int numero = 0;

while (numero < 1 || numero > 7)
{
    Console.Write("Digite um número de 1 a 7: ");
    numero = int.Parse(Console.ReadLine());
}

switch (numero)
{
    case 1:
        Console.WriteLine("Domingo.");
        break;
    case 2:
        Console.WriteLine("Segunda-Feira.");
        break;
    case 3:
        Console.WriteLine("Terça-Feira.");
        break;
    case 4:
        Console.WriteLine("Quarta-Feira.");
        break;
    case 5:
        Console.WriteLine("Quinta-Feira.");
        break;
    case 6:
        Console.WriteLine("Sexta-Feira.");
        break;
    case 7:
        Console.WriteLine("Sábado.");
        break;

}
*/


/*
int codigo = 0;

while (codigo < 1 || codigo > 3)
{
    Console.Write("Digite o código do produto (1-3): ");
    codigo = int.Parse(Console.ReadLine());
}

switch (codigo)
{
    case 1:
        Console.WriteLine("O código 1 representa ALIMENTO.");
        break;

    case 2:
        Console.WriteLine("O código 2 representa BEBIDA.");
        break;

    case 3:
        Console.WriteLine("O código 3 representa LIMPEZA.");
        break;
}
*/


/*
int[] numeros = new int[10];

int soma = 0;
int maior = int.MinValue;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {i + 1}° número: ");
    numeros[i] = int.Parse(Console.ReadLine());

    soma += numeros[i];

    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }
}
double media = soma / numeros.Length;

Console.WriteLine($"Soma = {soma}\nMédia = {media}\nMaior Número = {maior}");
*/


/*
double idade = 1;
double soma = 0;
int quantidade = 0;

while (idade > 0)
{
    Console.Write("Digite a idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade > 0)
    {
        quantidade++;
        soma += idade;
    }
}

double media = soma / quantidade;

Console.WriteLine($"Média das idades = {media}.");
*/


/*
Console.Write("Quer ler quantos números? ");
int quantidade = int.Parse(Console.ReadLine());

int pares = 0;
int impares = 0;

for (int i = 1; i <= quantidade; i++)
{
    Console.Write($"Digite o {i}° número: ");
    int numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}
Console.WriteLine($"Você digitou {pares} par(es) e {impares} ímpar(es)");
*/