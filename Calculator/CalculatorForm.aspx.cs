using Calculator.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator {
    public partial class CalculatorForm : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Button0_Click(object sender, EventArgs e) {
            ShowBox.Text += '0';
        }

        protected void Button1_Click(object sender, EventArgs e) {
            ShowBox.Text += '1';
        }

        protected void Button2_Click(object sender, EventArgs e) {
            ShowBox.Text += '2';
        }

        protected void Button3_Click(object sender, EventArgs e) {
            ShowBox.Text += '3';
        }

        protected void Button4_Click(object sender, EventArgs e) {
            ShowBox.Text += '4';
        }

        protected void Button5_Click(object sender, EventArgs e) {
            ShowBox.Text += '5';
        }

        protected void Button6_Click(object sender, EventArgs e) {
            ShowBox.Text += '6';
        }

        protected void Button7_Click(object sender, EventArgs e) {
            ShowBox.Text += '7';
        }

        protected void Button8_Click(object sender, EventArgs e) {
            ShowBox.Text += '8';
        }

        protected void Button9_Click(object sender, EventArgs e) {
            ShowBox.Text += '9';
        }

        protected void ComaButton_Click(object sender, EventArgs e) {
            ShowBox.Text += '.';
        }

        protected void SumButton0_Click(object sender, EventArgs e) {
            ShowBox.Text += '+';
        }

        protected void MinusButton_Click(object sender, EventArgs e) {
            ShowBox.Text += '-';
        }

        protected void MultiplyButton_Click(object sender, EventArgs e) {
            ShowBox.Text += 'x';
        }

        protected void DivButton_Click(object sender, EventArgs e) {
            ShowBox.Text += '/';
        }

        protected void DeleteButton_Click(object sender, EventArgs e) {
            int length = ShowBox.Text.Length;
            ShowBox.Text =  ShowBox.Text.Remove(length-1, 1);
            Console.WriteLine("length= " + length);
        }

        protected void ClearButton_Click(object sender, EventArgs e) {
            ShowBox.Text = "";
        }

        protected void ResultButton_Click(object sender, EventArgs e)
        {
            CalculatorController controller = new CalculatorController();
            ShowBox.Text = controller.GetResult(ShowBox.Text);
        }
    }
}