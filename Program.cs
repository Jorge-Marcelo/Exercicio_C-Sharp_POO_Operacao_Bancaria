using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_POO_Operação_Bancaria
{
 internal class Program
 {
  private static ContaBancaria conta;

  static void Main(string[] args)
  {
   Console.WriteLine("Bem-Vindo a sua Conta Bancaria");
   Console.WriteLine("--------------------------------------");

   Console.Write("Entre com o numero da conta: ");
   int numero = int.Parse(Console.ReadLine());
   Console.Write("Entre com o nome do titular da conta: ");
   string titular = Console.ReadLine();

   Console.Write("Havera Deposito (s/n): ");
   char resposta = char.Parse(Console.ReadLine());
   if (resposta == 's' || resposta == 'S'){
    Console.Write("Entre com o valor do deposito inicial: ");
   double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   conta = new ContaBancaria(numero, titular, depositoInicial);
}

   else { conta = new ContaBancaria(numero, titular); }

   Console.WriteLine("------------------------------------------------");
   Console.WriteLine(conta);

   Console.WriteLine("------------------------------------------------");
   Console.Write("Entre com um valor para deposito: ");
   double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   conta.Deposito(quantia);

   Console.WriteLine("------------------------------------------------");
   Console.WriteLine("Dados da conta atualizados: ");
   Console.WriteLine(conta);

   Console.WriteLine("------------------------------------------------");
   Console.Write("Entre com o valor para saque: ");
   quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   conta.Saque(quantia);

   Console.WriteLine("------------------------------------------------");
   Console.WriteLine("Dados da conta atualizados: ");
   Console.WriteLine(conta);

  }
 }
}
