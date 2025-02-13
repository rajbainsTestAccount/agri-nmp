#!/usr/bin/env bash
set -e
#export OCP_PIPELINE_CLI_VERSION='0.0.4'
export OCP_PIPELINE_CLI_URL="https://raw.githubusercontent.com/BainsConsultingInc/ocp-cd-pipeline/master/src/main/resources/pipeline-cli"

curl -sSL "${OCP_PIPELINE_CLI_URL}" | bash -s deploy --config=config.groovy --pr=1 --env=prod
