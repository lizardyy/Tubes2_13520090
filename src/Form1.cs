using Microsoft.Msagl.Drawing;
using System.Collections;
using System.Diagnostics;
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

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            
            if(dirs!=null)
            {
                Array.Clear(dirs, 0, dirs.Length);
            }
            if (files!=null)
            {
                Array.Clear(files, 0, files.Length);
            }
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                labelFolderPath.Text = dialog.SelectedPath;
                files = Directory.GetFiles(dialog.SelectedPath);
                dirs = Directory.GetDirectories(dialog.SelectedPath);
            }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            folder = labelFolderPath.Text;
            fileSearch = textBoxInputFileName.Text; // file yang akan dicari

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            if (fileSearch != null && folder != "No File Choosen..")
            {
                // Membersihkan data sebelumnya
                panelOutput.Visible = false;
                testing.Items.Clear();
                listLinkPath.Items.Clear();
                BFS.pengecekan.Clear();
                BFS.antrian.Clear();

                List<string> result = new List<string>();
                List<string> pengecekan = new List<string>();
                string[] splitPath;
                // flag untuk pewarnaan graf
                bool colorize = true;

                // Mengambil root node (folder pencarian)
                splitPath = folder.Split("\\");
                string root = splitPath[splitPath.Length - 1];
                string parentNow, filename;

                // BFS
                if (radioButtonBfs.Checked) {
                    watch.Start();
                    result = BFS.Solve(folder, fileSearch, checkBoxFindAll.Checked);
                    watch.Stop();
                    pengecekan = BFS.pengecekan;
                }

                // DFS
                if (radioButtonDfs.Checked)
                {
                    watch.Start();
                    DFS pp = new DFS();
                    pp.DFSearch(folder, fileSearch, pengecekan, result, checkBoxFindAll.Checked);
                    watch.Stop();
                }

                // Tampilan ditemukan atau tidak
                if (result.Count == 0){
                    testing.Items.Add("Tidak ditemukan file dengan nama " + fileSearch);
                }
                else {
                    foreach (string res in result) {
                        testing.Items.Add(res);
                        listLinkPath.Items.Add(res);
                    }
                }
                labelRuntime.Text = $"{watch.ElapsedMilliseconds} ms";
                panelOutput.Visible = true;

                // Algoritma untuk membuat graph dari pengecekan
                // Menambahkan node root pada folder pencarian
                graph.AddNode(folder).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                graph.FindNode(folder).LabelText = root;

                // Iterasi pada urutan pengecekan
                foreach (string pathfile in pengecekan) {

                    splitPath = pathfile.Split("\\");
                    filename = splitPath[splitPath.Length - 1];
                    splitPath = splitPath[..^1];
                    parentNow = string.Join("\\", splitPath);

                    var parentNode = graph.FindNode(parentNow);
                    var childNode = parentNode;

                    // penambahan edge dan pewarnaannya
                    if (!colorize && !checkBoxFindAll.Checked) {
                        graph.AddEdge(parentNow, pathfile).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        childNode = graph.FindNode(pathfile);
                        childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                    } else {
                        graph.AddEdge(parentNow, pathfile).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        childNode = graph.FindNode(pathfile);
                        childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    }
                    childNode.LabelText = filename;

                    // Jika yang akan diwarnai adalah file yang akan dicari
                    if (filename == fileSearch) {
                        colorize = false;
                        // Melakukan pewarnaan rute dari root node
                        while (parentNow != folder) {
                            childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            parentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            foreach (Microsoft.Msagl.Drawing.Edge edge in childNode.InEdges) {
                                if (edge.SourceNode == parentNode)
                                    edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                            }
                            splitPath = splitPath[..^1];
                            parentNow = string.Join("\\", splitPath);
                            childNode = parentNode;
                            parentNode = graph.FindNode(parentNow);
                        }
                        childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        parentNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        foreach (Microsoft.Msagl.Drawing.Edge edge in childNode.InEdges) {
                            if (edge.SourceNode == parentNode)
                                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        }
                    }

                    // Menampilkan graph secara bertahap
                    this.gViewer1.Graph = graph;
                    wait(200);
                }
            }
        }


        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void listLinkPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = 0;
            ListBox lb = sender as ListBox;
            if (lb != null)
            {
                indeks = lb.SelectedIndex;
            }
            if (indeks < listLinkPath.Items.Count && indeks >= 0)
            {
                ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");
                psi.Arguments = " /select," + testing.Items[indeks];//Set arguments
                Process.Start(psi);
            }
        }

    }
}