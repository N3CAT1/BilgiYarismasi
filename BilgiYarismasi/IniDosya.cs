using System;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace BilgiYarismasi
{
    class IniDosya
    {
        string path;
        /// <summary>
        /// INIFile Constructor.
        /// </summary>
        /// <param name="INIPath"></param>
        public IniDosya(string INIPath)
        {
            path = INIPath;
        }
        //[DllImport("kernel32")]
        //private static extern long WritePrivateProfileString1(string section,string key,string val,string filePath);
        //[DllImport("kernel32")]
        //private static extern int DegerOku(string section,string key,string def,StringBuilder retVal,int size,string filePath);

        [DllImport("Kernel32.dll")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetPrivateProfileStringW",
             SetLastError = true,
             CharSet = CharSet.Unicode, ExactSpelling = true,
             CallingConvention = CallingConvention.StdCall)]
        private static extern int GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            string lpReturnString,
            int nSize,
            string lpFilename);

        [DllImport("KERNEL32.DLL", EntryPoint = "WritePrivateProfileStringW",
             SetLastError = true,
             CharSet = CharSet.Unicode, ExactSpelling = true,
             CallingConvention = CallingConvention.StdCall)]
        private static extern int WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFilename);

        //************** ini dosyasındaki kategori isimlerini döndürür ************
        public string[] GetCategories(string iniFile)
        {
            string returnString = new string(' ', 65536);
            GetPrivateProfileString(null, null, null, returnString, 65536, iniFile);
            string[] result = returnString.Split('\0');
            //result.RemoveRange(result.Count - 2, 2);
            return result;
        }

        //******** ini dosyasındaki kategori altında bulunan anahtar kelimeleri döndürür *********
        public string[] GetKeys(string iniFile, string category)
        {
            string returnString = new string(' ', 32768);
            GetPrivateProfileString(category, null, null, returnString, 32768, iniFile);
            string[] result = returnString.Split('\0');
            //result.RemoveRange(result.Count-2,2);
            return result;
        }

        //************ ini dosyasına belirtilen kategori ve anahtar kelimeye göre değeri yazar ********
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.path);
        }

        //************** ini dosyasından belirtilen kategori ve anahtar kelimeye göre değeri okur *******
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            string a = temp.ToString();
            return temp.ToString();
        }
    }
}
