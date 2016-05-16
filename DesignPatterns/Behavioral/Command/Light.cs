namespace DesignPatterns.Behavioral.Command
{
    using System;

    public class Light : ISwitchable
    {
        public void PowerOn()
        {
            Console.WriteLine("The light is on.");
        }

        public void PowerOff()
        {
            Console.WriteLine("The light is off.");
        }
    }
}
