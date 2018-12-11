using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalDinnerAppBackup.Model
{
    class RestaurantCatalogSingleton
    {
        private static RestaurantCatalogSingleton _instance;

        public static RestaurantCatalogSingleton Instance
        {
            get { return _instance ?? (_instance = new RestaurantCatalogSingleton()); }
        }

        public ObservableCollection<Restaurant> Restaurants { get; set; }
        public ObservableCollection<Restaurant> RestaurantsCity { get; set; }

        private RestaurantCatalogSingleton()
        {
            Restaurants = new ObservableCollection<Restaurant>();
            RestaurantsCity = new ObservableCollection<Restaurant>();
            
        }

        public void LoadRestaurants()
        {
            Restaurants.Add(new Restaurant(1, "Ilden", "Roskilde", 50));
            Restaurants.Add(new Restaurant(2, "Jensen's Bøfhus", "Holbæk", 60));
            Restaurants.Add(new Restaurant(3, "Karma Sushi", "København", 70));
            Restaurants.Add(new Restaurant(4, "Siang Jiang", "Slagelse", 50));
        }

        public void RestaurantsByCity(string cityName)
        {
            foreach (Restaurant res in Restaurants)
            {
                if (res.City == cityName)
                    RestaurantsCity.Add(res);
            }
        }

        public void AddRestaurant(Restaurant res)
        {
            Restaurants.Add(res);
        }

        public void RemoveRestaurant(Restaurant res)
        {
            Restaurants.RemoveAt(res.Id);
        }
    }
}
