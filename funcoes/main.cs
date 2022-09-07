using System;

class Program
{
    public static void Main(string[] args)
    {

        //Chamando a função Bem-Vindo!!
        BemVindo();

        //Chamando a função soma
        int soma1 = Soma(3, 4);
        Console.WriteLine("Soma 1 = " + soma1);


        //Chamando a função comparação
        Console.Write("Digite o primeiro numero: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double valor2 = double.Parse(Console.ReadLine());

        double comparacao = Comparacao(valor1, valor2);

        Console.WriteLine("O maior valor entre " + valor1 + " e " + valor2 +  " é: " + comparacao);

        //chamando a função acumulado
        Console.Write("Digite um numero qualquer inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        int soma = Acumulado(numero);
        Console.WriteLine("O acumulado de 1 até " + numero + " é: " +  soma);


    }

    //declaração de uma função Ola Mundo
    static void BemVindo()
    {
        Console.WriteLine("Seja bem-vindo!!");
    }

    //declarando a função soma
    static int Soma(int n1, int n2)
    {
        int resultado = n1 + n2;
        return resultado;

    }

    //declarando a função de comparação
    static double Comparacao(double num1, double num2){
       
        double resultado;

        if(num1 >= num2){
            resultado = num1;
        }else{
            resultado = num2;
        }
        return resultado;
    }

    //função soma os numeros de 1 a N
    //Assumindo que N é maior que zero
    static int Acumulado(int numero){

        int s = 0;

        for(int cont = 1; cont <= numero; cont++){
            s = s + cont;
        }

        return s;
    }
}