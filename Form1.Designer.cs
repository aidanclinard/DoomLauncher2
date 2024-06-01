namespace DoomLauncher2
{
    partial class BetterDoomLauncher2
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
            this.START = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SourcePort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openGZDOOMDir = new System.Windows.Forms.OpenFileDialog();
            this.openZandronumDir = new System.Windows.Forms.OpenFileDialog();
            this.openBOOMDir = new System.Windows.Forms.OpenFileDialog();
            this.GZDOOMDir = new System.Windows.Forms.Button();
            this.ZandronumDir = new System.Windows.Forms.Button();
            this.BOOMDir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WadDir = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.refreshWads = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.DimGray;
            this.START.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.START.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.START.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.START.Font = new System.Drawing.Font("Doom 2016 Left", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.START.Location = new System.Drawing.Point(1003, 12);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(215, 95);
            this.START.TabIndex = 0;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Doom 2016 Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1003, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "GZDOOM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Doom 2016 Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1003, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 37);
            this.button2.TabIndex = 4;
            this.button2.Text = "ZANDRONUM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Doom 2016 Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1003, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 37);
            this.button3.TabIndex = 5;
            this.button3.Text = "BOOM";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SourcePort
            // 
            this.SourcePort.AutoSize = true;
            this.SourcePort.Font = new System.Drawing.Font("Doom 2016 Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourcePort.Location = new System.Drawing.Point(1063, 153);
            this.SourcePort.Name = "SourcePort";
            this.SourcePort.Size = new System.Drawing.Size(98, 27);
            this.SourcePort.TabIndex = 6;
            this.SourcePort.Text = "Source Port:";
            this.SourcePort.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Doom 2016 Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "AVAILABLE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Doom 2016 Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "INCLUDED:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("Doom 2016 Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 53);
            this.label3.TabIndex = 9;
            this.label3.Text = "WADS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Doom 2016 Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1022, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Make sure to double check which source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Doom 2016 Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1029, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "port your wads are compaitible with.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // openGZDOOMDir
            // 
            this.openGZDOOMDir.FileName = "openGZDOOMDir";
            this.openGZDOOMDir.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openZandronumDir
            // 
            this.openZandronumDir.FileName = "openZandronumDir";
            // 
            // openBOOMDir
            // 
            this.openBOOMDir.FileName = "openBOOMDir";
            // 
            // GZDOOMDir
            // 
            this.GZDOOMDir.BackColor = System.Drawing.Color.DimGray;
            this.GZDOOMDir.Location = new System.Drawing.Point(894, 183);
            this.GZDOOMDir.Name = "GZDOOMDir";
            this.GZDOOMDir.Size = new System.Drawing.Size(103, 37);
            this.GZDOOMDir.TabIndex = 12;
            this.GZDOOMDir.Text = "set GZDOOM directory";
            this.GZDOOMDir.UseVisualStyleBackColor = false;
            this.GZDOOMDir.Click += new System.EventHandler(this.GZDOOMDir_Click);
            // 
            // ZandronumDir
            // 
            this.ZandronumDir.BackColor = System.Drawing.Color.DimGray;
            this.ZandronumDir.Location = new System.Drawing.Point(894, 226);
            this.ZandronumDir.Name = "ZandronumDir";
            this.ZandronumDir.Size = new System.Drawing.Size(103, 37);
            this.ZandronumDir.TabIndex = 13;
            this.ZandronumDir.Text = "set Zandronum directory";
            this.ZandronumDir.UseVisualStyleBackColor = false;
            this.ZandronumDir.Click += new System.EventHandler(this.ZandronumDir_Click);
            // 
            // BOOMDir
            // 
            this.BOOMDir.BackColor = System.Drawing.Color.DimGray;
            this.BOOMDir.Location = new System.Drawing.Point(894, 269);
            this.BOOMDir.Name = "BOOMDir";
            this.BOOMDir.Size = new System.Drawing.Size(103, 37);
            this.BOOMDir.TabIndex = 14;
            this.BOOMDir.Text = "set BOOM directory";
            this.BOOMDir.UseVisualStyleBackColor = false;
            this.BOOMDir.Click += new System.EventHandler(this.BOOMDir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoomLauncher2.Properties.Resources.vignette;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1246, 844);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // WadDir
            // 
            this.WadDir.BackColor = System.Drawing.Color.DimGray;
            this.WadDir.Location = new System.Drawing.Point(146, 104);
            this.WadDir.Name = "WadDir";
            this.WadDir.Size = new System.Drawing.Size(114, 33);
            this.WadDir.TabIndex = 16;
            this.WadDir.Text = "set WAD directory";
            this.WadDir.UseVisualStyleBackColor = false;
            this.WadDir.Click += new System.EventHandler(this.WadDir_Click);
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(53, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 588);
            this.listView1.TabIndex = 17;
            this.listView1.TileSize = new System.Drawing.Size(1, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            // 
            // listView2
            // 
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(489, 183);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(391, 588);
            this.listView2.TabIndex = 17;
            this.listView2.TileSize = new System.Drawing.Size(1, 1);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.SmallIcon;
            // 
            // refreshWads
            // 
            this.refreshWads.BackColor = System.Drawing.Color.DimGray;
            this.refreshWads.Location = new System.Drawing.Point(185, 153);
            this.refreshWads.Name = "refreshWads";
            this.refreshWads.Size = new System.Drawing.Size(75, 23);
            this.refreshWads.TabIndex = 19;
            this.refreshWads.Text = "refresh";
            this.refreshWads.UseVisualStyleBackColor = false;
            this.refreshWads.Click += new System.EventHandler(this.refreshWads_Click);
            // 
            // BetterDoomLauncher2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::DoomLauncher2.Properties.Resources.FLOOR4_8;
            this.ClientSize = new System.Drawing.Size(1230, 805);
            this.Controls.Add(this.refreshWads);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.WadDir);
            this.Controls.Add(this.BOOMDir);
            this.Controls.Add(this.ZandronumDir);
            this.Controls.Add(this.GZDOOMDir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SourcePort);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.START);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BetterDoomLauncher2";
            this.Text = "BetterDoomLauncher2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SourcePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openGZDOOMDir;
        private System.Windows.Forms.OpenFileDialog openZandronumDir;
        private System.Windows.Forms.OpenFileDialog openBOOMDir;
        private System.Windows.Forms.Button GZDOOMDir;
        private System.Windows.Forms.Button ZandronumDir;
        private System.Windows.Forms.Button BOOMDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button WadDir;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button refreshWads;
    }
}

