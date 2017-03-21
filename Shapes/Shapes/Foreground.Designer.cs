namespace WorldofShapes
{
    partial class WorldOfShapes
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
            this.Instruction1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.Instruction2 = new System.Windows.Forms.Label();
            this.pointBox1 = new System.Windows.Forms.TextBox();
            this.pointBox2 = new System.Windows.Forms.TextBox();
            this.pointA = new System.Windows.Forms.Label();
            this.pointB = new System.Windows.Forms.Label();
            this.OutputLabel1 = new System.Windows.Forms.Label();
            this.pointC = new System.Windows.Forms.Label();
            this.pointBox3 = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.GroupBox();
            this.submit1 = new System.Windows.Forms.Button();
            this.shapePicture = new System.Windows.Forms.PictureBox();
            this.Enter = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.extraCoord = new System.Windows.Forms.GroupBox();
            this.pointBox4 = new System.Windows.Forms.TextBox();
            this.pointD = new System.Windows.Forms.Label();
            this.data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePicture)).BeginInit();
            this.extraCoord.SuspendLayout();
            this.SuspendLayout();
            // 
            // Instruction1
            // 
            this.Instruction1.AutoSize = true;
            this.Instruction1.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruction1.Location = new System.Drawing.Point(249, 9);
            this.Instruction1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Instruction1.Name = "Instruction1";
            this.Instruction1.Size = new System.Drawing.Size(373, 26);
            this.Instruction1.TabIndex = 0;
            this.Instruction1.Text = "Enter the name of a shape and click submit";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(295, 41);
            this.inputBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(214, 33);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextChanged += new System.EventHandler(this.inputBox_TextChanged);
            // 
            // Instruction2
            // 
            this.Instruction2.AutoSize = true;
            this.Instruction2.Location = new System.Drawing.Point(179, 93);
            this.Instruction2.Name = "Instruction2";
            this.Instruction2.Size = new System.Drawing.Size(606, 26);
            this.Instruction2.TabIndex = 2;
            this.Instruction2.Text = "Enter the coordiantes of the starting point and radius then click enter";
            // 
            // pointBox1
            // 
            this.pointBox1.Location = new System.Drawing.Point(41, 23);
            this.pointBox1.Name = "pointBox1";
            this.pointBox1.Size = new System.Drawing.Size(80, 33);
            this.pointBox1.TabIndex = 3;
            // 
            // pointBox2
            // 
            this.pointBox2.Location = new System.Drawing.Point(181, 24);
            this.pointBox2.Name = "pointBox2";
            this.pointBox2.Size = new System.Drawing.Size(84, 33);
            this.pointBox2.TabIndex = 4;
            // 
            // pointA
            // 
            this.pointA.AutoSize = true;
            this.pointA.Location = new System.Drawing.Point(6, 26);
            this.pointA.Name = "pointA";
            this.pointA.Size = new System.Drawing.Size(22, 26);
            this.pointA.TabIndex = 5;
            this.pointA.Text = "X";
            // 
            // pointB
            // 
            this.pointB.AutoSize = true;
            this.pointB.Location = new System.Drawing.Point(147, 23);
            this.pointB.Name = "pointB";
            this.pointB.Size = new System.Drawing.Size(24, 26);
            this.pointB.TabIndex = 6;
            this.pointB.Text = "Y";
            // 
            // OutputLabel1
            // 
            this.OutputLabel1.AutoSize = true;
            this.OutputLabel1.Location = new System.Drawing.Point(233, 285);
            this.OutputLabel1.Name = "OutputLabel1";
            this.OutputLabel1.Size = new System.Drawing.Size(0, 26);
            this.OutputLabel1.TabIndex = 7;
            // 
            // pointC
            // 
            this.pointC.AutoSize = true;
            this.pointC.Location = new System.Drawing.Point(291, 31);
            this.pointC.Name = "pointC";
            this.pointC.Size = new System.Drawing.Size(24, 26);
            this.pointC.TabIndex = 9;
            this.pointC.Text = "Z";
            // 
            // pointBox3
            // 
            this.pointBox3.Location = new System.Drawing.Point(358, 26);
            this.pointBox3.Name = "pointBox3";
            this.pointBox3.Size = new System.Drawing.Size(77, 33);
            this.pointBox3.TabIndex = 10;
            // 
            // data
            // 
            this.data.Controls.Add(this.pointBox1);
            this.data.Controls.Add(this.pointC);
            this.data.Controls.Add(this.pointBox3);
            this.data.Controls.Add(this.pointA);
            this.data.Controls.Add(this.pointB);
            this.data.Controls.Add(this.pointBox2);
            this.data.Location = new System.Drawing.Point(205, 151);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(447, 73);
            this.data.TabIndex = 11;
            this.data.TabStop = false;
            // 
            // submit1
            // 
            this.submit1.Location = new System.Drawing.Point(557, 47);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(83, 27);
            this.submit1.TabIndex = 12;
            this.submit1.Text = "Submit";
            this.submit1.UseVisualStyleBackColor = true;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // shapePicture
            // 
            this.shapePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shapePicture.Location = new System.Drawing.Point(725, 309);
            this.shapePicture.Name = "shapePicture";
            this.shapePicture.Size = new System.Drawing.Size(170, 158);
            this.shapePicture.TabIndex = 13;
            this.shapePicture.TabStop = false;
            this.shapePicture.Visible = false;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(406, 230);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(71, 35);
            this.Enter.TabIndex = 14;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(386, 491);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(105, 35);
            this.Quit.TabIndex = 15;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // extraCoord
            // 
            this.extraCoord.Controls.Add(this.pointBox4);
            this.extraCoord.Controls.Add(this.pointD);
            this.extraCoord.Location = new System.Drawing.Point(658, 150);
            this.extraCoord.Name = "extraCoord";
            this.extraCoord.Size = new System.Drawing.Size(173, 74);
            this.extraCoord.TabIndex = 16;
            this.extraCoord.TabStop = false;
            // 
            // pointBox4
            // 
            this.pointBox4.Location = new System.Drawing.Point(89, 32);
            this.pointBox4.Name = "pointBox4";
            this.pointBox4.Size = new System.Drawing.Size(62, 33);
            this.pointBox4.TabIndex = 1;
            // 
            // pointD
            // 
            this.pointD.AutoSize = true;
            this.pointD.Location = new System.Drawing.Point(18, 32);
            this.pointD.Name = "pointD";
            this.pointD.Size = new System.Drawing.Size(36, 26);
            this.pointD.TabIndex = 0;
            this.pointD.Text = "Y2";
            // 
            // WorldOfShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(949, 538);
            this.Controls.Add(this.extraCoord);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.shapePicture);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.OutputLabel1);
            this.Controls.Add(this.Instruction2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.Instruction1);
            this.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "WorldOfShapes";
            this.Text = "World of Shapes";
            this.data.ResumeLayout(false);
            this.data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapePicture)).EndInit();
            this.extraCoord.ResumeLayout(false);
            this.extraCoord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Instruction1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label Instruction2;
        private System.Windows.Forms.TextBox pointBox1;
        private System.Windows.Forms.TextBox pointBox2;
        private System.Windows.Forms.Label pointA;
        private System.Windows.Forms.Label pointB;
        private System.Windows.Forms.Label OutputLabel1;
        private System.Windows.Forms.Label pointC;
        private System.Windows.Forms.TextBox pointBox3;
        private System.Windows.Forms.GroupBox data;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.PictureBox shapePicture;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.GroupBox extraCoord;
        private System.Windows.Forms.TextBox pointBox4;
        private System.Windows.Forms.Label pointD;
    }
}

