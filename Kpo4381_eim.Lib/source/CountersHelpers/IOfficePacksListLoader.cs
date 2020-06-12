using System.Collections.Generic;

namespace Kpo4381.eim.Lib
{
    public interface IOfficePacksListLoader
    {
        List<OfficePacks> officePacksList { get; }
        LoadStatus status { get; }
        Delegate.OnStatusChangedDelegate onStatusChangedDelegate { get; }
        void SetOnStatusChanged(Delegate.OnStatusChangedDelegate onStatusChanged);
        void Execute();
    }
}