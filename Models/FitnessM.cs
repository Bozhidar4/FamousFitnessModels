//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FamousFitnessModels.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FitnessM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FitnessM()
        {
            this.Photo = "https://img02.deviantart.net/9471/i/2016/257/6/6/famous_healty_bread__jaco_de_bru" +
        "yn_by_thefabulouscroissant-dahoywe.png";
        }
    
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
    }
}
