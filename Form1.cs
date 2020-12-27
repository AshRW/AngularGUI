﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngularGUI
{
    public partial class Form1 : Form
    {
        string path = null, folderName = null, drive = null;
        string[] collection;
        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFolderDialog.ShowDialog();
            if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
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
                projectDriveLabel.Text = drive + " Drive";

            }
        }


        private void openedProjectTextBox_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFolderDialog.ShowDialog();
            if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
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
                projectDriveLabel.Text = drive + " Drive";
            }
        }

        private void createComponentButton_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                if (this.isValid())
                {
                    if (isValidFlag())
                    {
                        var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/c ng g c " + createNewTextBox.Text.ToLower()+" "+createNewFlagTextBox.Text.ToLower()/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
                        proc.Start();
                        createNewTextBox.Text = null;
                        createNewFlagTextBox.Text = null;
                    }
                    else
                        errMsgFlag.Text = "Please Check Entered Option/Flag";
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
                    if (isValidFlag())
                    {
                        var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k ng g s " + createNewTextBox.Text.ToLower() + " " + createNewFlagTextBox.Text.ToLower()/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
                        proc.Start();
                        createNewTextBox.Text = null;
                        createNewFlagTextBox.Text = null;
                    }
                    else
                        errMsgFlag.Text = "Please Check Entered Option/Flag";
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
                    if (isValidFlag())
                    {
                        var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k ng g module " + createNewTextBox.Text + " " + createNewFlagTextBox.Text.ToLower()/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
                        proc.Start();
                        createNewTextBox.Text = null;
                        createNewFlagTextBox.Text = null;
                    }
                    else
                        errMsgFlag.Text = "Please Check Entered Option/Flag";
                }
                else
                {
                    errmessage.Text = "Please Check Entered Name Again";
                }
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private bool isValid()
        {
            if (createNewTextBox.Text.Length != 0)
            {
                if (!createNewTextBox.Text.Contains(" "))
                {
                    string temp = createNewTextBox.Text;
                    if (!Char.IsDigit(temp[0]))
                    {
                        errmessage.Text = null;
                        return true;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        private bool isValidFlag()
        {
            if (createNewFlagTextBox.Text.Length == 0)
            {
                errMsgFlag.Text = null;
                return true;
            }
            else
            {
                if (createNewFlagTextBox.Text[0] == '-' && createNewFlagTextBox.Text[1] == '-')
                {
                    errMsgFlag.Text = null;
                    return true;
                }
                else
                    return false;
            }
        }

        private void openedProjectTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                path = openedProjectTextBox.Text;
                //openedProjectTextBox.Text = path;
                collection = path.Split('\\');
                folderName = collection[collection.Length - 1];
                drive = collection[0];
                projectNameHead.Text = "Project Name:";
                projectNameLabel.Text = folderName;
                projectLocHead.Text = "Project Location:";
                projectLocationLabel.Text = path;
                projectDriveHead.Text = "Drive:";
                projectDriveLabel.Text = drive + " Drive";
            }
        }

        private void npminstallButton_Click(object sender, EventArgs e)
        {
            var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k npm i"/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
            proc.Start();
        }
        private void npmAuditFixButton_Click(object sender, EventArgs e)
        {
            var proc = new Process { StartInfo = new ProcessStartInfo { FileName = "cmd.exe"/*, UseShellExecute = false*/ /*, RedirectStandardOutput = true*/, Arguments = @"/k npm audit fix"/*, RedirectStandardError = true*/, CreateNoWindow = false, WorkingDirectory = @path } };
            proc.Start();
        }
    }
}