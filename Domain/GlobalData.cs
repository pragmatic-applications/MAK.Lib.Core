namespace Domain;

public class GlobalData
{
    public static bool IsDevMode { get; set; } = false;
    public static bool IsBlazorServer { get; set; } = false;
    public static bool IsBlazorWasmHost { get; set; } = false;
    public static string DataStateKey { get; set; } = StringData.BlazorWasm;

    //public static string AppName { get; set; }
}
