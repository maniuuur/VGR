//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Video_Games_Rental.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class game
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public game()
        {
            this.order_detail = new HashSet<order_detail>();
        }
    
        public int game_id { get; set; }
        public int platform_id { get; set; }
        public int language_id { get; set; }
        public int genre_id { get; set; }
        public int condition_id { get; set; }
        public string title { get; set; }
        public int amount { get; set; }
        public decimal price { get; set; }
        public string image { get; set; }
        public string description { get; set; }
    
        public virtual condition condition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_detail> order_detail { get; set; }
        public virtual genre genre { get; set; }
        public virtual language language { get; set; }
        public virtual platform platform { get; set; }
    }
}
