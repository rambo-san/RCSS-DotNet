using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SimpleContactManager
{
    public partial class Form1 : Form
    {
        int id = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || comboBox1.SelectedItem == null)
                return;
            ListViewItem item = new ListViewItem(new string[] {
                id++.ToString(),
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Other",
                checkBox1.Checked ? "Yes" : "No",
                comboBox1.SelectedItem.ToString()
            });
            listView1.Items.Add(item);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ListViewItem item = listView1.GetItemAt(e.X, e.Y);
                if (item != null)
                {
                    listView1.ContextMenuStrip = contextMenuStrip1;
                    contextMenuStrip1.Show(listView1, e.Location);
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                textBox1.Text = selectedItem.SubItems[1].Text;
                textBox2.Text = selectedItem.SubItems[2].Text;
                textBox3.Text = selectedItem.SubItems[3].Text;
                radioButton1.Checked = selectedItem.SubItems[4].Text == "Male";
                radioButton2.Checked = selectedItem.SubItems[4].Text == "Female";
                checkBox1.Checked = selectedItem.SubItems[5].Text == "Yes";
                comboBox1.SelectedItem = selectedItem.SubItems[6].Text;
                listView1.Items.Remove(selectedItem); 
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                listView1.Items.Remove(selectedItem);
            }
        }

        private void filterFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool showFavoritesOnly = filterFavoritesToolStripMenuItem.Checked;

            // Create a list to hold items that need to be removed
            List<ListViewItem> itemsToRemove = new List<ListViewItem>();

            foreach (ListViewItem item in listView1.Items)
            {
                // Check if the item meets the filter criteria
                if (showFavoritesOnly && item.SubItems[5].Text != "Yes")
                {
                    itemsToRemove.Add(item);
                }
            }

            // Remove items that don't meet the criteria
            foreach (ListViewItem item in itemsToRemove)
            {
                listView1.Items.Remove(item);
            }

            // Optionally, you could restore the removed items if needed
            // or implement additional logic to handle item restoration.
        }

    }
}
