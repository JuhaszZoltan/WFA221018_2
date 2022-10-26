namespace WFA221018_2
{
    partial class FrmKereses
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
            this.dgvKereses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNevKeres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKereses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKereses
            // 
            this.dgvKereses.AllowUserToAddRows = false;
            this.dgvKereses.AllowUserToDeleteRows = false;
            this.dgvKereses.AllowUserToResizeColumns = false;
            this.dgvKereses.AllowUserToResizeRows = false;
            this.dgvKereses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKereses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKereses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKereses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvKereses.Location = new System.Drawing.Point(12, 107);
            this.dgvKereses.Name = "dgvKereses";
            this.dgvKereses.RowHeadersVisible = false;
            this.dgvKereses.RowHeadersWidth = 51;
            this.dgvKereses.RowTemplate.Height = 29;
            this.dgvKereses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKereses.Size = new System.Drawing.Size(458, 334);
            this.dgvKereses.TabIndex = 2;
            this.dgvKereses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKereses_CellClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 2F;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 8F;
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.tbNevKeres);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 79);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keresés díjazott neve alapján";
            // 
            // tbNevKeres
            // 
            this.tbNevKeres.Location = new System.Drawing.Point(6, 33);
            this.tbNevKeres.Name = "tbNevKeres";
            this.tbNevKeres.Size = new System.Drawing.Size(446, 34);
            this.tbNevKeres.TabIndex = 0;
            this.tbNevKeres.TextChanged += new System.EventHandler(this.TbNevKeres_TextChanged);
            // 
            // FrmKereses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKereses);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKereses";
            this.Text = "Keresés";
            this.Load += new System.EventHandler(this.FrmKereses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKereses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvKereses;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox2;
        private TextBox tbNevKeres;
    }
}