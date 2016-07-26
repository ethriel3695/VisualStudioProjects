using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    public partial class ViewMembershipBenefits : Form
    {
        #region Members
        string
            name,
            cost,
            benefit1,
            benefit2,
            benefit3,
            forcePower,
            membershipType;
        #endregion

        #region Methods

        #region Action Methods
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            //Displays a message to the user allowing a choice to close
            //the application or continue and roll the dice again
            if (MessageBox.Show("Do you want to close the form?", "Cancel Registration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Close();
            }
            else
            {
            }
        }

        private void btnRegisterMembership_Click(object sender, EventArgs e)
        {
            NewMemberRegistration registrationForm = new NewMemberRegistration();
            registrationForm.Show();
        }

        #endregion
        
        #region Public Methods
        /// <summary>
        /// Initializes the Form
        /// </summary>
        public ViewMembershipBenefits()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Changes the text boxes each time the combo box value is changed
        /// Sets the Interface to null
        /// Gets the class information based on the text value within the combo box
        /// Calls the methods from the classes to put the values within each label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMembershipType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
            Membership MembershipType = null;
            MembershipType = MembershipFactory.MembershipDetails(cboMembershipType.Text);
            name = MembershipType.membershipName();
            cost = MembershipType.membershipCost();
            benefit1 = MembershipType.membershipBenefit1();
            benefit2 = MembershipType.membershipBenefit2();
            benefit3 = MembershipType.membershipBenefit3();

            //If else if to change color of text based on class selected
            if (name == "Padawan")
            {
                lblBenefit2.ForeColor = Color.Red;
                lblBenefit3.ForeColor = Color.Red;
            }
            else if (name == "Jedi Knight")
            {
                lblBenefit2.ForeColor = Color.MidnightBlue;
                lblBenefit3.ForeColor = Color.Red;
            }
            else
            {
                lblBenefit2.ForeColor = Color.MidnightBlue;
                lblBenefit3.ForeColor = Color.MidnightBlue;
            }

            lblName.Text = name;
            lblCost.Text = cost;
            lblBenefit1.Text = benefit1;
            lblBenefit2.Text = benefit2;
            lblBenefit3.Text = benefit3;
            lblForcePower.Text = string.Empty;
            lblExceptionMessage.Text = string.Empty;
            cboForcePower.Text = string.Empty;
        }

        /// <summary>
        /// Adds a new temporary force power to the membership if the
        /// power is a Jedi power and an error message if the power is a Sith power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboForcePower_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                membershipType = cboMembershipType.Text;
                if (membershipType != "")
                {
                    forcePower = cboForcePower.Text;

                    if (forcePower.Contains("Sith") || forcePower.Contains("sith"))
                    {
                        throw new InvalidPowerException("Resist the temptation of the Dark Side." + 
                            " Power not added.");
                    }
                    lblExceptionMessage.Text = string.Empty;
                    lblForcePower.ForeColor = Color.Green;
                    lblForcePower.Text = forcePower;
                }
                else
                {
                    throw new InvalidPowerException("Select a Class from the drop-down list.");
                }
            }
            catch (InvalidPowerException invalidMembershipException)
            {
                lblForcePower.Text = string.Empty;
                lblExceptionMessage.ForeColor = Color.Red;
                lblExceptionMessage.Text = invalidMembershipException.Message;
            }
        }
        #endregion

        #endregion
    }
}
