//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webapi_galileo
{
    using System;
    using System.Collections.Generic;
    
    public partial class GAL_1200
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GAL_1200()
        {
            this.GAL_1201 = new HashSet<GAL_1201>();
        }
    
        public long COD_CLIE { get; set; }
        public string RIF_CLIE { get; set; }
        public string NIT_CLIE { get; set; }
        public string RS_CLIE { get; set; }
        public string DIR_CLIE { get; set; }
        public string TEL1_CLIE { get; set; }
        public string TEL2_CLIE { get; set; }
        public string FAX_CLIE { get; set; }
        public string CE_CLIE { get; set; }
        public string URL_CLIE { get; set; }
        public string CONTACTO_CLIE { get; set; }
        public Nullable<decimal> SALDO_CLIE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAL_1201> GAL_1201 { get; set; }
    }
}
