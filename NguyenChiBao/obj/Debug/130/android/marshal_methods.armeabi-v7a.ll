; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [208 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 68
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 92
	i32 57967248, ; 2: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 38
	i32 101534019, ; 3: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 79
	i32 120558881, ; 4: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 79
	i32 134690465, ; 5: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 96
	i32 160529393, ; 6: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 11
	i32 165246403, ; 7: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 50
	i32 166922606, ; 8: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 21
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 81
	i32 201930040, ; 10: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 12
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 48
	i32 219130465, ; 12: Xamarin.Android.Support.v4 => 0xd0faa61 => 37
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 63
	i32 278686392, ; 14: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 67
	i32 280482487, ; 15: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 61
	i32 318968648, ; 16: Xamarin.AndroidX.Activity.dll => 0x13031348 => 40
	i32 321597661, ; 17: System.Numerics => 0x132b30dd => 6
	i32 342366114, ; 18: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 65
	i32 389971796, ; 19: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 23
	i32 442521989, ; 20: Xamarin.Essentials => 0x1a605985 => 90
	i32 450948140, ; 21: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 60
	i32 465846621, ; 22: mscorlib => 0x1bc4415d => 3
	i32 469710990, ; 23: System.dll => 0x1bff388e => 5
	i32 476646585, ; 24: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 61
	i32 486930444, ; 25: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 72
	i32 514659665, ; 26: Xamarin.Android.Support.Compat => 0x1ead1551 => 21
	i32 524864063, ; 27: Xamarin.Android.Support.Print => 0x1f48ca3f => 34
	i32 527452488, ; 28: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 96
	i32 627609679, ; 29: Xamarin.AndroidX.CustomView => 0x2568904f => 56
	i32 640322727, ; 30: NguyenChiBao.dll => 0x262a8ca7 => 0
	i32 663517072, ; 31: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 86
	i32 666292255, ; 32: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 45
	i32 691348768, ; 33: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 98
	i32 692692150, ; 34: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 18
	i32 700284507, ; 35: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 93
	i32 720511267, ; 36: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 97
	i32 755637338, ; 37: XAB.de.hdodenhof.circleimageview.dll => 0x2d0a1c5a => 10
	i32 790371945, ; 38: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 57
	i32 801787702, ; 39: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 30
	i32 809851609, ; 40: System.Drawing.Common.dll => 0x30455ad9 => 101
	i32 843511501, ; 41: Xamarin.AndroidX.Print => 0x3246f6cd => 75
	i32 882883187, ; 42: Xamarin.Android.Support.v4.dll => 0x349fba73 => 37
	i32 916714535, ; 43: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 34
	i32 928116545, ; 44: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 92
	i32 956575887, ; 45: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 97
	i32 958213972, ; 46: Xamarin.Android.Support.Media.Compat => 0x391d2f54 => 33
	i32 967690846, ; 47: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 65
	i32 987342438, ; 48: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 15
	i32 1012816738, ; 49: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 78
	i32 1035644815, ; 50: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 44
	i32 1052210849, ; 51: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 69
	i32 1084122840, ; 52: Xamarin.Kotlin.StdLib => 0x409e66d8 => 95
	i32 1098167829, ; 53: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 17
	i32 1098259244, ; 54: System => 0x41761b2c => 5
	i32 1149092582, ; 55: Xamarin.AndroidX.Window => 0x447dc2e6 => 89
	i32 1175144683, ; 56: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 84
	i32 1204270330, ; 57: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 45
	i32 1264511973, ; 58: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 80
	i32 1267360935, ; 59: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 85
	i32 1275534314, ; 60: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 98
	i32 1292763917, ; 61: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 25
	i32 1293217323, ; 62: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 59
	i32 1297413738, ; 63: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 14
	i32 1322716291, ; 64: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 89
	i32 1376866003, ; 65: Xamarin.AndroidX.SavedState => 0x52114ed3 => 78
	i32 1395857551, ; 66: Xamarin.AndroidX.Media.dll => 0x5333188f => 73
	i32 1406073936, ; 67: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 52
	i32 1445445088, ; 68: Xamarin.Android.Support.Fragment => 0x5627bde0 => 29
	i32 1469204771, ; 69: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 43
	i32 1574652163, ; 70: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 24
	i32 1582372066, ; 71: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 58
	i32 1587447679, ; 72: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 11
	i32 1622152042, ; 73: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 71
	i32 1624863272, ; 74: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 88
	i32 1636350590, ; 75: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 55
	i32 1639515021, ; 76: System.Net.Http.dll => 0x61b9038d => 100
	i32 1657153582, ; 77: System.Runtime => 0x62c6282e => 8
	i32 1658241508, ; 78: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 82
	i32 1658251792, ; 79: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 91
	i32 1698840827, ; 80: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 94
	i32 1729485958, ; 81: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 49
	i32 1766324549, ; 82: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 81
	i32 1776026572, ; 83: System.Core.dll => 0x69dc03cc => 4
	i32 1788241197, ; 84: Xamarin.AndroidX.Fragment => 0x6a96652d => 60
	i32 1808609942, ; 85: Xamarin.AndroidX.Loader => 0x6bcd3296 => 71
	i32 1813058853, ; 86: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 95
	i32 1813201214, ; 87: Xamarin.Google.Android.Material => 0x6c13413e => 91
	i32 1866717392, ; 88: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 30
	i32 1867746548, ; 89: Xamarin.Essentials.dll => 0x6f538cf4 => 90
	i32 1885316902, ; 90: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 46
	i32 1916660109, ; 91: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 17
	i32 1919157823, ; 92: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 74
	i32 1983156543, ; 93: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 94
	i32 2019465201, ; 94: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 69
	i32 2037417872, ; 95: Xamarin.Android.Support.ViewPager => 0x79708790 => 39
	i32 2044222327, ; 96: Xamarin.Android.Support.Loader => 0x79d85b77 => 31
	i32 2055257422, ; 97: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 66
	i32 2079903147, ; 98: System.Runtime.dll => 0x7bf8cdab => 8
	i32 2090596640, ; 99: System.Numerics.Vectors => 0x7c9bf920 => 7
	i32 2097448633, ; 100: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 62
	i32 2139458754, ; 101: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 28
	i32 2166116741, ; 102: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 24
	i32 2196165013, ; 103: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 38
	i32 2201107256, ; 104: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 99
	i32 2201231467, ; 105: System.Net.Http => 0x8334206b => 100
	i32 2217644978, ; 106: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 84
	i32 2221056120, ; 107: XAB.de.hdodenhof.circleimageview => 0x8462a078 => 10
	i32 2244775296, ; 108: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 72
	i32 2256548716, ; 109: Xamarin.AndroidX.MultiDex => 0x8680336c => 74
	i32 2261435625, ; 110: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 64
	i32 2279755925, ; 111: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 77
	i32 2315684594, ; 112: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 41
	i32 2330457430, ; 113: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 23
	i32 2330986192, ; 114: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 35
	i32 2373288475, ; 115: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 29
	i32 2440966767, ; 116: Xamarin.Android.Support.Loader.dll => 0x917e326f => 31
	i32 2475788418, ; 117: Java.Interop.dll => 0x93918882 => 1
	i32 2487632829, ; 118: Xamarin.Android.Support.DocumentFile => 0x944643bd => 27
	i32 2505896520, ; 119: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 68
	i32 2581819634, ; 120: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 85
	i32 2605712449, ; 121: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 99
	i32 2620871830, ; 122: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 55
	i32 2633051222, ; 123: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 67
	i32 2698266930, ; 124: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 15
	i32 2701096212, ; 125: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 82
	i32 2732626843, ; 126: Xamarin.AndroidX.Activity => 0xa2e0939b => 40
	i32 2737747696, ; 127: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 43
	i32 2751899777, ; 128: Xamarin.Android.Support.Collections => 0xa406a881 => 20
	i32 2770495804, ; 129: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 93
	i32 2778768386, ; 130: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 87
	i32 2788639665, ; 131: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 32
	i32 2788775637, ; 132: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 36
	i32 2810250172, ; 133: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 52
	i32 2819470561, ; 134: System.Xml.dll => 0xa80db4e1 => 9
	i32 2853208004, ; 135: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 87
	i32 2855708567, ; 136: Xamarin.AndroidX.Transition => 0xaa36a797 => 83
	i32 2876493027, ; 137: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 36
	i32 2893257763, ; 138: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 12
	i32 2903344695, ; 139: System.ComponentModel.Composition => 0xad0d8637 => 103
	i32 2905242038, ; 140: mscorlib.dll => 0xad2a79b6 => 3
	i32 2916838712, ; 141: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 88
	i32 2919462931, ; 142: System.Numerics.Vectors.dll => 0xae037813 => 7
	i32 2921128767, ; 143: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 42
	i32 2921692953, ; 144: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 26
	i32 2978675010, ; 145: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 59
	i32 3016983068, ; 146: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 80
	i32 3024354802, ; 147: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 63
	i32 3056250942, ; 148: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 19
	i32 3068715062, ; 149: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 13
	i32 3092211740, ; 150: Xamarin.Android.Support.Media.Compat.dll => 0xb84f681c => 33
	i32 3129973490, ; 151: NguyenChiBao => 0xba8f9af2 => 0
	i32 3204912593, ; 152: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 19
	i32 3211777861, ; 153: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 58
	i32 3233339011, ; 154: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 14
	i32 3247949154, ; 155: Mono.Security => 0xc197c562 => 102
	i32 3258312781, ; 156: Xamarin.AndroidX.CardView => 0xc235e84d => 49
	i32 3267021929, ; 157: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 47
	i32 3296380511, ; 158: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 20
	i32 3317135071, ; 159: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 56
	i32 3321585405, ; 160: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 27
	i32 3340431453, ; 161: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 46
	i32 3345895724, ; 162: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 76
	i32 3352662376, ; 163: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 22
	i32 3353484488, ; 164: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 62
	i32 3357663996, ; 165: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 25
	i32 3362522851, ; 166: Xamarin.AndroidX.Core => 0xc86c06e3 => 54
	i32 3366347497, ; 167: Java.Interop => 0xc8a662e9 => 1
	i32 3374999561, ; 168: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 77
	i32 3405233483, ; 169: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 57
	i32 3429136800, ; 170: System.Xml => 0xcc6479a0 => 9
	i32 3439690031, ; 171: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 18
	i32 3476120550, ; 172: Mono.Android => 0xcf3163e6 => 2
	i32 3493954962, ; 173: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 51
	i32 3501239056, ; 174: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 47
	i32 3547625832, ; 175: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 35
	i32 3567349600, ; 176: System.ComponentModel.Composition.dll => 0xd4a16f60 => 103
	i32 3627220390, ; 177: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 75
	i32 3633644679, ; 178: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 42
	i32 3641597786, ; 179: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 66
	i32 3664423555, ; 180: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 39
	i32 3672681054, ; 181: Mono.Android.dll => 0xdae8aa5e => 2
	i32 3681174138, ; 182: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 13
	i32 3682565725, ; 183: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 48
	i32 3684561358, ; 184: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 51
	i32 3689375977, ; 185: System.Drawing.Common => 0xdbe768e9 => 101
	i32 3706696989, ; 186: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 53
	i32 3714038699, ; 187: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 32
	i32 3718780102, ; 188: Xamarin.AndroidX.Annotation => 0xdda814c6 => 41
	i32 3758932259, ; 189: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 64
	i32 3776062606, ; 190: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 28
	i32 3786282454, ; 191: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 50
	i32 3822602673, ; 192: Xamarin.AndroidX.Media => 0xe3d849b1 => 73
	i32 3829621856, ; 193: System.Numerics.dll => 0xe4436460 => 6
	i32 3832731800, ; 194: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 22
	i32 3862817207, ; 195: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 16
	i32 3874897629, ; 196: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 16
	i32 3885922214, ; 197: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 83
	i32 3888767677, ; 198: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 76
	i32 3896760992, ; 199: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 54
	i32 3921031405, ; 200: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 86
	i32 3955647286, ; 201: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 44
	i32 4063435586, ; 202: Xamarin.Android.Support.CustomView => 0xf2331b42 => 26
	i32 4105002889, ; 203: Mono.Security.dll => 0xf4ad5f89 => 102
	i32 4151237749, ; 204: System.Core => 0xf76edc75 => 4
	i32 4182413190, ; 205: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 70
	i32 4256097574, ; 206: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 53
	i32 4292120959 ; 207: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 70
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [208 x i32] [
	i32 68, i32 92, i32 38, i32 79, i32 79, i32 96, i32 11, i32 50, ; 0..7
	i32 21, i32 81, i32 12, i32 48, i32 37, i32 63, i32 67, i32 61, ; 8..15
	i32 40, i32 6, i32 65, i32 23, i32 90, i32 60, i32 3, i32 5, ; 16..23
	i32 61, i32 72, i32 21, i32 34, i32 96, i32 56, i32 0, i32 86, ; 24..31
	i32 45, i32 98, i32 18, i32 93, i32 97, i32 10, i32 57, i32 30, ; 32..39
	i32 101, i32 75, i32 37, i32 34, i32 92, i32 97, i32 33, i32 65, ; 40..47
	i32 15, i32 78, i32 44, i32 69, i32 95, i32 17, i32 5, i32 89, ; 48..55
	i32 84, i32 45, i32 80, i32 85, i32 98, i32 25, i32 59, i32 14, ; 56..63
	i32 89, i32 78, i32 73, i32 52, i32 29, i32 43, i32 24, i32 58, ; 64..71
	i32 11, i32 71, i32 88, i32 55, i32 100, i32 8, i32 82, i32 91, ; 72..79
	i32 94, i32 49, i32 81, i32 4, i32 60, i32 71, i32 95, i32 91, ; 80..87
	i32 30, i32 90, i32 46, i32 17, i32 74, i32 94, i32 69, i32 39, ; 88..95
	i32 31, i32 66, i32 8, i32 7, i32 62, i32 28, i32 24, i32 38, ; 96..103
	i32 99, i32 100, i32 84, i32 10, i32 72, i32 74, i32 64, i32 77, ; 104..111
	i32 41, i32 23, i32 35, i32 29, i32 31, i32 1, i32 27, i32 68, ; 112..119
	i32 85, i32 99, i32 55, i32 67, i32 15, i32 82, i32 40, i32 43, ; 120..127
	i32 20, i32 93, i32 87, i32 32, i32 36, i32 52, i32 9, i32 87, ; 128..135
	i32 83, i32 36, i32 12, i32 103, i32 3, i32 88, i32 7, i32 42, ; 136..143
	i32 26, i32 59, i32 80, i32 63, i32 19, i32 13, i32 33, i32 0, ; 144..151
	i32 19, i32 58, i32 14, i32 102, i32 49, i32 47, i32 20, i32 56, ; 152..159
	i32 27, i32 46, i32 76, i32 22, i32 62, i32 25, i32 54, i32 1, ; 160..167
	i32 77, i32 57, i32 9, i32 18, i32 2, i32 51, i32 47, i32 35, ; 168..175
	i32 103, i32 75, i32 42, i32 66, i32 39, i32 2, i32 13, i32 48, ; 176..183
	i32 51, i32 101, i32 53, i32 32, i32 41, i32 64, i32 28, i32 50, ; 184..191
	i32 73, i32 6, i32 22, i32 16, i32 16, i32 83, i32 76, i32 54, ; 192..199
	i32 86, i32 44, i32 26, i32 102, i32 4, i32 70, i32 53, i32 70 ; 208..207
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
