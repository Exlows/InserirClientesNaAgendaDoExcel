using PreencherAgendaExcel.Entities;
using PreencherAgendaExcel.Entities.Enums;
using System;
using System.Globalization;
using System.Threading;

namespace PreencherAgendaExcel
{
    class Program
    {

        static void Main(string[] args)
        {
            var resposta = "S";
            while (resposta != "N")
            {
                Console.Clear();

                Console.WriteLine("DADOS DO CLIENTE: ");
                Console.WriteLine("---------------------------------------------------------------");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Data do nascimento [dd/mm/aaaa]: ");
                DateTime nascimento = DateTime.Parse(Console.ReadLine());
                Console.Write("Email : ");
                string email = Console.ReadLine();
                Console.Write("Telefone: ");
                string telefone = Console.ReadLine();
                Console.Write("Genero [1: Masculino / 2: Feminino]: ");
                GeneroCliente genero = (GeneroCliente)Enum.ToObject(typeof(GeneroCliente), int.Parse(Console.ReadLine()));
                Console.WriteLine();
                Console.WriteLine("DADOS DO CONVENIO:");
                Console.WriteLine("---------------------------------------------------------------");
                Console.Write("Empresa do Convenio: ");
                string empresaDoConvenio = Console.ReadLine();
                Console.Write("Plano de Saúde: ");
                string planoDeSaude = Console.ReadLine();
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("ENDEREÇO:");
                Console.Write("CEP: ");
                string cep = Console.ReadLine();
                Console.Write("Numero: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("Complemento: ");
                string complemento = Console.ReadLine();



                Cliente cliente = new Cliente(nome, nascimento, email, telefone, genero, new Convenio(empresaDoConvenio, planoDeSaude), new Endereco(cep, numero, complemento));
                Console.WriteLine();

                Console.WriteLine(cliente);
                Console.WriteLine();

                Console.Write("Deseja continuar [S/N]: ");
                resposta = Console.ReadLine().ToUpper();
            }
        }
    }
}
