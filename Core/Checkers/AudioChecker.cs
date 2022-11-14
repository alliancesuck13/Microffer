using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace Microffer.Core.Checkers
{
    internal class AudioChecker
    {
        public ServiceController GetServiceController()
        {
            var svc = ServiceController.GetServices().Single(x => x.ServiceName == "Audiosrv");

            return svc;
        }
        public bool GetAudioStatus()
        {
            bool result = true;
            if (GetServiceController().Status.Equals(ServiceControllerStatus.Stopped))
            {
                result = false;
            }

            if (GetServiceController().Status.Equals(ServiceControllerStatus.Running))
            {
                result = true;
            }

            return result;
        }
    }
}
