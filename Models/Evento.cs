namespace MauiAg15.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public decimal CustoPorParticipante { get; set; }

        // Calcula a duração do evento em dias
        public int DuracaoDias => (int)(DataTermino - DataInicio).TotalDays + 1;

        // Calcula o custo total do evento
        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante * DuracaoDias;
    }
}
