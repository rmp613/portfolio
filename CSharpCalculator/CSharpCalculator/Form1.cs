using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSharpCalculator {
    public partial class Form1 : Form {
        string input = Constants.ZERO;
        bool shouldClear = false;

        public Form1() {
            InitializeComponent();
        }
        //Handle any button press according to the text string of the button
        private void button_Click(object sender, EventArgs e) {
            Button clickedButton = sender as Button;
            
            if(clickedButton != null) {
                if (shouldClear && Util.IsNumeric(clickedButton.Text))
                    input = Constants.ZERO;
                shouldClear = false;
                //If the button text should not be added to the display handle it specifically
                if(!Util.IsWritable(clickedButton.Text)) {
                    input = InputParser.HandleNonWritable(clickedButton.Text, input);
                    if (clickedButton.Text == Constants.SIGN_EQUALS || Util.ContainsErrorMsg(input)) {
                        shouldClear = true;
                    }
                } else if (input == Constants.ZERO && Util.IsNumeric(clickedButton.Text)) {
                    input = clickedButton.Text;
                } else {
                    input += clickedButton.Text;
                }
                lblDisplay.Text = input;
            }
        }
    }
}
