#include "pch.h"
#include "MyStruct.h"
#include "MyStruct.g.cpp"

#include "Lib.Static.h"

winrt::MyLib::implementation::MyStruct::MyStruct()
    : mNative(std::make_shared<::MyLib::MyStruct>())
{
}

double winrt::MyLib::implementation::MyStruct::Add(double x, double y)
{
    return mNative->add(x, y);
}

double winrt::MyLib::implementation::MyStruct::Substract(double x, double y)
{
    return mNative->substract(x, y);
}

double winrt::MyLib::implementation::MyStruct::Multiply(double x, double y)
{
    return mNative->multiply(x, y);
}

double winrt::MyLib::implementation::MyStruct::Divide(double x, double y)
{
    return mNative->divide(x, y);
}
