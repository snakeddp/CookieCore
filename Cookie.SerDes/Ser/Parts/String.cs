﻿using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Cookie.IO.Interfaces;
using Cookie.SerDes.Interfaces;

namespace Cookie.SerDes.Ser.Parts
{
    internal class String : ISerializerPart
    {
        public bool Predicat(PropertyInfo property)
        {
            return property.PropertyType == typeof(string);
        }

        public void OnMatch(List<Expression> contentExpressions, PropertyInfo propertyInfo, ParameterExpression paramT,
            ParameterExpression paramWriter)
        {
            var paramProp = Expression.Property(paramT, propertyInfo);

            var mi = typeof(IWriter).GetMethod("WriteValue").MakeGenericMethod(propertyInfo.PropertyType);
            var callWriter = Expression.Call(paramWriter, mi, paramProp);

            contentExpressions.Add(callWriter);
        }
    }
}