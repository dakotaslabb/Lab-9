using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_9
{
    class Humans
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;
        public string FavoriteColor;

        public Humans (string name, string homeTown, string favoriteFood, string favoriteColor)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavoriteColor = favoriteColor;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetHomeTown()
        {
            return HomeTown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }

        public string GetFavoriteColor()
        {
            return FavoriteColor;
        }
    }
}

