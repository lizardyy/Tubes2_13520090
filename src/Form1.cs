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
                if (radioButton1.Checked && !checkBox1.Checked)
                {
                    watch.Start();
                    string res = BFS.Process(folder, fileSearch);
                    watch.Stop();
                    //if (res == "")
                    //{
                    //    testing.Items.Add("Tidak ditemukan file dengan nama " + fileSearch);
                    //}
                    //else
                    //{
                    //    testing.Items.Add("Ditemukan file pada " + res);
                    //}

                    foreach (string cek in BFS.pengecekan)
                    {
                        testing.Items.Add(cek);
                    }

                    linkLabel1.Text = res;
                    label8.Text = $"{watch.ElapsedMilliseconds} ms";
                    panel4.Visible = true;
                    
                    
                    bool colorize = true;

                    foreach (string file in testing.Items)
                    {
                        string[] splitFilename = file.Split('\\');
                        int len = splitFilename.Length;
                        int i = 1;
                        string child = splitFilename[len - i];
                        var childNode = graph.FindNode(child);
                        while (childNode != null)
                        {
                            child = splitFilename[len - ++i] + "\\" + child;
                            childNode = graph.FindNode(child);
                        }
                        if (colorize)
                        {
                            graph.AddEdge(splitFilename[len - 2], child).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        }
                        else
                        {
                            graph.AddEdge(splitFilename[len - 2], child).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                        }

                        if (splitFilename[len - 1] == fileSearch)
                        {
                            colorize = false;
                        }
                        this.gViewer1.Graph = graph; //untuk menampilkan graph
                        wait(500);
                    }
                    
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