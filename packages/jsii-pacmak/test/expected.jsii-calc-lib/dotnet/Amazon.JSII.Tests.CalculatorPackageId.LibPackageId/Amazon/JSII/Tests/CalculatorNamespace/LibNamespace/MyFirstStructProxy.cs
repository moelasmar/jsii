using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace.LibNamespace
{
    /// <summary>This is the first struct we have created in jsii.</summary>
    /// <remarks>
    /// stability: deprecated
    /// </remarks>
    [JsiiTypeProxy(nativeType: typeof(IMyFirstStruct), fullyQualifiedName: "@scope/jsii-calc-lib.MyFirstStruct")]
    [System.Obsolete()]
    internal sealed class MyFirstStructProxy : DeputyBase, IMyFirstStruct
    {
        private MyFirstStructProxy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>An awesome number value.</summary>
        /// <remarks>
        /// stability: deprecated
        /// </remarks>
        [JsiiProperty(name: "anumber", typeJson: "{\"primitive\":\"number\"}")]
        [System.Obsolete()]
        public double Anumber
        {
            get => GetInstanceProperty<double>();
        }

        /// <summary>A string value.</summary>
        /// <remarks>
        /// stability: deprecated
        /// </remarks>
        [JsiiProperty(name: "astring", typeJson: "{\"primitive\":\"string\"}")]
        [System.Obsolete()]
        public string Astring
        {
            get => GetInstanceProperty<string>();
        }

        /// <remarks>
        /// stability: deprecated
        /// </remarks>
        [JsiiProperty(name: "firstOptional", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [System.Obsolete()]
        public string[] FirstOptional
        {
            get => GetInstanceProperty<string[]>();
        }
    }
}
