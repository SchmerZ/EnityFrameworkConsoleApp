//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnityFrameworkConsoleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class MailMessageFile
    {
        public int Id { get; set; }
        public int MailMessageId { get; set; }
        public string OriginalName { get; set; }
        public string FilePath { get; set; }
        public string MimeType { get; set; }
        public bool AllowToZip { get; set; }
        public int FileLocationId { get; set; }
    
        public virtual MailMessage MailMessage { get; set; }
    }
}
