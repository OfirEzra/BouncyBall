namespace BouncyBall
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
            this.BallPictureBox = new System.Windows.Forms.PictureBox();
            this.ActionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BallPictureBox
            // 
            this.BallPictureBox.Image = global::BouncyBall.Properties.Resources.ball;
            this.BallPictureBox.InitialImage = global::BouncyBall.Properties.Resources.ball;
            this.BallPictureBox.Location = new System.Drawing.Point(353, 120);
            this.BallPictureBox.Name = "BallPictureBox";
            this.BallPictureBox.Size = new System.Drawing.Size(122, 118);
            this.BallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BallPictureBox.TabIndex = 0;
            this.BallPictureBox.TabStop = false;
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(348, 415);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(127, 23);
            this.ActionButton.TabIndex = 1;
            this.ActionButton.Text = "Start!";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.BallPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BallPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BallPictureBox;
        private System.Windows.Forms.Button ActionButton;
    }
}

