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
            string cep = "02315130";
            int numero = 49;
            string complemento = "Casa 01";

            Endereco endereco = new Endereco(cep, numero, complemento);
            Console.WriteLine(endereco);
        }
    }
}
