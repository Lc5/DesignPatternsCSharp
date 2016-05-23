namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    using System;

    public class HorizontalScrollBarDecorator : WindowDecorator
    {
        public HorizontalScrollBarDecorator(IWindow window)
            : base(window)
        {
        }

        public override string Description
        {
            get
            {
                return base.Description + ", including horizontal scroll bar";
            }
        }

        public override void Draw()
        {
            base.Draw();
            this.DrawHorizontalScrollBar();
        }

        private void DrawHorizontalScrollBar()
        {
            Console.WriteLine("Drawing horizontal scroll bar.");
        }
    }
}