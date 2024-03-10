namespace oop
{
    public partial class Main
    {
        private class DoorCloseBehavior : IMoveable
        {
            public void Move()
            {
                Main.Instance.anim.SetBool("door", false);
            }
        }
    }
}
