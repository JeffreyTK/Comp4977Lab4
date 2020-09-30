using System.Collections.Generic;
using Province.Data;

namespace Province.Models
{
    public class City{

        public int CityId {get; set;}
        public string CityName {get; set;}
        public int Population {get; set;}
        public string ProvinceCode{get; set;}
        public Provinces Province {get; set;}

        public static List<City> GetCities(){
            List<City> cities = new List<City>(){
                new City{
                CityId=1,
                CityName="Surrey",
                Population=300000,
                ProvinceCode="BC"
                },
                new City{
                CityId=2,
                CityName="Richmond",
                Population=400000,
                ProvinceCode="BC"
                },
                new City{
                CityId=3,
                CityName="Burnaby",
                Population=100000,
                ProvinceCode="BC"
                },
                new City{
                CityId=4,
                CityName="Calgary",
                Population=500000,
                ProvinceCode="AB"
                },
                new City{
                CityId=5,
                CityName="Edmonton",
                Population=100000,
                ProvinceCode="AB"
                },
                new City{
                CityId=6,
                CityName="Lethbridge",
                Population=100000,
                ProvinceCode="AB"
                },
                new City{
                CityId=7,
                CityName="Toronto",
                Population=1000000,
                ProvinceCode="ON"
                },
                new City{
                CityId=8,
                CityName="Ottawa",
                Population=800000,
                ProvinceCode="ON"
                },
                new City{
                CityId=9,
                CityName="Kingston",
                Population=120000,
                ProvinceCode="ON"
                },
                };
                return cities;
            }
    }
}