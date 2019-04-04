using System;
using System.Text;
using stacksAndQueues;
using stacksAndQueues.classes;

namespace FIFOAnimalShelter
{
    class AnimalShelter
    {
        Queue<string> Shelter { get; set; }
        public void Enqueue(string animal)
        {
            Shelter.Enqueue(animal);
        }
        public Node<string> Dequeue(string pref)
        {
            if (pref != "dog" && pref != "cat")
            {
                return null;
            }
            Node<string> beginning = Shelter.Front;
            while (Shelter.Front.Value != pref)
            {
                Shelter.Enqueue(Shelter.Dequeue().Value);
            }
            Node<string> target = Shelter.Dequeue();
            if (target != beginning)
            {
                while (Shelter.Front != beginning)
                {
                    Shelter.Enqueue(Shelter.Dequeue().Value);
                }
            }
            return target;
        }
    }
}
