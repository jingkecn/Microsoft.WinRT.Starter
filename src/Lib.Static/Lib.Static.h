#pragma once

namespace MyLib
{
    struct MyStruct
    {
        MyStruct() = default;
        double add(double x, double y);
        double substract(double x, double y);
        double multiply(double x, double y);
        double divide(double x, double y);
    };
}