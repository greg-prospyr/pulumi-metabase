// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Metabase.Inputs
{

    /// <summary>
    /// The email configuration (if any) for Metabase.
    /// 
    /// Adding email integration enables users to set alerts and system notifications.
    /// 
    /// https://www.metabase.com/docs/latest/administration-guide/02-setting-up-email.html
    /// </summary>
    public sealed class EmailConfigArgs : Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("port")]
        public Input<double>? Port { get; set; }

        [Input("security")]
        public Input<string>? Security { get; set; }

        [Input("username")]
        public Input<string>? Username { get; set; }

        public EmailConfigArgs()
        {
        }
    }
}
