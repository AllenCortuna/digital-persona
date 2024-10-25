namespace digitalPersonaApp
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
            this.StatusText = new System.Windows.Forms.Label();
            this.fImage = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.AutoSize = true;
            this.StatusText.Location = new System.Drawing.Point(27, 414);
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(35, 13);
            this.StatusText.TabIndex = 0;
            this.StatusText.Text = "label1";
            this.StatusText.Click += new System.EventHandler(this.label1_Click);
            // 
            // fImage
            // 
            this.fImage.Location = new System.Drawing.Point(30, 12);
            this.fImage.Name = "fImage";
            this.fImage.Size = new System.Drawing.Size(354, 386);
            this.fImage.TabIndex = 1;
            this.fImage.TabStop = false;
            this.fImage.Click += new System.EventHandler(this.fImage_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(184, 431);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 486);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fImage);
            this.Controls.Add(this.StatusText);
            this.Name = "Form1";
            this.Text = "o";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusText;
        private System.Windows.Forms.PictureBox fImage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_button;
    }
}

