namespace FTBQHConsole.Models;

/// <summary>
/// 获取 根目录 出参
/// </summary>
public class GetRootDirResult
{
    /// <summary>
    /// 根目录
    /// </summary>
    public required DirectoryInfo RootDir { get; set; }
    /// <summary>
    /// config 目录
    /// </summary>
    public required DirectoryInfo ConfigDir { get; set; }
    /// <summary>
    /// kubejs 目录
    /// </summary>
    public required DirectoryInfo KubejsDir { get; set; }

}
