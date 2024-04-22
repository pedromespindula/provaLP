//Declare variáveis para armazenar altura, peso, idade e nome da pessoa
using Microsoft.VisualBasic;

do
{
Console.WriteLine("informe a altura");
double altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe o peso");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("informe a idade");
double idade = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o nome");
string nome = Console.ReadLine() ??""; //esse final do codigo foi o jeito que achei no google para tirar erro Conversão de literal nula ou possível valor nulo em tipo não anulável.CS8600

//Calcule o IMC usando a fórmula: IMC = peso / (altura * altura).
double imc = peso/(altura*altura);
Console.WriteLine($"O seu IMC é {imc}");
//Use if, if-else para determinar a categoria de IMC e a faixa etária da pessoa
if(imc<=18.5){
    Console.WriteLine("Seu IMC é magreza");
}else if(imc<=24.9){
    Console.WriteLine("Seu IMC é normal");
}else if(imc<=29.9){
    Console.WriteLine("Seu IMC é sobrepeso");
}else{
    Console.WriteLine("Seu imc é obesidade");
}
if(idade<=12){
    Console.WriteLine($"{nome} Sua faixa etaria é infantil");
}else if(idade<=17){
    Console.WriteLine($"{nome} Sua faixa etaria é adolescencia");
}else if(idade<=63){
    Console.WriteLine($"{nome} Sua faixa etaria é adulta");
}else{
    Console.WriteLine($"{nome} sSua faixa etaria é idosa");
}
    Console.WriteLine("Deseja continuar? (s/n)");
    string resposta = Console.ReadLine() ??"";
    if (resposta.ToLower() != "s"){
        break;
    }
    }while(true);  
//Use um loop do-while para permitir que o usuário insira os dados e gere relatórios múltiplas vezes






























































//1. O programa deverá perguntar o nome da pessoa.
// 2. Em seguida, perguntar a idade, altura e peso.
// 3. Calcule o IMC e determine a categoria de IMC (Abaixo do peso, Normal, Sobrepeso,
// Obeso).
// 4. Determine a faixa etária da pessoa (Criança, Adolescente, Adulto, Idoso).
// 5. Gere um relatório mostrando o nome, idade, IMC e faixa etária.
// 6. Pergunte ao usuário se ele gostaria de gerar um novo relatório para outra pessoa. Se
// sim, retorne ao passo 1; se não, encerre o programa