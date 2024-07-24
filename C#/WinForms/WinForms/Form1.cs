using System.Data;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            DataTable dt = new DataTable("MyTable");
            DataColumn c1 = new DataColumn("ID",typeof(int));
            DataColumn c2 = new DataColumn("Name",typeof(string));
            DataColumn c3 = new DataColumn("Age", typeof(int));
            dt.Columns.Add(c1);
            dt.Columns.Add(c2);
            dt.Columns.Add(c3);

            DataRow dr = dt.NewRow();
            dr["ID"] = 1;
            dr["Name"] = "Sunny";
            dr["Age"] = 23;

            dt.Rows.Add(dr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            Label Show_Text = new Label();
            Show_Text.Text = "Hello World!";
            Form1.ControlAccessibleObject.ReferenceEquals(this, Show_Text);
        }
    }
}
