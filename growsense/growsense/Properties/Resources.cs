using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TrainerBase.Properties
{
	// Token: 0x02000008 RID: 8
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00018EC5 File Offset: 0x000170C5
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00018ED0 File Offset: 0x000170D0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager temp = new ResourceManager("TrainerBase.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = temp;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00018F18 File Offset: 0x00017118
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00018F2F File Offset: 0x0001712F
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
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00018F38 File Offset: 0x00017138
		internal static Bitmap unknown
		{
			get
			{
				object obj = Resources.ResourceManager.GetObject("unknown", Resources.resourceCulture);
				return (Bitmap)obj;
			}
		}

		// Token: 0x040001B6 RID: 438
		internal static byte[] dummy;

		// Token: 0x040001B7 RID: 439
		private static ResourceManager resourceMan;

		// Token: 0x040001B8 RID: 440
		private static CultureInfo resourceCulture;
	}
}
