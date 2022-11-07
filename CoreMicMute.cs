using NAudio.CoreAudioApi;
using System;

namespace Microffer
{
    internal class CoreMicMute
    {
        // Запись найденных устройств
        private MMDevice[] rgMicDevice;
        int MaxMicro = 0;

        public CoreMicMute()
        {
            // DataFlow.Capture - Микрофоны(или устройства в которые поступает звук), DeviceState.Active - Активные устройства
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            MMDeviceCollection devices = devEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);

            MaxMicro = 0;
            // devices.Count - активные микрофоны
            for (int i = 0; i < devices.Count; i++)
            {
                MMDevice deviceAt = devices[i];
                if (deviceAt.DataFlow == DataFlow.Capture && deviceAt.State == DeviceState.Active)
                {
                    ++MaxMicro;
                }
            }

            rgMicDevice = new MMDevice[MaxMicro];
            MaxMicro = 0;

            for (int i = 0; i < devices.Count; i++)
            {
                MMDevice deviceAt = devices[i];
                // Меняем на свое устройство(а)
                if (deviceAt.DataFlow == DataFlow.Capture && deviceAt.State == DeviceState.Active)
                {
                    MaxMicro++;
                    rgMicDevice[MaxMicro - 1] = deviceAt;
                }
            }

            // Если не найден ни один микрофон
            if (MaxMicro == 0)
            {
                throw new InvalidOperationException("Микрофон не найден");
            }
        }

        // Функция, отключающая звук устройств записанных в массив  private MMDevice[] rgMicDevice
        public void SetMute(bool mute)
        {
            for (int i = 0; i < MaxMicro; i++)
            {
                rgMicDevice[i].AudioEndpointVolume.Mute = mute;
            }
        }
        
    }
}
