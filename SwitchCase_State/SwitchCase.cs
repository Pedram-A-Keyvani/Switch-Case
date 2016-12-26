using System.Collections.Generic;
using System.Linq;

namespace SwitchCase_State
{
    public abstract class SwitchCase<TCase>
    {
        protected List<ICase<TCase>> Cases { get; set; }
        protected List<ICase<TCase>> DefaultCases { get; set; }
    }
}
