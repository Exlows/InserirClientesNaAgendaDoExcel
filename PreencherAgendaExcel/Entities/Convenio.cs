using System;
using System.Collections.Generic;
using System.Text;

namespace PreencherAgendaExcel.Entities
{
    public class Convenio
    {
        public string NomeDaEmpresa { get; set; }
        public string PlanoDeSaude { get; set; }

        public Convenio()
        {
        }

        public Convenio(string nomeDaEmpresa, string planoDeSaude)
        {
            NomeDaEmpresa = nomeDaEmpresa;
            PlanoDeSaude = planoDeSaude;
        }
    }
}
