using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE_W05L01.Models
{
    public class Pagamenti
    {
        // sempre senza id del pagamento
        public int IdDipendente { get; set; }
        public DateTime PeriodoPagamento { get; set; }
        public decimal AmmontarePagamento { get; set; }
        public bool TipoPagamento { get; set; }

        Pagamenti() { }
        Pagamenti(int idDipendente, DateTime periodopagamento, decimal ammontare, bool tipo)
        {
            IdDipendente = idDipendente;
            PeriodoPagamento = periodopagamento;
            AmmontarePagamento = ammontare;
            TipoPagamento = tipo;
        }
    }
}