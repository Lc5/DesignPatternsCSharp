namespace DesignPatterns.GangOfFour.Behavioral.Command
{
    using System;

    public class Light : ISwitchable
    {
        public void PowerOff()
        {
            Console.WriteLine("The light is off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("The light is on.");
        }
    }
}