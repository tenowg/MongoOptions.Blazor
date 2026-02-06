using Microsoft.AspNetCore.Components;
using MongoOptions.Blazor.Areas.UI;
using MongoOptions.Blazor.Components.Fragments;
using MongoOptions.Interfaces;
using System.Linq.Expressions;
using MongoOptions.Types;

namespace MongoOptions.Blazor.Fragments
{
    /// <summary>
    /// Provides render fragments for properties in Blazor components.
    /// </summary>
    public class Fragments
    {
        /// <summary>
        /// Creates a render fragment for a numeric property using a dynamic number component.
        /// </summary>
        /// <typeparam name="NType">The numeric type.</typeparam>
        /// <typeparam name="TBackingType">The type of the backing object.</typeparam>
        /// <param name="backingObject">The object containing the property.</param>
        /// <param name="prop">The property info for the numeric property.</param>
        /// <returns>A render fragment for the number input.</returns>
        public static RenderFragment NumberFragment<NType, TBackingType>(TBackingType backingObject, PropertyMetadata prop) => __builder =>
        {
            __builder.OpenComponent<DynamicNumber<NType>>(0);
            __builder.AddAttribute(1, "Target", backingObject);
            __builder.AddAttribute(2, "Property", prop);
            __builder.AddAttribute(3, "Expression", (Expression<Func<NType>>)prop.ExpressionFactory(backingObject));
            __builder.CloseComponent();
        };

        /// <summary>
        /// Creates a render fragment for an enum property using a dynamic enum component.
        /// </summary>
        /// <typeparam name="NType">The enum type.</typeparam>
        /// <typeparam name="TBackingType">The type of the backing object.</typeparam>
        /// <param name="backingObject">The object containing the property.</param>
        /// <param name="prop">The property info for the enum property.</param>
        /// <returns>A render fragment for the enum input.</returns>
        public static RenderFragment EnumFragment<NType, TBackingType>(TBackingType backingObject, PropertyMetadata prop) => __builder =>
        {
            // this is done to avoid constrants (struct, Enum) on the method.
            List<NType> names = [];
            foreach (NType value in Enum.GetValues(typeof(NType)))
            {
                names.Add(value);
            }

            __builder.OpenComponent<DynamicEnum<NType>>(0);
            __builder.AddAttribute(1, "Target", backingObject);
            __builder.AddAttribute(2, "Property", prop);
            __builder.AddAttribute(3, "Expression", (Expression<Func<NType>>)prop.ExpressionFactory(backingObject));
            __builder.AddAttribute(4, "Items", names);
            __builder.AddAttribute(5, "Current", prop.Getter(backingObject));
            __builder.CloseComponent();
        };

        public static RenderFragment ConfigSelectorFragment<NType>() where NType : class, IConfigFile, new() => __builder =>
        {
            __builder.OpenComponent<ConfigSelector<NType>>(0);
            __builder.CloseComponent();
        };
    }
}
