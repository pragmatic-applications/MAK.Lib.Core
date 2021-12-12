namespace Helpers;

//public static class GlobalData
public class GlobalData
{
    public const string BlazorServer = "BlazorServer";
    public const string BlazorWasmHost = "BlazorWasmHost";
    public const string BlazorWasm = "BlazorWasm";

    public static bool IsDevMode { get; set; } = false;
    public static bool IsBlazorServer { get; set; } = false;
    public static bool IsBlazorWasmHost { get; set; } = false;
    public static string DataStateKey { get; set; } = BlazorWasm;
}
