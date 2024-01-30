using System;

using R5T.T0143;


namespace R5T.T0243
{
    /// <summary>
    /// Attribute indicating an class type is a test article implementation type.
    /// Test article implementation types must be an classes, and should implement a test article implementation interface type.
    /// These implementations call either:
    /// 1. Functionality methods instances, or
    /// 2. Service defintion methods
    /// in order to implement their test article interfaces.
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of test article implementation types.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    [MarkerAttributeMarker]
    public class TestArticleImplementationMarkerAttribute : Attribute,
        IMarkerAttributeMarker
    {
        /// <summary>
        /// Allows specifying that a type is *not* a test article type.
        /// This is useful for marking types that end up canonical test article implementation type code file locations, but are not actually test article implementation types.
        /// </summary>
        public bool IsTestArticleImplementation { get; }


        public TestArticleImplementationMarkerAttribute(
            bool isTestArticleImplementation = true)
        {
            this.IsTestArticleImplementation = isTestArticleImplementation;
        }
    }
}
