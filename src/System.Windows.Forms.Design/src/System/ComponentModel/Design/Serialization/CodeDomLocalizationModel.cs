//------------------------------------------------------------------------------
// <copyright file="CodeDomLocalizationModel.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------
namespace System.ComponentModel.Design.Serialization
{

    /// <include file='doc\CodeDomLocalizationModel.uex' path='docs/doc[@for="CodeDomLocalizationModel"]/*' />
    /// <summary>
    ///  Determines the localization model to be used by the CodeDom resource adapter.
    /// </summary>
    public enum CodeDomLocalizationModel
    {

        /// <include file='doc\CodeDomLocalizationModel.uex' path='docs/doc[@for="CodeDomLocalizationModel.None"]/*' />
        /// <summary>
        ///  Indicates that the localization provider should ignore localized properties.  It
        ///  will still write out resources for objects that do not support code generation and are
        ///  serializable.
        /// </summary>
        None = 0,

        /// <include file='doc\CodeDomLocalizationModel.uex' path='docs/doc[@for="CodeDomLocalizationModel.PropertyAssignment"]/*' />
        /// <summary>
        ///  Indicates that the localization provider will write out localizaed properties by assigning a resource to
        ///  each property.  This model is fast when the number of properties is small, but scales poorly
        ///  as the number of properties containing default values grows.
        /// </summary>
        PropertyAssignment = 1,

        /// <include file='doc\CodeDomLocalizationModel.uex' path='docs/doc[@for="CodeDomLocalizationModel.PropertyReflection"]/*' />
        /// <summary>
        ///  Indicates that the localization provider will write localized property values into a resource file and
        ///  use the ComponentResourceManager class to reflect on properties by name to fill
        ///  them at runtime.  This uses reflection at runtime so it can be slow, but it scales better for
        ///  large numbers of properties with default values.
        /// </summary>
        PropertyReflection = 2
    }
}
