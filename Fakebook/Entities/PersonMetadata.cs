using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Fakebook.Entities
{
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person { }

    internal sealed class PersonMetadata
    {
        [DisplayName("User")]
        public string Username { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Profile Picture")]
        public string Image { get; set; }

        [Display(AutoGenerateField = false)]
        public int UserId { get; set; }
    }
}