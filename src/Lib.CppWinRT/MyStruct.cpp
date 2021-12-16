#include "pch.h"
#include "MyStruct.h"
#include "MyStruct.g.cpp"

#include "Lib.Static.h"

winrt::Lib::CppWinRT::implementation::MyStruct::MyStruct()
    : mNative(std::make_shared<::Lib::Static::MyStruct>())
{
}

double winrt::Lib::CppWinRT::implementation::MyStruct::Add(double x, double y)
{
    return mNative->add(x, y);
}

double winrt::Lib::CppWinRT::implementation::MyStruct::Subtract(double x, double y)
{
    return mNative->subtract(x, y);
}

double winrt::Lib::CppWinRT::implementation::MyStruct::Multiply(double x, double y)
{
    return mNative->multiply(x, y);
}

double winrt::Lib::CppWinRT::implementation::MyStruct::Divide(double x, double y)
{
    return mNative->divide(x, y);
}
