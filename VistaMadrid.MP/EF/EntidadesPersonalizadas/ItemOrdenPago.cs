namespace VistaMadrid.MP.EF
{
    public class ItemOrdenPago
    {
        public int ID_Orden { get; set; }
        public string Cliente { get; set; }
        public string Mesa { get; set; }
        public string Condicion { get; set; }
        public decimal Total { get; set; }
        public decimal? SaldoPendiente { get; set; }

        public decimal MontoAPagar { get; set; }
    }
}
