package md52fd5744bb98f748d9267fe5c02814c81;


public class MapElementsRenderer
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_draw:(Landroid/graphics/Canvas;)V:GetDraw_Landroid_graphics_Canvas_Handler\n" +
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Maps.MapElementsRenderer, Syncfusion.SfMaps.Android", MapElementsRenderer.class, __md_methods);
	}


	public MapElementsRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MapElementsRenderer.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Maps.MapElementsRenderer, Syncfusion.SfMaps.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MapElementsRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MapElementsRenderer.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Maps.MapElementsRenderer, Syncfusion.SfMaps.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MapElementsRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MapElementsRenderer.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Maps.MapElementsRenderer, Syncfusion.SfMaps.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public MapElementsRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == MapElementsRenderer.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Maps.MapElementsRenderer, Syncfusion.SfMaps.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public void draw (android.graphics.Canvas p0)
	{
		n_draw (p0);
	}

	private native void n_draw (android.graphics.Canvas p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
