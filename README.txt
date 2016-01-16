Required dependencies for users
-------------------------------
- Windows Installer 3.1 (https://www.microsoft.com/en-us/download/details.aspx?id=25)
- Windows Imaging Component (https://www.microsoft.com/en-us/download/details.aspx?id=32)
- .Net Framework 4 (https://www.microsoft.com/en-us/download/details.aspx?id=17851) to run this program.
- .Net Framework 3.5 (this may actually be all that is required, i.e. not the above .Net Framework 4) (https://www.microsoft.com/en-us/download/details.aspx?id=25150)
- Report Viewer Redistributable 2008 (http://www.microsoft.com/en-us/download/details.aspx?id=6576) ( Even though .Net Framework 4 is installed, .Net Framework 2.0 is required to install the Report Viewer: https://www.microsoft.com/en-us/download/details.aspx?id=1639)
- Updates for Root Certificates (https://www.microsoft.com/en-us/download/confirmation.aspx?id=26609)

Your resolution must be at least 1024x768.

Developers
----------
- This code is known to build on Visual Studio 2010.
- This code targets .NET 3.5, so you must install .NET Framework 3.5 SP1  before opening the project in Visual Studio 2010 (https://www.microsoft.com/en-us/download/details.aspx?id=25150). If it asks you to retarget and you say yes, some things break.

Time tracker is a program to replace the old "punch card" machines, as well as
produce reports of employees work times throughout the payperiod. These reports are submitted to the payroll company at the end of each pay period.
Employees are assigned a 3 digit PIN which they use to login to the system.
There are three types of employees: timed, commissioned, and manager.
Timed employees utilize the "punch card" functionality.
Commissioned employees are typically salesmen. They do not use the software at all 
and are only enrolled so their name appears on the report at the end of the week.
Manager employees are able to change other employees information, add new employees, and "fix" employees time if there are problems or special circumstances throughout the week.

There are three "events" that the system can handle - DAY, LUNCH, and BREAK. Each event has an "in" and an "out" associated with it.
Each day must contain: 
0 or 2 DAY events
0 or 2 LUNCH events
an even number of BREAK events.

