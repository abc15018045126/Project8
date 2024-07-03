using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;


namespace Project8
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]

    public class Plugin : BasePlugin
    {
        private static readonly System.IntPtr NativeFieldInfoPtr_autoBirthItem;






        internal static new ManualLogSource Log;
        public override void Load()
        { }
            // Plugin startup logic
            public unsafe int autoBirthItem
        {
            get
            {
                nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBirthItem);
                return *(int*)num;
                Debug.WriteLine(num);
            }
            set
            {

                *(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoBirthItem)) = value;
                int a =9;
                a=value;
            }
        }
    }
}

