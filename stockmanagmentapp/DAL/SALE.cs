//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace stockmanagmentapp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SALE
    {
        public int id { get; set; }
        public int productid { get; set; }
        public int customerid { get; set; }
        public int categoryid { get; set; }
        public int productsalesamount { get; set; }
        public int productsalesprice { get; set; }
        public System.DateTime salesdate { get; set; }
        public bool isdeleted { get; set; }
        public Nullable<System.DateTime> deleteddate { get; set; }
    }
}
