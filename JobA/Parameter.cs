﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobA {
    public class Parameter {

        [Description("姓名")]
        public string Name {
            get;
            set;
        }

        [Description("年级")]
        public int Grade {
            get;
            set;
        }

        [Description("生日")]
        public DateTime Birthday {
            get;
            set;
        }

        [Description("成绩")]
        public decimal Score {
            get;
            set;
        }

        [Description("上次成绩")]
        public int? PreScore {
            get;
            set;
        }
    }
}
