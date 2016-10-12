namespace hello_world
{
    public class LowerUper
    {
        public string UperLower(string name)
        {
            return System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
        }
    }
}
