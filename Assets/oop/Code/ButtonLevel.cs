using UnityEngine;

namespace oop
{
    class ButtonLevel : Button
    {
        public override void PushButton(IMoveable m)
        {
            Debug.Log("pushed ButtonLevel");
            m.Move();
        }
    }
}
