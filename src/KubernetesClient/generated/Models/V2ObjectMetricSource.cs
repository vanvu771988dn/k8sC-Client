// <auto-generated>
// Code generated by https://github.com/kubernetes-client/csharp/tree/master/gen/KubernetesGenerator
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    /// <summary>
    /// ObjectMetricSource indicates how to scale on a metric describing a kubernetes
        /// object (for example, hits-per-second on an Ingress object).
    /// </summary>
    public partial class V2ObjectMetricSource
    {
        /// <summary>
        /// Initializes a new instance of the V2ObjectMetricSource class.
        /// </summary>
        public V2ObjectMetricSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2ObjectMetricSource class.
        /// </summary>
        /// <param name="describedObject">
        /// describedObject specifies the descriptions of a object,such as kind,name
        /// apiVersion
        /// </param>
        /// <param name="metric">
        /// metric identifies the target metric by name and selector
        /// </param>
        /// <param name="target">
        /// target specifies the target value for the given metric
        /// </param>
        public V2ObjectMetricSource(V2CrossVersionObjectReference describedObject, V2MetricIdentifier metric, V2MetricTarget target)
        {
            DescribedObject = describedObject;
            Metric = metric;
            Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// describedObject specifies the descriptions of a object,such as kind,name
        /// apiVersion
        /// </summary>
        [JsonPropertyName("describedObject")]
        public V2CrossVersionObjectReference DescribedObject { get; set; }

        /// <summary>
        /// metric identifies the target metric by name and selector
        /// </summary>
        [JsonPropertyName("metric")]
        public V2MetricIdentifier Metric { get; set; }

        /// <summary>
        /// target specifies the target value for the given metric
        /// </summary>
        [JsonPropertyName("target")]
        public V2MetricTarget Target { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DescribedObject == null)
            {
                throw new ArgumentNullException("DescribedObject");    
            }
            if (Metric == null)
            {
                throw new ArgumentNullException("Metric");    
            }
            if (Target == null)
            {
                throw new ArgumentNullException("Target");    
            }
            DescribedObject?.Validate();
            Metric?.Validate();
            Target?.Validate();
        }
    }
}