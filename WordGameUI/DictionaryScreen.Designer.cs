namespace WordGameUI
{
    partial class DictionaryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DictionaryScreen));
            this.Def = new System.Windows.Forms.Button();
            this.Cust = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Def
            // 
            this.Def.Location = new System.Drawing.Point(52, 28);
            this.Def.Name = "Def";
            this.Def.Size = new System.Drawing.Size(130, 54);
            this.Def.TabIndex = 0;
            this.Def.Text = "Use Default Dictionary";
            this.Def.UseVisualStyleBackColor = true;
            this.Def.Click += new System.EventHandler(this.Def_Click);
            // 
            // Cust
            // 
            this.Cust.Location = new System.Drawing.Point(52, 88);
            this.Cust.Name = "Cust";
            this.Cust.Size = new System.Drawing.Size(130, 54);
            this.Cust.TabIndex = 1;
            this.Cust.Text = "Browse for a Dictionary";
            this.Cust.UseVisualStyleBackColor = true;
            this.Cust.Click += new System.EventHandler(this.Cust_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // DictionaryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 200);
            this.Controls.Add(this.Cust);
            this.Controls.Add(this.Def);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DictionaryScreen";
            this.Text = "Word Game Setup";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Def;
        private System.Windows.Forms.Button Cust;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}