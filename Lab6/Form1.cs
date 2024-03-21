namespace Lab6
{
    public partial class Form1 : Form
    {
        public string path = "C:\\Users\\hp\\Desktop\\Lab6\\Lab6\\grocery_inventory_items.txt";
        public List<Item> list = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = ReadItem();
            UpdateListBox(list);

        }

        public List<Item> ReadItem()
        {
            StreamReader reader = new(
                new FileStream(path, FileMode.Open, FileAccess.Read));
            List<Item> list = new List<Item>();
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                string[] colums = line.Split("|");
                if (colums.Length == 3)
                {
                    Item item = new Item(int.Parse(colums[0]), colums[1], double.Parse(colums[2]));
                    list.Add(item);
                }
            }
            reader.Close();
            return list;
        }

        public void WriteItem()
        {
            StreamWriter writer = new(
                new FileStream(path, FileMode.Create, FileAccess.Write));
            foreach (Item item in list)
            {
                writer.WriteLine(item.ToString());
            }
            writer.Close();
        }

        public void UpdateListBox(List<Item> list)
        {
            listBox1.Items.Clear();
            foreach (Item item in list)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                list.RemoveAt(index);
                UpdateListBox(list);
                WriteItem();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
            WriteItem();
        }
    }
}
