using System;
namespace Dev;

public class logic
{
    public static string run(string s1, string s2)
    {
        var calc = new Calc();
        var zxc = s1.Split(' ');
        var zxc1 = s2.Split(' ');

        int x = int.Parse(zxc[0]);
        int a = int.Parse(zxc1[0]);
        int b = int.Parse(zxc1[1]);

        if (x == 1)
        {
            return calc.plus_(a, b).ToString();
        }

        if (x == 2)
        {
            return calc.minus_(a, b).ToString();
        }

        if (x == 3)
        {
            return calc.umnozh(a, b).ToString();
        }

        if (x == 4)
        {
            if (b == 0)
            {
                return "We cant / on 0!!";
            }
            else
            {
                return calc.razd(a, b).ToString();
            }
        }

        return "";
    }
}