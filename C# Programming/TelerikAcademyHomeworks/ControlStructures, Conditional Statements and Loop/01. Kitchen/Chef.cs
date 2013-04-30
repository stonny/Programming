using System;
using System.Linq;

namespace _01.Kitchen
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);

            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            throw new NotImplementedException(); 
        }

        private Carrot GetCarrot()
        {
            throw new NotImplementedException();
        }

        private Potato GetPotato()
        {
            throw new NotImplementedException();
        }

        private void Cut(Vegetable vegetable)
        {
            throw new NotImplementedException();
        }

        private void Cut(Potato potato)
        {
            throw new NotImplementedException();
        }

        private void Peel(Potato potato)
        {
            throw new NotImplementedException();
        }

        private void Cut(Carrot carrot)
        {
            throw new NotImplementedException();
        }

        private void Peel(Carrot carrot)
        {
            throw new NotImplementedException();
        }
    }
}