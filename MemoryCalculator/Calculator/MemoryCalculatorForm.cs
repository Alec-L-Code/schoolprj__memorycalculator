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



namespace Calculator
{
    public partial class MemoryCalculatorForm : Form
    {
        private readonly MemoryCalculator memoryCalculator;

        public MemoryCalculatorForm()
        {
            InitializeComponent();
            memoryCalculator = new MemoryCalculator();
            Output_TextBox.Text = "0";
        }

        // A method to change the text of the IO textbox. Handles zeros and any letters.
        private void ChangeIOText(string text, bool ignoreParse = false)
        {
            if(ignoreParse)
            {
                Output_TextBox.Text = text;
                return;
            }
            if (text == string.Empty) { Output_TextBox.Text = string.Empty; return; }
            if (Output_TextBox.Text == "0") { Output_TextBox.Text = text; }
            else if (Output_TextBox.Text == "-0") { Output_TextBox.Text = text; }
            else if (Output_TextBox.Text.Contains("*")) { Output_TextBox.Text = text; }
            else if (Regex.IsMatch(Output_TextBox.Text, @"[a-zA-Z]")) { Output_TextBox.Text = text; }
            else { Output_TextBox.Text += text; }
        }
        // An event handler for every number click
        private void Calculator_Number_Click(object sender, EventArgs e)
        {
            Button parsedSender = (Button)sender;
            string numberClickedStr = (string)(parsedSender.Tag); // Gets the string object from the tag associated with the button clicked
            parsedSender.Focus();
            ChangeIOText(numberClickedStr);
        }


        private void Calculator_Addition_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try { memoryCalculator.Add(number); }
                catch (OverflowException) { ChangeIOText("ERROR: OVERFLOW", true); memoryCalculator.Clear(); return; }
                ChangeIOText(string.Empty);
                ChangeIOText("0");
                if(memoryCalculator.CurrentValue != 0m)
                {
                    ChangeIOText("*" + memoryCalculator.CurrentValue, true);
                }
            }
            else
            {
                memoryCalculator.CurrentOperator = Calculator.Operator.ADD;
            }
        }
        private void Calculator_Subtraction_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try { memoryCalculator.Subtract(number); }
                catch (OverflowException) { ChangeIOText("ERROR: OVERFLOW", true); memoryCalculator.Clear(); return; }
                ChangeIOText(string.Empty);
                ChangeIOText("0");
                if (memoryCalculator.CurrentValue != 0m)
                {
                    ChangeIOText("*" + memoryCalculator.CurrentValue, true);
                }
            }
            else
            {
                memoryCalculator.CurrentOperator = Calculator.Operator.SUBTRACT;
            }
        }
        private void Calculator_Multiply_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try { memoryCalculator.Multiply(number); }
                catch (OverflowException) { ChangeIOText("ERROR: OVERFLOW", true); memoryCalculator.Clear(); return; }
                ChangeIOText(string.Empty);
                ChangeIOText("0");
                if (memoryCalculator.CurrentValue != 0m)
                {
                    ChangeIOText("*" + memoryCalculator.CurrentValue, true);
                }
            }
            else
            {
                memoryCalculator.CurrentOperator = Calculator.Operator.MULTIPLY;
            }
        }
        private void Calculator_Divide_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try
                {
                    memoryCalculator.Divide(number);
                } catch(DivideByZeroException) { ChangeIOText("ERROR: DIV BY ZERO", true); memoryCalculator.Clear(); return; }
                ChangeIOText(string.Empty);
                ChangeIOText("0");
                if (memoryCalculator.CurrentValue != 0m)
                {
                    ChangeIOText("*" + memoryCalculator.CurrentValue, true);
                }
            }
            else
            {
                memoryCalculator.CurrentOperator = Calculator.Operator.DIVIDE;
            }
        }
        private void Calculator_Clear_Click(object sender, EventArgs e)
        {
            memoryCalculator.Clear();
            ChangeIOText(string.Empty);
            ChangeIOText("0");
        }
        private void Calculator_Back_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Output_TextBox.Text == "0")
                {
                    return;
                }
                string parsedBackString = Output_TextBox.Text.Remove(Output_TextBox.Text.Length - 1, 1);
                if(parsedBackString == string.Empty)
                {
                    ChangeIOText("0", true);
                    return;
                }
                ChangeIOText(parsedBackString, true);
            }
            catch(ArgumentOutOfRangeException) { ChangeIOText("0", true); }
        }
        private void Calculator_Invert_Click(object sender, EventArgs e)
        {
            if(Output_TextBox.Text == string.Empty) { return; }
            if(Output_TextBox.Text.Contains("-"))
            {
                ChangeIOText(Output_TextBox.Text.Replace("-", string.Empty), true);
            }
            else
            {
                ChangeIOText(Output_TextBox.Text.Insert(0, "-"), true);
            }
        }
        private void Calculator_Decimal_Click(object sender, EventArgs e)
        {
            if (Output_TextBox.Text == string.Empty) { return; }
            if (Output_TextBox.Text.Contains("."))
            {
                return;
            }
            else
            {
                ChangeIOText(Output_TextBox.Text += ".", true);
            }
        }
        private void Calculator_Reciprocal_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try
                {
                    decimal recip = memoryCalculator.Reciprocal(number);
                    ChangeIOText(recip.ToString(), true);
                }
                catch (OverflowException) { }
                catch (DivideByZeroException) { ChangeIOText("ERROR: DIV BY ZERO", true); memoryCalculator.Clear(); return; }
            }
        }
        private void Calculator_Sqrt_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try
                {
                    decimal sqrt = memoryCalculator.SQRT(number);
                    ChangeIOText(sqrt.ToString(), true);
                } catch(OverflowException) { ChangeIOText("ERROR: IMAGINARY NUM", true); memoryCalculator.Clear(); return; }
            }
        }
        private void Calculator_Equals_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try
                {
                    memoryCalculator.Equals(number);
                } catch(DivideByZeroException) { ChangeIOText("ERROR: DIV BY ZERO", true); memoryCalculator.Clear(); return; }
                catch(OverflowException) { ChangeIOText("ERROR: OVERFLOW", true); memoryCalculator.Clear(); return; }
                ChangeIOText(memoryCalculator.CurrentValue.ToString(), true);
            }
            else
            {
                ChangeIOText(memoryCalculator.CurrentValue.ToString(), true);
            }
        }

        private void MemoryClear_Button_Click(object sender, EventArgs e)
        {
            memoryCalculator.MemoryClear();
            Memory_TextBox.Text = string.Empty;
        }

        private void MemoryStore_Button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                memoryCalculator.MemoryStore(number);
                Memory_TextBox.Text = "M";
            }
        }

        private void MemoryRecall_Button_Click(object sender, EventArgs e)
        {
            memoryCalculator.MemoryRecall();
            if(memoryCalculator.MemoryActive)
            {
                ChangeIOText(memoryCalculator.CurrentValue.ToString(), true);
            }
        }

        private void MemoryAdd_Button_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Output_TextBox.Text, out decimal number))
            {
                try { memoryCalculator.MemoryAdd(number); Memory_TextBox.Text = "M"; }
                catch (OverflowException) { ChangeIOText("ERROR: OVERFLOW", true); memoryCalculator.Clear(); return; }
            }
        }
    }
}
