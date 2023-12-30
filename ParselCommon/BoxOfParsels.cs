using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GIT_TEAM.ParselCommon
{
    public class BoxOfParsels : ICloneable
    {
       public List<Parsel> parsels;

        BoxOfParsels(BoxOfParsels boxOfParsels)
        {
            this.parsels = boxOfParsels.parsels;
        }

        public object Clone()
        {
            BoxOfParsels clone = new BoxOfParsels(this);
            return clone;
        }
    }
}
