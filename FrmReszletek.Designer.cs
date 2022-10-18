namespace WFA221018_2
{
    partial class FrmReszletek
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
            this.lblNev = new System.Windows.Forms.Label();
            this.rtbFoglalkozasok = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEvek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNev.Location = new System.Drawing.Point(13, 9);
            this.lblNev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(464, 74);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "###NEV###";
            this.lblNev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbFoglalkozasok
            // 
            this.rtbFoglalkozasok.BackColor = System.Drawing.Color.IndianRed;
            this.rtbFoglalkozasok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFoglalkozasok.Location = new System.Drawing.Point(13, 137);
            this.rtbFoglalkozasok.Margin = new System.Windows.Forms.Padding(4);
            this.rtbFoglalkozasok.Name = "rtbFoglalkozasok";
            this.rtbFoglalkozasok.Size = new System.Drawing.Size(464, 248);
            this.rtbFoglalkozasok.TabIndex = 1;
            this.rtbFoglalkozasok.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fő foglalkozásai:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "A díjakat elnyerte:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEvek
            // 
            this.lblEvek.BackColor = System.Drawing.Color.LightCoral;
            this.lblEvek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEvek.Location = new System.Drawing.Point(215, 402);
            this.lblEvek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvek.Name = "lblEvek";
            this.lblEvek.Size = new System.Drawing.Size(262, 40);
            this.lblEvek.TabIndex = 0;
            this.lblEvek.Text = "##evek##";
            this.lblEvek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmReszletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(490, 476);
            this.Controls.Add(this.rtbFoglalkozasok);
            this.Controls.Add(this.lblEvek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNev);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReszletek";
            this.Text = "Részletek";
            this.Load += new System.EventHandler(this.FrmReszletek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblNev;
        private RichTextBox rtbFoglalkozasok;
        private Label label1;
        private Label label2;
        private Label lblEvek;
    }
}