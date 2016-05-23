namespace DesignPatterns.GangOfFour.Structural.Adapter
{
    public class EbookAdapter : IPaperBook
    {
        private readonly IEbook ebook;

        public EbookAdapter(IEbook ebook)
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