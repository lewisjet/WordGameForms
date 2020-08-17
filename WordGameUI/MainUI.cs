using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordGameLibrary;

namespace WordGameUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
            string numtxt = string.Empty;
            new RandomChars(out List<char> currentChars, 2, 5);
            foreach(char i in currentChars) { numtxt += i.ToString(); }
            Nums.Text = numtxt;
        }
    }
}
