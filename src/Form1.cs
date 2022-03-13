namespace src
{

    public partial class Form1 : Form
    {
        string[] files;
        string[] dirs;
        string fileSearch; // file yang dicari
        string folder;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                label5.Text = dialog.SelectedPath;

                testing.Items.Clear();
                files = Directory.GetFiles(dialog.SelectedPath);
                dirs = Directory.GetDirectories(dialog.SelectedPath);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            folder = label5.Text;
            fileSearch = textBox2.Text; // file yang akan dicari
            if (fileSearch != null && folder != "No File Choosen..")
            {
                if (radioButton1.Checked)
                {
                    string res = BFS.Process(folder, fileSearch);
                    if (res == "")
                    {
                        testing.Items.Add("Tidak ditemukan file dengan nama " + fileSearch);
                    }
                    else
                    {
                        testing.Items.Add("Ditemukan file pada " + res);
                    }

                    foreach (string cek in BFS.pengecekan)
                    {
                        testing.Items.Add(cek);
                    }

                    //Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                    ////create a graph object 
                    //Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                    ////create the graph content 

                    //// mengambil nama parent
                    //string parent = Path.GetFileName(label5.Text);

                    //// menambahkan edge parent ke child
                    //foreach (string file in testing.Items)
                    //{
                    //    graph.AddEdge(parent, file).Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                    //}

                    //this.gViewer1.Graph = graph; //untuk menampilkan graph
                }
                if (radioButton2.Checked)
                {
                    // implement DFS searh
                    MessageBox.Show("Choose DFS");
                    foreach (string file in files)
                    {
                        testing.Items.Add(Path.GetFileName(file));
                    }
                    foreach (string dir in dirs)
                    {
                        testing.Items.Add(Path.GetFileName(dir));
                    }
                }
            }
        }

    }
}