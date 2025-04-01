using ADODB;
using Rrs.Ado.Com;
using System.Windows;

namespace Rrs.VB6DebuggerMarshalling.App;

class AdoObject : IAdoObject
{
    public void Connect(ParameterDirectionEnum Direction)
    {
        MessageBox.Show($"{Direction}");
    }
}
