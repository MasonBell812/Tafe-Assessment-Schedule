using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tafe_Assessment_Schedule
{
    
    public partial class Form1 : Form
    {
        //constants
        public const int MAX_COLUMNS = 5;

        //lists
        List<Assessment> atList;
        List<string> unitList;

        /************************************************
        Method:     Form1()
        Purpose:    Main method, initialises content
        NOTES:
        ************************************************/
        public Form1()
        {
            InitializeComponent();

            //show main panel
            main_Panel.Visible = true;
            details_Panel.Visible = false;

            //add columns to table
            table_DataGridView.Columns.Add("Column", "Unit");
            table_DataGridView.Columns.Add("Column", "AT");
            table_DataGridView.Columns.Add("Column", "Date");
            table_DataGridView.Columns.Add("Column", "Resubmit");
            table_DataGridView.Columns.Add("Column", "Completed");

            //change column size
            table_DataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            table_DataGridView.Columns[1].Width = 50;
            table_DataGridView.Columns[2].Width = 75;
            table_DataGridView.Columns[3].Width = 75;
            table_DataGridView.Columns[4].Width = 75;

            //initialise list
            atList = new List<Assessment>();
            unitList = new List<string>();

            //call methods
            ReadCSVData();
            DisplayData();

        }

        /************************************************
        Method:     ReadCSVData()
        Purpose:    Reads CSV files, adds data to lists
        NOTES:
        ************************************************/
        private void ReadCSVData()
        {
            try
            {
                //check if the list already has objects in it
                if(atList.Count > 0)
                {
                    //clear the list
                    atList.Clear();
                }
                if(unitList.Count > 0)
                {
                    //clear the list
                    unitList.Clear();
                }

                //***** GET ASSESSMENTS *****
                //get assessments file source
                string filePath = @"assessments.csv";
                //read assessments file
                if(File.Exists(filePath))
                {
                    //read file line by line
                    using(StreamReader file = new StreamReader(filePath))
                    {
                        string line;
                        int lineCount = 0;

                        //while there are lines left in the file to read
                        while((line = file.ReadLine()) != null)
                        {
                            //split the line
                            string[] lineArray = line.Split(',');
                            //skip first line
                            if(lineCount > 0)
                            {
                                string unit = lineArray[0];
                                string at = lineArray[1];
                                DateTime date = DateTime.ParseExact(lineArray[2], "d/M/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                                bool resubmit = Boolean.Parse(lineArray[3]);
                                bool completed = Boolean.Parse(lineArray[4]);
                                string description = lineArray[5];
                                atList.Add(new Assessment(unit, at, date, resubmit, completed, description));
                            }
                            //increment lineCount
                            lineCount++;
                        }//END while loop
                        //close file
                        file.Close();
                    }//END using
                }

                //MessageBox.Show(DateTime.Compare(atList[0].Date, atList[1].Date).ToString());

                //***** GET UNITS *****
                //get units file source
                filePath = @"TAFE Units.txt";
                //read units file
                if(File.Exists(filePath))
                {
                    //read file line by line
                    using(StreamReader file = new StreamReader(filePath))
                    {
                        string line;
                        int lineCount = 0;

                        //while there are lines left in the file to read
                        while ((line = file.ReadLine()) != null)
                        {
                            unitList.Add(line);
                            lineCount++;
                        }
                        file.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /************************************************
        Method:     DisplayData()
        Purpose:    Displays data from lists
        NOTES:
        ************************************************/
        private void DisplayData()
        {
            //clear table
            table_DataGridView.Rows.Clear();

            //sort atList by date
            atList.Sort((x, y) => DateTime.Compare(x.Date, y.Date));

            //loops through every item in the assessment list
            for (int i = 0; i < atList.Count; i++)
            {
                //fills table with values from assessment list
                table_DataGridView.Rows.Add();
                table_DataGridView[0, i].Value = atList[i].Unit.ToString();
                table_DataGridView[1, i].Value = atList[i].AT.ToString();
                table_DataGridView[2, i].Value = atList[i].Date.ToShortDateString();
                table_DataGridView[3, i].Value = atList[i].Resubmit.ToString();
                table_DataGridView[4, i].Value = atList[i].Completed.ToString();
                //set description tooltip for first cell in each row
                table_DataGridView[0, i].ToolTipText = atList[i].Description;

                //if "assessment" is a week number
                if(atList[i].Unit.ToString().Substring(0,4) == "Week")
                {
                    //clear unneeded data (increases readability of table)
                    table_DataGridView[1, i].Value = "";
                    table_DataGridView[3, i].Value = "";
                    table_DataGridView[4, i].Value = "";
                }
            }

            //clear the ComboBox
            unit_ComboBox.Items.Clear();
            //loops through every item in the units list
            for(int i = 0; i < unitList.Count; i++)
            {
                //adds units to the units ComboBox
                unit_ComboBox.Items.Add(unitList[i]);
            }
        }

        /************************************************
        Method:     ValidateAssessment()
        Purpose:    Checks if inputted assessment has proper info
        NOTES:
        ************************************************/
        private bool ValidateAssessment()
        {
            bool valid = true;
            string errorMsg = "";

            //if unit is not selected
            if(unit_ComboBox.Text == "")
            {
                errorMsg += "> Must select a unit\n";
                valid = false;
            }
            //if assessment task number is not entered
            if(at_TextBox.Text == "")
            {
                errorMsg += "> Must enter an AT (Assessment Task) number\n";
                valid = false;
            }
            //if assessment task is not a number
            if(int.TryParse(at_TextBox.Text, out int result) == false)
            {
                errorMsg += "> AT (Assessment Task) must be a number\n";
                valid = false;
            }

            //if not valid
            if(!valid)
            {
                //display error message
                MessageBox.Show(errorMsg, "INPUT ERROR");
            }

            return valid;
        }

        /************************************************
        Method:     addAssessment_Button_Click() event handler
        Purpose:    Opens the "add assessment" screen
        NOTES:
        ************************************************/
        private void addAssessment_Button_Click(object sender, EventArgs e)
        {
            //TODO: Reset unit combo box

            //hides main panel
            main_Panel.Visible = false;
            //change page title
            title_Label.Text = "Add New Assessment";
            //resets inputs to default values
            at_TextBox.Text = "";
            date_DateTimePicker.Value = DateTime.Now;
            resubmit_CheckBox.Checked = false;
            completed_CheckBox.Checked = false;
            //hide saveUpdate button, show add button
            add_Button.Visible = true;
            saveUpdate_Button.Visible = false;
            //shows details panel
            details_Panel.Visible = true;
        }

        /************************************************
        Method:     back_Button_Click() event handler
        Purpose:    Closes details screen, opens main screen
        NOTES:
        ************************************************/
        private void back_Button_Click(object sender, EventArgs e)
        {
            //hide details panel
            details_Panel.Visible = false;
            //show main panel
            main_Panel.Visible = true;
        }

        /************************************************
        Method:     date_DateTimePicker_MouseDown() event handler
        Purpose:    Opens calendar when clicking the body of the DateTimePicker
        NOTES:
        ************************************************/
        private void date_DateTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            //shows the calendar when you click the body of the DateTimePicker
            //(idk how/why this code works, got it from the internet)
            SendKeys.Send("%{DOWN}");
        }

        /************************************************
        Method:     add_Button_Click() event handler
        Purpose:    Adds new assessment from user input
        NOTES:
        ************************************************/
        private void add_Button_Click(object sender, EventArgs e)
        {
            //if assessment input is valid
            if(ValidateAssessment())
            {
                //get input
                string unit = unit_ComboBox.Text;
                string at = at_TextBox.Text;
                DateTime date = date_DateTimePicker.Value.Date;
                bool resubmit = resubmit_CheckBox.Checked;
                bool completed = completed_CheckBox.Checked;
                string description = description_TextBox.Text;
                //add assessment to list
                //if description is empty, add with default description
                if (description == "")
                {
                    atList.Add(new Assessment(unit, at, date, resubmit, completed));
                }
                else
                {
                    atList.Add(new Assessment(unit, at, date, resubmit, completed, description));
                }
                
                //display new assessment
                DisplayData();
                //show message
                MessageBox.Show("New assessment added!", "ADD SUCCESSFUL");
            }
        }

        /************************************************
        Method:     refresh_Button_Click() event handler
        Purpose:    Refreshes table
        NOTES:
        ************************************************/
        private void refresh_Button_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        /************************************************
        Method:     delete_Button_Click() event handler
        Purpose:    Deletes selected assessment task
        NOTES:
        ************************************************/
        private void delete_Button_Click(object sender, EventArgs e)
        {
            //get confirmation of delete
            DialogResult dialogResult = MessageBox.Show("Delete selected assessment?", "DELETE", MessageBoxButtons.YesNo);  
            if(dialogResult == DialogResult.Yes)
            {
                //loop through atList
                for (int i = 0; i < atList.Count; i++)
                {
                    //get selected assessment
                    if (table_DataGridView.Rows[i].Selected)
                    {
                        //remove selected assessment from list
                        atList.RemoveAt(i);
                        //re-display table
                        DisplayData();
                    }
                }
            }
        }

        /************************************************
        Method:     edit_Button_Click() event handler
        Purpose:    Opens edit screen for selected assessment task
        NOTES:
        ************************************************/
        private void edit_Button_Click(object sender, EventArgs e)
        {
            //hides main panel
            main_Panel.Visible = false;
            //change page title
            title_Label.Text = "Update Selected Assessment";
            //hide add button, show saveUpdate button
            add_Button.Visible = false;
            saveUpdate_Button.Visible = true;

            //FILL INPUT FIELDS
            //loop through atList
            for (int i = 0; i < atList.Count; i++)
            {
                //get selected assessment
                if (table_DataGridView.Rows[i].Selected)
                {
                    //loop through unit ComboBox
                    for(int j = 0; j < unit_ComboBox.Items.Count; j++)
                    {
                        //if selected unit equals unit in ComboBox
                        if (atList[i].Unit.ToString() == unit_ComboBox.Items[j].ToString())
                        {
                            //select correct unit in ComboBox
                            unit_ComboBox.SelectedIndex = j;
                        }
                    }
                    //fills inputs with current data
                    at_TextBox.Text = atList[i].AT.ToString();
                    date_DateTimePicker.Value = atList[i].Date;
                    resubmit_CheckBox.Checked = atList[i].Resubmit;
                    completed_CheckBox.Checked = atList[i].Completed;
                }
            }

            //shows details panel
            details_Panel.Visible = true;
        }

        private void saveUpdate_Button_Click(object sender, EventArgs e)
        {
            //if inputs are valid
            if(ValidateAssessment())
            {
                //loop through atList
                for(int i = 0; i < atList.Count; i++)
                {
                    //get selected assessment
                    if(table_DataGridView.Rows[i].Selected)
                    {
                        //change list values based on input
                        atList[i].Unit = unit_ComboBox.SelectedItem.ToString();
                        atList[i].AT = at_TextBox.Text;
                        atList[i].Date = date_DateTimePicker.Value;
                        atList[i].Resubmit = resubmit_CheckBox.Checked;
                        atList[i].Completed = completed_CheckBox.Checked;
                        atList[i].Description = description_TextBox.Text;
                        //refresh table
                        DisplayData();
                        //show completion message
                        MessageBox.Show("Update complete!", "UPDATE");
                    }
                }
            }
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            //***** GET ASSESSMENTS *****
            //get assessments file source
            string filePath = @"assessments.csv";
            //read assessments file
            if (File.Exists(filePath))
            {
                //read file line by line
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    //string line;
                    //int lineCount = 0;

                    file.WriteLine("Unit,AT,Date,Resubmit,Completed");
                    
                    for(int i = 0; i < atList.Count; i++)
                    {
                        file.WriteLine(atList[i].ToCSVString());
                    }
                    //close file
                    file.Close();
                }//END using
                MessageBox.Show("Save complete!", "SAVE");
            }
        }
    }
}
