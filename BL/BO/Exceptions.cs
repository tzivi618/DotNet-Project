

namespace BO;
[Serializable]
public class BlNotFoundIdException : Exception
{
    public BlNotFoundIdException(string? message) : base(message) { }
    public BlNotFoundIdException(string message, Exception innerException)
     : base(message, innerException) { }
}

public class BlExistIdException : Exception
{
    public BlExistIdException(string? message) : base(message) { }
    public BlExistIdException(string message, Exception innerException)
     : base(message, innerException) { }
}

public class BlNotInEnoughInStockException : Exception
{
    public BlNotInEnoughInStockException(string? message) : base(message) { }
    public BlNotInEnoughInStockException(string message, Exception innerException)
     : base(message, innerException) { }
}


