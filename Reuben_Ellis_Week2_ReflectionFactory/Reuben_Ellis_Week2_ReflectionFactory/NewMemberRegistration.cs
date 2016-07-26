using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Reuben_Ellis_Week2_ReflectionFactory
{
    public partial class NewMemberRegistration : Form
    {
        #region Members
        //First three variables are regular expressions used to validate user input
        private string
            namePattern = @"^([A-Z][a-z]*[-' ]?)+$",
            usernamePattern = @"^(?=.*[a-zA-Z0-9]).{6,13}$",
            passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
            textValue = string.Empty,
            errorMessageText = string.Empty,
            finalValidationMessage = string.Empty,
            finalErrorValidationMessage = string.Empty;

        private bool 
            validValue = false;

        private Color
            invalidEntry = Color.Red;

        TextBox
            textOnFocus = new TextBox();

        #endregion

        #region Methods

        #region Public Methods

        /// <summary>
        /// Constructor method which initializes the form with default values
        /// </summary>
        public NewMemberRegistration()
        {
            InitializeComponent();
            cboMembershipType.SelectedIndex = 0;
            cboCity.SelectedIndex = 0;
            cboZipCode.SelectedIndex = 0;
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblUsername.Visible = false;
            lblPassword.Visible = false;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Validates the user input in each TextBox with the use of regular expressions
        /// </summary>
        /// <param name="textBox">A placeholder for the textbox being checked</param>
        /// <param name="errorMessage">A label which holds the error message</param>
        /// <param name="regularPatterns">The regular expression pattern used for the validation</param>
        /// <param name="errorMessageDetails">An error message which displays in a label by the TextBox</param>
        private void ValidateRegularExpressionPatterns(TextBox textBox, Label errorMessage, 
            string regularPatterns, string errorMessageDetails)
        {
            textValue = textBox.Text;

            if (Regex.IsMatch(textValue, regularPatterns))
            {
                validValue = true;
            }
            else
            {
                validValue = false;
            }

            if (validValue)
            {
                errorMessage.Visible = false;
            }
            else
            {
                errorMessage.Visible = true;
                errorMessage.Text = errorMessageDetails;
                errorMessage.ForeColor = invalidEntry;
            }
        }

        /// <summary>
        /// Checks to see if any TextBoxes are empty before registration submission
        /// </summary>
        private void checkForEmptyOnSubmit()
        {
            finalValidationMessage = string.Empty;
            textOnFocus = null;

            if (txtFirstName.Text.Length == 0)
            {
                finalValidationMessage += "First name is required.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtFirstName;
                }
            }

            if (txtLastName.Text.Length == 0)
            {
                finalValidationMessage += "Last name is required.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtLastName;
                }
            }

            if (txtAddress.Text.Length == 0)
            {
                finalValidationMessage += "Address is required.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtAddress;
                }
            }

            if (txtUsername.Text.Length == 0)
            {
                finalValidationMessage += "Username is required.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtUsername;
                }
            }

            if (txtPassword.Text.Length == 0)
            {
                finalValidationMessage += "Password is required.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtPassword;
                }
            }
        }

        /// <summary>
        /// Checks to see if any of the error labels are visible and returns an error MessageBox
        /// </summary>
        private void checkForLabelErrorMessage()
        {
            if (lblFirstName.Visible == true)
            {
                finalValidationMessage += "First name is not Valid.\n";
                textOnFocus = txtFirstName;
            }

            if (lblLastName.Visible == true)
            {
                finalValidationMessage += "Last name is not Valid.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtLastName;
                }
            }

            if (lblUsername.Visible == true)
            {
                finalValidationMessage += "Username is not Valid.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtUsername;
                }
            }

            if (lblPassword.Visible == true)
            {
                finalValidationMessage += "Password is not Valid.\n";
                if (textOnFocus == null)
                {
                    textOnFocus = txtPassword;
                }
            }
        }

        #region Action Methods
        
        /// <summary>
        /// The Cancel button which checks to make sure the user wants to close the application before closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelRegistration_Click(object sender, EventArgs e)
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

        /// <summary>
        /// When the City value is changed, the Zip combobox value is changed to match the City
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCity.SelectedIndex == 0)
            {
                cboZipCode.SelectedIndex = 0;
            }
            else if (cboCity.SelectedIndex == 1)
            {
                cboZipCode.SelectedIndex = 1;
            }
            else if (cboCity.SelectedIndex == 2)
            {
                cboZipCode.SelectedIndex = 2;
            }
        }

        /// <summary>
        /// When the Zip value is changed, the City combobox value is changed to match the Zip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboZipCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZipCode.SelectedIndex == 0)
            {
                cboCity.SelectedIndex = 0;
            }
            else if (cboZipCode.SelectedIndex == 1)
            {
                cboCity.SelectedIndex = 1;
            }
            else if (cboZipCode.SelectedIndex == 2)
            {
                cboCity.SelectedIndex = 2;
            }
        }

        /// <summary>
        /// Checks to see if the first name is valid and returns an error message if invalid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            errorMessageText = "Please enter a valid first name";
            ValidateRegularExpressionPatterns(txtFirstName, lblFirstName, namePattern, errorMessageText);
        }

        /// <summary>
        /// Checks to see if the last name is valid and returns an error message if invalid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            errorMessageText = "Please enter a valid last name";
            ValidateRegularExpressionPatterns(txtLastName, lblLastName, namePattern, errorMessageText);
        }

        /// <summary>
        /// Checks to see if the username is valid and returns an error message if invalid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            errorMessageText = "Please enter between 6 and 13 characters \nand only numbers or letters";
            ValidateRegularExpressionPatterns(txtUsername, lblUsername, usernamePattern, errorMessageText);
        }

        /// <summary>
        /// Checks to see if the password is valid and returns an error message if invalid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //PasswordChar sets the TextBox to display Asterisks in place of text to keep password secure
            txtPassword.PasswordChar = '*';
            errorMessageText = "Please enter between 8 and 15 characters \npassword must contain" +
                "1 lowercase letter \n1 uppercase letter and 1 numeric value";
            ValidateRegularExpressionPatterns(txtPassword, lblPassword, passwordPattern, errorMessageText);
        }

        /// <summary>
        /// The submit registration button checks to make sure TextBoxes are not empty
        /// or filled with invalid values and returns error messages or a success message appropriately
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitRegistration_Click(object sender, EventArgs e)
        {
            checkForEmptyOnSubmit();
            checkForLabelErrorMessage();

            if (finalValidationMessage.Length > 0)
            {
                finalValidationMessage = finalValidationMessage.Substring(0, finalValidationMessage.Length - 1);

                MessageBox.Show(finalValidationMessage, "Error Messages!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textOnFocus.Focus();
            }
            else
            {
                MessageBox.Show("Registration Successful", "Complete!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
