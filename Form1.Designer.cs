
namespace PasswordGenerator
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.PasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPasswordBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Leelawadee", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(174, 45);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(535, 64);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "label1";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.Font = new System.Drawing.Font("Leelawadee", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLengthLabel.Location = new System.Drawing.Point(174, 187);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(535, 74);
            this.PasswordLengthLabel.TabIndex = 1;
            this.PasswordLengthLabel.Text = "Password Length: 5";
            this.PasswordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.Location = new System.Drawing.Point(228, 308);
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.Size = new System.Drawing.Size(435, 45);
            this.PasswordLengthSlider.TabIndex = 2;
            this.PasswordLengthSlider.Scroll += new System.EventHandler(this.PasswordLengthSlider_Scroll);
            // 
            // CopyPasswordBotton
            // 
            this.CopyPasswordBotton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CopyPasswordBotton.Font = new System.Drawing.Font("Leelawadee", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPasswordBotton.Location = new System.Drawing.Point(228, 392);
            this.CopyPasswordBotton.Name = "CopyPasswordBotton";
            this.CopyPasswordBotton.Size = new System.Drawing.Size(435, 57);
            this.CopyPasswordBotton.TabIndex = 3;
            this.CopyPasswordBotton.Text = "Copy Password";
            this.CopyPasswordBotton.UseVisualStyleBackColor = false;
            this.CopyPasswordBotton.Click += new System.EventHandler(this.CopyPasswordBotton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(932, 531);
            this.Controls.Add(this.CopyPasswordBotton);
            this.Controls.Add(this.PasswordLengthSlider);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PasswordLengthLabel;
        private System.Windows.Forms.TrackBar PasswordLengthSlider;
        private System.Windows.Forms.Button CopyPasswordBotton;
    }
}

