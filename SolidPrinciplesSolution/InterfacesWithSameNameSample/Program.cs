using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesWithSameNameSample
{
    public interface IDrivable
    {
        void MoveTo(int x, int y, int z);
    }

    public interface IFlyable
    {
        void MoveTo(int x, int y, int z);
    }

    public class BatMobile : IFlyable, IDrivable
    {
        void IFlyable.MoveTo(int x, int y, int z)
        {
            Console.WriteLine("Move To - IFlyable");
        }

        void IDrivable.MoveTo(int x, int y, int z)
        {
            Console.WriteLine("Move To - IDrivable");
        }

        public void MoveTo(int x, int y, int z)
        {
            Console.WriteLine("Move To - THIRD OPTION");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDrivable batMobileDrive = new BatMobile();
            batMobileDrive.MoveTo(1, 2, 3);

            IFlyable batMobileFly = new BatMobile();
            batMobileFly.MoveTo(1, 2, 3);

            BatMobile batMobileVar1 = new BatMobile();
            batMobileVar1.MoveTo(1, 2, 3);
        }
    }
}
