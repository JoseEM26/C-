﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea3_GuiaMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NegociosEntities : DbContext
    {
        public NegociosEntities()
            : base("name=NegociosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<USP_PRODUCTOLISTARE_Result> USP_PRODUCTOLISTARE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<USP_PRODUCTOLISTARE_Result>("USP_PRODUCTOLISTARE");
        }
    }
}
