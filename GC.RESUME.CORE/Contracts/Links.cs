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
    public partial class Links
    {
        [Display(Name = "Primary ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public decimal Id { get; set; }

        [Display(Name = "Profile ID")]
        [Required(ErrorMessage = "The Profile ID is a required value.")]
        [DataMember]
        public int profileId { get; set; }

        [Display(Name = "Linkedin")]
        [DataMember]
        public string LinkedinURL { get; set; }

        [Display(Name = "Facebook")]
        [DataMember]
        public string FacebookURL { get; set; }

        [Display(Name = "Github")]
        [DataMember]
        public string GithubURL { get; set; }

        [Display(Name = "Twitter")]
        [DataMember]
        public string TwitterURL { get; set; }

    }
}
