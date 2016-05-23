namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    using System;

    public class VerticalScrollBarDecorator : WindowDecorator
    {
        public VerticalScrollBarDecorator(IWindow window)
            : base(window)
        {
        }

        public override string Description
        {
            get
            {
                return base.Description + ", including vertical scroll bar";
            }
        }

        public override void Draw()
        {
            base.Draw();
            this.DrawVerticalScrollBar();
        }

        private void DrawVerticalScrollBar()
        {
            Console.WriteLine("Drawing vertical scroll bar.");
        }
    }
}