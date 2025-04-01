using Rrs.VB6DebuggerMarshalling.Com;
using System.Windows;

namespace Rrs.VB6DebuggerMarshalling.App;

class DotNetObject : IDotNetObject
{
    public void Celebrate() => MessageBox.Show("Yeeehaaw!");
}
