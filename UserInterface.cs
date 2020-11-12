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
                    }

                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }

                }
            }
        }
    }
}


