﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoMarketClient;

namespace Crypto.Core.Indicators {
    public class WindowIndicator : SingleValueIndicator {
        int length = 9;
        [DefaultValue(9)]
        public int Length {
            get { return length; }
            set {
                if(Length == value)
                    return;
                length = value;
                OnPropertiesChanged();
            }
        }
    }
}
