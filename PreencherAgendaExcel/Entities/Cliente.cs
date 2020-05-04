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

        public Cliente(string nome, DateTime dataDeNascimento, string email, string telefone, Convenio convenio, string genero)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
            Email = email;
            Telefone = telefone;
            Convenio = convenio;
            Genero = genero;
            _idade = Idade;
        }

        public int Idade 
        {
            get 
            {
                // Pega a data de nascimento inserida e coloca em uma variável
                DateTime dataDoNascimento = DateTime.Parse(DataDeNascimento.ToString());

                // Extrai o ano do nascimento para uma variável
                int anoDoNascimento = dataDoNascimento.Date.Year;
                // Cria uma variável auxiliar com o último dia e mês do ano e concatena com o ano do nascimento do cliente
                DateTime dataAuxiliar = DateTime.Parse($"31/12/{anoDoNascimento}");
                // Coloca em uma variável o dia do ano da variávl auxiliar, ou seja, 366 se for ano bissexto ou 365 se for normal
                int diaDoAnoDaDataAuxiliar = dataAuxiliar.Date.DayOfYear;

                // Coloca o dia do ano referente a data de nascimento em uma variável
                int diaDoAnoDoNascimento = dataDoNascimento.Date.DayOfYear;

                // Coloca em uma variável o dia do ano atual
                int diaDoAnoAtual = DateTime.Now.DayOfYear;
                // Verifica se o ano do nascimento do cliente não é bissexto. Caso não seja, diminui um dia do dia do ano atual pois 2020 é bissexto
                if (diaDoAnoDaDataAuxiliar != 366)
                {
                    diaDoAnoAtual = DateTime.Now.DayOfYear - 1;
                }

                // Encontra a idade subitraindo o ano atual do ano do nascimento
                int idade = DateTime.Now.Year - dataDoNascimento.Year;
                // Verifica se o dia do Ano atual é maior que o do nascimento, se for subtrai um ano pois ainda não fez aniversário
                if (diaDoAnoAtual > diaDoAnoDoNascimento)
                {
                    idade -= 1;
                }

                return idade;
            }
            
            set
            {
                
            }
        }


        public override string ToString()
        {
            return $"Cliente:\n" +
                $"Nome: {Nome}\n" +
                $"Data de Nascimento: {DataDeNascimento}\n" +
                $"Idade: {_idade}\n" +
                $"Email: {Email}\n" +
                $"Telefone: {Telefone}\n" +
                $"Genero: {Genero}\n" +
                $"Convenio Empresa: {Convenio.NomeDaEmpresa}\n" +
                $"Convenio PLano: {Convenio.PlanoDeSaude}";
        }
    }
}
