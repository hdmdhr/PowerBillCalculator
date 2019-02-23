using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBillCalculator
{
    class Validator
    {
        /// <summary>
        /// Validate a TextBox to have a non-negative integer.
        /// </summary>
        /// <param name="tb">TextBox</param>
        /// <param name="txtBoxName">Name for the TextBox</param>
        /// <returns>Bool: if TextBox pass validation</returns>
        public static bool TBHasNonNegativeInt(TextBox tb, string txtBoxName)
        {
            if (tb.Text == "")  // check if empty
            {
                MessageBox.Show(txtBoxName + " need to be filled.", "Input Error");
                tb.Focus();
                return false;
            }
            else
            {
                // not empty, check if integer
                if (!Int32.TryParse(tb.Text, out int myInt))
                {
                    MessageBox.Show(txtBoxName + " requires a whole number.", "Input Error");
                    tb.SelectAll();  // highlight text for easy replacement
                    tb.Focus();
                    return false;
                }
                else
                {
                    //  is integer, check if negative  
                    if (Convert.ToInt32(tb.Text) < 0)
                    {
                        MessageBox.Show(txtBoxName + " requires a non-negative value.", "Input Error");
                        tb.SelectAll();  // highlight text for easy replacement
                        tb.Focus();
                        return false;
                    }
                    else
                        return true;
                }
            }
        }
    }
}
