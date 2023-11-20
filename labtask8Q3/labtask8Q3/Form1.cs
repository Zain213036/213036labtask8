using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace labtask8Q3
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > MaxCharacters)
            {
                textBox1.Text = textBox1.Text.Substring(0, MaxCharacters);
                textBox1.SelectionStart = MaxCharacters;
                textBox1.SelectionLength = 0;
            }

            label1.Text = $"{textBox1.Text.Length} / {MaxCharacters}";
        }
    }
}

