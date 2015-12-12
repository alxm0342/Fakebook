using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fakebook.Entities
{
    [MetadataType(typeof(CommentMetadata))]
    public partial class Comment { }

    internal sealed class CommentMetadata
    {
        [DisplayName("Comment")]
        public string Comment1 { get; set; }

        [Display(AutoGenerateField = false)]
        public int CommentId { get; set; }

        [DisplayName("User"), Display(AutoGenerateField = false)]
        public Nullable<int> UserId { get; set; }

        [DisplayName("Time"), Display(AutoGenerateField = false), DisplayFormat(DataFormatString = "{0:ddd, MMMM dd, yyyy h:mm tt}")]
        public Nullable<System.DateTime> CommentTime { get; set; }
    }
}