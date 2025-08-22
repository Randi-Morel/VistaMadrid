namespace VistaMadrid.MP.EF
{
    public class ItemFactura
    {
        public int ID_Producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }

        public decimal Subtotal => PrecioVenta * Cantidad;
    }
}
