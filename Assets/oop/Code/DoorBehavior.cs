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
         
        bool doorIsOpen ;
        public void Move()
        {
            Debug.Log("Move");

            if (doorIsOpen)
            {
                CloseDoor();
              
            }
           else if (!doorIsOpen)
            {
                OpenDoor();
               
            }
        }
        private void CloseDoor()
        {
            Main.Instance.anim.SetBool("door", false);
            doorIsOpen = false;
        }
        private void OpenDoor()
        {
            //Main.Instance.anim.SetInteger("state", 2);
            Main.Instance.anim.SetBool("door", true);
            doorIsOpen = true;
        }
    }
}
