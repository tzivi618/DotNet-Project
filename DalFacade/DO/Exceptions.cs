

namespace DO;

[Serializable]
public class DalNotFoundIdException : Exception
{
    public DalNotFoundIdException(string errorMassege) : base(errorMassege) { }
}

[Serializable]
public class DalExistIdException : Exception
{
    public DalExistIdException(string errorMassege) : base(errorMassege) { }
}

[Serializable]
public class DalWrongOptionException : Exception
{
    public DalWrongOptionException(string errorMassege) : base(errorMassege) { }
}




