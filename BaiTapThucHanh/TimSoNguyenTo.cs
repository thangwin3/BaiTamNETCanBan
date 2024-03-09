using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapThucHanh
{
    internal class TimSoNguyenTo
    {
        public bool KiemTraNguyenTo(int number)
        {
            if (number >= 2)
            {
                for (int i = 2; i <number; i++)
                {
                    if (number % i == 0)
                        return false;
                }
                return true;
            }
            return false;
        }

    }
}
