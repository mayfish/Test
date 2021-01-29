using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    /*
     * 身分證字號區域碼所對應的數值
     */
    public enum AreaCode : int
    {
        [Description("台北市")]
        A = 10,
        [Description("台中市")]
        B = 11,
        [Description("基隆市")]
        C = 12,
        [Description("台南市")]
        D = 13,
        [Description("高雄市")]
        E = 14,
        [Description("台北縣")]
        F = 15,
        [Description("宜蘭縣")]
        G = 16,
        [Description("桃園縣")]
        H = 17,
        [Description("嘉義市")]
        I = 34,
        [Description("新竹縣")]
        J = 18,
        [Description("苗栗縣")]
        K = 19,
        [Description("台中縣")]
        L = 20,
        [Description("南投縣")]
        M = 21,
        [Description("彰化縣")]
        N = 22,
        [Description("新竹市")]
        O = 35,
        [Description("雲林縣")]
        P = 23,
        [Description("嘉義縣")]
        Q = 24,
        [Description("台南縣")]
        R = 25,
        [Description("高雄縣")]
        S = 26,
        [Description("屏東縣")]
        T = 27,
        [Description("花蓮縣")]
        U = 28,
        [Description("台東縣")]
        V = 29,
        [Description("金門縣")]
        W = 32,
        [Description("澎湖縣")]
        X = 30,
        [Description("陽明山")]
        Y = 31,
        [Description("連江縣")]
        Z = 33,
    }
}
