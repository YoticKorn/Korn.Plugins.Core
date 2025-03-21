﻿using System;

namespace Korn.Plugins.Core
{
    public static class EnvUtils
    {
        public static bool HasModule(string name) => Interop.GetModuleHandle(name) != IntPtr.Zero;
    }
}