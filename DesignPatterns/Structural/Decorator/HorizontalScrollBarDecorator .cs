namespace DesignPatterns.Structural.Decorator
{
    public class HorizontalScrollBarDecorator : WindowDecorator
    {
        public HorizontalScrollBarDecorator(IWindow window) : base(window)
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
            //Draw horizontal scroll bar
        }        
    }
}
