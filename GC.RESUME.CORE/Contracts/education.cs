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
    public partial class education
    {
        [Display(Name = "Primary ID")]
        [DataMember]
        public decimal Id { get; set; }
        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int profileId { get; set; }
        [Display(Name = "School Name")]
        [Required(ErrorMessage = "The school name is a required value.")]
        [DataMember]
        public string schoolName { get; set; }
        [Display(Name = "Degree Title")]
        [Required(ErrorMessage = "The degree title is a required value.")]
        [DataMember]
        public string degreeTitle { get; set; }
        [Display(Name = "Degree Path")]
        [DataMember]
        public string degreePath { get; set; }
        [Display(Name = "From Date")]
        [DataMember]
        public DateTime fromDt { get; set; }
        [Display(Name = "To Date")]
        [DataMember]
        public DateTime toDt { get; set; }
        [Display(Name = "GPA")]
        [DataMember]
        public decimal GPA { get; set; }
    }
}
