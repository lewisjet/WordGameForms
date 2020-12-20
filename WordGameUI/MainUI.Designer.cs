namespace WordGameUI
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.Nums = new System.Windows.Forms.Label();
            this.RulesBox = new System.Windows.Forms.GroupBox();
            this.HighScore = new System.Windows.Forms.Label();
            this.Rules = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MainArea = new System.Windows.Forms.Panel();
            this.Score = new System.Windows.Forms.Label();
            this.ResetBut = new System.Windows.Forms.Button();
            this.RulesBox.SuspendLayout();
            this.MainArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nums
            // 
            this.Nums.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nums.Location = new System.Drawing.Point(151, 6);
            this.Nums.Name = "Nums";
            this.Nums.Size = new System.Drawing.Size(302, 61);
            this.Nums.TabIndex = 0;
            this.Nums.Text = "VV,CCCCC";
            this.Nums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RulesBox
            // 
            this.RulesBox.Controls.Add(this.HighScore);
            this.RulesBox.Controls.Add(this.Rules);
            this.RulesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RulesBox.Location = new System.Drawing.Point(6, 9);
            this.RulesBox.Name = "RulesBox";
            this.RulesBox.Size = new System.Drawing.Size(231, 445);
            this.RulesBox.TabIndex = 1;
            this.RulesBox.TabStop = false;
            this.RulesBox.Text = "Rules";
            // 
            // HighScore
            // 
            this.HighScore.AutoSize = true;
            this.HighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScore.Location = new System.Drawing.Point(6, 417);
            this.HighScore.Name = "HighScore";
            this.HighScore.Size = new System.Drawing.Size(164, 25);
            this.HighScore.TabIndex = 4;
            this.HighScore.Text = "High Score: null";
            // 
            // Rules
            // 
            this.Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.Location = new System.Drawing.Point(1, 21);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(224, 346);
            this.Rules.TabIndex = 0;
            this.Rules.Text = resources.GetString("Rules.Text");
            // 
            // UserInput
            // 
            this.UserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInput.Location = new System.Drawing.Point(161, 91);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(292, 38);
            this.UserInput.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(229, 135);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(155, 56);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MainArea
            // 
            this.MainArea.Controls.Add(this.ResetBut);
            this.MainArea.Controls.Add(this.Score);
            this.MainArea.Controls.Add(this.SubmitButton);
            this.MainArea.Controls.Add(this.UserInput);
            this.MainArea.Controls.Add(this.Nums);
            this.MainArea.Location = new System.Drawing.Point(243, 3);
            this.MainArea.Name = "MainArea";
            this.MainArea.Size = new System.Drawing.Size(550, 464);
            this.MainArea.TabIndex = 4;
            // 
            // Score
            // 
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(229, 237);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(155, 85);
            this.Score.TabIndex = 4;
            this.Score.Text = "0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetBut
            // 
            this.ResetBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBut.Location = new System.Drawing.Point(428, 408);
            this.ResetBut.Name = "ResetBut";
            this.ResetBut.Size = new System.Drawing.Size(119, 53);
            this.ResetBut.TabIndex = 5;
            this.ResetBut.Text = "Reset";
            this.ResetBut.UseVisualStyleBackColor = true;
            this.ResetBut.Click += new System.EventHandler(this.ResetBut_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 466);
            this.Controls.Add(this.MainArea);
            this.Controls.Add(this.RulesBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Word Game";
            this.RulesBox.ResumeLayout(false);
            this.RulesBox.PerformLayout();
            this.MainArea.ResumeLayout(false);
            this.MainArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Nums;
        private System.Windows.Forms.GroupBox RulesBox;
        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Panel MainArea;
        private System.Windows.Forms.Label HighScore;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Button ResetBut;
    }
}

