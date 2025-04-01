using Rrs.Ado.Com;
using System.Runtime.InteropServices;

namespace Rrs.VB6DebuggerMarshalling.Com;

[Guid("2bc679ea-8c2a-498c-9c3d-7877c1b5b8d2")]
public interface IDotNetObjectFactory
{
    IDotNetObject NewDotNetObject();
    IAdoObject NewAdoObject();
}
