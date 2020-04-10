using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private bool has_dot;
        private bool has_op;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_symbol(int symb)
        {
            if (res.Text == "0" || res.Text == float.PositiveInfinity.ToString())
                res.Text = "";
            res.Text += symb;
        }

        #region numbers
        private void but0_Click(object sender, EventArgs e)
        {
            add_symbol(0);
        }

        private void but1_Click(object sender, EventArgs e)
        {
            add_symbol(1);
        }

        private void but2_Click(object sender, EventArgs e)
        {
            add_symbol(2);
        }

        private void but3_Click(object sender, EventArgs e)
        {
            add_symbol(3);
        }

        private void but4_Click(object sender, EventArgs e)
        {
            add_symbol(4);
        }

        private void but5_Click(object sender, EventArgs e)
        {
            add_symbol(5);
        }

        private void but6_Click(object sender, EventArgs e)
        {
            add_symbol(6);
        }

        private void but7_Click(object sender, EventArgs e)
        {
            add_symbol(7);
        }

        private void but8_Click(object sender, EventArgs e)
        {
            add_symbol(8);
        }

        private void but9_Click(object sender, EventArgs e)
        {
            add_symbol(9);
        }

        #endregion

        private void plus_Click(object sender, EventArgs e)
        {
            if (res.Text.EndsWith(",") ||
                res.Text.EndsWith("+") || res.Text.EndsWith("-") ||
                res.Text.EndsWith("*") || res.Text.EndsWith("/") || res.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (has_op)
                Calculate();
            has_dot = false;
            res.Text += "+";
            has_op = true;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (res.Text.EndsWith(",") ||
                res.Text.EndsWith("+") || res.Text.EndsWith("-") ||
                res.Text.EndsWith("*") || res.Text.EndsWith("/") || res.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (has_op)
                Calculate();
            has_dot = false;
            res.Text += "-";
            has_op = true;

        }

        private void multi_Click(object sender, EventArgs e)
        {
            if (res.Text.EndsWith(",") ||
                res.Text.EndsWith("+") || res.Text.EndsWith("-") ||
                res.Text.EndsWith("*") || res.Text.EndsWith("/") || res.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (has_op)
                Calculate();
            has_dot = false;
            res.Text += "*";
            has_op = true;

        }

        private void div_Click(object sender, EventArgs e)
        {
            if (res.Text.EndsWith(",") ||
                res.Text.EndsWith("+") || res.Text.EndsWith("-") ||
                res.Text.EndsWith("*") || res.Text.EndsWith("/") || res.Text == float.PositiveInfinity.ToString()
                )
                return;
            if (has_op)
                Calculate();
            has_dot = false;
            res.Text += "/";
            has_op = true;

        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (has_dot || 
                res.Text.EndsWith("+") || res.Text.EndsWith("-") ||
                res.Text.EndsWith("*") || res.Text.EndsWith("/") || res.Text == float.PositiveInfinity.ToString()
                )
                return;
            res.Text += ",";
            has_dot = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            has_dot = false;
            has_op = false;
            Calculate();
        }

        private void ce_Click(object sender, EventArgs e)
        {
            res.Text = "0";
            has_dot = false;
            has_op = false;
        }

        private void Calculate()
        {
            var reg = Regex.Match(res.Text, @"(-?\d+(,\d+)?)[-+*/]");
            if (!reg.Success)
                return;
            var fir = reg.Value;
            var op = fir.Last();
            var y = float.Parse(res.Text.Substring(fir.Length));
            fir = fir.Substring(0, fir.Length - 1);
            var x = float.Parse(fir);
            switch (op)
            {
                case '+':
                    res.Text = (x + y).ToString();
                    break;
                case '-':
                    res.Text = (x - y).ToString();
                    break;
                case '*':
                    res.Text = (x * y).ToString();
                    break;
                case '/':
                    res.Text = (x / y).ToString();
                    break;
            }
            if (res.Text.Contains('E'))
                res.Text = float.PositiveInfinity.ToString();
            if (res.Text.Contains(','))
                has_dot = true;
            Clipboard.SetText(res.Text);
        }
        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                add_symbol(e.KeyChar - 48);
            if (e.KeyChar == '/')
                div_Click(sender, e);
            if (e.KeyChar == '.')
                dot_Click(sender, e);
            if (e.KeyChar == '*')
                multi_Click(sender, e);
            if (e.KeyChar == '-')
                minus_Click(sender, e);
            if (e.KeyChar == '+')
                plus_Click(sender, e);
            if (e.KeyChar == (char)Keys.Enter)
                equal_Click(sender, e);
        }
    }
}
