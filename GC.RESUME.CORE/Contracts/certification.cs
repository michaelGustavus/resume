using System;
using System.Collections.Generic;
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
    public partial class certification
    {
        [Display(Name = "Primary ID")]
        [DataMember]
        public decimal Id { get; set; }
        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int profileId { get; set; }
        [Display(Name = "Received From")]
        [Required(ErrorMessage = "The received from field is a required value.")]
        [DataMember]
        public string recievedFrom { get; set; }
        [Display(Name = "Certification Title")]
        [Required(ErrorMessage = "The certification title is a required value.")]
        [DataMember]
        public string certTitle { get; set; }
    }
}
