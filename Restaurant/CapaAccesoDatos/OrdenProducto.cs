//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaAccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdenProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrdenProducto()
        {
            this.ProductoVariante = new HashSet<ProductoVariante>();
        }
    
        public int id_orden_producto { get; set; }
        public int id_orden { get; set; }
        public Nullable<int> id_tipo_producto { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public string comentarios { get; set; }
        public string status { get; set; }
        public string verificador { get; set; }
    
        public virtual Orden Orden { get; set; }
        public virtual TipoProducto TipoProducto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductoVariante> ProductoVariante { get; set; }
    }
}
