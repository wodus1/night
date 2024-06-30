using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Waknights.Core
{
    public interface ISubSystem
    {
        void Initialize();
        void Deinitialize();
    }
}
