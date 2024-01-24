using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace DoorsControlSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            SimpleDoor simpleDoorObj = new SimpleDoor();
            
            SmartDoor smartDoorObj = new SmartDoor();
           
            BuzzerManager buzzerManagerObj = new BuzzerManager();
            Action<DoorState> buzzerObserver = new Action<DoorState>(buzzerManagerObj.Update);
            smartDoorObj.StateChanged += buzzerObserver;

            PagerManager pagerManagerObj = new PagerManager();
            Action<DoorState> pagerObserver = new Action<DoorState>(pagerManagerObj.Update);
            smartDoorObj.StateChanged += pagerObserver;

            AutoCloseManager autoCloseManagerObj = new AutoCloseManager();
            Action<DoorState> autoCloseObserver = new Action<DoorState>(autoCloseManagerObj.Update);
            smartDoorObj.StateChanged += autoCloseObserver;

            smartDoorObj.Open();
            
            smartDoorObj.Close();
        }
    }
}

