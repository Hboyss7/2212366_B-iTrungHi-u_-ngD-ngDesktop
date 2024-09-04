namespace Bai4
{
    partial class FormBai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHH1 = new System.Windows.Forms.Label();
            this.lblHH2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Hàng hóa";
            // 
            // lblHH1
            // 
            this.lblHH1.AutoSize = true;
            this.lblHH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHH1.Location = new System.Drawing.Point(61, 116);
            this.lblHH1.Name = "lblHH1";
            this.lblHH1.Size = new System.Drawing.Size(19, 29);
            this.lblHH1.TabIndex = 1;
            this.lblHH1.Text = ".";
            // 
            // lblHH2
            // 
            this.lblHH2.AutoSize = true;
            this.lblHH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHH2.Location = new System.Drawing.Point(64, 205);
            this.lblHH2.Name = "lblHH2";
            this.lblHH2.Size = new System.Drawing.Size(19, 29);
            this.lblHH2.TabIndex = 2;
            this.lblHH2.Text = ".";
            // 
            // FormBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHH2);
            this.Controls.Add(this.lblHH1);
            this.Controls.Add(this.label1);
            this.Name = "FormBai1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHH1;
        private System.Windows.Forms.Label lblHH2;
    }
}