﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Web.XmlTransform.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Web.XmlTransform.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; was found in more than one assembly.
        /// </summary>
        internal static string XMLTRANSFORMATION_AmbiguousTypeMatch {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_AmbiguousTypeMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transform and Locator attributes must contain only a type name, or a type name followed by a list of attributes in parentheses..
        /// </summary>
        internal static string XMLTRANSFORMATION_BadAttributeValue {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_BadAttributeValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Fatal syntax error.
        /// </summary>
        internal static string XMLTRANSFORMATION_FatalTransformSyntaxError {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_FatalTransformSyntaxError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import tag cannot have both a &apos;path&apos; and an &apos;assembly&apos;.
        /// </summary>
        internal static string XMLTRANSFORMATION_ImportAttributeConflict {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_ImportAttributeConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import tag must have a &apos;path&apos; or an &apos;assembly&apos;.
        /// </summary>
        internal static string XMLTRANSFORMATION_ImportMissingAssembly {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_ImportMissingAssembly", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import tag must have a &apos;namespace&apos;.
        /// </summary>
        internal static string XMLTRANSFORMATION_ImportMissingNamespace {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_ImportMissingNamespace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Import tag does not support &apos;{0}&apos; attribute.
        /// </summary>
        internal static string XMLTRANSFORMATION_ImportUnknownAttribute {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_ImportUnknownAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a type of {1}.
        /// </summary>
        internal static string XMLTRANSFORMATION_IncorrectBaseType {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_IncorrectBaseType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No element in the source document matches &apos;{0}&apos;.
        /// </summary>
        internal static string XMLTRANSFORMATION_InsertBadXPath {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_InsertBadXPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; does not evaluate to an element.
        /// </summary>
        internal static string XMLTRANSFORMATION_InsertBadXPathResult {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_InsertBadXPathResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} requires an XPath argument.
        /// </summary>
        internal static string XMLTRANSFORMATION_InsertMissingArgument {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_InsertMissingArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many arguments to {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_InsertTooManyArguments {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_InsertTooManyArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot comment out the whole XML document.
        /// </summary>
        internal static string XMLTRANSFORMATION_InvalidCommentOutTarget {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_InvalidCommentOutTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No attribute &apos;{0}&apos; exists for the Match Locator.
        /// </summary>
        internal static string XMLTRANSFORMATION_MatchAttributeDoesNotExist {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_MatchAttributeDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; must have a no-argument constructor to be instantiated by the transformation engine.
        /// </summary>
        internal static string XMLTRANSFORMATION_NoValidConstructor {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_NoValidConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} requires exactly {1} arguments.
        /// </summary>
        internal static string XMLTRANSFORMATION_RequiresExactArguments {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_RequiresExactArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} requires at least {1} arguments.
        /// </summary>
        internal static string XMLTRANSFORMATION_RequiresMinimumArguments {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_RequiresMinimumArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Too many arguments for {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TooManyArguments {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TooManyArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Argument &apos;{0}&apos; did not match any attributes.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformArgumentFoundNoAttributes {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformArgumentFoundNoAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformBeginExecutingMessage {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformBeginExecutingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} does not expect arguments; ignoring.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformDoesNotExpectArguments {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformDoesNotExpectArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Done executing {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformEndExecutingMessage {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformEndExecutingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error during {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformErrorExecutingMessage {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformErrorExecutingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Commented out &apos;{0}&apos; element.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageCommentOut {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageCommentOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inserted &apos;{0}&apos; element.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageInsert {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No attributes found to remove.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageNoRemoveAttributes {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageNoRemoveAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No attributes found to set.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageNoSetAttributes {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageNoSetAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed &apos;{0}&apos; element.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageRemove {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageRemove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed &apos;{0}&apos; attribute.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageRemoveAttribute {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageRemoveAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removed {0} attributes.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageRemoveAttributes {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageRemoveAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replaced &apos;{0}&apos; element.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageReplace {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageReplace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set &apos;{0}&apos; attribute.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageSetAttribute {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageSetAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set {0} attributes.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformMessageSetAttributes {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformMessageSetAttributes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} (transform line {1}, {2}).
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformNameFormatLong {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformNameFormatLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformNameFormatShort {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformNameFormatShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No element in the source document matches &apos;{0}&apos;.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformNoMatchingTargetNodes {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformNoMatchingTargetNodes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not executing {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformNotExecutingMessage {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformNotExecutingMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found multiple target elements, but the &apos;{0}&apos; Transform only applies to the first match.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformOnlyAppliesOnce {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformOnlyAppliesOnce", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; did not find a match, because matching nodes in the source document were modified or removed by a previous transform.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformSourceMatchWasRemoved {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformSourceMatchWasRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Applying to &apos;{0}&apos; element (source line {1}, {2}).
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformStatusApplyTarget {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformStatusApplyTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Applying to &apos;{0}&apos; element (no source line info).
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformStatusApplyTargetNoLineInfo {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformStatusApplyTargetNoLineInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to on {0}.
        /// </summary>
        internal static string XMLTRANSFORMATION_TransformStatusXPath {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_TransformStatusXPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not resolve &apos;{0}&apos; as a type of {1}.
        /// </summary>
        internal static string XMLTRANSFORMATION_UnknownTypeName {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_UnknownTypeName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown tag &apos;{0}&apos;.
        /// </summary>
        internal static string XMLTRANSFORMATION_UnknownXdtTag {
            get {
                return ResourceManager.GetString("XMLTRANSFORMATION_UnknownXdtTag", resourceCulture);
            }
        }
    }
}
