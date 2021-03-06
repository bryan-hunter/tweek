using System;

namespace Tweek.Drivers.Rules.Management
{

    public class TweekManagementRulesDriverSettings
    {
       public int SampleIntervalInMs {get;set;} = 30000;
       public int FailureDelayInMs {get;set;} = 60000;

       public TimeSpan FailureDelay => TimeSpan.FromMilliseconds(FailureDelayInMs);
       public TimeSpan SampleInterval => TimeSpan.FromMilliseconds(SampleIntervalInMs);
    }
}
