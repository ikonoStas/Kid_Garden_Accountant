//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursach
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit_Tabel
    {
        public int ID_Visit_Tabel { get; set; }
        public int Personal_Account_ID { get; set; }
        public int Visit_Days_Amount { get; set; }
        public int Month_Code { get; set; }
    
        public virtual Kids__Personal_Account Kids__Personal_Account { get; set; }
        public virtual Month Month { get; set; }
    }
}
