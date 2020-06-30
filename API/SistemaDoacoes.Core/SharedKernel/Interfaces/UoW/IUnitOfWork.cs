using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDoacoes.Core.SharedKernel
{
    public interface IUnityOfWork
    {
        bool Commit();
    }
}
