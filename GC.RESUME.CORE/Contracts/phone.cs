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
    public partial class phone
    {
        [Display(Name = "Primary ID")]
        [DataMember]
        public decimal Id { get; set; }
        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int profileId { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "The phone number is a required value.")]
        [DataMember]
        public string phone1 { get; set; }
    }
}
