namespace WFA221018_2
{
    partial class FrmUj
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUjSzemely = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFoglalkozasok = new System.Windows.Forms.TextBox();
            this.tbUjNev = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudDijEve = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUjDij = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDijazottNeve = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDijEve)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbFoglalkozasok);
            this.groupBox1.Controls.Add(this.tbUjNev);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új személy felvétele";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.btnUjSzemely, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 226);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 65);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnUjSzemely
            // 
            this.btnUjSzemely.BackColor = System.Drawing.Color.LightGray;
            this.btnUjSzemely.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUjSzemely.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUjSzemely.Location = new System.Drawing.Point(110, 3);
            this.btnUjSzemely.Name = "btnUjSzemely";
            this.btnUjSzemely.Size = new System.Drawing.Size(424, 59);
            this.btnUjSzemely.TabIndex = 2;
            this.btnUjSzemely.Text = "Új személy";
            this.btnUjSzemely.UseVisualStyleBackColor = false;
            this.btnUjSzemely.Click += new System.EventHandler(this.BtnUjSzemely_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(171, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Foglalkozások:";
            // 
            // tbFoglalkozasok
            // 
            this.tbFoglalkozasok.Location = new System.Drawing.Point(232, 138);
            this.tbFoglalkozasok.Name = "tbFoglalkozasok";
            this.tbFoglalkozasok.Size = new System.Drawing.Size(338, 34);
            this.tbFoglalkozasok.TabIndex = 0;
            // 
            // tbUjNev
            // 
            this.tbUjNev.Location = new System.Drawing.Point(232, 67);
            this.tbUjNev.Name = "tbUjNev";
            this.tbUjNev.Size = new System.Drawing.Size(338, 34);
            this.tbUjNev.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.nudDijEve);
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDijazottNeve);
            this.groupBox2.Location = new System.Drawing.Point(12, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 214);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Új díj kiosztása";
            // 
            // nudDijEve
            // 
            this.nudDijEve.Location = new System.Drawing.Point(527, 69);
            this.nudDijEve.Margin = new System.Windows.Forms.Padding(4);
            this.nudDijEve.Name = "nudDijEve";
            this.nudDijEve.Size = new System.Drawing.Size(68, 34);
            this.nudDijEve.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.btnUjDij, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 131);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(646, 65);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnUjDij
            // 
            this.btnUjDij.BackColor = System.Drawing.Color.LightGray;
            this.btnUjDij.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUjDij.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUjDij.Location = new System.Drawing.Point(110, 3);
            this.btnUjDij.Name = "btnUjDij";
            this.btnUjDij.Size = new System.Drawing.Size(424, 59);
            this.btnUjDij.TabIndex = 2;
            this.btnUjDij.Text = "Új József Attila Díj";
            this.btnUjDij.UseVisualStyleBackColor = false;
            this.btnUjDij.Click += new System.EventHandler(this.BtnUjDij_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(481, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Év:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Név:";
            // 
            // tbDijazottNeve
            // 
            this.tbDijazottNeve.Location = new System.Drawing.Point(106, 69);
            this.tbDijazottNeve.Name = "tbDijazottNeve";
            this.tbDijazottNeve.Size = new System.Drawing.Size(338, 34);
            this.tbDijazottNeve.TabIndex = 0;
            // 
            // FrmUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUj";
            this.Text = "Új adatok felvétele";
            this.Load += new System.EventHandler(this.FrmUj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDijEve)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnUjSzemely;
        private Label label2;
        private Label label1;
        private TextBox tbFoglalkozasok;
        private TextBox tbUjNev;
        private GroupBox groupBox2;
        private NumericUpDown nudDijEve;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnUjDij;
        private Label label4;
        private Label label3;
        private TextBox tbDijazottNeve;
    }
}