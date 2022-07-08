// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Metabase
{
    [MetabaseResourceType("metabase:index:Metabase")]
    public partial class Metabase : Pulumi.ComponentResource
    {
        /// <summary>
        /// The DNS name for the Metabase instance.
        /// </summary>
        [Output("dnsName")]
        public Output<string> DnsName { get; private set; } = null!;

        /// <summary>
        /// The security group id for the Metabase instance.
        /// </summary>
        [Output("securityGroupId")]
        public Output<string> SecurityGroupId { get; private set; } = null!;


        /// <summary>
        /// Create a Metabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Metabase(string name, MetabaseArgs args, ComponentResourceOptions? options = null)
            : base("metabase:index:Metabase", name, args ?? new MetabaseArgs(), MakeResourceOptions(options, ""), remote: true)
        {
        }

        private static ComponentResourceOptions MakeResourceOptions(ComponentResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new ComponentResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = ComponentResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class MetabaseArgs : Pulumi.ResourceArgs
    {
        [Input("dbSubnetIds", required: true)]
        private InputList<string>? _dbSubnetIds;

        /// <summary>
        /// The subnets to use for the RDS instance.
        /// </summary>
        public InputList<string> DbSubnetIds
        {
            get => _dbSubnetIds ?? (_dbSubnetIds = new InputList<string>());
            set => _dbSubnetIds = value;
        }

        /// <summary>
        /// The domain name on which to serve Metabase.  Must be a subdomain of the hostedZoneId.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        [Input("ecsSubnetIds", required: true)]
        private InputList<string>? _ecsSubnetIds;

        /// <summary>
        /// The subnets to use for the Fargate task.
        /// </summary>
        public InputList<string> EcsSubnetIds
        {
            get => _ecsSubnetIds ?? (_ecsSubnetIds = new InputList<string>());
            set => _ecsSubnetIds = value;
        }

        /// <summary>
        /// The email configuration (if any) for Metabase.
        /// 
        /// Adding email integration enables users to set alerts and system notifications.
        /// 
        /// https://www.metabase.com/docs/latest/administration-guide/02-setting-up-email.html
        /// </summary>
        [Input("emailConfig")]
        public Input<Inputs.EmailConfigArgs>? EmailConfig { get; set; }

        /// <summary>
        /// A hosted zone name in which to provision DNS records.
        /// </summary>
        [Input("hostedZoneName", required: true)]
        public Input<string> HostedZoneName { get; set; } = null!;

        [Input("lbSubnetIds", required: true)]
        private InputList<string>? _lbSubnetIds;

        /// <summary>
        /// The subnets to use for the load balancer.
        /// </summary>
        public InputList<string> LbSubnetIds
        {
            get => _lbSubnetIds ?? (_lbSubnetIds = new InputList<string>());
            set => _lbSubnetIds = value;
        }

        /// <summary>
        /// The version of Metabase to run - used as a tag on the `metabase/metabase` Dockerhub image.
        /// </summary>
        [Input("metabaseVersion")]
        public Input<string>? MetabaseVersion { get; set; }

        /// <summary>
        /// Client ID for OIDC auth for the load balancer.
        /// </summary>
        [Input("oidcClientId", required: true)]
        public Input<string> OidcClientId { get; set; } = null!;

        /// <summary>
        /// Client secret for OIDC auth for the load balancer.
        /// </summary>
        [Input("oidcClientSecret", required: true)]
        public Input<string> OidcClientSecret { get; set; } = null!;

        /// <summary>
        /// The VPC to use for the Metabase cluster.
        /// </summary>
        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public MetabaseArgs()
        {
        }
    }
}
