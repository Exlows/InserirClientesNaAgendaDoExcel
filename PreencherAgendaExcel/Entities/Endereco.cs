using System;
using System.Collections.Generic;
using System.Text;
using ViaCep;

namespace PreencherAgendaExcel.Entities
{
    public class Endereco
    {
        public string CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        private string _local;
        private string _bairro;
        private string _cidade;
        private string _estado;
        

        public Endereco()
        {
        }

        public Endereco(string cep, int numero, string complemento)
        {
            CEP = cep;
            Numero = numero;
            Complemento = complemento;
            _local = Local;
            _bairro = Bairro;
            _cidade = Cidade;
            _estado = Estado;
            
        }

        public string Local
        {
            get
            {
                string local = new ViaCepClient().Search(CEP).Street;
                return local;
            }
        }

        public string Bairro
        {
            get
            {
                string bairro = new ViaCepClient().Search(CEP).Neighborhood;
                return bairro;
            }
        }

        public string Cidade
        {
            get
            {
                string cidade = new ViaCepClient().Search(CEP).City;
                return cidade;
            }
        }

        public string Estado
        {
            get
            {
                string estado = new ViaCepClient().Search(CEP).StateInitials;
                return estado;
            }
        }

        public override string ToString()
        {
            return $"ENDEREÇO:\n" +
                $"Local: {_local}\n" +
                $"Numero: {Numero}\n" +
                $"Complemento: {Complemento}\n" +
                $"Bairro: {_bairro}\n" +
                $"Cidade: {_cidade}\n" +
                $"Estado: {_estado}\n" +
                $"Cep: {CEP}\n";
        }
    }
}
