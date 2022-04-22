namespace PICalculations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.piLibrary = new System.Windows.Forms.Label();
            this.piSequence = new System.Windows.Forms.Label();
            this.piMonteCarlo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // piLibrary
            // 
            this.piLibrary.AutoSize = true;
            this.piLibrary.Location = new System.Drawing.Point(485, 12);
            this.piLibrary.Name = "piLibrary";
            this.piLibrary.Size = new System.Drawing.Size(38, 15);
            this.piLibrary.TabIndex = 2;
            this.piLibrary.Text = "label2";
            // 
            // piSequence
            // 
            this.piSequence.AutoSize = true;
            this.piSequence.Location = new System.Drawing.Point(485, 47);
            this.piSequence.Name = "piSequence";
            this.piSequence.Size = new System.Drawing.Size(38, 15);
            this.piSequence.TabIndex = 3;
            this.piSequence.Text = "label2";
            // 
            // piMonteCarlo
            // 
            this.piMonteCarlo.AutoSize = true;
            this.piMonteCarlo.Location = new System.Drawing.Point(485, 83);
            this.piMonteCarlo.Name = "piMonteCarlo";
            this.piMonteCarlo.Size = new System.Drawing.Size(38, 15);
            this.piMonteCarlo.TabIndex = 4;
            this.piMonteCarlo.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.piMonteCarlo);
            this.Controls.Add(this.piSequence);
            this.Controls.Add(this.piLibrary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label piLibrary;
        private Label piSequence;
        private Label piMonteCarlo;
    }
}