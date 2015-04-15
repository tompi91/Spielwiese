using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spielwiese
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int z = 3;
        int a = 7;

        private void button1_Click(object sender, EventArgs e)
        {
            string test = GetAnswer_String();
            int answer = GetAnswer_Int();
            MessageBox.Show(test + " = " + answer.ToString());
        }

        public int GetAnswer_Int()
        {
            return a + z;
        }

        public string GetAnswer_String()
        {
            return a.ToString() + " + " + z.ToString();
        }
    }
}
