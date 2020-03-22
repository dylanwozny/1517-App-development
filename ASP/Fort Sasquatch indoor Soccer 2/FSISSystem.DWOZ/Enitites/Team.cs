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
    [Table("Team")]
    public class Team
    {
        private string _wins;
        private string _losses; 


        //-----------------------------------------------------------------------
        [Key]
        public int TeamID { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Team name is required")]
        [StringLength(50, ErrorMessage = "string must be under 50 characters")]
        public string TeamName { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Coach is required")]
        [StringLength(75, ErrorMessage = "string must be under 75 characters")]

        public string Coach { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Assistant Coach is required")]
        [StringLength(75, ErrorMessage = "string must be under 75 characters")]

        public string AssistantCoach { get; set; }

        //--------------------------------------------------------------------

        [Required(ErrorMessage = "Email is required")]
        [StringLength(10, ErrorMessage = "string must be under 10 characters")]

        public string EmailAddress { get; set; }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "wins are required.")]
        public string Wins
        {
            get { return _wins; }
            set { _wins= string.IsNullOrEmpty(value) ? null : value; }
        }

        //--------------------------------------------------------------
        [Required(ErrorMessage = "Losses are required.")]
        public string Losses
        {
            get { return _losses; }
            set { _losses = string.IsNullOrEmpty(value) ? null : value; }
        }


    }
}



//   [Wins] [int] NULL,
//	[Losses] [int] NULL,