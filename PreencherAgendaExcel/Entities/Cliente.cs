using System;
using System.Collections.Generic;
using System.Text;

namespace PreencherAgendaExcel.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public Convenio Convenio { get; set; }
        public string Genero { get; set; }
        
        private int _idade;
        
        public int Idade 
        {
            get 
            {
                return _idade;
            }
            
            set
            {
                
            }
        }

    }
}
