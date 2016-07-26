#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
#endregion

namespace ReubenEllis_Week4_DiceRollModified
{
    public partial class DiceRollApplicationModified : Form
    {
        #region Members
        //diceRollNumber is used to identify which roll the dice values match on
        //diceRollTurn is used to indicate how many rolls the dice will perform
        //diceTotalValue indicates the total value of both dice rolls added together
        private int
            diceRollNumber = 0,
            diceRollTurn = 100,
            diceTotalValue = 0;

        //Stores values of each roll where dice are doubles to produce a list
        ArrayList
            diceTempValue = new ArrayList();

        //Stores the value of the diceRollNumber for display inside a textbox
        private string
            DiceRollValue = string.Empty,
            doubleValues = string.Empty;

        //Stores the value of each dice roll and the number of dice with matching values
        private string[]
            diceValue = new string[5],
            diceDoubles = new string[3];

        //Creates a new listview variable
        private ListViewItem
            listValues = new ListViewItem(),
            listValuesDoubles = new ListViewItem();

        #endregion

        #region Method

        #region Public Method
        //Function to initialize the diceRollApplication
        public DiceRollApplicationModified()
        {
            InitializeComponent();
            //Enables the column names to appear when the application loads
            //so the user knows the column names
            //and for the data to appear on a new line and in columns format
            list1stSequence.View = View.Details;
            list2ndSequence.View = View.Details;
            listSequence1Doubles.View = View.Details;
            listSequence2Doubles.View = View.Details;
        }
        #endregion

        /// <summary>
        /// Button Click event which calls methods and makes the application functionality occur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Private Method
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //Clears the listViews so a new list can be written if the user
            //chooses to roll the dice again
            list1stSequence.Items.Clear();
            list2ndSequence.Items.Clear();
            listSequence1Doubles.Items.Clear();
            listSequence2Doubles.Items.Clear();

            //Calls the rollDice method then the displayMessage method
            rollDice(list1stSequence);
            rollDice(list2ndSequence);
            displayMessage();
        }

        /// <summary>
        /// Populates a list of the number of Dice rolls with matching values and a list of the values
        /// </summary>
        /// <param name="diceRollValues"></param>
        /// <param name="listViewContainer"></param>
        /// <returns></returns>
        private void diceListPopulate(ArrayList diceRollValues, ListView listViewContainer)
        {
            //LINQ statement to get all the dice values within the diceRollValues ArrayList
            var diceValues = from int diceRoll in diceRollValues
                             select diceRoll;
            foreach (int diceRoll in diceValues)
            {
                doubleValues += diceRoll + " ";
            }

            //Puts the number of double pairs in the first column and a list of the double values
            //in the second column
            diceDoubles[0] = (doubleValues.Length / 2).ToString();
            diceDoubles[1] = doubleValues;

            listValuesDoubles = new ListViewItem(diceDoubles);
            listViewContainer.Items.Add(listValuesDoubles);

            //Resets the doubleValues list so each Sequence list begins at 0
            doubleValues = string.Empty;
        }

        /// <summary>
        /// Method which rolls the dice and iterates through 100 throws and writes
        /// a list of the values and a total of the dice values for each throw
        /// </summary>
        private void rollDice(ListView listViewParameter)
        {
            diceRollTurn = 100;
            diceRollNumber = 0;

            SuperDice dice1 = new SuperDice();

            //For loop iterates through the dice rolls 100 times and then ends
            for (int i = 0; i < diceRollTurn; i++)
            {
                //Increments the value of the diceRollNumber to indicate what roll the user is on
                diceRollNumber++;
                //Assigns the current diceRollNumber value to a placeholder variable
                DiceRollValue = diceRollNumber.ToString();

                //gets the random vlaues from the SuperDice class
                dice1.RollValueDice1();
                dice1.RollValueDice2();

                //Checks to see if the values match and adds the value to an ArrayList
                if (dice1.diceRoll1 == dice1.diceRoll2)
                {
                    diceTempValue.Add(dice1.diceRoll1);
                }

                diceTotalValue = dice1.diceRoll1 + dice1.diceRoll2;

                listViewParameter.ShowItemToolTips = true;

                //Assign values to the listview columns
                diceValue[0] = DiceRollValue;
                diceValue[1] = dice1.diceRoll1.ToString();
                diceValue[2] = dice1.diceRoll2.ToString();
                diceValue[3] = diceTotalValue.ToString();

                listValues = new ListViewItem(diceValue);
                listViewParameter.Items.Add(listValues);
            }
            if (listViewParameter == list1stSequence)
            {
                diceListPopulate(diceTempValue, listSequence1Doubles);
            }
            else
            {
                diceListPopulate(diceTempValue, listSequence2Doubles);
            }

            diceTempValue.Clear();
        }

        private void displayMessage()
        {
            //Displays a message to the user allowing a choice to close
            //the application or continue and roll the dice again
            if (MessageBox.Show("Roll Sequence is Complete! " +
                "Do you want to view the results?", "Dice Roll", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to cancel?", "Final Cancel", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                }
                
            }
        }

        private void diceRollApplication_Load(object sender, EventArgs e)
        {
        }

        #endregion
        #endregion
    }
}

