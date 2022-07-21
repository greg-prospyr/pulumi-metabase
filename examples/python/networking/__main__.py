import pulumi
import pulumi_metabase as metabase

metabase_service = metabase.Metabase("metabaseService",
    vpc_id="vpc-123",
    networking=metabase.NetworkingArgs(
        ecs_subnet_ids=[
            "subnet-123",
            "subnet-456",
        ],
        db_subnet_ids=[
            "subnet-789",
            "subnet-abc",
        ],
        lb_subnet_ids=[
            "subnet-def",
            "subnet-ghi",
        ],
    ))
pulumi.export("url", metabase_service.dns_name)
