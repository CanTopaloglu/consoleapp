using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOop;
public class User 
{
    //public int Calc(params int[] numbers)  /// Params keyword'ünü kullandık.
    //{
    //    int result = 0;
    //    foreach(var item in numbers)
    //    {
    //        result+= item;
    //    }

    //    return result;

    //}
    public void SetAge(ref int age)
    {
        age += 10;
    }

    public void SetAge2(out int age)
    {
        age = 10;
    }
}




