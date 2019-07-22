using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace FVCCommon
{
    /// <summary>
    /// 通用验证类
    /// </summary>
    class DataValidate
    {


        /// <summary>
        /// 验证是否是数字(带上小数一起验证)
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsNumber(string txt) {
            Regex objRegNumber = new Regex(@"^[1-9]\d*$");
            Regex objRegDecimal = new Regex(@"^[0-9]*[.][0-9]+$");
            bool isNumber = objRegNumber.IsMatch(txt);
            bool isDecimal = objRegDecimal.IsMatch(txt);
            if (isNumber || isDecimal)
            {
                return true;
            }
            else {
                return false;
            }
        }

        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsInteger(string txt)
        {
            Regex objReg = new Regex(@"^[1-9]\d*$");
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// 验证是否是Email
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsEmail(string txt)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// 验证身份证
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsIdentityCard(string txt)
        {
            Regex objReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return objReg.IsMatch(txt);
        }
    }
}
