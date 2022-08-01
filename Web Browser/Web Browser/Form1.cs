using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        //Name: Ben Lee
        //ID  : 1567783
        public Form1()
        {
            InitializeComponent();
        }

        List<string> bookMarksList = new List<string>();

        const string FILTER = "CSV Files|*.csv|All Files|*.*";
        /// <summary>
        /// Takes the webbrowser back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        /// <summary>
        /// Takes the webbrowser forward
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        /// <summary>
        /// Takes the webbrowser to url in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxSearchBar.Text);
        }
        /// <summary>
        /// Shows the status of web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            textBoxStatus.Text = "Loading...";
        }
        /// <summary>
        /// Changes the title bar name and clears status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textBoxStatus.Clear();
            textBoxSearchBar.Text = webBrowser1.Document.Url.ToString();
            this.Text = webBrowser1.DocumentTitle; 
        }
        /// <summary>
        /// closes the web browser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clears listbox and adds the next url
        /// </summary>
        private void UpdateListBox()
        {
            //Clear listBox
            listBoxBookMarks.Items.Clear();
            //FOR each url in the lists
            for (int i = 0; i < bookMarksList.Count; i++)
            {
                //Add url to listBox
                listBoxBookMarks.Items.Add(bookMarksList[i]);
            }
        }
        /// <summary>
        /// Clears the listbox
        /// </summary>
        private void Initialise()
        {
            bookMarksList.Clear();
            textBoxSearchBar.Clear();
            UpdateListBox();
        }
        /// <summary>
        /// uses the initialise method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newBookmarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Initialise();
        }
        /// <summary>
        /// this adds the searchbar contents of the search bar if it isnt full
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if the textbox is empty
            if (textBoxSearchBar.Text == "")
            {

            }
            else
            {
                bookMarksList.Add(textBoxSearchBar.Text);
                UpdateListBox();
            }
        }
        /// <summary>
        /// lets the user select a url in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxBookMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxBookMarks.SelectedIndex;
            textBoxSearchBar.Text = listBoxBookMarks.Items[index].ToString();
            webBrowser1.Navigate(textBoxSearchBar.Text);
        }
        /// <summary>
        /// saves the current listbox to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBookmarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            saveFileDialog1.Filter = FILTER;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Open the output file
                writer = File.CreateText(saveFileDialog1.FileName);
                //FOR each student in the lists
                for(int i=0; i < bookMarksList.Count; i++)
                {
                    writer.WriteLine(bookMarksList[i]);
                }
                writer.Close();
                this.Text = saveFileDialog1.FileName;
            }
        }
        /// <summary>
        /// opens a bookmark listbox from a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadBookmarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string line = "";
            string[] csvArray;
            string bookmark = "";

            openFileDialog1.Filter = FILTER;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = File.OpenText(openFileDialog1.FileName);
                Initialise();
                while (!reader.EndOfStream)
                {
                    try
                    {
                        //Read a line from the file
                        line = reader.ReadLine();
                        //split the values in the line using an array
                        csvArray = line.Split();
                        //Check if the array has correct number of elements
                        if (csvArray.Length == 1)
                        {
                            //Extract the data into separate variables
                            bookmark = csvArray[0];
                            //Add the values to the list
                            bookMarksList.Add(bookmark);
                        }
                        else
                        {
                            Console.WriteLine("Error: " + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line);
                    }
                }
                reader.Close();
                this.Text = openFileDialog1.FileName;
                UpdateListBox();
            }
        }
        /// <summary>
        /// this deletes a selected index from listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxBookMarks.SelectedIndex;
            //Clear the data from the list
            bookMarksList.RemoveAt(index);
            UpdateListBox();
        }
    }
}
