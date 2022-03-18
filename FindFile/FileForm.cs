using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace FindFile
{
    public partial class FileForm : Form
    {
        string lastAdded;
        List<FileSystemWatcher> watchers;
        public FileForm()
        {
            InitializeComponent();
            listBox1.HorizontalScrollbar = true;
            this.Resize += Form1_Resize;
            lastAdded = string.Empty;
            this.notifyIcon1.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            //this.notifyIcon1.ContextMenuStrip.Items.Add("Open", Image.FromFile("icon.ico"), Menu1_Click);
            this.notifyIcon1.ContextMenuStrip.Items.Add("Exit", null, Menu2_Click);
            this.notifyIcon1.Visible = false;

            watchers = new List<FileSystemWatcher>();
            new string[] { Environment.GetFolderPath(Environment.SpecialFolder.Programs), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) }.ToList().ForEach(x=> { FileSystemWatcher wc = new FileSystemWatcher(x); wc.EnableRaisingEvents = true; wc.Created += Watcher_Created; watchers.Add(wc);  });
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Dispose();
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            if(!e.Name.Contains("Temp") && !lastAdded.Contains(e.Name) && Directory.Exists(e.FullPath) && e.ChangeType == WatcherChangeTypes.Created)
            {
                MessageBox.Show("Was added new programm: "+ e.Name, "Programm alert");
            }
            lastAdded = e.Name;
        }

        void Menu1_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }
        
        void Menu2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            ShowWindow();
        }
        private void ShowWindow()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
            Thread.Sleep(100);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                Process.Start("explorer.exe", Path.GetDirectoryName((string)listBox1.SelectedItem));
            }
        }

        private void buttonWhat_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Directory.GetFiles(textBoxWhere.Text).ToList().ForEach(x=> 
            {
                FileInfo info = new FileInfo(x);
                if ((checkName.Checked && info.Name.Replace(info.Extension, "").Contains(textBoxWhat.Text)) || (checkExt.Checked && info.Extension.Contains(textBoxWhat.Text)) || (checkLast.Checked && info.LastWriteTime.ToString().Contains(textBoxWhat.Text)) || (checkCreate.Checked && info.CreationTime.ToString().Contains(textBoxWhat.Text)) || (checkOpen.Checked && info.LastAccessTime.ToString().Contains(textBoxWhat.Text)))
                {
                    listBox1.Items.Add(x);
                }
            }); ;
            GC.Collect();
        }

        private void buttonWhere_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxWhere.Text = fileDialog.SelectedPath;
            }
        }

        
    }
}
