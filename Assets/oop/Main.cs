using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace oop
{
    public class Main : MonoBehaviour
    {
        private List<IPushButton> buttons = new List<IPushButton>();

        void Start()
        {
            buttons.Add(new ButtonStop());
            buttons.Add(new ButtonLevel());
            buttons.Add(new ButtonOpenDoor());

         
        }
        public void Push()
        {
         foreach (var button in buttons)
              {
                button.PushButton();
              }
        }
    }
}
