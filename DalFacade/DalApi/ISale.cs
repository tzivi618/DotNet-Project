

namespace DalApi;
using DO;
using System;
using System.Collections.Generic;

public interface ISale : Icrud<Sale>
{
    List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
}

