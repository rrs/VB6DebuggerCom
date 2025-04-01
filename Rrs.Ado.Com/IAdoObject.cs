using ADODB;
using System.Runtime.InteropServices;

namespace Rrs.Ado.Com;

[Guid("8e00c991-818c-4298-9b8f-4ac74b644ae2")]
public interface IAdoObject
{
    void Connect(ParameterDirectionEnum Direction);
}
