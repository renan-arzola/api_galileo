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
    
    public partial class GAL_1300
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GAL_1300()
        {
            this.GAL_1310 = new HashSet<GAL_1310>();
        }
    
        public long COD_ENT { get; set; }
        public string DESC_ENT { get; set; }
        public string DES_ENT { get; set; }
        public string PLACAS_ENT { get; set; }
        public Nullable<decimal> COLOR_ENT { get; set; }
        public Nullable<decimal> AÑO_ENT { get; set; }
        public string ICONO_ENT { get; set; }
        public Nullable<long> cod_fleet { get; set; }
        public decimal SERIAL_ENT { get; set; }
        public string SERHEX_ENT { get; set; }
        public Nullable<decimal> connect_state { get; set; }
        public Nullable<decimal> index_tcp { get; set; }
        public Nullable<long> cod_op { get; set; }
        public decimal cod_tveh { get; set; }
        public string eco_ent { get; set; }
        public Nullable<decimal> tel_sim_ent { get; set; }
        public Nullable<decimal> ser_sim_ent { get; set; }
        public Nullable<decimal> cod_eq { get; set; }
    
        public virtual GAL_1102 GAL_1102 { get; set; }
        public virtual GAL_1201 GAL_1201 { get; set; }
        public virtual GAL_1302 GAL_1302 { get; set; }
        public virtual GAL_1304 GAL_1304 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GAL_1310> GAL_1310 { get; set; }
    }
}
