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
    [Table("Player")]
    public class Player
    {
        //---------------------fully implemented-----------------------------------------

        private string _gender;
        private string _medicalalertdetails;


        //--------------------------------------------------------------
        [Key]
        public int PlayerID { get; set; }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "GuardianID is required.")]
        public int GuardianID { get; set; }


        //--------------------------------------------------------------
        [Required(ErrorMessage = "TeamID is required.")]
        public int TeamID{ get; set; }
        
        //--------------------------------------------------------------

        [Required(ErrorMessage = "Player name is required")]
        [StringLength(50, ErrorMessage = "string must be under 50 characters")]
        public string FirstName { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "last name of player is required")]
        [StringLength(50, ErrorMessage = "string must be under 50 characters")]

        public string LastName { get; set; }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "Age is required.")]
        public int Age{ get; set; }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender {
            get { return _gender; }
            set { _gender = _gender.ToUpper(); }          
        }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "Alberts health care number is required.")]
        public string AlbertaHealthCareNumber { get; set; }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "medical alert details are required.")]
        [StringLength(250, ErrorMessage = "mdeical alert description must be under 250 characters")]
        public string MedicalAlertDetails
        {
            get { return _medicalalertdetails; }
            set { _medicalalertdetails = string.IsNullOrEmpty(value) ? null : value; }
        }

        //--------------------------------------------------------------------
        [NotMapped]

        public string FullName
        {
            get { return FirstName + "," + "" + LastName; }
        } 

    }
}
