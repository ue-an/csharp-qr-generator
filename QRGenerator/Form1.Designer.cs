namespace QRGenerator
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.pcbxQR = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(541, 320);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(122, 52);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(143, 337);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(361, 20);
            this.txtData.TabIndex = 1;
            // 
            // pcbxQR
            // 
            this.pcbxQR.Location = new System.Drawing.Point(85, 31);
            this.pcbxQR.Name = "pcbxQR";
            this.pcbxQR.Size = new System.Drawing.Size(419, 271);
            this.pcbxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxQR.TabIndex = 2;
            this.pcbxQR.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(85, 337);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 493);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pcbxQR);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.PictureBox pcbxQR;
        private System.Windows.Forms.Label lblData;
    }
}

