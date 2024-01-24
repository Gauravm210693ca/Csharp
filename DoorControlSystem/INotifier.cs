using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorsControlSystem
{
    public interface INotifier
    {
        void Update(DoorState state);
    }
}
