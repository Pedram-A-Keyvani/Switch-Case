using System.Collections.Generic;

namespace SwitchCase_State.Server
{
    public abstract class SwitchCase<TCase>
    {
        protected List<ICase<TCase>> Cases { get; set; }

        protected List<ICase<TCase>> DefaultCases { get; set; }
    }
}
