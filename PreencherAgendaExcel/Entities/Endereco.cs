using System;
using System.Collections.Generic;
using System.Text;
using ViaCep;

namespace PreencherAgendaExcel.Entities
{
    public class Endereco
    {
        public string CEP { get; }
        public int Numero { get; }
        public string Complemento { get;}
        public string  Logradouro { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }


        public Endereco(string cep, int numero, string complemento, string logradouro = "", string bairro = "")
        {
            CEP = cep;
            Numero = numero;
            Complemento = complemento;

            var viaCepResult = new ViaCepClient().Search(CEP);

            //Logradouro = !string.IsNullOrEmpty(viaCepResult.Street) ? viaCepResult.Street : logradouro;
            Logradouro = viaCepResult.Street ?? logradouro;

            if (!string.IsNullOrEmpty(viaCepResult.Neighborhood))
            {
                Bairro = viaCepResult.Neighborhood;
            }
            else
            {
                Bairro = bairro;
            }

            Cidade = viaCepResult.City;
            Estado = viaCepResult.StateInitials;
        }


        //public override string ToString()
        //{
        //    return $"ENDEREÇO:\n" +
        //        $"Local: {_local}\n" +
        //        $"Numero: {Numero}\n" +
        //        $"Complemento: {Complemento}\n" +
        //        $"Bairro: {_bairro}\n" +
        //        $"Cidade: {_cidade}\n" +
        //        $"Estado: {_estado}\n" +
        //        $"Cep: {CEP}\n";
        //}
    }
}
