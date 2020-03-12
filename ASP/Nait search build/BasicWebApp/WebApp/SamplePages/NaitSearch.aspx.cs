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

            //------------------DROP DOWN LIST------------------------

            //the web page has a flag that can be checked to see
            //   if the web page is posting back
            if (!Page.IsPostBack)
            {
                //if the page is not PostBack, it means that this
                //    is the first time the page has been displayed
                //you can do page initialization by testing the 
                //    IsPostBack
                // LIST is a bunch of the same classes
                //Create a List<DDLdata> where T is a class that has
                //    2 columns: a value and a text display

                List<DDLData> ReviewStars = new List<DDLData>();

                // adding values to the list
                ReviewStars.Add(new DDLData(1,"1 star"));
                ReviewStars.Add(new DDLData(2, "2 stars"));
                ReviewStars.Add(new DDLData(3, "3 stars"));
                ReviewStars.Add(new DDLData(4, "4 stars"));
                ReviewStars.Add(new DDLData(5, "5 stars"));

                // SORT
                ReviewStars.Sort((x, y) => x.displayField.CompareTo(y.displayField));

                // grab form id  and place Review list into drop down list
                CollectionList.DataSource = ReviewStars;

                // if there is a value and text feild do this
                CollectionList.DataValueField = "valueField";
                CollectionList.DataTextField = nameof(DDLData.displayField);

                //bind your data
                CollectionList.DataBind();

                // add in an insert
                CollectionList.Items.Insert(0, new ListItem("select...", "0"));

            }
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
            CollectionList.SelectedIndex = 0;
            Membership.ClearSelection();

        }
    }
}