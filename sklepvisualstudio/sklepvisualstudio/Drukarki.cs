//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sklepvisualstudio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Drukarki
    {
        public string model { get; set; }
        public string typ { get; set; }
        public decimal cena { get; set; }
        public Nullable<bool> kolor_boolean { get; set; }
    
        public virtual Produkty Produkty { get; set; }
    }
}
