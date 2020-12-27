using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngularGUI
{
    public partial class Form1 : Form
    {
        string path=null, folderName=null, drive=null;
        string[] collection;
        public Form1()
        {
            InitializeComponent();
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFolderDialog.ShowDialog();
            if(dialog == DialogResult.OK || dialog == DialogResult.Yes)
            {
                path = openFolderDialog.SelectedPath;
                openedProjectTextBox.Text = path;
                collection = path.Split('\\');
                folderName = collection[collection.Length - 1];
                drive = collection[0];
                projectNameHead.Text = "Project Name:";
                projectNameLabel.Text = folderName;
                projectLocHead.Text = "Project Location:";
                projectLocationLabel.Text = path;
                projectDriveHead.Text = "Drive:";
                projectDriveLabel.Text = drive+" Drive";

            }
        }


        private void openedProjectTextBox_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFolderDialog.ShowDialog();
            if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
            {
                path = openFolderDialog.SelectedPath;
                openedProjectTextBox.Text = path;
            }
        }

        private void createComponentButton_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                if (this.isValid())
                {
                    var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k ng g c "+createNewTextBox.Text.ToLower()/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
                    proc.Start();
                    //remove this comment later
                    createNewTextBox.Text = null;
                }
                else
                {
                    errmessage.Text = "Please Check Entered Name Again";
                }
            }
            else
            {
                errmessage.Text = "Please Open Project Folder First";
            }
        }

        private void createServiceButton_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                if (this.isValid())
                {
                    var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k ng g s " + createNewTextBox.Text.ToLower()/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
                    proc.Start();
                    //remove this comment later
                    createNewTextBox.Text = null;
                }
                else
                {
                    errmessage.Text = "Please Check Entered Name Again";
                }
            }
        }

        private void createModuleButton_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                if (this.isValid())
                {
                    var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k ng g s " + createNewTextBox.Text/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
                    proc.Start();
                    //remove this comment later
                    createNewTextBox.Text = null;
                }
                else
                {
                    errmessage.Text = "Please Check Entered Name Again";
                }
            }
        }


        private bool isValid()
        {
            if (createNewTextBox.Text.Length != 0)
            {
                if (!createNewTextBox.Text.Contains(" "))
                {
                    errmessage.Text=null;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
