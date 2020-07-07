using System;
using System.Runtime.InteropServices;

namespace Shadows.Tizen
{
    internal static class Libraries
    {
        internal const string Evas = "libevas.so.1";
    }

    internal static partial class Interop
    {
        internal static partial class Evas
        {
            [DllImport(Libraries.Evas)]
            internal static extern void evas_object_clip_unset(IntPtr obj);
        }
    }
}
