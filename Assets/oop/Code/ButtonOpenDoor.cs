using UnityEngine;

namespace oop
{
    class ButtonOpenDoor : Button
    {
        public override void PushButton(IMoveable m)
        {
            Debug.Log("pushed ButtonOpenDoor");
            m.Move();
        }
    }
}
