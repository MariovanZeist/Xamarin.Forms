using Android.Runtime;

[assembly: ResourceDesigner("Xamarin.Forms.Platform.Android.Resource", IsApplication = false)]

namespace Xamarin.Forms.Platform.Android
{
	public class Resource
	{
		static Resource()
		{
			ResourceIdManager.UpdateIdValues();
		}

		public class Attribute
		{
			// aapt resource value: 0x7f0100a5
			// ReSharper disable once InconsistentNaming
			// Android is pretty insistent about this casing
			public static int actionBarSize = 2130772133;

			// aapt resource value: 0x7f010001
			public static int vpiCentered = 2130771969;
			
			// aapt resource value: 0x7f010000
			public static int vpiCirclePageIndicatorStyle = 2130771968;
			
			// aapt resource value: 0x7f010006
			public static int vpiFillColor = 2130771974;
			
			// aapt resource value: 0x7f010003
			public static int vpiOrientation = 2130771971;
			
			// aapt resource value: 0x7f010002
			public static int vpiPageColor = 2130771970;
			
			// aapt resource value: 0x7f010005
			public static int vpiRadius = 2130771973;
			
			// aapt resource value: 0x7f010004
			public static int vpiSnap = 2130771972;
			
			// aapt resource value: 0x7f010007
			public static int vpiStrokeColor = 2130771975;
			
			// aapt resource value: 0x7f010008
			public static int vpiStrokeWidth = 2130771976;

			static Attribute()
			{
				ResourceIdManager.UpdateIdValues();
			}

			Attribute()
			{
			}
		}

		public partial class Boolean
		{
			
			// aapt resource value: 0x7f040000
			public static int default_circle_indicator_centered = 2130968576;
			
			// aapt resource value: 0x7f040001
			public static int default_circle_indicator_snap = 2130968577;
			
			static Boolean()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Boolean()
			{
			}
		}
		
		public partial class Color
		{
			
			// aapt resource value: 0x7f030008
			public static int default_circle_indicator_fill_color = 2130903048;
			
			// aapt resource value: 0x7f030009
			public static int default_circle_indicator_page_color = 2130903049;
			
			// aapt resource value: 0x7f03000a
			public static int default_circle_indicator_stroke_color = 2130903050;
			
			// aapt resource value: 0x7f030000
			public static int vpi__background_holo_dark = 2130903040;
			
			// aapt resource value: 0x7f030001
			public static int vpi__background_holo_light = 2130903041;
			
			// aapt resource value: 0x7f030004
			public static int vpi__bright_foreground_disabled_holo_dark = 2130903044;
			
			// aapt resource value: 0x7f030005
			public static int vpi__bright_foreground_disabled_holo_light = 2130903045;
			
			// aapt resource value: 0x7f030002
			public static int vpi__bright_foreground_holo_dark = 2130903042;
			
			// aapt resource value: 0x7f030003
			public static int vpi__bright_foreground_holo_light = 2130903043;
			
			// aapt resource value: 0x7f030006
			public static int vpi__bright_foreground_inverse_holo_dark = 2130903046;
			
			// aapt resource value: 0x7f030007
			public static int vpi__bright_foreground_inverse_holo_light = 2130903047;
			
			static Color()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Color()
			{
			}
		}
		
		public partial class Dimension
		{
			
			// aapt resource value: 0x7f060000
			public static int default_circle_indicator_radius = 2131099648;
			
			// aapt resource value: 0x7f060001
			public static int default_circle_indicator_stroke_width = 2131099649;
			
			static Dimension()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Dimension()
			{
			}
		}
		
		public partial class Id
		{
			
			// aapt resource value: 0x7f080000
			public static int horizontal = 2131230720;
			
			// aapt resource value: 0x7f080003
			public static int indicator = 2131230723;
			
			// aapt resource value: 0x7f080002
			public static int pager = 2131230722;
			
			// aapt resource value: 0x7f080001
			public static int vertical = 2131230721;
			
			static Id()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Id()
			{
			}
		}
		
		public partial class Integer
		{
			
			// aapt resource value: 0x7f050000
			public static int default_circle_indicator_orientation = 2131034112;
			
			static Integer()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Integer()
			{
			}
		}
		
		public partial class Layout
		{
			
			// aapt resource value: 0x7f020000
			public static int horizontal_viewpager = 2130837504;
			
			// aapt resource value: 0x7f020001
			public static int vertical_viewpager = 2130837505;
			
			static Layout()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Layout()
			{
			}
		}
		
		public partial class Style
		{
			
			// aapt resource value: 0x7f070000
			public static int Theme_PageIndicatorDefaults = 2131165184;
			
			// aapt resource value: 0x7f070001
			public static int Widget = 2131165185;
			
			// aapt resource value: 0x7f070002
			public static int Widget_CirclePageIndicator = 2131165186;
			
			static Style()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Style()
			{
			}
		}
		
		public partial class Styleable
		{
			
			public static int[] CirclePageIndicator = new int[]
			{
					2130771969,
					2130771970,
					2130771971,
					2130771972,
					2130771973,
					2130771974,
					2130771975,
					2130771976};
			
			// aapt resource value: 0
			public static int CirclePageIndicator_vpiCentered = 0;
			
			// aapt resource value: 5
			public static int CirclePageIndicator_vpiFillColor = 5;
			
			// aapt resource value: 2
			public static int CirclePageIndicator_vpiOrientation = 2;
			
			// aapt resource value: 1
			public static int CirclePageIndicator_vpiPageColor = 1;
			
			// aapt resource value: 4
			public static int CirclePageIndicator_vpiRadius = 4;
			
			// aapt resource value: 3
			public static int CirclePageIndicator_vpiSnap = 3;
			
			// aapt resource value: 6
			public static int CirclePageIndicator_vpiStrokeColor = 6;
			
			// aapt resource value: 7
			public static int CirclePageIndicator_vpiStrokeWidth = 7;
			
			public static int[] ViewPagerIndicator = new int[]
			{
					2130771968};
			
			// aapt resource value: 0
			public static int ViewPagerIndicator_vpiCirclePageIndicatorStyle = 0;
			
			static Styleable()
			{
				global::Android.Runtime.ResourceIdManager.UpdateIdValues();
			}
			
			private Styleable()
			{
			}
		}
	}
}