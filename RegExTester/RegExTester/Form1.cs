using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegExTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxPreloaded_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxPreloaded.SelectedItem.ToString() == "Email")
            {
                txtRegEx.Text = "^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$";
                txtRegEx.Enabled = false;
            }

            switch (cbxPreloaded.SelectedItem.ToString())
            {
                case "Email":
                    txtRegEx.Text = "^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$";
                    txtRegEx.Enabled = false;
                    break;
                case "Phone Number":
                    txtRegEx.Text = "^[2-9]\\d{2}-\\d{3}-\\d{4}$";
                    txtRegEx.Enabled = false;
                    break;
                case "Numbers":
                    txtRegEx.Text = "^[0-9]*$";
                    txtRegEx.Enabled = false;
                    break;
                case "Zip Code":
                    txtRegEx.Text = "^\\d{5}-\\d{4}|\\d{5}|[A-Z]\\d[A-Z] \\d[A-Z]\\d$";
                    txtRegEx.Enabled = false;
                    break;
                case "Currency":
                    txtRegEx.Text = "^\\$[0-9]+(\\.[0-9][0-9])?$";
                    txtRegEx.Enabled = false;
                    break;
                case "Social":
                    txtRegEx.Text = "^\\d{3}-\\d{2}-\\d{4}$";
                    txtRegEx.Enabled = false;
                    break;
                default:
                    txtRegEx.Text = "";
                    txtRegEx.Enabled = true;
                    break;
            }
        }

        private void txtTestText_TextChanged(object sender, EventArgs e)
        {
            Regex tester = new Regex(txtRegEx.Text);
            if (tester.IsMatch(txtTestText.Text))
            {
                lblResult.Text = "Validation Passed";
            }
            else
            {
                lblResult.Text = "Validation Failed";
            }
        }
    }
}
