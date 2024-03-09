using UnityEngine;

namespace oop
{
    class ButtonStop : Button
    {
        public override void PushButton(IMoveable m)
        {
            Debug.Log("pushed ButtonStop");
            m.Move();
        }
    }
}
