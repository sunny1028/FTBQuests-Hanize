using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTBQHConsole.Util.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class Extention
    {
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>是否删除成功</returns>
        public static bool DeleteFile(this string? filePath)
        {
            if (filePath.IsNullOrWhiteSpace() || !File.Exists(filePath)) return false;

            try { File.Delete(filePath); } catch { return false; }

            return true;
        }

        /// <summary>
        /// 删除文件夹
        /// </summary>
        /// <param name="dirPath"></param>
        /// <returns>是否删除成功</returns>
        public static bool DeleteDir(this string? dirPath)
        {
            if (dirPath.IsNullOrWhiteSpace() || !Directory.Exists(dirPath)) return false;
            try { Directory.Delete(dirPath, true); } catch { return false; }
            return true;
        }


        /// <summary>
        /// 判断指定的字符串是null、空还是仅由空白字符组成。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace([NotNullWhen(false)] this string? str) => string.IsNullOrWhiteSpace(str);
        /// <summary>
        /// 判断指定的字符串是null还是空字符串。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty([NotNullWhen(false)] this string? str) => string.IsNullOrEmpty(str);

        /// <summary>
        /// 字符串是否 非空、非null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNotNullAndNotWhiteSpace([NotNullWhen(true)] this string? str) => !string.IsNullOrWhiteSpace(str);
        /// <summary>
        /// 字符串是否 非null
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNotNullOrEmpty([NotNullWhen(true)] this string? str) => !string.IsNullOrEmpty(str);




    }
}
