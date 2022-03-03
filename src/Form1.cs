namespace src
{

    public partial class Form1 : Form
    {
        string[] files;
        string[] dirs;
        string fileSearch; // file yang dicari
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;

                listBox1.Items.Clear();
                files = Directory.GetFiles(dialog.SelectedPath);
                dirs = Directory.GetDirectories(dialog.SelectedPath);
            }
        }


        private void gViewer1_Load(object sender, EventArgs e)
        {
            

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileSearch = textBox2.Text; // file yang akan dicari

            if (radioButton1.Checked)
            {
                // implement BFS search
                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }

                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                //create a graph object 
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                //create the graph content 
                
                // mengambil nama parent
                string parent = Path.GetFileName(textBox1.Text);

                // menambahkan edge parent ke child
                foreach (string file in listBox1.Items)
                {
                    graph.AddEdge(parent, file).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                }

                this.gViewer1.Graph = graph; //untuk menampilkan graph
            }
            if (radioButton2.Checked)
            {
                // implement DFS searh
                MessageBox.Show("Choose DFS");
                foreach (string file in files)
                {
                    listBox1.Items.Add(Path.GetFileName(file));
                }
                foreach (string dir in dirs)
                {
                    listBox1.Items.Add(Path.GetFileName(dir));
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}