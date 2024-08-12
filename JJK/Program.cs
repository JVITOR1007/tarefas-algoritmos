
/* Console.WriteLine("Seu nome bonitão");

string user1 = Console.ReadLine();

Console.WriteLine("Olá " + user1 + ", Digita a letra");


int a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de b");

int b = int.Parse(Console.ReadLine());
int c = a * b;
Console.WriteLine($"A Multiplicação de {a} x {b} é igual a {c}");

Console.WriteLine("Digite um numero");

int num1 = int.Parse(Console.ReadLine());

bool Impar = ( (num1 % 2 ) > 0  );

if(Impar){
    Console.WriteLine("Numero impar");
}

else{
    Console.WriteLine("Numero par");
} 

Console.WriteLine("Crie sua senha:");
string senha = Console.ReadLine();

Console.WriteLine("Bem vindo de novo seu zaruto");
Console.WriteLine("Digite a senha");

string senhaDigitada = Console.ReadLine();

if(senha == senhaDigitada)
{
    Console.WriteLine("Entrou");
}
else{
    Console.WriteLine("Senha incorreta");
}
*/

Console.WriteLine("Digite uma nota:");
int nota = int.Parse(Console.ReadLine());

if(nota >= 60)
{
    Console.WriteLine("Aprovado");
}
else if(nota >= 20)
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Reprovado");
}