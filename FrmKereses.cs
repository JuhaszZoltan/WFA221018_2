using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA221018_2
{
    public partial class FrmKereses : Form
    {
        public FrmKereses()
        {
            InitializeComponent();
        }

        private void FrmKereses_Load(object sender, EventArgs e)
            => Kereses(string.Empty);
        private void TbNevKeres_TextChanged(object sender, EventArgs e)
            => Kereses(tbNevKeres.Text);

        private void Kereses(string nevEleje)
        {
            dgvKereses.Rows.Clear();
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new(
                cmdText: "SELECT * FROM szemely " +
                $"WHERE nev LIKE '{tbNevKeres.Text}%' " +
                $"ORDER BY nev ASC;",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
                dgvKereses.Rows.Add(sqlDataReader[0], sqlDataReader[1]);
        }

        private void DgvKereses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string szemelyId = dgvKereses[0, e.RowIndex].Value.ToString();
            _ = new FrmReszletek(szemelyId).ShowDialog();
        }
    }
}
