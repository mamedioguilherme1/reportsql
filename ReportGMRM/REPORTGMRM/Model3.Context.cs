﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace REPORTGMRM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DemoDWGMRM2017Entities3 : DbContext
    {
        public DemoDWGMRM2017Entities3()
            : base("name=DemoDWGMRM2017Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetReportProducto_Result> GetReportProducto(Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate, string nombreProducto)
        {
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            var nombreProductoParameter = nombreProducto != null ?
                new ObjectParameter("nombreProducto", nombreProducto) :
                new ObjectParameter("nombreProducto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetReportProducto_Result>("GetReportProducto", fromDateParameter, toDateParameter, nombreProductoParameter);
        }
    }
}
