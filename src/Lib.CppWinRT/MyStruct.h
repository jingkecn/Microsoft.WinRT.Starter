#pragma once

#include "MyStruct.g.h"

namespace MyLib
{
    struct MyStruct;
}

namespace winrt::MyLib::implementation
{
    struct MyStruct : MyStructT<MyStruct>
    {
        MyStruct();
        double Add(double x, double y);
        double Substract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    private:
        std::shared_ptr<::MyLib::MyStruct> mNative;
    };
}

namespace winrt::MyLib::factory_implementation
{
    struct MyStruct : MyStructT<MyStruct, implementation::MyStruct>
    {
    };
}
