namespace oop
{
    public partial class Main
    {
        private class DoorOpenBehavior : IMoveable
        {
            public void Move()
            {
                Main.Instance.anim.SetBool("door", true);
            }
        }
    }
}
