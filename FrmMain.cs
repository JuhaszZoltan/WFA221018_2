using Microsoft.Data.SqlClient;

namespace WFA221018_2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlComman = new(
                cmdText: 
                "SELECT szemely.id, ev, nev " +
                "FROM szemely " +
                "INNER JOIN kituntetes " +
                "ON szemely.id = szemelyId " +
                "ORDER BY ev DESC, nev ASC;",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlComman.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int szemelyId = sqlDataReader.GetInt32(0);
                int ev = sqlDataReader.GetInt32(1);
                string nev = sqlDataReader.GetString(2);
                int rowIndex = dgvMain.Rows.Add(szemelyId, ev, nev);
                if (ev % 2 == 0)
                {
                    dgvMain.Rows[rowIndex]
                        .DefaultCellStyle
                        .BackColor = Color.LightCoral;
                }
            }
        }

        private void DgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string szemelyId = dgvMain[0, e.RowIndex].Value.ToString();
            _ = new FrmReszletek(szemelyId)
                .ShowDialog();
        }
    }
}