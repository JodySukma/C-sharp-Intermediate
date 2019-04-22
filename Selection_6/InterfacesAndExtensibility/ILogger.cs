using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_6.InterfacesAndExtensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
