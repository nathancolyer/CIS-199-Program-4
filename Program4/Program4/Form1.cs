// A1212
// Program 4 CIS 199-01
// Due: 4/25/17
// This program will calculate and list the price of a package based on the difference between zip codes, height, weight, length, and width of the packge.
// You can view the package detailsThis program will also change the origin or destination of the package to UofL zip code and update the list.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        private List<GroundPackage> packageList = new List<GroundPackage>(); //creates a parellel list

        public Form1()
        {
            InitializeComponent();
        }

        //Adds the prices of package to list.
        private void addPackageBtn_Click(object sender, EventArgs e)
        {
            GroundPackage package;
            int orig; // stores origin zip from textbox
            int dest; // stores dest. zip from textbox
            double l; // stores length from textbox
            double w; // stores width from textbox
            double h; // stores height from textbox
            double wt; // stores weight from textbox

            //tests to make sure correct variable is entered
            if (int.TryParse(origZipBox.Text, out orig))
            {
                if (int.TryParse(destZipBox.Text, out dest))
                {
                    if (double.TryParse(lengthBox.Text, out l))
                    {
                        if (double.TryParse(widthBox.Text, out w))
                        {
                            if (double.TryParse(heightBox.Text, out h))
                            {
                                if (double.TryParse(weightBox.Text, out wt))
                                {
                                    package = new GroundPackage(orig, dest, l, w, h, wt); //puts values into package

                                    packageList.Add(package); // adds the values to the package list
                                    packageListBox.Items.Add(package.CalcCost().ToString("c")); //calculates and adds price to list
                                }
                                else // shows error message for corresponding variable
                                    MessageBox.Show("Enter valid weight");
                            }
                            else
                                MessageBox.Show("Enter valid height");
                        }
                        else
                            MessageBox.Show("Enter valid width");
                    }
                    else
                        MessageBox.Show("Enter valid length");
                }
                else
                    MessageBox.Show("Enter valid destination zip");
            }
            else
                MessageBox.Show("Enter valid origin zip");
        }
        //Precondtion: listbox item is selected
        //Post: list the details of selected package
        private void detailBtn_Click(object sender, EventArgs e) 
        {
            int index; //index variable
            index = packageListBox.SelectedIndex;

            if (index >= 0 ) //help with this
            {
                MessageBox.Show(packageList[index].ToString());
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        //Pre: item must be selected
        //Post: updates the destination zip code and returns a message and changes price.
        private void toLouisBtn_Click(object sender, EventArgs e) 
        {
            int index;
            index = packageListBox.SelectedIndex;
             if( index >= 0)
            {
                packageList[index].DestZip = 40292;
                packageListBox.Items[index] = packageList[index].CalcCost().ToString("c");
                MessageBox.Show("Destination Zip updated");
            }
        }

        //Pre: item must be select
        //Post: updates the origin zip code and returns a message and changes price.
        private void fromLouisBtn_Click(object sender, EventArgs e) 
        {
            int index;
            index = packageListBox.SelectedIndex;
            if (index >= 0)
            {
                packageList[index].OrigZip = 40292;
                packageListBox.Items[index] = packageList[index].CalcCost().ToString("c");
                MessageBox.Show("Origin Zip updated");
            }
        }
    }
}
