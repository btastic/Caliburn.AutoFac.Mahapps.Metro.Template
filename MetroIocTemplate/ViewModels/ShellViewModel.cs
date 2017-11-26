using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace MetroIocTemplate.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
    }
}