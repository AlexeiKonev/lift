using UnityEngine;

namespace oop
{
    public abstract class Button : IPushButton
    {
        public int id = 9;

        public virtual void PushButton()
        {
            Debug.Log("default Button");
        }
    }
}
