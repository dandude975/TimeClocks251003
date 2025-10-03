using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLab251003_2
{
    public class LondonTime : LocalTime
    {
            public LondonTime(DateTime lt) : base(lt) { }
            protected override string City => "London";
            protected override int OffsetHours => 0;
    }
}
