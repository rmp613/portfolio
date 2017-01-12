using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace CSharpCalculator {
    class InputParser {
        public static string CalculateResult(List<Char> _input) {
            List<Char> input = _input;
            List<double> numbers = new List<double>();
            List<Char> operators = new List<Char>();

            // If last char is an operator return and log 
            if (Util.IsOperator(input[input.Count - 1])) {
                return Constants.ERR_INVALID_DOUBLE;
            }

            //fill number and operator lists and check for invalid input errors
            numbers = GetNumbers(input);
            if (numbers.Count <= 0) {
                return Constants.ERR_INVALID_DOUBLE;
            }
            operators = GetOperators(input);
            if (operators.Count != numbers.Count - 1) {
                return Constants.ERR_INVALID_DOUBLE;
            }

            //Resolve expressions starting with high priority expressions
            return ResolveExpressions(numbers, operators, Constants.HIGH_PASS);
        }
        //Handles any operators that shouldnt be input to the display for Form1
        public static string HandleNonWritable(string _operator, string _txt) {
            if (_operator == Constants.CLEAR_ENTRY) {
                if (_txt.Length > 1) {
                    _txt = _txt.Remove(_txt.Length - 1);
                } else {
                    _txt = Constants.ZERO;
                }
            } else if (_operator == Constants.CLEAR) {
                _txt = Constants.ZERO;
            } else if (_operator == Constants.SIGN_EQUALS) {
                _txt = CalculateResult(_txt.ToList<Char>());
            } else {
                _txt = Constants.ERR_INVALID_DOUBLE;
            }
            return _txt;
        }
        // Returns string. This method resolves high priority expressions and then 
        // recursively calls itself to resolve leftover expressions
        private static string ResolveExpressions(
            List<double> _numbers, 
            List<Char> _operators, 
            int _pass) {

            int pass = _pass;
            int end = _operators.Count;
            bool isOperator = false;

            for (int i = 0; i < end; i++) {
                Char o = _operators[i];
                // decide on which operator type to check for based on pass
                switch (pass) {
                    case Constants.HIGH_PASS:
                        isOperator = Util.IsHighPriorityOperator(o);
                        break;
                    case Constants.MED_PASS:
                        isOperator = Util.IsMediumPriorityOperator(o);
                        break;
                    case Constants.LOW_PASS:
                        isOperator = Util.IsLowPriorityOperator(o);
                        break;
                }

                // if o is an operator then get the numbers on either side, calculate the result
                // and replace the expression in the numbers and operators lists
                if (isOperator) {
                    string newNumber = Calculator.Calculate(o, _numbers[i], _numbers[i + 1]);
                    if (Util.IsNumeric(newNumber)) {
                        _numbers[i] = Double.Parse(newNumber);
                        _numbers.RemoveAt(i + 1);
                        _operators.RemoveAt(i);
                        i--;
                        end--;
                    } else
                        return Constants.SIGN_INFINITY;
                }
            }

            //decrement pass to check for lower priority operators
            pass--;
            //recursively call this method if pass > 0  otherwise return result
            if (pass > 0)
                return ResolveExpressions(_numbers, _operators, pass);
            else
                return _numbers[0].ToString();
        }
        // Returns a List<Char> filled with the operators contained within _input
        private static List<Char> GetOperators(List<Char> _input) {
            List<Char> operators = new List<Char>();

            // Iterate through _input and fill operators list
            // i starts at one to avoid adding a possible and allowed + or - sign at the start
            for (int i = 1; i < _input.Count; i++) {
                Char c = _input[i];
                if (Util.IsOperator(c)) {
                    operators.Add(c);
                    i++;
                }
            }
            return operators;
        }
        // Returns a List<double> filled with the numbers contained within _input
        private static List<double> GetNumbers(List<Char> _input) {
            List<double> numbers = new List<double>();
            double? firstNumber = GetNumber(_input, 0);

            // Make sure there is a number before there is a non-sign operator
            if (!firstNumber.HasValue)
                return new List<double>();

            numbers.Add(firstNumber.Value);

            //iterate through _input to fill the numbers list
            for (int i = 1; i < _input.Count; i++) {
                if (Util.IsOperator(_input[i])) {
                    i++;
                    double? number = GetNumber(_input, i);
                    if (!number.HasValue)
                        return new List<double>();

                    numbers.Add(number.Value);
                }
            }
            return numbers;
        }
        // Returns a double? from a List<Char> by taking the Chars between operators
        private static double? GetNumber(List<Char> _input, int _index) {
            string s = Constants.EMPTY;
            double number = 0;
            int sign = 1;
            bool alreadyDecimal = false;

            //checks for a second operator which doesnt belong
            if (Util.IsHighPriorityOperator(_input[_index]) || Util.IsMediumPriorityOperator(_input[_index]))
                return null;

            // Checks for an + or - which changes the sign of the result number
            if (Util.IsLowPriorityOperator(_input[_index])) {
                sign = _input[_index] == '-' ? -1 : 1;
                _index++;
            }

            // Loops through _input and adds each digit of the number to a string
            while (!Util.IsOperator(_input[_index])) {
                if (Util.IsDecimalPoint(_input[_index])) {
                    if (alreadyDecimal) {
                        return null;
                    } else {
                        alreadyDecimal = true;
                        if (s.Length == 0)
                            s = Constants.ZERO;
                    }
                }
                s += _input[_index];
                if (_index < _input.Count - 1)
                    _index++;
                else if (_index == _input.Count - 1) break;
            }
            if (!double.TryParse(s, out number))
                return null;
            return number * sign;
        }
    }
}
