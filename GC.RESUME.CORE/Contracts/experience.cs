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
    public partial class experience
    {
        [Display(Name = "Primary ID")]
        [DataMember]
        public decimal Id { get; set; }
        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int profileId { get; set; }
        [Display(Name = "Title")]
        [Required(ErrorMessage = "The title is a required value.")]
        [DataMember]
        public string title { get; set; }
        [Display(Name = "Employer")]
        [Required(ErrorMessage = "The employer is a required value.")]
        [DataMember]
        public string employer { get; set; }
        [Display(Name = "From Date")]
        [DataMember]
        public DateTime fromDt { get; set; }
        [Display(Name = "To Date")]
        [DataMember]
        public DateTime toDt { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "The description is a required value.")]
        [DataMember]
        public string description { get; set; }
    }
}
