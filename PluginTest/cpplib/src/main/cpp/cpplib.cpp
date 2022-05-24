#include <jni.h>
#include <string>

extern "C" int Add(int a, int b)
{
    return a + b;
}

extern "C" JNIEXPORT jstring JNICALL
Java_com_edo_cpplib_NativeLib_stringFromJNI(
        JNIEnv* env,
        jobject /* this */) {
    std::string hello = "Hello from C++";
    return env->NewStringUTF(hello.c_str());
}