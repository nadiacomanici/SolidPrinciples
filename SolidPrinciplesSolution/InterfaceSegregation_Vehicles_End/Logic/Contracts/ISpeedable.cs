using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_Vehicles_End.Logic.Contracts
{
    public interface ISpeedable
    {
        int Speed { get; }
        void IncreaseSpeedBy(int value);
        void DecreaseSpeedBy(int value);
    }
}
