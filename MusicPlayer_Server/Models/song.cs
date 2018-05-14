namespace MusicPlayer_Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("song")]
    public partial class song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public song()
        {
            playlist_detail = new HashSet<playlist_detail>();
            rates = new HashSet<rate>();
        }

        [Key]
        public int song_id { get; set; }

        [Required]
        [StringLength(255)]
        public string song_name { get; set; }

        public int? turn_num { get; set; }

        [StringLength(255)]
        public string short_description { get; set; }

        [Column(TypeName = "ntext")]
        public string content { get; set; }

        public DateTime updated_at { get; set; }

        [StringLength(255)]
        public string song_path { get; set; }

        public int artist_id { get; set; }

        public virtual artist artist { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<playlist_detail> playlist_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rate> rates { get; set; }
    }
}
