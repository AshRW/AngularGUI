# Angular GUI
#### by Anurag RW

This **Windows Forms Application** is build using **C#** and **.NET Framework** in Visual Studio.\
This Application is a Graphical User Interface for the Angular CLI.

## Download Latest Released Version
Download the latest released verion here:
[Download Angular GUI](https://github.com/AshRW/AngularGUI/releases/download/0.1/AngularGUI.v0.1.exe)

## The Latest Release
This release of the Angular GUI Application can generate **Components, Modules, and Services** for your Angular Project. It can also **install node module packages** (npm install) and it can also **fix low and medium level vulnerabilities** of your Angular Project(npm audit fix).
Just open the project location by browsing the folder or simple copy and paste the project folder location into the input text box and hit enter. Then you may go on with using this application. You can also enter options/flags while creating Components, Modules, and Services.

## How it Works

The Application uses `System.Diagnostics` to communicate with the command line interface.\
It works by running `cmd.exe` as a `Process` on the desired directory and sends angular cli commands as process arguments when starting the process.
Also, running `ng.cmd` as a `Process` and then passing other function commands as arguments to the process is also taken into action in this project.

Here is an example of a function that executes the audit-fix command.
```c#
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
```

## Project Videos
**Watch Project Video (Full HD):**
[Project Video - YouTube Link](https://youtu.be/yd1dWbCStYw)

## Features
* Validated Inputs
* Linear Data Flow
* Bypasses the delay glitches of command line

## Background
I am Anurag, a bachelor of engineering - computer science graduate. I love to explore new software technologies, so I tried to get my hands wet in the C# .Net progamming. I built this project without any prior experience in C# or .Net Framework or the windows form application. Though the Angular CLI is not a big hassle for many, I still built a GUI for it because I wanted to learn how to get started with building UI enabled desktop applications.

## See more of my Projects
I have **more projects listed and hosted on this website**:\
**[My Projects - Anurag RW]**(https://hosted-project-list.web.app/)

### Note
I am aware that the application is not optimal and my way of achieving a functionality might not be fool-proof and also that it may be extremely naïve. It doesn't yet make a complete GUI suit for a command line process but its just a start. I'll add more functionality and sophistication to the application as I go on learning C#, the .NET Framework, and the Windows Form Application.
