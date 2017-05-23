using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhostRider.Zaba.Bll
{
    public class Generics
    {
        public void test()
        {
            //Stream
        }
    }

    public class StreamingHandler<TStream>
    {
        public void Handle(TStream stream)
        {
            int i = 0;
            switch (i)
            {
                case 1:
                    //
                    break;
                case 2:
                case 5:
                    break;
            }

            ///Hashtable
            //Dictionary<string, int>
        }

        // sarah
        // haars

        // s => 1
        //h
        //a => 2
        //

        // klucz => dddd
        // klucz2 => qqqq

    }

    //byte[] Stream
    public static class Gowno
    {
        public static void Whaever(this GhostRider obj, int i)
        {
            
        }
    }

    public sealed class GhostRider
    {
        public void Whaever(int i)
        {
            
        }
    }

    public class test
    {
        private GhostRider g;

        public void Test()
        {
            g = new GhostRider();

            g.Whaever(9);

            g.Whaever(8);
        }
    }
}
