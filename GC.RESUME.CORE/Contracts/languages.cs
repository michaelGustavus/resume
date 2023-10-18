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
    public partial class languages
    {
        [Display(Name = "Primary ID")]
        [DataMember]
        public decimal Id { get; set; }
        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int profileId { get; set; }
        [Display(Name = "Language Name")]
        [Required(ErrorMessage = "The language name is a required value.")]
        [DataMember]
        public string langName { get; set; }
        
    }
}
