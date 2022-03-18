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

        int test = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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


        private void button2_Click(object sender, EventArgs e)
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
                BFS.warnaPath.Clear();

                List<string> result = new List<string>();
                Dictionary<string, string> pathColor = new Dictionary<string, string>();
                string[] splitPath;
                bool colorize = true;

                // Mengambil root node (folder pencarian)
                splitPath = folder.Split("\\");
                string root = splitPath[splitPath.Length - 1];
                string file, warna, parent, child, ujung;

                // BFS
                if (radioButtonBfs.Checked) {
                    watch.Start();
                    result = BFS.Solve(folder, fileSearch, checkBoxFindAll.Checked);
                    watch.Stop();
                    pathColor = BFS.warnaPath;
                }

                // DFS
                if (radioButtonDfs.Checked)
                {
                    // implement DFS searh
                    //MessageBox.Show("Choose DFS");
                    //foreach (string file in files)
                    //{
                    //    testing.Items.Add(Path.GetFileName(file));
                    //}
                    //foreach (string dir in dirs)
                    //{
                    //    testing.Items.Add(Path.GetFileName(dir));
                    //}
                }

                // Tampilan ditemukan atau tidak
                if (result.Count == 0){
                    //linkLabel1.Text = "Tidak ditemukan file dengan nama " + fileSearch;
                    testing.Items.Add("Tidak ditemukan file dengan nama " + fileSearch);
                }
                else {
                    foreach (string res in result) {
                        testing.Items.Add(res);
                        //linkLabel1.Text = res;  // Implementasi yang ini masih menunggu link label yang bisa dinamis
                        listLinkPath.Items.Add(res);
                    }
                }
                labelRuntime.Text = $"{watch.ElapsedMilliseconds} ms";
                panelOutput.Visible = true;

                // Algoritma untuk membuat graph dari pathWarna

                if (result.Count == 0)
                    graph.AddNode(root).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                else
                    graph.AddNode(root).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;

                foreach (KeyValuePair<string, string> pair in pathColor)
                {
                    file = pair.Key;
                    warna = pair.Value;

                    splitPath = file.Split('\\');
                    ujung = splitPath[splitPath.Length - 1];
                    splitPath = splitPath[..^1];

                    parent = string.Join("\\", splitPath);
                    child = ujung;

                    int i = 0;
                    var parentNode = graph.FindNode(parent);
                    while (parentNode == null && parent != "") {
                        parent = string.Join("\\", splitPath.Skip(++i));
                        parentNode = graph.FindNode(parent);
                    }

                    if (graph.FindNode(child) != null) {
                        child = parent + "\\" + child;
                    }

                    // Pemberian warna pada node dan edge pada graph
                    if (warna == "Red") {
                        if (!checkBoxFindAll.Checked && !colorize) {
                            graph.AddEdge(parent, child).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                            graph.FindNode(child).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        } else {
                            graph.AddEdge(parent, child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        }
                    }
                    else {
                        graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.AddEdge(parent, child).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.FindNode(child).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    }

                    // Mengubah flag/tanda warna ketika tidak melakukan pencarian menyeluruh dan telah ditemukan file yang dicari
                    if (ujung.Equals(fileSearch) && !checkBoxFindAll.Checked)
                        colorize = false;

                    this.gViewer1.Graph = graph;
                    wait(200);
                }
            }
            test++;
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