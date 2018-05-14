namespace MusicPlayer_Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("playlist")]
    public partial class playlist
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public playlist()
        {
            playlist_detail = new HashSet<playlist_detail>();
        }

        [Key]
        public int playlist_id { get; set; }

        [Required]
        [StringLength(255)]
        public string playlist_name { get; set; }

        public DateTime updated_at { get; set; }

        public int user_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<playlist_detail> playlist_detail { get; set; }

        public virtual user user { get; set; }
    }
}
