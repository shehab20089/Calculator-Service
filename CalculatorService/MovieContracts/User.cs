using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorServiceLibrary
{

    [DataContract]
    public class User
    {

        [DataMember]
        [Key]
        public int userID { get; set; }
        [DataMember]
        [Required]
        public string userName { get; set; }
        [DataMember]
        [Required]
        public string password { get; set; }
        [DataMember]
        [Required]
        public bool addAuth { get; set; }
        [DataMember]
        [Required]
        public bool subAuth { get; set; }
        [DataMember]
        [Required]
        public bool multiAuth { get; set; }
        [DataMember]
        [Required]
        public bool divAuth { get; set; }
    }
}
