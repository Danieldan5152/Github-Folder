using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_webrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// When the button is clicked this will be excuted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("A button was clicked\r\n");
        }

       /// <summary>
       /// This code will run whenever the mouse is inside of the button
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.AppendText("The mouse has entered the button\r\n");
        }

        /// <summary>
        /// When mouse leaves enter text into the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.AppendText("The mouse has left the button\r\n");
        }
    }
}
