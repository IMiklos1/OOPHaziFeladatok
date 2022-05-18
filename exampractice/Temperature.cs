using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer
{
    enum Unit
    {
        CELSIUS,
        KELVIN
    }
    class Temperature
    {
        private double _temperature;
        private Unit _unit;

        private const double K = 273.15;

        public double temperature { get => _temperature; set => _temperature = value; }
        internal Unit Unit { get => _unit; set => _unit = value; }

        public Temperature(double temperature, Unit unit)
        {
            _temperature = temperature;
            _unit = unit;
        }

        //public Temperature(double temperature)
        //{
        //    _temperature = temperature;
        //    _unit = 0;
        //}
        public Temperature(double temperature) : this(temperature, 0)
        {
            //_temperature = temperature;
            //_unit = 0;
        }

        public override string ToString()
        {
            return $"Temperature: {_temperature}, Unit: {_unit}"; 
        }

        public void ConvertTemp()
        {
            if (_unit == Unit.CELSIUS)
            {
                _temperature += K;
                _unit = Unit.KELVIN;
            }
            else
            {
                _temperature -= K; 
                _unit = Unit.CELSIUS;
            }
        }

        /// <summary>
        /// This is a function.
        /// </summary>
        /// <param name="temp">Temperature object</param>
        /// <param name="outUnit">Unit to convert to</param>
        /// <returns>A new temperature object</returns>
        public static Temperature ConvertTempTo(Temperature temp, Unit outUnit)
        {

            //if (temp.Unit == Unit.CELSIUS && outUnit != Unit.CELSIUS)
            //{
            //    return new(temp.temperature + 273.15, Unit.KELVIN);
            //}
            //if (temp.Unit == Unit.KELVIN && outUnit != Unit.KELVIN)
            //{
            //    return new(temp.temperature - 273.15, Unit.CELSIUS);
            //}
            //return temp;

            if (temp.Unit == outUnit) 
                return temp;
            if (outUnit == Unit.CELSIUS) 
                return new(temp.temperature + K, Unit.KELVIN);
            return new(temp.temperature - K, Unit.CELSIUS);
        }
    }
}
