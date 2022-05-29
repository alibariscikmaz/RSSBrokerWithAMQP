using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using RabbitMQ.Client;

namespace AMQPProducer
{
    public partial class frmProducerPanel : Form
    {
        public frmProducerPanel()
        {
            InitializeComponent();

            dataGridReset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRSSInput.Text != "" && cboxTopics.Text != "")
            {
                string connectionString;
                SqlConnection cnn;
                connectionString = @"workstation id=OOPProjectDBGp34.mssql.somee.com;packet size=4096;user id=alibaris22_SQLLogin_1;pwd=rc4p9p3rkw;data source=OOPProjectDBGp34.mssql.somee.com;persist security info=False;initial catalog=OOPProjectDBGp34";
                cnn = new SqlConnection(connectionString);

                SqlCommand cmd;

                string sql = "INSERT INTO RSSFeeds (RSSLink, RSSTopic) " +
                    "VALUES (@link, @topic)";

                // Open connection to insert data
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                // Turning data field texts into parameters for readability of queries and prevent SQL injection attacks.
                cmd.Parameters.Add("@link", SqlDbType.NVarChar, 500).Value = txtRSSInput.Text;
                cmd.Parameters.Add("@topic", SqlDbType.NVarChar, 500).Value = cboxTopics.Text;

                // Execute SQL Query to insert new user into DB
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                // Close connection after insertion
                cnn.Close();

                dataGridReset();
            }

            else
            {
                lbError.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection cnn;
            connectionString = @"workstation id=OOPProjectDBGp34.mssql.somee.com;packet size=4096;user id=alibaris22_SQLLogin_1;pwd=rc4p9p3rkw;data source=OOPProjectDBGp34.mssql.somee.com;persist security info=False;initial catalog=OOPProjectDBGp34";
            cnn = new SqlConnection(connectionString);

            SqlCommand cmd;

            string sql = "UPDATE RSSFeeds " +
                "SET isDeleted = 1 " +
                "WHERE RSSLink = @link";

            // Open connection to insert data
            cnn.Open();

            cmd = new SqlCommand(sql, cnn);
            // Turning data field texts into parameters for readability of queries and prevent SQL injection attacks.
            cmd.Parameters.Add("@link", SqlDbType.NVarChar, 500).Value = dgwRSSList.SelectedRows[0].Cells[0].Value.ToString();
            // Execute SQL Query to insert new user into DB
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            // Close connection after insertion
            cnn.Close();

            dataGridReset();
        }

        private void dataGridReset()
        {
            DataSet ds = new DataSet();
            DataTable dataTable = new DataTable();
            string connectionString;
            connectionString = @"workstation id=OOPProjectDBGp34.mssql.somee.com;packet size=4096;user id=alibaris22_SQLLogin_1;pwd=rc4p9p3rkw;data source=OOPProjectDBGp34.mssql.somee.com;persist security info=False;initial catalog=OOPProjectDBGp34";
            string sql = "SELECT RSSLink, RSSTopic " +
                "FROM RSSFeeds " +
                "WHERE isDeleted = 0;";
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(ds, "RSSFeeds");
            dataTable = ds.Tables["RSSFeeds"];
            cnn.Close();
            dgwRSSList.DataSource = ds.Tables["RSSFeeds"];
            dgwRSSList.ReadOnly = true;
            dgwRSSList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgwRSSList.Rows.Count - 1; i++)
            {
                var factory = new ConnectionFactory
                {
                    Uri = new Uri("amqp://guest:guest@localhost:5672")
                };
                using var cnn = factory.CreateConnection();
                using var ch = cnn.CreateModel();

                List<CPublishDirectExchange> messageList = new List<CPublishDirectExchange>();
                messageList = CPublishDirectExchange.RSSURLToMessages(dgwRSSList.Rows[i].Cells[0].Value.ToString());

                CPublishDirectExchange publisher = new CPublishDirectExchange();

                foreach (var message in messageList)
                {
                    publisher.PublishToExchange(ch, dgwRSSList.Rows[i].Cells[1].Value.ToString(), message);
                }
            }
        }
    }
}