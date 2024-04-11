﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace huynhd2_InClass20240409
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This should only run once when the page is initially loaded in the browser
            if (!IsPostBack)
            {
                lblFruits.Items.Add("Strawberry");
            }
        }

        protected void lblFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This code runs when the user selectes a new item from the lblFruits List Box
            // Copy the currently selected item from the list box into our label
            lblChosenFruit.Text = lblFruits.SelectedValue;
            
        }
        // I need an event that will run when the user,
        // in ther brower, selects a fruit from the list box
        // "event-driven" programming
        // Our event is The user selected an item from the list box
    }
}