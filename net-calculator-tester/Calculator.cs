﻿using System;

namespace net_calculator_tester
{
    public class Calculator
    {
        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        public float Divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }

            return num1 / num2;
        }

        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
