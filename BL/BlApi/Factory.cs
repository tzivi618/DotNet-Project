
using DalApi;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using System;
using BlImplementation;
namespace BlApi
{
    public static class Factory
    {

        public static IBl Get { get { return new Bl(); } }

    }
}
