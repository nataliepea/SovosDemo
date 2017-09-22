using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.Data;
using Telerik.WinControls;

namespace BeerocracyWindowsApp
{
	public partial class frmCreate : Telerik.WinControls.UI.RadForm
    {
		public frmCreate()
		{
			InitializeComponent();
            ThemeResolutionService.ApplicationThemeName = "Office2007Black";
            txtIng.EnableTheming = false;
            txtDisplayIng.EnableTheming = false;
        }

		private void frmSearch_Load(object sender, EventArgs e)
		{
			// This line of code loads data into the 'dsBeerocracy1.BeerIngredient' table. 
			this.beerIngredientTableAdapter.Fill(this.dsBeerocracy1.BeerIngredient);
			// This line of code loads data into the 'dsBeerocracy.Beer' table. 
			this.beerTableAdapter.Fill(this.dsBeerocracy.Beer);
			// This line of code loads data into the 'dsBeerocracy.Ingredient' table. 
			this.ingredientTableAdapter.Fill(this.dsBeerocracy.Ingredient);

			//We don't want anything selected in the lb when the form loads.
			lbIngredient.ClearSelected();

			//Set focus on the lb
			lbIngredient.Select();

            //Jane: The beer dropdown should be sorted and displaying correct corresponding ingredients on page load.
            //ddBeer.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
        }


		private void lbIngredient_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtDisplayIng.Text = "";

            //Display selected ingredients
            foreach (DataRowView drv in lbIngredient.SelectedItems)
			{
				txtDisplayIng.Text += (drv.Row["IngredientName"].ToString() + Environment.NewLine);
			}
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
            if (txtNewIng.Text != String.Empty)
            {
                //Jane:  Using the data connection already defined for ingredients, add code here to add the user's 
                //ingredient to the database.  Ensure proper validation is setup on the user input. (done)
                ingredientTableAdapter.Insert(txtNewIng.Text);
                this.ingredientTableAdapter.Fill(this.dsBeerocracy.Ingredient);
                txtNewIng.Clear();

                lbIngredient.ClearSelected();

                //Jane:  Add functionality to preserve the items they have already selected in the ListBox.
                //Jane:  Add functionality to select the new beer in the beer dropdown and ensure correct ings are displayed as well.
            }
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
            if (txtNewBeer.Text != String.Empty && txtDisplayIng.Text != String.Empty)
            {
                //Jane:  Enchancement(low priority): implement beer category functionality.  The database relationship is 
                //already there, functionality for it needs to be added to the front end.

			    //Insert new record into Beer table and store the id.
			    object newBeerId = beerTableAdapter.InsertAndReturnId(txtNewBeer.Text, Environment.UserName, DateTime.Now, null);

			    //Now insert record for each ingredient into join table
			    foreach (DataRowView drv in lbIngredient.SelectedItems)
			    {
				    beerIngredientTableAdapter.Insert((Int32)newBeerId, (int)drv.Row["IngredientID"]);
			    }

                //Rebind the beer drop down to display the new beer
                this.beerTableAdapter.Fill(this.dsBeerocracy.Beer);

                //Jane:  Ensure newly saved beer appears as selected in the beer dropdown (already done)
                ddBeer.SelectedValue = newBeerId;

                lbIngredient.ClearSelected();
            }
        }

        private void ddBeer_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtIng.Text = "";

            //Jane:  add code here to fill the Ingredients box when a new beer is selected. (done)
            if (ddBeer.SelectedValue != null)
            {
                foreach (DataRow dr in beerIngredientTableAdapter.GetIngredients((Int32)ddBeer.SelectedValue))
                {
                    txtIng.Text += dr["IngredientName"].ToString() + Environment.NewLine;
                }
            }
        }
    }
}
