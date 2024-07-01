using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Night.Core
{
    public interface ISubSystem
    {
        void Initialize();
        void Deinitialize();
    }
}
