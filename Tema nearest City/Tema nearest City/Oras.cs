using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_nearest_City
{
    class Oras
    {
        private int _firstCoordonate;
        private int _secondCoordonate;
        private string _cityName;

        public Oras()
        {

        }
        public Oras(int firstCoordonate,int secondCoordonate,string cityName)
        {
            _cityName = cityName;
            _firstCoordonate = firstCoordonate;
            _secondCoordonate = secondCoordonate;
        }
        public int FirstCoordonate
        {
            get { return _firstCoordonate; }
            set { value = _firstCoordonate; }
        }
        public int SecondCoordonate
        {
            get { return _secondCoordonate; }
            set { value = _secondCoordonate; }
        }
        public string CityName
        {
            get { return _cityName; }
            set { value = CityName; }
        }
    }
}
