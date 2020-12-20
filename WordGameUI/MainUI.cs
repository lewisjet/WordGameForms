using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordGameLibrary;

namespace WordGameUI
{
    public partial class MainUI : Form
    {
       MainGame mainGame;
        int localHighScore;
        public MainUI()
        {
            InitializeComponent();
          localHighScore = HighScoreInitializer();
            Ctor();
        }

        private int HighScoreInitializer()
        {
            string path = Environment.CurrentDirectory + @"\Highscore.X1SaveFile";
            if (!File.Exists(path)) {/* File.Create(path);*/ File.WriteAllText(path, "0"); }
            try
            {
                return int.Parse(File.ReadAllText(path));
            }
            catch
            {
              File.Delete(path);
              return  HighScoreInitializer();
            }
        }

        private void HighScoreSave(int score)
        {
            string path = Environment.CurrentDirectory + @"\Highscore.X1SaveFile";
           
            File.WriteAllText(path, score.ToString());
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            mainGame.CalculationsOnly(UserInput.Text, Globals.entireDictionary);
            UserInput.Text = string.Empty;
            UpdateScore();
        }

        void UpdateScore()
        {
            Score.Text = mainGame.Score.ToString();

            if(localHighScore < mainGame.Score) { localHighScore = mainGame.Score; HighScoreSave(localHighScore); }
            HighScore.Text = $"High Score: {localHighScore}";

        }



        void Ctor()
        {
            string numtxt = string.Empty;
            Random random = new Random();
            new RandomChars(out List<char> currentChars, 2, 5, random);

            foreach (char i in currentChars) { numtxt += i.ToString(); }
            Nums.Text = numtxt;

            mainGame = new MainGame(currentChars);
            UpdateScore();
        }

        private void ResetBut_Click(object sender, EventArgs e)
        {
            UserInput.Text = string.Empty;
            Ctor();
        }
    }
}
