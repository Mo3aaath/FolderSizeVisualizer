using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FolderSizeVisualizer.ClassesF;

namespace FolderSizeVisualizer
{
    public partial class Form1 : Form
    {

        List<FolderSizeVisualizer.ClassesF.Folder> myFolders = new List<FolderSizeVisualizer.ClassesF.Folder>();

        public Form1()
        {
            InitializeComponent();
            TreeNode root = new TreeNode();
            treeView.Nodes.Add(root);
            Explore(SelectedPath, root);

        }

        private String SelectedPath = @"C:\Users\moaat\Desktop\TestF";

        private void browseBt_Click(object sender, EventArgs e)
        {
            treeView.Nodes.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            SelectedPath = fbd.SelectedPath;

            TreeNode root = new TreeNode();
            treeView.Nodes.Add(root);

            Explore(SelectedPath, root);
        }

        public void Explore(String path, TreeNode root)
        {
            root.Text = Path.GetFileName(path);
            FileInfo fi = new FileInfo(path);

            if (File.Exists(path)) {
                Leaf file = new Leaf(fi.Name, fi.Extension, fi.Length);
            }

            else if (Directory.Exists(path))
            { 
                Folder folder = new Folder(fi.Name);

                string[] files = Directory.GetFiles(path);
                string[] dirs = Directory.GetDirectories(path);

                foreach (string file in files) 
                { 
                    myFolders.Add(folder);
                    TreeNode node = new TreeNode();
                    Explore(file, node); 
                }

                foreach (string dir in dirs) 
                {
                    TreeNode node = new TreeNode(Path.GetFileName(dir));
                    root.Nodes.Add(node);
                    Explore(dir, node);
                }
                
            }
            
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine("clicked");
        }
    }
}
