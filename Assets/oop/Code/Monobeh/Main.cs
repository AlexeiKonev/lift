using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace oop
{
    public class Main : MonoBehaviour
    {
        public static Main Instance;

        public Animator anim; 

        const string open  = "OpenDoor";
        const string close  = "CloseDoor";
        const string level = "Level";
        const string stop = "Stop";

            IPushButton openDoor = new ButtonOpenDoor();
            IPushButton closeDoor = new ButtonCloseDoor();
            IPushButton levelButton = new ButtonLevel();
            IPushButton stopButton = new ButtonStop();

            IMoveable moveDoor = new DoorBehavior();
            IMoveable moveLift = new LiftBehavior();

        void Start()
        {

            if (Instance == null)
            {
            Instance = this;
            }

            Instance.anim = GameObject.Find("Lift").GetComponent<Animator>();
        }
        public void Push( string button)
        {

                if (button == open)
            {
                openDoor.PushButton(moveDoor);
            }
               if (button == close)
            {
                closeDoor.PushButton(moveDoor);
            }

                if (button == level)
            {
                levelButton.PushButton(moveLift);
            }

              if (button == stop)
            {
                stopButton.PushButton(moveLift);
            }

           

        }
    }
}
