workspace(
    name = "rulesissue",
)

load("@bazel_tools//tools/build_defs/repo:http.bzl", "http_archive")

http_archive(
    name = "d2l_rules_csharp",
    sha256 = "616caa8a0bcfc622862790198efc6cdeacb0f3c115591b9eded66bffb7f217fd",
    strip_prefix = "rules_csharp-5531b47d7d0f0880a4bcc4c02d68b75845b2dce5",
    urls = [
        "https://github.com/Brightspace/rules_csharp/archive/5531b47d7d0f0880a4bcc4c02d68b75845b2dce5.tar.gz",
    ],
)

load(
    "@d2l_rules_csharp//csharp:defs.bzl",
    "csharp_register_toolchains",
    "csharp_repositories",
    "import_nuget_package",
)

csharp_register_toolchains()
csharp_repositories()
