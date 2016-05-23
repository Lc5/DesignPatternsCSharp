namespace DesignPatterns.GangOfFour.Behavioral.Visitor
{
    using System.Collections.Generic;

    public class Document
    {
        private readonly List<DocumentPart> parts = new List<DocumentPart>();

        public void Accept(IVisitor visitor)
        {
            foreach (var part in this.parts)
            {
                part.Accept(visitor);
            }
        }

        public void AddPart(DocumentPart documentPart)
        {
            this.parts.Add(documentPart);
        }
    }
}