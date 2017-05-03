using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostRider.Tournament.Management.Test
{
    class CoContra
    {
        public void test()
        {
            //IRainyWeather<IRoman> bla = new RainyWeather<ICloud>();
        }
    }

    //PLCHANDLER<PLCCOMMAND>

    internal interface ICloud
    {
    }

    interface ISpecificCloud : ICloud
    {

       
    }

    interface IRoman : ISpecificCloud
    {

    }

    interface IWeather<out TCloud> where TCloud : ICloud
    {
        TCloud DoWhatever();
    }

    interface ICoolWeather<out TCloud> : IWeather<TCloud> where TCloud : ICloud { }

    interface IRainyWeather<out TCloud> : ICoolWeather<TCloud> where TCloud : ICloud { }

    class Roman : IRoman { }
    class RainyWeather<TCloud> : IRainyWeather<TCloud> where TCloud : ICloud {
        public TCloud DoWhatever()
        {
            throw new NotImplementedException();
        }
    }
}
