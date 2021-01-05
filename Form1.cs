using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AngularGUI
{
    public partial class Form1 : Form
    {
        //   GLOBAL VARIABLES   ///////////////////////////////////////////////////////////////////////////////////////
        string path = null, folderName = null, drive = null, processID, netStatOutput, portArgOn=null;
        string[] collection, collection2, collection3, collection4;
        bool status;
        int portNumber = 4200, futurePortNumber=-1;

        //   CONSTRUCTOR   /////////////////////////////////////////////////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            //   FUNCTIONS   //////////////
            isAlreadyServingConstructor();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //   PROJECT LOCATION OPENING METHODS   ///////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFolderDialog.ShowDialog();
            if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
            {
                path = openFolderDialog.SelectedPath;
                if (isAngularProject())
                {
                    openedProjectTextBox.Text = path;
                    pathSettingFunction();
                }
                else
                {
                    folderLocation.Text = "Selected Folder is not an \nAngular Project!";
                    path = null;
                }

            }
        }
        private void openedProjectTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                path = openedProjectTextBox.Text;
                if (isAngularProject())
                {
                    pathSettingFunction();
                }
                else
                {
                    folderLocation.Text = "Selected Folder is not an \nAngular Project!";
                    path = null;
                }
            }
        }
        private void openedProjectTextBox_Click(object sender, EventArgs e)
        {
            DialogResult dialog = openFolderDialog.ShowDialog();
            if (dialog == DialogResult.OK || dialog == DialogResult.Yes)
            {
                path = openFolderDialog.SelectedPath;
                if (isAngularProject())
                {
                    openedProjectTextBox.Text = path;
                    pathSettingFunction();
                }
                else
                {
                    folderLocation.Text = "Selected Folder is not an \nAngular Project!";
                    path = null;
                }
            }
        }
        //   PROJECT LOCATION INITIALIZING FUNCTION     ///////////////
        private void pathSettingFunction()
        {
            folderLocation.Text = null;
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

        //   FUNCTION TO CHECK IF OPENED LOCATION IS ANGULAR PROJECT OR NOT   ///////////////
        private bool isAngularProject()
        {
            if (File.Exists(@path + @"\angular.json"))
            {
                return true;
            }
            else
                return false;
        }


        //   CREATE COMPONENT   //////////
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

        //   CREATE SERVICE   /////////////
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

        //   CREATE MODULE  ///////////////////
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

        //   HOLD TOP PANEL AND MOVE DIALOG BOX AROUND   ///////
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        // MOVE DIALOG ENDS   ////////////////////////////////

        // DIALOG BOX FUNCTIONS // MINIMIZE MAXIMIZE CLOSE //////////////
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
            if (status == true)
            {
                stopProjectForce();
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
        // DIALOG BOX FUNCTIONS // MINIMIZE MAXIMIZE CLOSE //////////////

        //   STOP PROJECT ANYWAY   ///////////////////////////////////////
        private void stopProjectForce()
        {
            var proc2 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = @"/c netstat -ano | findstr :" + portNumber,
                    CreateNoWindow = true,
                }
            };
            proc2.Start();
            netStatOutput = proc2.StandardOutput.ReadLine();
            collection2 = Regex.Split(netStatOutput, @"\s+");
            processID = collection2[collection2.Length - 1];
            var stopAngular = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = @"/c taskkill /PID " + processID + " /F",
                    CreateNoWindow = true,
                }
            };
            stopAngular.Start();
        }
        //   CREATE NEW COMPONENT, MODULE, SERVICE NAME CHECKER   ////////
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
        //   PORT NUMBER SELECT FUNCTION ///////////////////////////////////////
        private void setPortNumber_Click(object sender, EventArgs e)
        {
            string temp = portNumberInput.Text;
            int pn;
            
            if (status == true)
            {
                if (portNumberInput.Text != null)
                {
                    if (int.TryParse(temp, out pn))
                    {
                        if (pn != portNumber)
                        {
                        errmessage.Text = null;
                        portNumberDisplay.Text = "Next: " + pn;
                        futurePortNumber = pn;
                        }
                    }
                    else
                        errmessage.Text = "Enter numbers only for port";
                }
                else
                {
                    errmessage.Text = null;
                    portNumberDisplay.Text = "Next: 4200";
                    futurePortNumber = 4200;
                }
            }
            else
            {
                if (portNumberInput.Text != null)
                {
                    if (int.TryParse(temp, out pn))
                    {
                        if (pn != portNumber)
                        {
                        errmessage.Text = null;
                        portNumberDisplay.Text = "Current: " + pn;
                        portNumber = pn;
                        portArgOn = @" --port " + portNumber;
                        }
                    }
                    else
                        errmessage.Text = "Enter numbers only for port";
                }
                else
                {
                    errmessage.Text = null;
                    portNumberDisplay.Text = "Current: 4200";
                    portNumber = 4200;
                    portArgOn = @" --port " + portNumber;
                }
            }
            
        }


        //      NG SERVE AND NG SERVING STOP BUTTON   /////////////////////
        private void ngServeButton_Click(object sender, EventArgs e)
        {
            string arg = "--o";
            if (path != null || status==true)
            {
                errmessage.Text = null;
                if (!status)
                {
                    if (isAlreadyServing())
                    {
                        status = true;
                        ngServeButton.Text = "Stop Project";
                        outPut.Text = "Project already running on other app";
                    }
                    else
                    {
                        outPut.Text = null;
                        ngServeButton.Enabled = false;
                        if (!browserOpen.Checked)
                        {
                            arg = null;
                        }
                        var proc1 = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "cmd.exe",
                                UseShellExecute = false, 
                                RedirectStandardOutput = true, 
                                RedirectStandardError = true, 
                                Arguments = @"/c ng s " + arg + portArgOn,
                                CreateNoWindow = true,
                                WorkingDirectory = @path
                            }
                        };
                        proc1.Start();
                        isServing();
                        ngServeButton.Text = "Stop Project";
                        ngServeButton.Enabled = true;
                        if (browserOpen.Checked)
                        {
                            outPut.Text = "Opening Browser...";
                        }
                        else
                        {
                            outPut.Text = "Project started at localhost:" + portNumber;
                        }
                        wait(2000);
                        outPut.Text = null;
                    }
                }
                else
                {
                    progressBar.Value = 0;
                    ngServeButton.Enabled = false;
                    var proc2 = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            Arguments = @"/c netstat -ano | findstr :" + portNumber,
                            CreateNoWindow = true,
                        }
                    };
                    proc2.Start();
                    netStatOutput = proc2.StandardOutput.ReadLine();
                    collection2 = Regex.Split(netStatOutput, @"\s+");
                    processID = collection2[collection2.Length - 1];
                    var stopAngular = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = "cmd.exe",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            Arguments = @"/c taskkill /PID " + processID + " /F",
                            CreateNoWindow = true,
                        }
                    };
                    stopAngular.Start();
                    status = false;
                    outPut.Text = stopAngular.StandardOutput.ReadLine();
                    ngServeButton.Text = "Serve Project";
                    ngServeButton.Enabled = true;
                    if (futurePortNumber!=-1)
                    {
                        portNumber = futurePortNumber;
                        portNumberDisplay.Text = "Current: " + portNumber;
                        portArgOn = @" --port " + portNumber;
                        futurePortNumber = -1;
                    }

                }
            }
            else
                errmessage.Text = "Please Open Project First";
        }
        //   NPM INSTALL BUTTON   ///////////////////////////////////////////////
        private void npminstallButton_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                errmessage.Text = null;
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = @"/k npm i",
                        WorkingDirectory = @path
                    }
                };
                proc.Start();
            }
            else
                errmessage.Text = "Please Open Project First";
        }
        //    NPM AUDIT FIX BUTTON   /////////////////////////////////////////////
        private void npmAuditFixButton_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                errmessage.Text = null;
                var proc = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = @"/k npm audit fix",
                        WorkingDirectory = @path
                    }
                };
                proc.Start();
            }
            else
                errmessage.Text = "Please Open Project First";
        }

        //   FUNCTIONS FOR CONSTRUCTORS HERE   //////////////////////////////////////////////////////////////////

        public void isAlreadyServingConstructor()
        {
            status = isAlreadyServing();
            if (status)
                ngServeButton.Text = "Stop Project";
            else
                ngServeButton.Text = "Serve Project";
        }

        //   BACKGROUND FUNCTIONS HERE   ////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        //   MAKES PROGRAM WAIT WITHOUT CONSUMING MEMORY OR PROCESSING RESOURCES   ///////////////////////
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
        //   TO CHECK IF NG SERVE IS DONE YET and also manages progress bar   /////////////////////////////
        private void isServing()
        {
            string output = null;
            int flag = 1;
            progressBar.Value = 0;
            do
            {
                if (progressBar.Value != 90)
                    progressBar.Value += 10;
                wait(3000);
                var proc3 = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        Arguments = @"/c netstat -ano | findstr :" + portNumber,
                        CreateNoWindow = true
                    }
                };
                proc3.Start();
                output = proc3.StandardOutput.ReadLine();
                if (output != null)
                {
                    collection3 = Regex.Split(output, @"\s+");
                    if (collection3[4] == "LISTENING")
                    {
                        flag = 0;
                        status = true;
                        progressBar.Value = 100;
                    }

                }
            } while (flag == 1);
            if (flag == 0)
                Console.WriteLine("Served");
        }
        private bool isAlreadyServing()
        {
            string output = null;
            var proc3 = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = @"/c netstat -ano | findstr :" + portNumber,
                    CreateNoWindow = true
                }
            };
            proc3.Start();
            output = proc3.StandardOutput.ReadLine();
            if (output != null)
            {
                collection4 = Regex.Split(output, @"\s+");
                if (collection4[4] == "LISTENING")
                {
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
    }
}
