using System;
using System.Collections.Generic;
using System.Text;

namespace EnchantmentCalculator
{
    class lifeCP1
    {
        public double fs_amount { get; set; }
        public static readonly lifeCP1 Instance = new lifeCP1();
        public static double Percentage(double fs_amount)
        {
            if (fs_amount <= 14)
            {
                return (fs_amount * 3) + 30;
            }
            else
            {
                return ((fs_amount - 14) * .6) + 72;
            }
        }

    }
    class lifeCP2
    {
        public double fs_amount { get; set; }
        public static readonly lifeCP2 Instance = new lifeCP2();
        public static double Percentage(double fs_amount)
        {
            if (fs_amount <= 40)
            {
                return fs_amount + 10;
            }
            else
            {
                return ((fs_amount - 40) * .2) + 50;
            }
        }

    }
    class lifeCP3
    {
        public double fs_amount { get; set; }
        public static readonly lifeCP3 Instance = new lifeCP3();
        public static double Percentage(double fs_amount)
        {
            if (fs_amount <= 44)
            {
                return (fs_amount * .75) + 7.5;
            }
            else
            {
                return ((fs_amount - 44) * .15) + 40.5;
            }
        }

    }
    class lifeCP4
    {
        public double fs_amount { get; set; }
        public static readonly lifeCP4 Instance = new lifeCP4();
        public static double Percentage(double fs_amount)
        {
            if (fs_amount <= 110)
            {
                return (fs_amount * .25) + 2.5;
            }
            else
            {
                return ((fs_amount - 110) * .05) + 30;
            }
        }

    }
    class lifeCP5
    {
        public double fs_amount { get; set; }
        public static readonly lifeCP5 Instance = new lifeCP5();
        public static double Percentage(double fs_amount)
        {
            return (fs_amount * .05) + .5;
        }

    }
}
