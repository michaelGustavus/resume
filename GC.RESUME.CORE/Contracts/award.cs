using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GC.RESUME.CORE.Contracts
{
    [Serializable]
    [DataContract]
    [JsonObject(MemberSerialization.OptOut)]
    class Award
    {
        [Display(Name = "Primary ID")]
        [DataMember]
        public Guid Id { get; set; }

        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public Guid profileId { get; set; }
        [Display(Name = "Place")]
        [Required(ErrorMessage = "The Place is a required value.")]
        [DataMember]
        public string place { get; set; }
        [Display(Name = "Location")]
        [DataMember]
        public string location { get; set; }
        [Display(Name = "Competition Name")]
        [Required(ErrorMessage = "The competition name is a required value.")]
        [DataMember]
        public string compName { get; set; }

        [Display(Name = "Year Received")]
        [Required(ErrorMessage = "The year received field is a required value.")]
        [DataMember]
        public int yearRec { get; set; }
    }
}
