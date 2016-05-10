namespace DesignPatterns.Structural.Adapter
{
    public class EBookAdapter : IPaperBook
    {
        private IEBook ebook;

        public EBookAdapter(IEBook ebook)
        {
            this.ebook = ebook;
        }

        public void Open()
        {
            this.ebook.PressStart();
        }

        public void TurnPage()
        {
            this.ebook.PressNext();
        }
    }
}
