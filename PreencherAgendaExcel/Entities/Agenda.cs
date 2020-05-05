using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PreencherAgendaExcel.Entities
{
    public class Agenda
    {
        public Cliente Paciente { get; set; }
        public string pathDaAgendaexcel = "C:\\zWorkFolder\\PreencherAgendaExcel\\AGENDAKATIA.xlsx";

        public Agenda(Cliente cliente)
        {
            Paciente = cliente;
        }


        public void SalvarClienteNoExcel()
        {
            var workbook = new XLWorkbook(pathDaAgendaexcel);

            var ws = workbook.Worksheet("Contatos01");

            int linha = ProcurarLinhaVazia();

            Console.WriteLine($"Linha Vazia: {linha}");

            ws.Cell($"A{linha}").Value = Paciente.Nome.ToUpper();
            ws.Cell($"B{linha}").Value = Paciente.Genero.ToString().ToUpper();
            ws.Cell($"C{linha}").Value = Paciente.DataDeNascimento.ToShortDateString();
            ws.Cell($"D{linha}").Value = Paciente.Idade.ToString().ToUpper();
            ws.Cell($"E{linha}").Value = Paciente.Email;
            ws.Cell($"F{linha}").Value = Paciente.Telefone.ToString();
            ws.Cell($"G{linha}").Value = Paciente.Convenio.NomeDaEmpresa.ToString().ToUpper();
            ws.Cell($"H{linha}").Value = Paciente.Convenio.PlanoDeSaude.ToString().ToUpper();
            ws.Cell($"I{linha}").Value = Paciente.Endereco.Local.ToString().ToUpper();
            ws.Cell($"J{linha}").Value = Paciente.Endereco.Numero;
            ws.Cell($"K{linha}").Value = Paciente.Endereco.Complemento.ToString().ToUpper();
            ws.Cell($"L{linha}").Value = Paciente.Endereco.Bairro.ToString().ToUpper();
            ws.Cell($"M{linha}").Value = Paciente.Endereco.Cidade.ToString().ToUpper();
            ws.Cell($"N{linha}").Value = Paciente.Endereco.Estado.ToString().ToUpper();
            string cep = Paciente.Endereco.CEP.ToString();
            ws.Cell($"O{linha}").Value = cep;

            Console.WriteLine("SALVO COM SUCESSO");

            workbook.SaveAs(pathDaAgendaexcel);
        }

        public int ProcurarLinhaVazia()
        {
            var workbook = new XLWorkbook(pathDaAgendaexcel);

            var ws = workbook.Worksheet("Contatos01");

            int linha = 1;

            while (!ws.Cell($"A{linha}").IsEmpty())
            {
                linha++;
            }

            return linha;
        }
    }
}
