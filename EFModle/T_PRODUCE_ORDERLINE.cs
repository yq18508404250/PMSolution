//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModle
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PRODUCE_ORDERLINE
    {
        public string BILLCODE { get; set; }
        public decimal LINENUM { get; set; }
        public string CIGARETTECODE { get; set; }
        public string CIGARETTENAME { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<decimal> PRICE { get; set; }
        public string UNIT { get; set; }
        public Nullable<decimal> MOENY { get; set; }
        public Nullable<decimal> MULTIPLE { get; set; }
        public string ALLOWSORT { get; set; }
    }
}