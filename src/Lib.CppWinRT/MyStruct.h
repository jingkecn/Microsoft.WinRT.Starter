#pragma once

#include "MyStruct.g.h"

namespace Lib::Static
{
    struct MyStruct;
}

namespace winrt::Lib::CppWinRT::implementation
{
    struct MyStruct : MyStructT<MyStruct>
    {
        MyStruct();
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Divide(double x, double y);
    private:
        std::shared_ptr<::Lib::Static::MyStruct> mNative;
    };
}

namespace winrt::Lib::CppWinRT::factory_implementation
{
    struct MyStruct : MyStructT<MyStruct, implementation::MyStruct>
    {
    };
}
