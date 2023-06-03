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
using System.IO;
using System.Windows;
using Point = System.Windows.Point;

namespace TestUI
{
    public partial class Chat : Form
    {
        SqlConnection sqlConnection;

        string strOp;
        string opValue;
        string op;
        public static List<string> listOp = new List<string>();

        Dictionary<string, string> opDict = new Dictionary<string, string>();

        Panel windows;
        public Chat()
        {
            InitializeComponent();
            this.Height = 859;
            this.Width =  534;
            windows = new Panel() { Parent = this, BackColor = Color.LightGray, AutoSize = true };
            windows.Dock = DockStyle.Fill;  
            windows.BringToFront();
            msgLimitLb.Text = "0 из 255 символов";
            windows.AutoScroll= true;
            
        }
        public class TextAnalys
        {
            private readonly MLService _mlService;

            public TextAnalys()
            {
                _mlService = new MLService();
                List<string> listOp = new List<string>();
            }

            public async Task SomeMethodAsync(string msg, Control parentControl)
            {
                string strOp = msg;
               
                string prediction = await _mlService.RunPredictionAsync(strOp);
                if (prediction.Contains("определение"))
                {
                    prediction = prediction.Replace("определение", string.Empty).TrimEnd();
                    listOp.Add(prediction);
                }
                else
                {
                    listOp.Add(prediction);
                }
            }
        }
        int pos = 0;
        public void Search() 
        {   
            if (listOp.Count > 0)
            {

                op = listOp.First();

                if (opDict.TryGetValue(op, out opValue) == true)
                {
                    Label lb = new Label() { Parent = windows, Location = new System.Drawing.Point(windows.Location.X, pos), ForeColor = Color.Black, BackColor = Color.Green, Text = "Чат-бот" };
                    lb.Font = new Font(lb.Font.FontFamily, 10);
                    lb.Size = new System.Drawing.Size((int)(windows.Width * 0.98), 25);
                    pos = lb.Bottom;

                    TextBox tb = new TextBox() { Parent = windows, Location = new System.Drawing.Point(windows.Location.X, pos), BackColor = Color.LightBlue, ForeColor = Color.Black, Text = opValue, ReadOnly = true, Multiline = true };
                    tb.Size = new System.Drawing.Size((int)(windows.Width * 0.98), (opValue.Length) - (opValue.Length / 2));
                    tb.Font = new Font(tb.Font.FontFamily, 12);

                    pos = tb.Bottom;

                    Label time = new Label() { Parent = tb, Text = (DateTime.Now).ToString("t"), Dock = DockStyle.Right, Size = new System.Drawing.Size(60, tb.Height) };
                    time.Font = new Font(lb.Font.FontFamily, 10);

                    pos = pos + 20;

                }
                else
                {
                    Label lb = new Label() { Parent = windows, Location = new System.Drawing.Point(windows.Location.X, pos), ForeColor = Color.Black, BackColor = Color.Green, Text = "Чат-бот" };
                    lb.Font = new Font(lb.Font.FontFamily, 10);
                    lb.Size = new System.Drawing.Size((int)(windows.Width * 0.98), 25);
                    pos = lb.Bottom;

                    TextBox tb = new TextBox() { Parent = windows, Location = new System.Drawing.Point(windows.Location.X, pos), BackColor = Color.LightBlue, ForeColor = Color.Black, Text = "Термин отсуствует! ", ReadOnly = true, Multiline = true };
                    tb.Size = new System.Drawing.Size((int)(windows.Width * 0.98), (msgBox.Text.Length) + 30);
                    tb.Font = new Font(tb.Font.FontFamily, 12);

                    pos = tb.Bottom;

                    Label time = new Label() { Parent = tb, Text = (DateTime.Now).ToString("t"), Dock = DockStyle.Right, Size = new System.Drawing.Size(60, tb.Height) };
                    time.Font = new Font(lb.Font.FontFamily, 10);

                    pos = pos + 20;

                }
                listOp.Clear();
            }
        }
        public void sendMsg() 
        {
            Search();
        }
        private async void senMsgButton_Click(object sender, EventArgs e)
        {
            if(msgBox.Text.Length >0)
            { 
            if (msgBox.Text.Length < 255)
            { 
                Label lb = new Label() { Parent = windows, Location = new System.Drawing.Point(windows.Location.X, pos), ForeColor = Color.Black, BackColor = Color.Green, Text = userInfo.UserName };
                lb.Font = new Font(lb.Font.FontFamily, 10);
                lb.Size = new System.Drawing.Size((int)(windows.Width * 0.98), 25);
                pos = lb.Bottom;

                TextBox tb = new TextBox() { Parent = windows, Location = new System.Drawing.Point(windows.Location.X, pos), BackColor = Color.LightBlue, ForeColor = Color.Black, Text = msgBox.Text, ReadOnly = true, Multiline = true };
                tb.Size = new System.Drawing.Size((int)(windows.Width * 0.98), (msgBox.Text.Length) + 30);
                tb.Font = new Font(tb.Font.FontFamily, 12);

                pos = tb.Bottom;

                Label time = new Label() { Parent = tb, Text = (DateTime.Now).ToString("t"), Dock = DockStyle.Right, Size = new System.Drawing.Size(60, tb.Height) };
                time.Font = new Font(lb.Font.FontFamily, 10);

                pos = pos + 20;
                TextAnalys textAnalys = new TextAnalys();
                string msg = msgBox.Text.Trim();
                await textAnalys.SomeMethodAsync(msg,windows);
                sendMsg();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Запрос превышает лимит в 255 символов!");
            }
            }
            else System.Windows.Forms.MessageBox.Show("Пустая строка!");
        }
        
        private async void Chat_Load(object sender, EventArgs e)
        {
            string connectionSource = Database.ConnectionString;
            sqlConnection = new SqlConnection(connectionSource);
            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [opDict]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    var key = sqlReader[0].ToString();
                    var value = sqlReader[1].ToString();
                    opDict[key] = value;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }  
        }
        
        private void msgBox_TextChanged(object sender, EventArgs e)
        {
            msgLimitLb.Text = msgBox.Text.Length + " из 255 символов";
        }
    }
    }

 
