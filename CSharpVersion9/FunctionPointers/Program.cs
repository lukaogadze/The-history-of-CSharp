// See https://aka.ms/new-console-template for more information


//This method has a managed calling convention. This is the same as leaving the managed keyword off.

unsafe
{
    // delegate* managed<int, int>;

// This method will be invoked using whatever the default unmanaged calling convention on the runtime
// platform is. This is platform and architecture dependent and is determined by the CLR at runtime.
    // delegate* unmanaged<int, int>;

// This method will be invoked using the cdecl calling convention
// Cdecl maps to System.Runtime.CompilerServices.CallConvCdecl
    // delegate* unmanaged[Cdecl] <int, int>;

// This method will be invoked using the stdcall calling convention, and suppresses GC transition
// Stdcall maps to System.Runtime.CompilerServices.CallConvStdcall
// SuppressGCTransition maps to System.Runtime.CompilerServices.CallConvSuppressGCTransition
    // delegate* unmanaged[Stdcall, SuppressGCTransition] <int, int>;

    Console.WriteLine("Hello, World!");
}

unsafe class Example {
    Example(Action<int> a, delegate*<int, void> f) {
        a(42);
        f(42);
    }
}