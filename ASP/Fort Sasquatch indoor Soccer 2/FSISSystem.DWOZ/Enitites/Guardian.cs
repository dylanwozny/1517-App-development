using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// additional namespaces......
#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace FSISSystem.DWOZ.Enitites
{
    [Table("Guardian")]
    public class Guardian
    {
        [Key]
        public int GuardianID { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "guardian name is required")]
        [StringLength(50, ErrorMessage = "string must be under 50 characters")]
        public string FirstName { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Last name of guardian is required")]
        [StringLength(50, ErrorMessage = "string must be under 50 characters")]

        public string LastName { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Emergency number is required")]
        [StringLength(10, ErrorMessage = "string must be under 10 characters")]

        public string EmergencyPhoneNumber { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Email is required")]
        [StringLength(10, ErrorMessage = "string must be under 10 characters")]

        public string EmailAddress { get; set; }










    }
}
