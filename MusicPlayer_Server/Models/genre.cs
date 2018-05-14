namespace MusicPlayer_Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("genre")]
    public partial class genre
    {
        [Key]
        public int genre_id { get; set; }

        [Required]
        [StringLength(255)]
        public string genre_name { get; set; }

        public DateTime updated_at { get; set; }
    }
}
