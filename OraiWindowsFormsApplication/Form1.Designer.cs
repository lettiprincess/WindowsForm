namespace OraiWindowsFormsApplication
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
            this.buttonPlus = new System.Windows.Forms.Button();
            this.dbSzam = new System.Windows.Forms.NumericUpDown();
            this.ennyiSorLabel = new System.Windows.Forms.Label();
            this.getAllDataOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbSzam)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(291, 18);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(61, 25);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // dbSzam
            // 
            this.dbSzam.Location = new System.Drawing.Point(156, 18);
            this.dbSzam.Name = "dbSzam";
            this.dbSzam.Size = new System.Drawing.Size(120, 22);
            this.dbSzam.TabIndex = 5;
            // 
            // ennyiSorLabel
            // 
            this.ennyiSorLabel.Location = new System.Drawing.Point(9, 20);
            this.ennyiSorLabel.Name = "ennyiSorLabel";
            this.ennyiSorLabel.Size = new System.Drawing.Size(141, 20);
            this.ennyiSorLabel.TabIndex = 6;
            this.ennyiSorLabel.Text = "Ennyi sort szeretnék:";
            // 
            // getAllDataOut
            // 
            this.getAllDataOut.Location = new System.Drawing.Point(358, 20);
            this.getAllDataOut.Name = "getAllDataOut";
            this.getAllDataOut.Size = new System.Drawing.Size(75, 23);
            this.getAllDataOut.TabIndex = 7;
            this.getAllDataOut.Text = "Mind!";
            this.getAllDataOut.UseVisualStyleBackColor = true;
            this.getAllDataOut.Click += new System.EventHandler(this.getAllDataOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(457, 311);
            this.Controls.Add(this.getAllDataOut);
            this.Controls.Add(this.ennyiSorLabel);
            this.Controls.Add(this.dbSzam);
            this.Controls.Add(this.buttonPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dbSzam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.NumericUpDown dbSzam;
        private System.Windows.Forms.Label ennyiSorLabel;
        private System.Windows.Forms.Button getAllDataOut;
    }
}

