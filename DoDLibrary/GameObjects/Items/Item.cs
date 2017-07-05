using DoDLibrary.GameObjects.Characters;

namespace DoDLibrary.GameObjects.Items
{
    public abstract class Item : GameObject, ICarryable
    {
        public string Name { get; }

        public Item(string name) : base('I')
        {
            Name = name;
        }

        public virtual string GetPickedUp(Character character)
        {
            character.Backpack.Add(this);

            return $"{this.Name} was added to your backpack.";
        }
    }
}
