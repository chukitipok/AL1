using System;
using System.Collections.Generic;
using Xunit;

namespace ESGI.DesignPattern.Projet.Tests
{
    public class Tests
    {
        TestingDescriptorMapper testDescriptorMapper;

        public  Tests()
        {
            testDescriptorMapper = new TestingDescriptorMapper();
        }

        [Fact]
        public void it_maps_remoteId_descriptor_as_DefaultDescriptor()
        {
            var remoteIdDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("remoteId");

            Assert.IsType<DefaultDescriptor>(remoteIdDescriptor);
        }

        [Fact]
        public void it_maps_createdDate_descriptor_as_DefaultDescriptor()
        {
            var createdDateDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("createdDate");

            Assert.IsType<DefaultDescriptor>(createdDateDescriptor);
        }

        [Fact]
        public void it_maps_lastChangedDate_descriptor_as_DefaultDescriptor()
        {
            var lastChangedDateDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("lastChangedDate");

            Assert.IsType<DefaultDescriptor>(lastChangedDateDescriptor);
        }

        [Fact]
        public void it_maps_createdBy_descriptor_as_ReferenceDescriptor()
        {
            var createdByDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("createdBy");

            Assert.IsType<ReferenceDescriptor>(createdByDescriptor);
        }

        [Fact]
        public void it_maps_lastChangedBy_descriptor_ReferenceDescriptor()
        {
            var lastChangedByDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("lastChangedBy");

            Assert.IsType<ReferenceDescriptor>(lastChangedByDescriptor);
        }

        [Fact]
        public void it_maps_optimisticLockVersion_descriptor_as_DefaultDescriptor()
        {
            var optimisticLockVersionDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("optimisticLockVersion");

            Assert.IsType<DefaultDescriptor>(optimisticLockVersionDescriptor);
        }

        [Fact]
        public void it_does_not_map_unknown_descriptors()
        {
            var unknownDescriptor =
                testDescriptorMapper.GetMappedDescriptorFor("unknown");

            Assert.Null(unknownDescriptor);
        }
    }

    internal class TestingDescriptorMapper : DescriptorMapper
    {
        List<AttributeDescriptor> descriptors;

        public TestingDescriptorMapper()
        {
            descriptors = CreateAttributeDescriptors();
        }

        public AttributeDescriptor GetMappedDescriptorFor(string descriptorName)
        {
            return descriptors.Find(descriptor => descriptor.DescriptorName == descriptorName);
        }
    }
}

