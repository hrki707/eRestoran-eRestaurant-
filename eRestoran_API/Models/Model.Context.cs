﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class eRestoranEntities : DbContext
    {
        public eRestoranEntities()
            : base("name=eRestoranEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dostave> Dostave { get; set; }
        public virtual DbSet<Klijenti> Klijenti { get; set; }
        public virtual DbSet<KreditneKartice> KreditneKartice { get; set; }
        public virtual DbSet<Narudzbe> Narudzbe { get; set; }
        public virtual DbSet<NarudzbeStavke> NarudzbeStavke { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Popusti> Popusti { get; set; }
        public virtual DbSet<PopustiStavke> PopustiStavke { get; set; }
        public virtual DbSet<StavkeMenija> StavkeMenija { get; set; }
        public virtual DbSet<TipoviStavke> TipoviStavke { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }
        public virtual DbSet<ZaposleniciUloge> ZaposleniciUloge { get; set; }
    
        public virtual ObjectResult<esp_IzvjestajProdatiArtikli_Result> esp_IzvjestajProdatiArtikli()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_IzvjestajProdatiArtikli_Result>("esp_IzvjestajProdatiArtikli");
        }
    
        public virtual ObjectResult<esp_IzvjestajProdatiArtikliKupac_Result> esp_IzvjestajProdatiArtikliKupac(Nullable<int> kupacID)
        {
            var kupacIDParameter = kupacID.HasValue ?
                new ObjectParameter("kupacID", kupacID) :
                new ObjectParameter("kupacID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_IzvjestajProdatiArtikliKupac_Result>("esp_IzvjestajProdatiArtikliKupac", kupacIDParameter);
        }
    
        public virtual ObjectResult<esp_IzvjestajTop5NajskupljihNarudzbi_Result> esp_IzvjestajTop5NajskupljihNarudzbi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_IzvjestajTop5NajskupljihNarudzbi_Result>("esp_IzvjestajTop5NajskupljihNarudzbi");
        }
    
        public virtual ObjectResult<esp_IzvjestajTop5ProdavanihArtikala_Result> esp_IzvjestajTop5ProdavanihArtikala()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_IzvjestajTop5ProdavanihArtikala_Result>("esp_IzvjestajTop5ProdavanihArtikala");
        }
    
        public virtual ObjectResult<esp_NajcesciProizvodi_Result> esp_NajcesciProizvodi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_NajcesciProizvodi_Result>("esp_NajcesciProizvodi");
        }
    
        public virtual ObjectResult<esp_NajKupljeneStavke_Result> esp_NajKupljeneStavke(Nullable<int> klijentId)
        {
            var klijentIdParameter = klijentId.HasValue ?
                new ObjectParameter("KlijentId", klijentId) :
                new ObjectParameter("KlijentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_NajKupljeneStavke_Result>("esp_NajKupljeneStavke", klijentIdParameter);
        }
    
        public virtual ObjectResult<esp_NarudzbePregled_Result> esp_NarudzbePregled()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_NarudzbePregled_Result>("esp_NarudzbePregled");
        }
    
        public virtual ObjectResult<esp_OcjeneByStavka_Result> esp_OcjeneByStavka(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_OcjeneByStavka_Result>("esp_OcjeneByStavka", idParameter);
        }
    
        public virtual ObjectResult<esp_OcjenePrikaz_Result> esp_OcjenePrikaz()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_OcjenePrikaz_Result>("esp_OcjenePrikaz");
        }
    
        public virtual ObjectResult<esp_OcjeneStavkaPrikaz_Result> esp_OcjeneStavkaPrikaz(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<esp_OcjeneStavkaPrikaz_Result>("esp_OcjeneStavkaPrikaz", idParameter);
        }
    }
}