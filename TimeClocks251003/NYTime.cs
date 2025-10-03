using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLab251003_2
{
    public class NYTime : LocalTime
    {
        public NYTime(DateTime lt) : base(lt) { }
        protected override string City => "New York";
        protected override int OffsetHours => -5;
    }
}
