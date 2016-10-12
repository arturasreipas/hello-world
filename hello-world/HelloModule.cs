namespace hello_world
{
    public class HelloModule
    {
        public string SayHello(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                return "Name cannot be empty";
            }

            var module = new LowerUper();
            //return string.Format("Hello, {0}", System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name.ToLower()));
            return string.Format("Hello, {0}!", module.UperLower(name));
        }
    }
}
