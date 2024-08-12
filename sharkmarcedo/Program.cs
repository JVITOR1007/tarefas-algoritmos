Console.WriteLine("Digite o valor da nota1");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da nota2");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da nota3");
int nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da nota4");
int nota4 = int.Parse(Console.ReadLine());

float media = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10f;
Console.WriteLine("Média da disciplina: " + media);
if(media >= 60){
    Console.WriteLine("aprovado");
    return;
}
else if (media < 20){
    Console.WriteLine("reprovado amostradinho");
    return;
}
else{
    Console.WriteLine("recuperação oh vacilão faz o L");
}