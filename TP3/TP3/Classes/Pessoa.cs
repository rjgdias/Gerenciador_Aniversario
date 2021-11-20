using System;
using System.Collections.Generic;
using System.Text;

namespace TP3.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime Data { get; set; }
        public int CalcularDat()
        {
            int nDias;
            DateTime dataAt = DateTime.Today;
            DateTime proximaData = Data.AddYears(dataAt.Year - Data.Year);
            if (proximaData < dataAt)
                proximaData = proximaData.AddYears(1);
            nDias = (proximaData - dataAt).Days;
            return nDias;
        }
    }
}
