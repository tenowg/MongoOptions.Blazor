using System.Linq.Expressions;
using System.Reflection;

namespace MongoOptions.Blazor.Extensions
{
    /// <summary>
    /// Provides extension methods for PropertyInfo to create lambda expressions for Blazor components.
    /// </summary>
    public static class MongoBlazorPropertyExtensions
    {
        extension(PropertyInfo prop)
        {
            /// <summary>
            /// Creates a lambda expression for accessing a property of a specific type.
            /// </summary>
            /// <typeparam name="TProp">The type of the property value.</typeparam>
            /// <param name="SettingsObject">The object containing the property.</param>
            /// <returns>A lambda expression that accesses the property.</returns>
            public Expression<Func<TProp>> CreateLambda<TProp>(object SettingsObject)
            {
                var constant = Expression.Constant(SettingsObject);
                var property = Expression.Property(constant, prop.Name);

                Expression finalExpression = property;
                if (prop.PropertyType != typeof(TProp))
                {
                    finalExpression = Expression.Call(property, typeof(object).GetMethod("ToString")!);
                }

                return Expression.Lambda<Func<TProp>>(finalExpression);
            }

            /// <summary>
            /// Creates a lambda expression for accessing a property with a specified type.
            /// </summary>
            /// <param name="SettingsObject">The object containing the property.</param>
            /// <param name="type">The expected type of the property value.</param>
            /// <returns>A lambda expression that accesses the property.</returns>
            public Expression<Func<object>> CreateLambda(object SettingsObject, Type type)
            {
                var constant = Expression.Constant(SettingsObject);
                var property = Expression.Property(constant, prop.Name);

                Expression finalExpression = property;
                if (prop.PropertyType != type)
                {
                    finalExpression = Expression.Call(property, typeof(object).GetMethod("ToString")!);
                }

                return Expression.Lambda<Func<object>>(finalExpression);
            }
        }
    }
}
