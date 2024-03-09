using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace oop
{
    public interface IMoveable
    { 
      
        void Move();
        
    }
    public class DoorBehavior : IMoveable
    {
        Animator anim;
        bool doorIsOpen;
        public void Move()
        {
            if (doorIsOpen)
            {
                CloseDoor();
                doorIsOpen = false;
            }
            else
            {
                OpenDoor();
                doorIsOpen = true;
            }
        }
        private void CloseDoor()
        {

        }
        private void OpenDoor()
        {

        }
    }
}
