using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkToPc
{
    // This is a simple program that will read user input from keyboard and mouse event

    public partial class Form1 : Form
    {
        // Global var storing the text string
        string text;

        public Form1()
        {
            InitializeComponent();

            //Enable KeyPreview, allow program to read your keyboard
            KeyPreview = true;
            
            //Assign action
            tboxInput.KeyPress += new KeyPressEventHandler(tboxInput_KeyPress);
            tboxInput.TextChanged += tboxInput_TextChanged;
        }

        // When any entrey is in the tboxInput
        private void tboxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            text += "[" + e.KeyChar.ToString() + "] pressed.\r\n";
        }

        // When tboxInput changed
        private void tboxInput_TextChanged(object sender, EventArgs e)
        {
            tboxOutput.Text = text;
        }

        // Just a simple button to clear both text boxes
        private void btnClearTxt_Click(object sender, EventArgs e)
        {
            text = "";
            tboxOutput.Text = "";
            tboxInput.Text = "";
        }
        
        // Double click the input textbox to clear text
        private void tboxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tboxInput.Text = "";
            text = "";
        }

        // Double click the output textbox to clear to text
        private void tboxOutput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tboxOutput.Text = "";
            text = "";
        }
    }
}
