using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ReallySimpleRestClient.Http
{
    [CollectionDataContract(Namespace = "", Name = "errors")]
    public class Errors : List<ErrorResponse>
    {
    }
}
