using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTest
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }

        public void ValidatId() 
        {
            if (Id == null)
            {
                throw new ArgumentOutOfRangeException();
            }     
            if (Id == 1) 
            {
                throw new ArgumentException();
            }
        }

        public void ValidatModel()
        {
            if (Model == null)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (Model.Length < 4)
            {
                throw new ArgumentException();
            }
        }


        public void ValidationPrice()
        {
            if (Price < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(Price > 0)
            {
                throw new ArgumentException();
            }
        }
    } 
}
