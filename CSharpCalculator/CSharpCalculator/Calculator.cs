using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpCalculator {
    static class Calculator {
        // Returns string. Calculate the result of a single operator maths expression
        public static string Calculate(char _oper, double _first, double _second) {
            string answer = Constants.ZERO;
            //perform the correct maths operation
            switch (_oper) {
                case Constants.SIGN_POWER:
                    answer = Power(_first, _second);
                    break;
                case Constants.SIGN_MULTIPLY:
                    answer = Multiply(_first, _second);
                    break;
                case Constants.SIGN_DIVIDE:
                    answer = Divide(_first, _second);
                    break;
                case Constants.SIGN_MODULO:
                    answer = Modulo(_first, _second);
                    break;
                case Constants.SIGN_PLUS:
                    answer = Add(_first, _second);
                    break;
                case Constants.SIGN_MINUS:
                    answer = Subtract(_first, _second);
                    break;
            }

            return answer;
        }
        #region Operations
        //Try to multiply two doubles
        private static string Multiply(double _first, double _second) {
            try {
                string result = checked(_first * _second).ToString();
                return result;
            } catch (OverflowException) {
                return Constants.ERR_OUT_OF_RANGE;
            }
        }
        //Try to divide two doubles
        private static string Divide(double _first, double _second) {
            if (_second == 0) {
                return Constants.ERR_DIVIDE_BY_ZERO;
            }
            try {
                string result = checked(_first / _second).ToString();
                return result;
            } catch (OverflowException) {
                return Constants.ERR_OUT_OF_RANGE;
            }
        }
        //Try to get the modulus of two doubles
        private static string Modulo(double _first, double _second) {
            if (_second == 0) {
                return Constants.ERR_DIVIDE_BY_ZERO;
            }
            try {
                string result = checked(_first % _second).ToString();
                return result;
            } catch (OverflowException) {
                return Constants.ERR_OUT_OF_RANGE;
            }
        }
        //Try to add two doubles
        private static string Add(double _first, double _second) {
            try {
                string result = checked(_first + _second).ToString();
                return result;
            } catch (OverflowException) {
                return Constants.ERR_OUT_OF_RANGE;
            }
        }
        //Try to subract a double from another double
        private static string Subtract(double _first, double _second) {
            try {
                string result = checked(_first - _second).ToString();
                return result;
            } catch (OverflowException) {
                return Constants.ERR_OUT_OF_RANGE;
            }
        }
        //Try to multiply a double (_first) by itself (_second) times
        private static string Power(double _first, double _second) {
            try {
                string result = checked(Math.Pow(_first, _second).ToString());
                return result;
            } catch (OverflowException) {
                return Constants.ERR_OUT_OF_RANGE;
            }
        }
        #endregion
    }
}
