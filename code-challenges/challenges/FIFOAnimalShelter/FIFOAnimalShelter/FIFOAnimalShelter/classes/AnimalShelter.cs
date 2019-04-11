using System;
using System.Text;
using FIFOAnimalShelter.classes;
using stacksAndQueues;
using stacksAndQueues.classes;

namespace FIFOAnimalShelter
{
    public class AnimalShelter
    {
        public Queue<Animal> Shelter { get; set; }
        Node<Animal> Current { get; set; }
        Node<Animal> Oldest { get; set; }

        public void Enqueue(Animal animal)
        {
            if (Shelter.Rear != null)
            {
                animal.Value += Convert.ToInt32(Shelter.Rear.Value);
            }
            Shelter.Enqueue(animal);
        }
        public Node<int> Dequeue(Animal pref)
        {
            Current = Shelter.Front;
            Oldest = Shelter.Front;
            if (pref is Dog)
            {
                if (Shelter.Front is Dog)
                {
                    Node<Animal> result = Shelter.Dequeue();
                }
                
            }
            if (pref is Cat)
            {

            }
            return null;
        }
    }
}
