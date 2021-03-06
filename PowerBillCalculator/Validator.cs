﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBillCalculator
{
    /*
     * Author: DongMing Hu
     * Date: Feb. 22, 2019
     * Purpose: A class contains various validation methods to validate a textbox.
     * 
     */

    class Validator
    {
        /// <summary>
        /// Test if a TextBox have a non-negative integer value, return bool.
        /// </summary>
        /// <param name="tb">TextBox</param>
        /// <param name="txtBoxName">Name for the TextBox</param>
        /// <returns>Bool: if TextBox pass validation</returns>
        public static bool TBHasNonNegativeInt(TextBox tb, string txtBoxName)
        {
            if (TBIsEmpty(tb, txtBoxName))  // check if empty
                return false;
            else  // not empty, check if has integer
            {
                if (!TBHasInt(tb, txtBoxName))
                    return false;
                else  // is integer, check if negative  
                {
                    return !TBHasNegativeValue(tb, txtBoxName);
                }
            }
        }

        // Check if a textbox has non-negative double
        public static bool TBHasNonNegativeDouble(TextBox tb, string txtBoxName)
        {
            if (TBIsEmpty(tb, txtBoxName))  // check if empty
                return false;
            else  // not empty, check if has double
            {
                if (!TBHasDouble(tb, txtBoxName))
                    return false;
                else  // is double, check if negative  
                {
                    return !TBHasNegativeValue(tb, txtBoxName);
                }
            }
        }

        //--------------------- Breakdown Methods ---------------------------//

        // check if a textbox is empty, if yes, show messagebox
        // always do this FIRST!
        public static bool TBIsEmpty(TextBox tb, string txtBoxName)
        {
            if (tb.Text == "")
            {
                MessageBox.Show(txtBoxName + " need to be provided.", "Input Error");
                tb.Focus();
                return true;
            }
            else
                return false;
        }

        // check if a textbox has integer value, if no, show messagebox
        // always do this after isEmpty validation
        public static bool TBHasInt(TextBox tb, string txtBoxName)
        {
            if (!Int32.TryParse(tb.Text, out int myInt))
            {
                MessageBox.Show(txtBoxName + " requires a whole number.", "Input Error");
                tb.SelectAll();  // highlight text for easy replacement
                tb.Focus();
                return false;
            }
            else
                return true;
        }

        // check if a textbox has a double value, if no, show messagebox
        // always do this after isEmpty validation
        public static bool TBHasDouble(TextBox tb, string txtBoxName)
        {
            if (!Double.TryParse(tb.Text, out double myDouble))
            {
                MessageBox.Show(txtBoxName + " requires a valid number.", "Input Error");
                tb.SelectAll();  // highlight text for easy replacement
                tb.Focus();
                return false;
            }
            else
                return true;
        }

        // check if a textbox has negative value, if yes, show messagebox
        // always do this after isEmpty validation
        public static bool TBHasNegativeValue(TextBox tb, string txtBoxName)
        {
            if (Convert.ToDouble(tb.Text) < 0)
            {
                MessageBox.Show(txtBoxName + " requires a non-negative value.", "Input Error");
                tb.SelectAll();  // highlight text for easy replacement
                tb.Focus();
                return true;
            }
            else
                return false;
        }

    }
}
