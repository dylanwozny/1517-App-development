using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class NaitSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // load empty feilds on first page refresh
            Message.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {

            //----------------------- FOR TEXT BOX-----------------------
            // returning information in text boxes

            string msg = "";

            string textspace = ", ";

            // grab text box info
            msg += "ISBN: " + ISBN.Text + textspace;

            // -----------------------CHECK BOX LIST-----------------------
            bool founditem = false;

            foreach(ListItem i in Rating.Items)
            {
                if (i.Selected)
                {
                    msg += "Rating: " + i.Text + textspace;
                    founditem = true;
                }
            }

            if (!founditem)
            {
                msg += "You did not select a rating. Please select one.";
            }


            //--------------------RADIO BUTTON LIST-------------------------------

            // just putting into a shorter variable for ternarny operator
            string A = Membership.SelectedValue;

            // else if in a ternary operator
            msg += "MemberShip: " + (A == "0" ? "Premuim" : A == "1" ? "regular" : A == "2" ? "non-member" : "Please Select a membership") + textspace ;

            // Print out message
            Message.Text = msg;

       }

        protected void Clear_Click(object sender, EventArgs e)
        {
            Rating.ClearSelection();//a method which reset a list (CheckBoxList)
            ISBN.Text = "";
        }
    }
}