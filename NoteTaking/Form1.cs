using System.Data;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("title", typeof(String));
            table.Columns.Add("Messages", typeof(String));
            dataGridView1.DataSource = table;

        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
        }

        private void bttRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                txtMessage.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                table.Rows[index].Delete();
            }
        }

        private void bttNewSave_Click(object sender, EventArgs e)
        {
            this.bttSave_Click(sender, e);
            txtTitle.Clear();
            txtMessage.Clear();
        }
    }
}