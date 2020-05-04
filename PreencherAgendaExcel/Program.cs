using PreencherAgendaExcel.Entities;
using System;
using System.Globalization;
using System.Threading;

namespace PreencherAgendaExcel
{
    class Program
    {

        static void Main(string[] args)
        {
            string nome = "Bruno";
            DateTime nascimento = DateTime.Parse("28/01/1986");
            string email = "bruno@gmail.com";
            string telefone = "11973200555";
            string nomeEmpresaConvenio = "Bradesco";
            string nomePLanoDeSaude = "Completo enfermaria";
            string genero = "Masculino";

            Cliente cliente = new Cliente(nome, nascimento, email, telefone, new Convenio(nomeEmpresaConvenio, nomePLanoDeSaude), genero);

            Console.WriteLine(cliente);
        }
    }
}
