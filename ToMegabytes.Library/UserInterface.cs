/* UserInterface.cs
 * Author: Christopher Loura
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToMegabytes
{
    public partial class UserInterface : Form
    {
        /// <summary>
        /// The linked list cells which contain the file information
        /// </summary>
        private LinkedListCell<KeyValuePair<double, string>> _elements = null;

        /// <summary>
        /// Creates the UI
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
            //BackColor = System.Drawing.Color.Blue;
        }

        /// <summary>
        /// Click event handler for the 'Open file' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpenFile_Click(object sender, EventArgs e)
        {
            if (uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadFile(uxOpenDialog.FileName);
                    uxFileName.Text = uxOpenDialog.FileName;
                    uxFileName.SelectionStart = uxFileName.Text.Length;

                    MessageBox.Show("File Successfully Read");
                }

                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Reads in a text file and stores the data from each
        /// line into a linked list
        /// </summary>
        /// <param name="fn">The name of the file</param>
        private void ReadFile(string fn)
        {
            using (StreamReader sr = new StreamReader(fn))
            {
                while (!sr.EndOfStream)
                {
                    try
                    {
                        string[] parts = sr.ReadLine().Split(' ');

                        double num = Convert.ToDouble(parts[0]);
                        LinkedListCell<KeyValuePair<double, string>> cell = new LinkedListCell<KeyValuePair<double, string>>();

                        cell.Data = new KeyValuePair<double, string>(num, parts[1]);
                        cell.Next = _elements;

                        _elements = cell;
                    }

                    catch (Exception)
                    {
                        continue;
                    }

                }
            }
        }

        /// <summary>
        /// Event handler for the 'Compute' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCompute_Click(object sender, EventArgs e)
        {
            LinkedListCell<KeyValuePair<double, string>> copy = _elements;
            double sum = 0;

            while(copy != null)
            {
                if(copy.Data.Value.Contains("KB"))
                {
                    sum += ConvertKilobytes(copy.Data.Key);
                }

                else if(copy.Data.Value.Contains("GB"))
                {
                    sum += ConvertGigabytes(copy.Data.Key);
                }

                else
                {
                    sum += copy.Data.Key;
                }
                copy = copy.Next;
            }
            uxNumMB.Text = sum.ToString();
        }

        /// <summary>
        /// Converts the given kilobytes to megabytes
        /// </summary>
        /// <param name="kilo">The number of kilobytes</param>
        /// <returns>The kilobytes converted to megabytes</returns>
        private double ConvertKilobytes(double kilo)
        {
            return kilo / 1024;
        }

        /// <summary>
        /// Converts the given gigabytes to megabytes
        /// </summary>
        /// <param name="giga">The number of gigabytes</param>
        /// <returns>The gigabytes converted to megaytes</returns>
        private double ConvertGigabytes(double giga)
        {
            return giga * 1024;
        }
    }
}


