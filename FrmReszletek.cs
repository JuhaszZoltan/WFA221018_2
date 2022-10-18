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
    public partial class FrmReszletek : Form
    {
        public string SzemelyId { get; set; }
        public FrmReszletek(string szemelyId)
        {
            InitializeComponent();
            SzemelyId = szemelyId;
        }

        private void FrmReszletek_Load(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();

            //nev
            SqlCommand sqlCommand = new(
                cmdText: 
                $"SELECT nev " +
                $"FROM szemely " +
                $"WHERE id = {SzemelyId};",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            lblNev.Text = sqlDataReader.GetString(0);
            sqlDataReader.Close();
            sqlCommand = new(
                cmdText:
                $"SELECT megnevezes " +
                $"FROM foglalkozas " +
                $"WHERE szemelyId = {SzemelyId};",
                connection: sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
                rtbFoglalkozasok.Text += $"[*] {sqlDataReader[0]}\n";
            sqlDataReader.Close();

            sqlCommand = new(
                cmdText:
                $"SELECT ev " +
                $"FROM kituntetes " +
                $"WHERE szemelyId = {SzemelyId} " +
                $"ORDER BY ev ASC;",
                connection: sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            string evek = "";
            while (sqlDataReader.Read())
                evek += $"{sqlDataReader[0]}, ";

            lblEvek.Text = evek.Remove(evek.Length - 2, 2);
        }
    }
}
