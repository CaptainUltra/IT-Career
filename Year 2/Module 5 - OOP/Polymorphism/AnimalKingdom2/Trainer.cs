namespace AnimalKingdom2
{
    public class Trainer
    {
        private IAnimal entity;
        public Trainer(IAnimal entity)
        {
            this.Entity = entity;
        }
        public void Make()
        {
            this.Entity.Perform();
        }
        public IAnimal Entity
        {
            get { return this.entity; }
            set { this.entity = value; }
        }
        
    }
}