using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator {
    static class Util {
        //Check if a string means a button is non-writable to output
        public static bool IsWritable(string txt) {
            return (
                txt == Constants.SIGN_EQUALS ||
                txt == Constants.CLEAR_ENTRY ||
                txt == Constants.CLEAR
                ) ? false : true;
        }
        //Check if a string can be parsed into a double and therefore if it is numeric
        public static bool IsNumeric(string str) {
            double d;
            return Double.TryParse(str, out d);
        }
        //Check if a character is a decimal point
        public static bool IsDecimalPoint(Char _c) {
            return (_c == Constants.DECIMAL_POINT) ? true : false;
        }
        //Check if a character is a maths operator
        public static bool IsOperator(Char _c) {
            return (
                _c == Constants.SIGN_PLUS || 
                _c == Constants.SIGN_MINUS ||
                _c == Constants.SIGN_MULTIPLY ||
                _c == Constants.SIGN_DIVIDE ||
                _c == Constants.SIGN_POWER ||
                _c == Constants.SIGN_MODULO
                ) ? true : false;
        }
        //Check if a character is a maths operator
        public static bool ContainsErrorMsg(string _str) {
            return (
                _str.Contains(Constants.ERR_DIVIDE_BY_ZERO) ||
                _str.Contains(Constants.ERR_INVALID_DOUBLE) ||
                _str.Contains(Constants.ERR_OUT_OF_RANGE)
                ) ? true : false;
        }
        //Check if a character is a low priority operator
        public static bool IsLowPriorityOperator(Char _c) {
            return (
                _c == Constants.SIGN_PLUS ||
                _c == Constants.SIGN_MINUS
                ) ? true : false;
        }
        //Check if a character is a medium priority operator
        public static bool IsMediumPriorityOperator(Char _c) {
            return (
                _c == Constants.SIGN_MULTIPLY ||
                _c == Constants.SIGN_DIVIDE ||
                _c == Constants.SIGN_MODULO
                ) ? true : false;
        }
        //Check if a character is a high priority operator
        public static bool IsHighPriorityOperator(Char _c) {
            return (_c == Constants.SIGN_POWER) ? true : false;
        }
    }
}
