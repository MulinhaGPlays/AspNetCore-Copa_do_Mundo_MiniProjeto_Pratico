//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopaDoMundo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alocacao
    {
        public int IDArea { get; set; }
        public int IDTor { get; set; }
        public Nullable<System.DateTime> alocacaodata { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual Torcedor Torcedor { get; set; }
    }
}
