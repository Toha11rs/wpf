//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DauevaApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requests()
        {
            this.Comments = new HashSet<Comments>();
        }
    
        public long id { get; set; }
        public System.DateTime StartDate { get; set; }
        public long CarType_id { get; set; }
        public string CarModel { get; set; }
        public string Problem { get; set; }
        public long Status_id { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string RepairParts { get; set; }
        public Nullable<long> Master_id { get; set; }
        public long Client_id { get; set; }
    
        public virtual CarType CarType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Statuses Statuses { get; set; }
        public virtual Users Master { get; set; }
        public virtual Users Client { get; set; }
    }
}
