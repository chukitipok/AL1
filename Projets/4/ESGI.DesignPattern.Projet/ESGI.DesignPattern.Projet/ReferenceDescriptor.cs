using System;

namespace ESGI.DesignPattern.Projet
{
    public class ReferenceDescriptor: AttributeDescriptor
    {

        public ReferenceDescriptor(string descriptorName, Type mapperType, Type forType)
            : base(descriptorName, mapperType, forType)
        {
        }
    }
}