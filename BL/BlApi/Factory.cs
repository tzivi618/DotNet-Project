using BlImplementation;
namespace BlApi
{
    public static class Factory
    {
        public static IBl Get { get { return new Bl(); } }

    }
}
