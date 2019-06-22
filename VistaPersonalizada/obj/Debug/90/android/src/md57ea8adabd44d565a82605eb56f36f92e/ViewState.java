package md57ea8adabd44d565a82605eb56f36f92e;


public class ViewState
	extends android.preference.Preference.BaseSavedState
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_writeToParcel:(Landroid/os/Parcel;I)V:GetWriteToParcel_Landroid_os_Parcel_IHandler\n" +
			"n_InitializeCreator:()Lmd57ea8adabd44d565a82605eb56f36f92e/ViewStateCreator;:__export__\n" +
			"";
		mono.android.Runtime.register ("VistaPersonalizada.ViewState, VistaPersonalizada", ViewState.class, __md_methods);
	}


	public ViewState (android.os.Parcel p0)
	{
		super (p0);
		if (getClass () == ViewState.class)
			mono.android.TypeManager.Activate ("VistaPersonalizada.ViewState, VistaPersonalizada", "Android.OS.Parcel, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public ViewState (android.os.Parcelable p0)
	{
		super (p0);
		if (getClass () == ViewState.class)
			mono.android.TypeManager.Activate ("VistaPersonalizada.ViewState, VistaPersonalizada", "Android.OS.IParcelable, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	private static md57ea8adabd44d565a82605eb56f36f92e.ViewStateCreator CREATOR = InitializeCreator ();


	public void writeToParcel (android.os.Parcel p0, int p1)
	{
		n_writeToParcel (p0, p1);
	}

	private native void n_writeToParcel (android.os.Parcel p0, int p1);

	private static md57ea8adabd44d565a82605eb56f36f92e.ViewStateCreator InitializeCreator ()
	{
		return n_InitializeCreator ();
	}

	private static native md57ea8adabd44d565a82605eb56f36f92e.ViewStateCreator n_InitializeCreator ();

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
