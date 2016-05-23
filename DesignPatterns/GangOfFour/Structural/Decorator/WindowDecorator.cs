namespace DesignPatterns.GangOfFour.Structural.Decorator
{
    public abstract class WindowDecorator : IWindow
    {
        private readonly IWindow window;

        public WindowDecorator(IWindow window)
        {
            this.window = window;
        }

        public virtual string Description
        {
            get
            {
                return this.window.Description;
            }

            set
            {
                this.window.Description = value;
            }
        }

        public virtual void Draw()
        {
            this.window.Draw();
        }
    }
}