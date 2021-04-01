using System;
using System.Collections.Generic;
using System.Text;

namespace Seance0401
{
    interface ICar
    {
        string getColor();
        void setColor(string c);

        int getWheelCount();
        void setWheelCount(int newWheelCount);

        int getCurrentGear();
        void changeGear(int newGear);

        int getCurrentSpeed();
        void speedUp(int icrement);
        void speedDown(int decrement);
    }
}
