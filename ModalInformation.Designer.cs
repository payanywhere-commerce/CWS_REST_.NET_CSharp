﻿namespace SampleCodeREST
{
    partial class ModalInformation
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
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtInfo
            // 
            this.TxtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtInfo.Location = new System.Drawing.Point(12, 12);
            this.TxtInfo.MaxLength = 0;
            this.TxtInfo.Multiline = true;
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtInfo.Size = new System.Drawing.Size(673, 435);
            this.TxtInfo.TabIndex = 0;
            this.TxtInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtInfo_KeyDown);
            // 
            // ModalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 459);
            this.Controls.Add(this.TxtInfo);
            this.Name = "ModalInformation";
            this.Text = "ModalInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInfo;
    }
}