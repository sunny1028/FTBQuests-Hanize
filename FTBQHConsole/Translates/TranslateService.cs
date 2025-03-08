using FTBQHConsole.Models;

namespace FTBQHConsole.Translates;

/// <summary>
/// 翻译服务
/// </summary>
public class TranslateService
{
    /// <summary>
    /// 执行翻译
    /// </summary>
    /// <param name="request"></param>
    public void Execute(GetRootDirResult request)
    {
        ConfigHandling(request.ConfigDir);
    }

    /// <summary>
    /// 处理
    /// </summary>
    /// <param name="configDir"></param>
    private void ConfigHandling(DirectoryInfo configDir)
    {
        //获取所有文件
        var snbts = configDir.GetFiles("*.snbt", SearchOption.AllDirectories);
    
    }

}
