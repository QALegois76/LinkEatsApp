using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleAppEntityFramework.Models
{
    public class RestoComment
    {
        [Key]
        public Guid RestoCommentID { get; set; }

        public string RestoCommentComent { get; set; }

        //[AllowNull]
        //public Client RestoCommentClient { get; set; }
        //[AllowNull]
        //public Restaurant RestoCommentRestaurant { get; set; }
        
        [Range(0,5)]
        public int RestoCommentRate { get; set; } = 0;
    }
}
