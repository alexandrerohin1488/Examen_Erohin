//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen_Erohin
{
    using System;
    using System.Collections.Generic;
    
    public partial class SostavOrder
    {
        public int ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string ProductID { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual Order Order { get; set; }
    }
}