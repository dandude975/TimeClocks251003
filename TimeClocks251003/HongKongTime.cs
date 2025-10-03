using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLab251003_2
{
    public class HongKongTime : LocalTime
    {
        public HongKongTime(DateTime lt) : base(lt) { }
        protected override string City => "Hong Kong";
        protected override int OffsetHours => +8;
    }
}
