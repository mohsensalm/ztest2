using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }

    public class Jeep : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
        #endregion
    }

    public class Suv : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }


    public class AutomobileController
    {
        private readonly IAutomobile _mAutomobile;

        public AutomobileController(IAutomobile automobile)
        {
            this._mAutomobile = automobile;
        }

        public void Ignition()
        {
            _mAutomobile.Ignition();
        }

        public void Stop()
        {
            _mAutomobile.Stop();
        }
    }
}
