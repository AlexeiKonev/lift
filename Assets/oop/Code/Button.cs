
using UnityEngine;

namespace oop
{
    public abstract class Button : IPushButton
    {


        public virtual void PushButton(IMoveable m)
        {
            Debug.Log("default Button");
            m.Move();
        }
    }
}
