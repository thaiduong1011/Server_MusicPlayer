namespace MusicPlayer_Server.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class login_count
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_id { get; set; }

        public int? count { get; set; }

        public virtual user user { get; set; }
    }
}
