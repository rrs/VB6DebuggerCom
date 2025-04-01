using Rrs.Ado.Com;
using Rrs.VB6DebuggerMarshalling.Com;

namespace Rrs.VB6DebuggerMarshalling.App;

class DotNetObjectFactory : IDotNetObjectFactory
{
    public IAdoObject NewAdoObject() => new AdoObject();
    public IDotNetObject NewDotNetObject() => new DotNetObject();
}
