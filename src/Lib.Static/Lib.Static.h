#pragma once

namespace Lib
{
    namespace Static
    {
        struct MyStruct
        {
            MyStruct() = default;
            double add(double x, double y);
            double subtract(double x, double y);
            double multiply(double x, double y);
            double divide(double x, double y);
        };
    }
}
