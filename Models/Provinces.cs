using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Province.Models
{
    public class Provinces{
        [Key]
        public string ProvinceCode {get; set;}
        public string ProvinceName {get; set;}
        public List<City> Cities {get; set;}

        public static List<Provinces> GetProvinces(){
            List<Provinces> provinces = new List<Provinces>(){
                new Provinces{
                ProvinceCode="BC",
                ProvinceName="British Columbia",
                },
                new Provinces{
                ProvinceCode="AB",
                ProvinceName="Alberta"
                },
                new Provinces{
                ProvinceCode="ON",
                ProvinceName="Ontario"
                },
                };
                return provinces;
            }
        }
    }