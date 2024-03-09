using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace oop
{
    public class Main : MonoBehaviour
    {
        const string open  = "OpenDoor";
        const string close  = "CloseDoor";
        const string level = "Level";
        const string stop = "Stop";

            IPushButton openDoor = new ButtonOpenDoor();
            IPushButton closeDoor = new ButtonCloseDoor();
            IPushButton levelButton = new ButtonLevel();
            IPushButton stopButton = new ButtonStop();

        void Start()
        {
           
         
        }
        public void Push( string button)
        {

                if (button == open)
            {
                openDoor.PushButton();
            }
               if (button == close)
            {
                closeDoor.PushButton();
            }

                if (button == level)
            {
                levelButton.PushButton();
            }

              if (button == stop)
            {
                stopButton.PushButton();
            }

           

        }
    }
}
