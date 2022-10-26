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
    public partial class FrmUj : Form
    {
        public int SzemelyId { get; set; } = -1;

        public FrmUj()
        {
            InitializeComponent();
            nudDijEve.Minimum = 2017;
            nudDijEve.Maximum = DateTime.Now.Year;
            nudDijEve.Value = nudDijEve.Maximum;
        }

        private void FrmUj_Load(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new(
                cmdText: "SELECT MAX(id) FROM szemely;",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            sqlDataReader.Read();
            SzemelyId = sqlDataReader.GetInt32(0) + 1;
        }

        private void BtnUjSzemely_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();

            string errorMsg = string.Empty;

            if (string.IsNullOrWhiteSpace(tbUjNev.Text))
                errorMsg += "A Név mező nem maradhat üres\n";
            if (string.IsNullOrWhiteSpace(tbFoglalkozasok.Text))
                errorMsg += "A személy foglalkozásai nincsenek megadva\n";
            SqlCommand sqlCommand = new(
                cmdText: $"SELECT nev FROM szemely WHERE nev LIKE '{tbUjNev.Text}';",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
                errorMsg += "Ilyen nevű személy már szerepel az adatbázisban\n";
            sqlDataReader.Close();
            if (!tbFoglalkozasok.Text.Contains(','))
                errorMsg += "A foglalkozások felsorolásának nem megfelelő a formátuma\n";

            if (errorMsg != string.Empty)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: errorMsg,
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                SqlDataAdapter sqlDataAdapter = new()
                {
                    InsertCommand = new(
                        $"INSERT INTO szemely VALUES ({SzemelyId}, '{tbUjNev.Text}');",
                        sqlConnection)
                };
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
                
                string[] foglalkozasok = tbFoglalkozasok.Text.Split(',');

                string inserCmdStr = "INSERT INTO foglalkozas VALUES ";
                foreach (var f in foglalkozasok)
                    inserCmdStr += $"({SzemelyId}, '{f}'),";
                inserCmdStr = inserCmdStr.TrimEnd(',') + ";";
                sqlDataAdapter = new()
                {
                    InsertCommand = new(
                        cmdText: inserCmdStr,
                        connection: sqlConnection)
                };
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                _ = MessageBox.Show(
                    caption: "ADATBÁZIS FRISSÍTVE!",
                    text: $"{tbUjNev.Text} rögzítése sikeresen megtörtént!",
                    icon: MessageBoxIcon.Information,
                    buttons: MessageBoxButtons.OK);

                tbDijazottNeve.Text = tbUjNev.Text;
                tbUjNev.Text = string.Empty;
                tbFoglalkozasok.Text = string.Empty;

                SzemelyId = -1;
            }
        }

        private void BtnUjDij_Click(object sender, EventArgs e)
        {
            using SqlConnection sqlConnection = new(Program.ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new(
                cmdText: $"SELECT id FROM szemely WHERE nev LIKE '{tbDijazottNeve.Text}';",
                connection: sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool vanIlyenNev = sqlDataReader.Read();

            if (!vanIlyenNev)
            {
                _ = MessageBox.Show(
                    caption: "HIBA!",
                    text: "Nem található ilyen nevű személy az adatbázisban!",
                    icon: MessageBoxIcon.Error,
                    buttons: MessageBoxButtons.OK);
            }
            else
            {
                SzemelyId = sqlDataReader.GetInt32(0);
                sqlDataReader.Close();
                sqlCommand = new(
                    cmdText: $"SELECT MAX(id) FROM kituntetes;",
                    connection: sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();
                int kituntetesId = sqlDataReader.GetInt32(0) + 1;
                sqlDataReader.Close();
                SqlDataAdapter sqlDataAdapter = new()
                {
                    InsertCommand = new(
                        cmdText: "INSERT INTO kituntetes VALUES " +
                        $"({kituntetesId}, {SzemelyId}, {nudDijEve.Value});",
                        connection: sqlConnection)
                };
                sqlDataAdapter.InsertCommand.ExecuteNonQuery();

                _ = MessageBox.Show(
                        caption: "ADATBÁZIS FRISSÍTVE!",
                        text: $"{tbDijazottNeve.Text} számára a József Attila díj rögzítése megtörtént!",
                        icon: MessageBoxIcon.Information,
                        buttons: MessageBoxButtons.OK);
            }
        }
    }
}
