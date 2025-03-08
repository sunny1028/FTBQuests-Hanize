global using FTBQHConsole.Util;
global using FTBQHConsole.Util.Extension;
using FTBQHConsole.Models;

Console.WriteLine("Hello, World!");

//获取 根目录
var rootDir = ConsoleHelper.ReadLineQA("请输入目录（该目录内应该存在<config><kubejs>这2个目录）[默认：当前目录]", ".", input =>
{
    if (input.IsNullOrWhiteSpace()) input = ".";
    var rootDir = new DirectoryInfo(input);
    var configDir = rootDir.GetDirectories("config").FirstOrDefault();
    var kubejsDir = rootDir.GetDirectories("kubejs").FirstOrDefault();
    if (configDir == null || kubejsDir == null)
    {
        Console.WriteLine("请输入目录（该目录内应该存在<config><kubejs>这2个目录）");
        return false;
    }
    return true;
}, input =>
{
    var rootDir = new DirectoryInfo(input);
    return new GetRootDirResult
    {
        RootDir = rootDir,
        ConfigDir = rootDir.GetDirectories("config").First(),
        KubejsDir = rootDir.GetDirectories("kubejs").First()
    };
});
