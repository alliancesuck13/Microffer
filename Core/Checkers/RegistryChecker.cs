using Microsoft.Win32;

namespace Microffer.Core.Checkers
{
    internal class RegistryChecker
    {
        // "Software\Microffer\Hotkey"
        // Todo: Hotkeys

        public RegistryKey CreateRegistryKey(string path)
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@path);

            return key;
        }

        public RegistryKey OpenRegistryKey(string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@path);
            return key;
        }

        public bool CheckExistingKey(string path)
        {
            bool result = false;
            if (OpenRegistryKey(path)?.SubKeyCount != null)
            {
                result = true;
                OpenRegistryKey(path).Close();
            }
            else
            {
                result = false;
                OpenRegistryKey(path).Close();
            }

            return result;
        }
    }
}
