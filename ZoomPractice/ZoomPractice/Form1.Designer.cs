namespace ZoomPractice
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
            this.txtXPos = new System.Windows.Forms.TextBox();
            this.lblXPos = new System.Windows.Forms.Label();
            this.lblYPos = new System.Windows.Forms.Label();
            this.txtYPos = new System.Windows.Forms.TextBox();
            this.lblMagnification = new System.Windows.Forms.Label();
            this.txtMag = new System.Windows.Forms.TextBox();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtXPos
            // 
            this.txtXPos.Location = new System.Drawing.Point(40, 44);
            this.txtXPos.Name = "txtXPos";
            this.txtXPos.Size = new System.Drawing.Size(51, 20);
            this.txtXPos.TabIndex = 0;
            // 
            // lblXPos
            // 
            this.lblXPos.AutoSize = true;
            this.lblXPos.Location = new System.Drawing.Point(40, 25);
            this.lblXPos.Name = "lblXPos";
            this.lblXPos.Size = new System.Drawing.Size(54, 13);
            this.lblXPos.TabIndex = 1;
            this.lblXPos.Text = "X Position";
            // 
            // lblYPos
            // 
            this.lblYPos.AutoSize = true;
            this.lblYPos.Location = new System.Drawing.Point(40, 81);
            this.lblYPos.Name = "lblYPos";
            this.lblYPos.Size = new System.Drawing.Size(54, 13);
            this.lblYPos.TabIndex = 2;
            this.lblYPos.Text = "Y Position";
            // 
            // txtYPos
            // 
            this.txtYPos.Location = new System.Drawing.Point(40, 97);
            this.txtYPos.Name = "txtYPos";
            this.txtYPos.Size = new System.Drawing.Size(51, 20);
            this.txtYPos.TabIndex = 3;
            // 
            // lblMagnification
            // 
            this.lblMagnification.AutoSize = true;
            this.lblMagnification.Location = new System.Drawing.Point(37, 139);
            this.lblMagnification.Name = "lblMagnification";
            this.lblMagnification.Size = new System.Drawing.Size(81, 13);
            this.lblMagnification.TabIndex = 4;
            this.lblMagnification.Text = "Magnification %";
            // 
            // txtMag
            // 
            this.txtMag.Location = new System.Drawing.Point(40, 155);
            this.txtMag.Name = "txtMag";
            this.txtMag.Size = new System.Drawing.Size(51, 20);
            this.txtMag.TabIndex = 5;
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(40, 201);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(78, 48);
            this.btnZoom.TabIndex = 6;
            this.btnZoom.Text = "Open Magnification Window";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Location = new System.Drawing.Point(154, 44);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(75, 23);
            this.btnZoomIn.TabIndex = 7;
            this.btnZoomIn.Text = "Zoom In";
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Location = new System.Drawing.Point(154, 81);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(75, 23);
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.Text = "Zoom Out";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.txtMag);
            this.Controls.Add(this.lblMagnification);
            this.Controls.Add(this.txtYPos);
            this.Controls.Add(this.lblYPos);
            this.Controls.Add(this.lblXPos);
            this.Controls.Add(this.txtXPos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtXPos;
        private System.Windows.Forms.Label lblXPos;
        private System.Windows.Forms.Label lblYPos;
        private System.Windows.Forms.TextBox txtYPos;
        private System.Windows.Forms.Label lblMagnification;
        private System.Windows.Forms.TextBox txtMag;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
    }
}

