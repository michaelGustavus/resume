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
    public partial class user
    {
        [Display(Name = "Primary ID")]
        [Required(ErrorMessage = "The Primary ID is a required value.")]
        [DataMember]
        public decimal Id { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "The User Name is a required value.")]
        [DataMember]
        public string userName { get; set; }
    }
}
