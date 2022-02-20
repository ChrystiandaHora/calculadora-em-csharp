using System;

class MainClass {
  public static void Main (string[] args) {
    //adicionar variáveis
    double n1, n2, n3;
    double media;

    //aparecer na tela o comando para digitar a nota e ler a nota escrita
    Console.WriteLine(" Digite o primeiro valor ");
    n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" Digite o segundo valor ");
    n2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine(" Digite o terceiro valor ");
    n3 = Convert.ToDouble(Console.ReadLine());

    //cálculo da média
    media = (n1 + n2 + n3) /3;
    Console.WriteLine("Sua média foi: " + media);
    Console.ReadKey();


   //nao mexer
  }
}