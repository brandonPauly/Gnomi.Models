
using gnomi.dataService.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace gnomi.dataService.metadata
{
    public class humanMetadata<t> : iHumanMetadata<t>
    {
        private PropertyInfo[] _properties;
        private iEntity<t> _entity;

        public void refresh(iEntity<t> entity)
        {
            _entity = entity;
            _properties = entity.GetType().GetProperties();
        }
        public string name => "human";
        public string parameterNames => $"({ String.Join(',', _properties.Where(prop => prop.GetValue(_entity) != null && prop.Name != "metadata").Select(prop => "@" + prop.Name)) })";
        public string attributeNames => $"({ String.Join(',', _properties.Where(prop => prop.GetValue(_entity) != null && prop.Name != "metadata").Select(n => n.Name)) })";

        public IEnumerable<string> getAttributeNames => _properties.Where(prop => prop.GetValue(_entity) != null && prop.Name != "metadata").Select(n => n.Name);
    }
}
