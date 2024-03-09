using UnityEngine;

namespace oop
{
    class ButtonCloseDoor : Button
    {
        public override void PushButton(IMoveable m)
        {

            Debug.Log("pushed CloseDoor");
            m.Move();
        }
    }
}
