//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eRestoran_API.Models
{
    using System;
    
    public partial class esp_NarudzbePregled_Result
    {
        public int NarudzbaID { get; set; }
        public string imePrezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public System.DateTime Datum { get; set; }
        public Nullable<decimal> ukupnaCijena { get; set; }
    }
}
