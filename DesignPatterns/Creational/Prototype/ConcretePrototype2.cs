namespace DesignPatterns.Creational.Prototype
{
    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}
