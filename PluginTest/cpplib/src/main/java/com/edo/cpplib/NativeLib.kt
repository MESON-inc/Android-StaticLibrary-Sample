package com.edo.cpplib

class NativeLib {

    /**
     * A native method that is implemented by the 'cpplib' native library,
     * which is packaged with this application.
     */
    external fun stringFromJNI(): String

    companion object {
        // Used to load the 'cpplib' library on application startup.
        init {
            System.loadLibrary("cpplib")
        }
    }
}