using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0401
{
    class BasicCar : ICar
    {
        private string color = "Gray";
        private int speed = 0;
        private int gear = 1;
        private int wheelCount = 4;


        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        public string getColor()
        {
            return color;
        }

        public int getCurrentGear()
        {
            return gear;
        }

        public int getCurrentSpeed()
        {
            return speed;
        }

        public int getWheelCount()
        {
            return wheelCount;
        }

        public void setColor(string c)
        {
            color = c;
        }

        public void setWheelCount(int newWheelCount)
        {
            wheelCount = newWheelCount;
        }

        public void speedDown(int decrement)
        {
            speed -= decrement;
        }

        public void speedUp(int increment)
        {
            speed += increment;
        }
    }
}
