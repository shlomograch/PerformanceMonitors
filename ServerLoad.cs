namespace ServerLoadWriter
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServerLoad")]
    public partial class ServerLoad
    {
        [Key]
        public int Id { get; set; }

        public string DnsName { get; set; }

        public string CpuUtilization { get; set; }

        public string MemoryUtilization { get; set; }

        public string Date { get; set; }
    }
}
