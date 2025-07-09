using System.Data;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DataTable todolist = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Columns

            todolist.Columns.Add("Title");
            todolist.Columns.Add("Description");

            //
            toDoListView.DataSource = todolist;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            titleTextbox.Text = "";
            descripitionTextbox.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                todolist.Rows[toDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isEditing = false;
            titleTextbox.Text = todolist.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descripitionTextbox.Text = todolist.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todolist.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = titleTextbox.Text;
                todolist.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = descripitionTextbox.Text;

            }
            else
            {
                todolist.Rows.Add(titleTextbox.Text,descripitionTextbox.Text);
            }

            titleTextbox.Text = "";
            descripitionTextbox.Text = "";
            isEditing = false;
        }
    }
}
