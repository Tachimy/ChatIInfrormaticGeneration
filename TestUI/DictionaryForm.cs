using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace TestUI
{
    public partial class DictionaryForm : Form
    {
        public DictionaryForm()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection;
        string connectionSource = Database.ConnectionString;
        private async void DictionaryForm_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionSource);
            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [opDict]", sqlConnection);
            List<string[]> data = new List<string[]>();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[2]);

                    data[data.Count - 1][0] = sqlReader[0].ToString();
                    data[data.Count - 1][1] = sqlReader[1].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
            foreach (string[] s in data)
                dictDg.Rows.Add(s);
        }

            
    }
}
