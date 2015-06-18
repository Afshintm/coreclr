// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using System;

public class bug
{
    public static int Main(String[] args)
    {
        Decimal cur1 = new Decimal(UInt32.MaxValue);
        Console.WriteLine("The decimal value is: " + cur1);
        Console.WriteLine("The decimal value should be: " + UInt32.MaxValue);

        if ((long)cur1 != (long)UInt32.MaxValue)
        {
            Console.WriteLine("Test failed");
            return 1;
        }
        else
        {
            Console.WriteLine("Test passed");
            return 100;
        }
    }
}