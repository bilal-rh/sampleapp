#!/bin/bash
# This script has basic build deploy steps
red='\033[0;31m'

green='\033[0;32m'

blue='\033[0;34m'

echo -e "${green} \n\nMake sure below pre-reqs are installed...Cancel if they are not"
#oc apply -f pipeline-operator.yaml
echo -e "${blue} \n1.OpenShift GitOps Operator"
sleep 3





#Create new project/namespace
APP_NAME="s2i-dotnet"
CICD_PROJECT="mashraf-dev"


# create task to deploy using oc client 
echo -e "${green} \n\napply manifest & update deploy task..."
oc apply -f apply-manifest-task.yaml
oc apply -f update-deployment-task.yaml




# apply cluster level configs such as cluster menu links etc
echo -e "${green} \n\nCreating basic dotnet pipeline..."
oc apply -f pipeline.yaml


# create trigger, bindings and evnt listener
echo -e "${green} \n\napply manifest task..."
oc apply -f trigger-binding-listner.yaml
oc expose svc el-app-eventlistener

echo -e "${green} \n\n Use below url to configure event listerner in git repo settings..."
echo "URL: $(oc get route el-app-eventlistener --template='http://{{.spec.host}}')"
# configure webhook 


