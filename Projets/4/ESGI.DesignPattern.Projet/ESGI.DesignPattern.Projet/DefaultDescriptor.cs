using System;

namespace ESGI.DesignPattern.Projet
{
    public class DefaultDescriptor : AttributeDescriptor
    {

        public DefaultDescriptor(string descriptorName, Type mapperType, Type forType)
            : base(descriptorName, mapperType, forType)
        {
        }
    }
}