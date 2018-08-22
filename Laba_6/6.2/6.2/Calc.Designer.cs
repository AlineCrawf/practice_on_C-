namespace _6._2
{
    partial class Calc
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
            this.EvenLabel = new System.Windows.Forms.Label();
            this.PalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EvenLabel
            // 
            this.EvenLabel.AutoSize = true;
            this.EvenLabel.Location = new System.Drawing.Point(31, 82);
            this.EvenLabel.Name = "EvenLabel";
            this.EvenLabel.Size = new System.Drawing.Size(0, 13);
            this.EvenLabel.TabIndex = 0;
            // 
            // PalLabel
            // 
            this.PalLabel.AutoSize = true;
            this.PalLabel.Location = new System.Drawing.Point(34, 145);
            this.PalLabel.Name = "PalLabel";
            this.PalLabel.Size = new System.Drawing.Size(35, 13);
            this.PalLabel.TabIndex = 1;
            this.PalLabel.Text = "label1";
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 324);
            this.Controls.Add(this.PalLabel);
            this.Controls.Add(this.EvenLabel);
            this.Name = "Calc";
            this.Text = "Calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EvenLabel;
        private System.Windows.Forms.Label PalLabel;
    }
}