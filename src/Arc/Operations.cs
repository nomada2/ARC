﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arc
{
    public static class Operations
    {
        public static NumberValue Negate(IValue operand)
        {
            return NumberValue.Create(operand.ImplicitConversionToNumberValue().Value);
        }

        public static NumberValue Add(IValue left, IValue right)
        {
            return NumberValue.Create(left.ImplicitConversionToNumberValue().Value + right.ImplicitConversionToNumberValue().Value);
        }

        public static NumberValue Subtract(IValue left, IValue right)
        {
            return NumberValue.Create(left.ImplicitConversionToNumberValue().Value - right.ImplicitConversionToNumberValue().Value);
        }

        public static NumberValue Multiply(IValue left, IValue right)
        {
            return NumberValue.Create(left.ImplicitConversionToNumberValue().Value * right.ImplicitConversionToNumberValue().Value);
        }

        public static NumberValue Divide(IValue left, IValue right)
        {
            return NumberValue.Create(left.ImplicitConversionToNumberValue().Value / right.ImplicitConversionToNumberValue().Value);
        }

        public static NumberValue Modulus(IValue left, IValue right)
        {
            return NumberValue.Create(left.ImplicitConversionToNumberValue().Value % right.ImplicitConversionToNumberValue().Value);
        }

        public static StringValue Concatenate(IValue left, IValue right)
        {
            return StringValue.Create(left.ImplicitConversionToStringValue().Value + right.ImplicitConversionToStringValue().Value);
        }

        public static BoolValue Not(IValue operand)
        {
            return BoolValue.Create(!operand.ImplicitConversionToBoolValue().Value);
        }

        public static BoolValue And(IValue left, IValue right)
        {
            return BoolValue.Create(left.ImplicitConversionToBoolValue().Value && right.ImplicitConversionToBoolValue().Value);
        }

        public static BoolValue Or(IValue left, IValue right)
        {
            return BoolValue.Create(left.ImplicitConversionToBoolValue().Value || right.ImplicitConversionToBoolValue().Value);
        }
    }
}