using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Nevercrack.Properties
{
	// Token: 0x02000005 RID: 5
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020D1 File Offset: 0x000002D1
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00003428 File Offset: 0x00001628
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("Nevercrack.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000011 RID: 17 RVA: 0x00003470 File Offset: 0x00001670
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020DB File Offset: 0x000002DB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00003488 File Offset: 0x00001688
		internal static Bitmap e54029b9525dd7ca11296572d52edae5bccb13a4
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("e54029b9525dd7ca11296572d52edae5bccb13a4", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000034B8 File Offset: 0x000016B8
		internal static Bitmap photo_1530533718754_001d2668365a
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("photo-1530533718754-001d2668365a", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x0400001A RID: 26
		private static ResourceManager resourceMan;

		// Token: 0x0400001B RID: 27
		private static CultureInfo resourceCulture;
	}
}
