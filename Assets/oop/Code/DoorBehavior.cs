using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace oop 
{
    public class DoorBehavior : IMoveable
    {
        //public  Animator anim;
        bool doorIsOpen;
        public void Move()
        {
            Debug.Log("Move");
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
            Main.Instance.anim.SetInteger("state", 1);
        }
        private void OpenDoor()
        {
            Main.Instance.anim.SetInteger("state", 0);
        }
    }
}
