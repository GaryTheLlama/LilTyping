using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Otter;

namespace LilTyping
{
    public static class EntityFactory
    {
        public static Entity GetEntity(string entityName)
        {
            entityName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(entityName);

            Assembly currentAssembly = Assembly.GetExecutingAssembly();

            Object[] args = { 50.0f, 50.0f };
            var currentType = currentAssembly.GetTypes().SingleOrDefault(t => t.Name == entityName);

            return (Entity)Activator.CreateInstance(currentType, args);
        }
    }
}
