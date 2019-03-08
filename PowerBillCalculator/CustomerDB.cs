using CustomerData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBillCalculator
{
    /*
     * Author: DongMing Hu
     * Date: Feb. 26, 2019
     * Purpose: Controller layer of MVC pattern. Include two static methods, one for reading data from file, one for saving data into file. Constant "path" is the relative location of the .txt file.
     * 
     */

    static class CustomerDB
    {
        const string path = "Customers.txt";
        /// <summary>
        /// Read customer list from a file.
        /// </summary>
        /// <returns>a customer list</returns>
        public static List<Customer> LoadCustomers()
        {
            List<Customer> customers = new List<Customer>();
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // prepare
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    var fields = line.Split(',');
                    Customer cust = new Customer(Convert.ToInt32(fields[0]), fields[1], Convert.ToChar(fields[2].Trim(' ')), Convert.ToDouble(fields[3]));
                    customers.Add(cust);
                }
            }
            catch (Exception ex)
            {
                throw ex;  // throw error, let form handle it
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
            }

            return customers;
        }

        /// <summary>
        /// Write a list of customers into a file.
        /// </summary>
        /// <param name="customers"></param>
        public static void SaveCustomers(List<Customer> customers)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                // prepare
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write
                foreach (var cust in customers)
                {
                    sw.WriteLine(cust.ToCSV());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null)
                    sw.Close();  // close stream writer first
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
