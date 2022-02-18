using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySchedule
{
    public partial class EventForm : Form
    {
        string connString = "server=localhost;uid=root;database=db_schedule;sslmode=none;Pwd=1234";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txdate.Text = Form1.static_month + "/" + UserControlDays.static_day + "/" + Form1.static_year;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            string sql = $"INSERT INTO schedule(date , event) values( {txdate.Text}, {txevent.Text} )";
            conn.Open();

            var cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

        }
    }
}
