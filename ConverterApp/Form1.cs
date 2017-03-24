using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    // This program was written by Gail Mosdell
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Original base includes code under btn_CM_To_Inches_Click and btn_Exit_Click
    // Date : February 2017

    //Expanded code, including everything other then what is mentioned above, written by Timothy Stewart
    //Date: 24/03/2017

{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double dbl_UofM, dbl_Convert;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;
           
            // validate user entry and convert to a double

            if (! double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * CM_TO_INCH;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }
        }

        private void btn_C_To_F_Click(object sender, EventArgs e)
        {
            //Constant does not work correctly, see C_TO_F error1.png and C_TO_F error2.png in Debugging Screenshots Folder.

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * 1.8 + 32;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + "° Celsius is converted to ";
                lbl_Convert.Text = "° Fahrenheit.";
            }
        }

        private void btn_CM_To_Feet_Click(object sender, EventArgs e)
        {
            const double CM_TO_FEET = 0.0328084;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * CM_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " centimetres is converted to ";
                lbl_Convert.Text = " feet.";
            }
        }

        private void btn_KM_To_Miles_Click(object sender, EventArgs e)
        {
            const double KM_TO_MILES = 0.621371;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * KM_TO_MILES;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " kilometers is converted to ";
                lbl_Convert.Text = " miles.";
            }
        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            
            const double M_TO_FEET = 3.2808;

            // validate user entry and convert to a double

            if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure.Clear();
                txt_UnitOfMeasure.Focus();
                txt_Convert.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert = dbl_UofM * M_TO_FEET;
                txt_Convert.Text = dbl_Convert.ToString();
                lbl_Display.Text = txt_UnitOfMeasure.Text + " metres is converted to ";
                lbl_Convert.Text = " feet.";
            }

        }
    }
}
