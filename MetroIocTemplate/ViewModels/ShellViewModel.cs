using System.ComponentModel.Composition;
using Caliburn.Micro;

namespace $safeprojectname$.ViewModels
{
    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
    }
}