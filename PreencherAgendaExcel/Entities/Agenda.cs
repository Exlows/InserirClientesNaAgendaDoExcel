using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
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

            var worksheet = workbook.Worksheet("Contatos01");

            int linha = ProcurarLinhaVazia();

            Console.WriteLine($"Linha Vazia: {linha}");

            worksheet.Cell($"A{linha}").Value = Paciente.Nome.ToUpper();
            worksheet.Cell($"B{linha}").Value = Paciente.Genero.ToString().ToUpper();
            worksheet.Cell($"C{linha}").Value = Paciente.DataDeNascimento.ToShortDateString();
            worksheet.Cell($"D{linha}").Value = Paciente.Idade.ToString().ToUpper();
            worksheet.Cell($"E{linha}").Value = Paciente.Email;
            worksheet.Cell($"F{linha}").Value = Paciente.Telefone.ToString();
            worksheet.Cell($"G{linha}").Value = Paciente.Convenio.NomeDaEmpresa.ToString().ToUpper();
            worksheet.Cell($"H{linha}").Value = Paciente.Convenio.PlanoDeSaude.ToString().ToUpper();
            worksheet.Cell($"I{linha}").Value = Paciente.Endereco.Logradouro.ToString().ToUpper();
            worksheet.Cell($"J{linha}").Value = Paciente.Endereco.Numero;
            worksheet.Cell($"K{linha}").Value = Paciente.Endereco.Complemento.ToString().ToUpper();
            worksheet.Cell($"L{linha}").Value = Paciente.Endereco.Bairro.ToString().ToUpper();
            worksheet.Cell($"M{linha}").Value = Paciente.Endereco.Cidade.ToString().ToUpper();
            worksheet.Cell($"N{linha}").Value = Paciente.Endereco.Estado.ToString().ToUpper();
            string cep = Paciente.Endereco.CEP.ToString();
            worksheet.Cell($"O{linha}").Value = cep;

            workbook.SaveAs(pathDaAgendaexcel);
            Console.WriteLine("SALVO COM SUCESSO");
            Console.WriteLine();

            workbook.Dispose();

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
