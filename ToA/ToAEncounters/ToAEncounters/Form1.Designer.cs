namespace ToARandomEncounters
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.encounter1Browser = new System.Windows.Forms.WebBrowser();
            this.encounter3Browser = new System.Windows.Forms.WebBrowser();
            this.encounter2Browser = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Beach",
            "Jungle (No Undead)",
            "Jungle (Lesser Undead)",
            "Jungle (Greater Undead)",
            "Mountains",
            "Rivers",
            "Ruins",
            "Swamp",
            "Wasteland"});
            this.comboBox1.Location = new System.Drawing.Point(814, 524);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select Terrain";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 551);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Encounters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encounter1Browser
            // 
            this.encounter1Browser.Location = new System.Drawing.Point(8, 65);
            this.encounter1Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.encounter1Browser.Name = "encounter1Browser";
            this.encounter1Browser.Size = new System.Drawing.Size(800, 400);
            this.encounter1Browser.TabIndex = 2;
            // 
            // encounter3Browser
            // 
            this.encounter3Browser.Location = new System.Drawing.Point(8, 524);
            this.encounter3Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.encounter3Browser.Name = "encounter3Browser";
            this.encounter3Browser.Size = new System.Drawing.Size(800, 400);
            this.encounter3Browser.TabIndex = 3;
            // 
            // encounter2Browser
            // 
            this.encounter2Browser.Location = new System.Drawing.Point(814, 65);
            this.encounter2Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.encounter2Browser.Name = "encounter2Browser";
            this.encounter2Browser.Size = new System.Drawing.Size(800, 400);
            this.encounter2Browser.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 34);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(814, 25);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(600, 34);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(8, 484);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(596, 34);
            this.textBox3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Afternoon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Evening";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Morning";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 966);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.encounter2Browser);
            this.Controls.Add(this.encounter3Browser);
            this.Controls.Add(this.encounter1Browser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tomb of Annihilation Encounters";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser encounter1Browser;
        private System.Windows.Forms.WebBrowser encounter3Browser;
        private System.Windows.Forms.WebBrowser encounter2Browser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

