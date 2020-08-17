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
using System.Net;
using System.IO;
using System.Media;

namespace WordGameUI
{
    public partial class DictionaryScreen : Form
    {
        public DictionaryScreen()
        {
            InitializeComponent();
        }

        private void Def_Click(object sender, EventArgs e)
        {
            try
            {
                string dictionary = new WebClient().DownloadString(@"https://gamesforx1games.s3.eu-west-2.amazonaws.com/Dict.txt");
                File.WriteAllText(Environment.CurrentDirectory + @"\Dict.txt", dictionary);
            }
            catch
            {
                
            }
            try
            {
                Globals.entireDictionary = File.ReadAllLines(Environment.CurrentDirectory + @"\Dict.txt").ToList();
            }
            catch
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Sorry, an error occured. Please check your internet connection and try again. You only have to download the dictionary once!");
                return;
            }
            Complete();
        }

        private void Cust_Click(object sender, EventArgs e)
        {
            var sfd = new OpenFileDialog
            {
                Title = "Browse For A Dictionary",
                DefaultExt = ".txt"
                
            };
            

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Globals.entireDictionary = DictionaryGrabber.GetFromPath(sfd.FileName);
            }
            Complete();
        }


        void Complete()
        {
            this.Hide();
            new MainUI().ShowDialog();
            this.Close();
            
            
        }
    }
}
