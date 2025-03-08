using FTBQHConsole.Util.Extension;
using System;

namespace FTBQHConsole.Util;

/// <summary>
/// 
/// </summary>
public static class ConsoleHelper
{
    static string[] AllowBoolYes = ["y", "1", "a", "true", "t"];
    static string[] AllowBoolNo = ["n", "0", "2", "false", "f"];

    /// <summary>
    /// 读取问答型的用户输入内容
    /// </summary>
    /// <typeparam name="T">输入内容转换类型</typeparam>
    /// <param name="tipMsg">提示文案</param>
    /// <param name="defaultValue">默认数据</param>
    /// <returns></returns>
    public static T ReadLineQA<T>(string tipMsg, string defaultValue)
    {
        return ReadLineQA(tipMsg, defaultValue, input =>
        {
            if (typeof(T) == typeof(string)) return true;

            else if (typeof(T) == typeof(bool))
                return AllowBoolYes.Contains(input.ToLower()) || AllowBoolNo.Contains(input.ToLower());

            else if (typeof(T) == typeof(short) || typeof(T) == typeof(byte) || typeof(T) == typeof(int) || typeof(T) == typeof(long))
                return long.TryParse(input.ToString(), out _);

            else if (typeof(T) == typeof(double) || typeof(T) == typeof(decimal) || typeof(T) == typeof(float))
                return double.TryParse(input.ToString(), out _);

            return false;
        }, input => (T)(object)input);
    }

    /// <summary>
    /// 读取问答型的用户输入内容
    /// </summary>
    /// <typeparam name="T">输入内容转换类型</typeparam>
    /// <param name="tipMsg">提示文案</param>
    /// <param name="defaultValue">默认数据</param>
    /// <param name="resultAssert">结果断言</param>
    /// <returns></returns>
    public static T ReadLineQA<T>(string tipMsg, string defaultValue, Func<string, bool> resultAssert)
        => ReadLineQA(tipMsg, defaultValue, resultAssert, input => (T)(object)input);

    /// <summary>
    /// 读取问答型的用户输入内容
    /// </summary>
    /// <typeparam name="T">输入内容转换类型</typeparam>
    /// <param name="tipMsg">提示文案</param>
    /// <param name="defaultValue">默认数据</param>
    /// <param name="resultAssert">结果断言</param>
    /// <param name="convert">结果转换</param>
    /// <returns></returns>
    public static T ReadLineQA<T>(string tipMsg, string defaultValue, Func<string, bool> resultAssert, Func<string, T> convert)
    {
        while (true)
        {
            Console.WriteLine(tipMsg);
            var input = Console.ReadLine();
            if (input.IsNullOrWhiteSpace()) if (defaultValue.IsNullOrWhiteSpace()) continue; else return (T)(object)defaultValue;

            if (resultAssert(input)) return convert(input);
            continue;
        }
    }

}
