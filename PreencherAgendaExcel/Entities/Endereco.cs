using System;
using System.Collections.Generic;
using System.Text;

namespace PreencherAgendaExcel.Entities
{
    class Endereco
    {

        public string Local { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public Endereco()
        {
        }

        public void BuscaCep(string cepParaBusca) 
        {
            
        }
    }
}
