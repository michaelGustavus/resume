using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

#nullable disable

namespace GC.RESUME.CORE.Contracts
{
    [Serializable]
    [DataContract]
    [JsonObject(MemberSerialization.OptOut)]
    public partial class profile
    {
        [Display(Name = "Primary ID")]
        [DataMember]

        public decimal Id { get; set; }
        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int userId { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The first name is a required value.")]
        [DataMember]
        public string firstName { get; set; }
        [Display(Name = "Middle Name")]
        [DataMember]
        public string midName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The last name is a required value.")]
        [DataMember]
        public string lastName { get; set; }
        [Display(Name = "Address")]
        [Required(ErrorMessage = "The address is a required value.")]
        [DataMember]
        public string address { get; set; }
        [Display(Name = "Second Address")]
        [DataMember]
        public string address2 { get; set; }
        [Display(Name = "City")]
        [Required(ErrorMessage = "The city is a required value.")]
        [DataMember]
        public string city { get; set; }
        [Display(Name = "State")]
        [Required(ErrorMessage = "The state is a required value.")]
        [DataMember]
        public string state { get; set; }
        [Display(Name = "ZIP Code")]
        [Required(ErrorMessage = "The ZIP code is a required value.")]
        [DataMember]
        public string zip { get; set; }
        [Display(Name = "About")]
        [Required(ErrorMessage = "The about is a required value.")]
        [DataMember]
        public string about { get; set; }
        [Display(Name = "Interests")]
        [Required(ErrorMessage = "The interests field is a required value.")]
        [DataMember]
        public string interests { get; set; }
        [Display(Name = "URL")]
        [DataMember]
        public string picURL { get; set; }
    }
}
