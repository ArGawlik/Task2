using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Task3;
using Task3.Vehicles;
using Task6.Exceptions;

namespace Task6
{
    internal class Parking
    {
        public int parkingSize;
        public List<Vehicle> Cars { get; set; }

        public Parking(int parkingSize)
        {
            this.parkingSize = parkingSize;
            this.Cars = new List<Vehicle>();
        }
        public Parking Add(Vehicle car)
        {
            if (Cars.Count >= parkingSize)
            {
                throw new AddException("The parking has not enough space for more cars");
            }
            else if (Cars.Select(x=>x.vehicleId).Contains(car.vehicleId))
            {
                throw new AddException("The car with provided ID already exists");
            }
            else
            {
                Cars.Add(car);
            }
            return this;
        }

        public List<Vehicle> GetAutoByParameter(string parameter, string value)
        {
            //PropertyInfo actualProperty = null;
            //foreach (PropertyInfo property in typeof(Vehicle).GetProperties())
            //{
            //    if(property.Name == parameter)
            //    {
            //        actualProperty = property;
            //        break;
            //    }
            //}
            //if (actualProperty == null)
            //{
            //    throw new GetAutoByParameterException("Provided parameter does not exist");
            //}
            //else
            //{
            //    var selectedCars = Cars.Where(x => actualProperty.GetValue(x).ToString() == value).ToList();
            //    if (selectedCars.Count > 0)
            //    {
            //        return selectedCars;
            //    }
            //    else
            //    {
            //        throw new GetAutoByParameterException($"Parameter {parameter} with provided value does not exist");
            //    }
            //}
            if (Cars.Count == 0)
            {
                throw new GetAutoByParameterException("No cars on parking");
            }
            if (!Cars[0].vehicleParameters.ContainsKey(parameter))
            {
                throw new GetAutoByParameterException("Provided parameter does not exist");
            }
            var result = Cars.Where(x => x.vehicleParameters[parameter] == value).ToList();
            if (result.Count == 0)
            {
                throw new GetAutoByParameterException($"Parameter {parameter} with provided value does not exist");
            }
            return result;
        }

        public void UpdateAuto(string vehicleId, Vehicle newVehicle)
        {
            if (!Cars.Select(x => x.vehicleId).Contains(vehicleId))
            {
                throw new UpdateAutoException("Vehicle with provided ID does not exist");
            }
            else
            {
                int index = Cars.IndexOf(Cars.Where(x => x.vehicleId == vehicleId).First());
                Cars[index] = newVehicle;
            }
        }
        public void RemoveAuto(string vehicleId)
        {
            if (!Cars.Select(x => x.vehicleId).Contains(vehicleId))
            {
                throw new RemoveAutoException("Vehicle with provided ID does not exist");
            }
            else
            {
                Cars.Remove(Cars.Where(x => x.vehicleId == vehicleId).First());
            }
        }
    }
}
