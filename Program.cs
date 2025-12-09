using System.Runtime.InteropServices;

class SwapMouseButtons
{
    [DllImport("user32.dll")]
    public static extern int SwapMouseButton(Int32 fSwap);

    static void Main(string[] args)
    {
        int alreadyPrimary = SwapMouseButton(1);
        if (alreadyPrimary != 0)
        {
            SwapMouseButton(0);
        }
    }
}