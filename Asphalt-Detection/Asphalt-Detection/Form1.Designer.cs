
namespace Asphalt_Detection
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
            this.btnB = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.File = new System.Windows.Forms.OpenFileDialog();
            this.txtRes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnB
            // 
            this.btnB.BackColor = System.Drawing.Color.Lime;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnB.Location = new System.Drawing.Point(150, 371);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(124, 67);
            this.btnB.TabIndex = 0;
            this.btnB.Text = "Browse";
            this.btnB.UseVisualStyleBackColor = false;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Red;
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnR.Location = new System.Drawing.Point(495, 371);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(124, 67);
            this.btnR.TabIndex = 1;
            this.btnR.Text = "Recognize";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(37, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(701, 338);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // File
            // 
            this.File.FileName = "openFileDialog1";
            // 
            // txtRes
            // 
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRes.Location = new System.Drawing.Point(305, 391);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(162, 26);
            this.txtRes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.OpenFileDialog File;
        private System.Windows.Forms.TextBox txtRes;
    }
}

