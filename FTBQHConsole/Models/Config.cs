namespace FTBQHConsole.Models;

/// <summary>
/// 配置表
/// </summary>
public static class Config
{
    /// <summary>
    /// 是否显示原文
    /// </summary>
    public static bool DisplayOriginal { get; set; } = true;
    /// <summary>
    /// 当显示原文时，是否原文前置
    /// </summary>
    public static bool OriginalPreface { get; set; }

    /// <summary>
    /// 结果拼接 前缀
    /// </summary>
    public static string Prefix { get; set; } = "";
    /// <summary>
    /// 结果拼接 后缀
    /// </summary>
    public static string Suffix { get; set; } = "";

}
