using UnityEngine;

namespace oop
{
    public class LiftBehavior : IMoveable
    {
        public void Move()
        {
            Debug.Log("lift move");
        }
        private void UpMove()
        {
            Debug.Log("lift Up move");
        }
        private void DownMove()
        {
            Debug.Log("lift Down move");
        }
        private void StopMove()
        {
            Debug.Log("lift Stop move");
        }
    }
}