//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HOmework2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int ID { get; set; }
        public string FIO { get; set; }
        public Nullable<int> GROUP_ID { get; set; }
    
        public virtual Group Group { get; set; }
    }
}
