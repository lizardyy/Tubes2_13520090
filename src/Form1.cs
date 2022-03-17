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
            
                // menghapus data sebelumnya
            testing.Items.Clear();
            BFS.pengecekan.Clear();
            BFS.antrian.Clear();
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
                label5.Text = dialog.SelectedPath;
                files = Directory.GetFiles(dialog.SelectedPath);
                dirs = Directory.GetDirectories(dialog.SelectedPath);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var watch = new System.Diagnostics.Stopwatch();
            folder = label5.Text;
            fileSearch = textBox2.Text; // file yang akan dicari

            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            if (fileSearch != null && folder != "No File Choosen..")
            {
                panel4.Visible = false;
                testing.Items.Clear();
                // BFS without All Occurence checked
                if (radioButton1.Checked && !checkBox1.Checked) {
                    watch.Start();
                    List<string> result = BFS.Process(folder, fileSearch, false);
                    watch.Stop();

                    foreach (string cek in BFS.pengecekan) {
                        testing.Items.Add(cek);
                    }

                    if (result.Count == 0) {
                        linkLabel1.Text = "Tidak ditemukan file dengan nama " + fileSearch;
                    }
                    else {
                        // Kalau 1 masih benar
                        foreach (string res in result) {
                            linkLabel1.Text = res;
                        }
                    }
                    label8.Text = $"{watch.ElapsedMilliseconds} ms";
                    panel4.Visible = true;


                    bool colorize = true;

                    string[] splitPath = folder.Split("\\");
                    graph.AddNode(splitPath[splitPath.Length - 1]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                    foreach (string file in testing.Items) {
                        splitPath = file.Split('\\');
                        string parent, child;

                        int len = splitPath.Length;
                        string ujung = splitPath[len - 1];
                        splitPath = splitPath[..^1];

                        int i = 0;

                        parent = string.Join("\\", splitPath);
                        child = ujung;

                        var parentNode = graph.FindNode(parent);
                        while (parentNode == null && parent != "") {
                            i++;
                            parent = string.Join("\\", splitPath.Skip(i));
                            parentNode = graph.FindNode(parent);
                        }

                        if (graph.FindNode(child) != null) {
                            child = parent + "\\" + child;
                        }

                        graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        if (colorize) {
                            graph.AddEdge(parent, child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graph.FindNode(child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        }
                        else {
                            graph.AddEdge(parent, child).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        }

                        if (ujung == fileSearch) {
                            colorize = false;
                        }
                        this.gViewer1.Graph = graph; //untuk menampilkan graph
                        wait(200);
                    }
                }

                // BFS with All Occurence checked
                if (radioButton1.Checked && checkBox1.Checked) {
                    watch.Start();
                    List<string> result = BFS.Process(folder, fileSearch, true);
                    watch.Stop();

                    foreach (string cek in BFS.pengecekan) {
                        testing.Items.Add(cek);
                    }

                    if (result.Count == 0) {
                        linkLabel1.Text = "Tidak ditemukan file dengan nama " + fileSearch;
                    }
                    else {
                        // Kalau multivalue masih belum bisa, cuma hasil terakhir yang keluar
                        foreach (string res in result) {
                            linkLabel1.Text = res;
                        }
                    }
                    label8.Text = $"{watch.ElapsedMilliseconds} ms";
                    panel4.Visible = true;

                    string[] splitPath = folder.Split("\\");
                    string root = splitPath[splitPath.Length - 1];
                    graph.AddNode(root).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                    foreach (string file in testing.Items)
                    {
                        splitPath = file.Split('\\');
                        string parent, child;

                        int len = splitPath.Length;
                        string ujung = splitPath[len - 1];
                        splitPath = splitPath[..^1];

                        int i = 0;

                        parent = string.Join("\\", splitPath);
                        child = ujung;

                        var parentNode = graph.FindNode(parent);
                        while (parentNode == null && parent != "")
                        {
                            i++;
                            parent = string.Join("\\", splitPath.Skip(i));
                            parentNode = graph.FindNode(parent);
                        }

                        if (graph.FindNode(child) != null)
                        {
                            child = parent + "\\" + child;
                        }

                        graph.FindNode(parent).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        graph.AddEdge(parent, child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        graph.FindNode(child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                        this.gViewer1.Graph = graph; //untuk menampilkan graph
                        wait(200);
                    }

                    // Ini untuk mewarnai route file yang ditemukan, tapi belum jadi
                    //foreach (string res in result) {
                    //    string[] splitRes = res.Split("\\");
                    //    int len = splitRes.Length, i = 1;
                    //    string parent = "";
                    //    string child = splitRes[len - i];

                    //    var childNode = graph.FindNode(child);
                    //    while (parent != root) {
                    //        childNode.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    //        parent = splitRes[len - ++i];

                    //        var edgeFound = graph.Find
                    //    }
                    //}
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
            test++;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", linkLabel1.Text);
            ProcessStartInfo psi = new ProcessStartInfo("Explorer.exe");
            psi.Arguments = " /select," + linkLabel1.Text;//Set arguments
            Process.Start(psi);
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
    }
}