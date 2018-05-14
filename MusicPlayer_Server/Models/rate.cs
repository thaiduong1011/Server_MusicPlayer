namespace MusicPlayer_Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rate")]
    public partial class rate
    {
        [Key]
        public int rate_id { get; set; }

        public int song_id { get; set; }

        [Column("rate")]
        public byte? rate1 { get; set; }

        [StringLength(255)]
        public string comment { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime updated_at { get; set; }

        public virtual song song { get; set; }
    }
}
