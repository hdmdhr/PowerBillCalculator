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
        /// <returns>If the TextBox pass validation</returns>
        public static bool TBHasNonNegativeInt(TextBox tb, string txtBoxName)
        {
            
            if (tb.Text == "")  // check if empty
            {
                MessageBox.Show(txtBoxName + "need to be filled.", "Input Error");
                tb.Focus();
                return false;
            }

            // check if integer
            if (Int32.TryParse(tb.Text, out int myInt))
            {
                // check if negative
                if (Convert.ToInt32(tb.Text) < 0)
                {
                    MessageBox.Show(txtBoxName + "need a non-negative integer value.", "Input Error");
                    return false;
                }
            }
            else
            {
                MessageBox.Show(txtBoxName + "need a non-negative integer value.", "Input Error");
                tb.SelectAll();  // highlight text for easy replacement
                tb.Focus();
                return false;
            }



        }


    }
}
