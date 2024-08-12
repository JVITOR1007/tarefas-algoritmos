/*
void Escreva(string msg){
         Console.WriteLine(msg);

}

void MostrarIdade(string nome, int idade){
    Escreva($"{nome} tem {idade}");
}
MostrarIdade("azpilicueta", 34);

void CalcularIdade(string nome, int ano)
{
    int idade = 2024 - ano;
    MostrarIdade(nome,idade);
}
CalcularIdade("azpilicueta", 2019);

int mior(int a, int b)
{
    if(a >= b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine(mior(12,122));
Console.WriteLine(mior(132,32));
Console.WriteLine(mior(299,76));
Console.WriteLine(mior(11234,12222));

float resultado;

resultado = (2*100 + 3*50) / 5f;
Console.WriteLine("a média é: " + resultado);

resultado = (2*90 + 3*89) / 5f;
Console.WriteLine("a média é: " + resultado);

resultado = (2*86 + 3*45) / 5f;
Console.WriteLine("a média é: " + resultado);

void Calcule(int a, int b)
{
    float resultado = (a+b)/2f;
    Console.WriteLine("a média é: " + resultado);
}
Calcule(100,60);
Calcule(40,50);
Calcule(78,90);









*/










using System.Security.Cryptography.X509Certificates;

void Soma(float a, float b){
     float resultado = a + b;
     Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtracao(float a, float b){
     float resultado = a - b;
     Console.WriteLine($"{a} - {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} x {b} = {resultado}");
}

void Divisao(float a, float b){
    if(b == 0){
        Console.WriteLine("Ei mano, infelizmente você caiu na pegadinha do mario games e teve erro de divisão por zero!");
    }
     float resultado = a / b;
     Console.WriteLine($"{a} : {b} = {resultado}");
} 

float a;
float b;

void DigitarAeB(string operacao){
    Console.WriteLine(operacao);
    Console.WriteLine("Digite oque vc quiser mush, um valor de a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite oque vc quiser skibidi, um valor de b:");
    b = float.Parse(Console.ReadLine());

}

Console.WriteLine("--- ------------------------------------calculadora do mush -------------------------------------------");
Console.WriteLine("1 - Soma, igual a soma das noobasdas que voce dar no lol");
Console.WriteLine("2 - Subtração, como sua namorada fez com vc no dia 21/04/2024 ás 17:23 no domingo na praça do flores ");
Console.WriteLine("3 - Multiplicação, Multiplica o tanto de vezes que vc foi beta");
Console.WriteLine("4 - Divisão, igual ao seu prata no valorant");
Console.WriteLine("5 - Sair, para assistir skibidi toaleit");
Console.WriteLine("------------------------------------------------------------------------------------------------------- ");
Console.WriteLine("Digite a opção mais alpha e rei do streif");

int opcao = int.Parse(Console.ReadLine());

if(opcao == 1){
    DigitarAeB("Soma");
    Soma(a,b);
}
 else if(opcao == 2){
    DigitarAeB("Subtração");
    Subtracao(a, b);
 }
 else if(opcao == 3){
    DigitarAeB("Multiplicação");
    Multiplicacao(a,b);
 }
 else if(opcao == 4){
    DigitarAeB("Divisão");
    Divisao(a, b);
 }
 else if(opcao == 5){
    Console.WriteLine("Saindo para vc assistir skibidi tiolet...");
 }
 else{Console.WriteLine("Opção errada platina");}