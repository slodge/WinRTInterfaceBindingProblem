using System.Windows.Input;

namespace App1
{
    public interface IIntermediateCommand : ICommand
    {
        void Execute();
    }
}