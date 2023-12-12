namespace KojiTheLabDestroyer
{
    partial class Form2
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
            this.SignOut = new System.Windows.Forms.Button();
            this.darkside = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignOut
            // 
            this.SignOut.Location = new System.Drawing.Point(713, 25);
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(75, 23);
            this.SignOut.TabIndex = 0;
            this.SignOut.Text = "SignOut";
            this.SignOut.UseVisualStyleBackColor = true;
            this.SignOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // darkside
            // 
            this.darkside.Location = new System.Drawing.Point(12, 4);
            this.darkside.Name = "darkside";
            this.darkside.Size = new System.Drawing.Size(75, 23);
            this.darkside.TabIndex = 2;
            this.darkside.Text = "Edit profile";
            this.darkside.UseVisualStyleBackColor = true;
            this.darkside.Click += new System.EventHandler(this.darkside_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.darkside);
            this.Controls.Add(this.SignOut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignOut;
        private System.Windows.Forms.Button darkside;
        private System.Windows.Forms.Label label1;
    }
}