# Contact Database Application

This is a guide on how to create an Azure Resource Manager (ARM) template for deploying the Contact Database Application to Azure, and how to set up a GitHub Actions workflow for continuous integration and deployment.

## Creating the ARM Template

1. Create a new file in your repository named `deploy.json`.
2. Copy the contents of the ARM template provided in the `deploy.json` file in this repository into your new file.
3. Customize the parameters in the `parameters` section of the template to fit your needs. For example, you might want to change the `name` and `appServicePlanName` parameters to match the names you want to use for your App Service and App Service Plan, respectively.

## Creating the GitHub Actions Workflow

1. In your repository, create a new directory named `.github`, and inside it, another directory named `workflows`.
2. Inside the `workflows` directory, create a new file named `azure.yml`.
3. Copy the contents of the GitHub Actions workflow provided in the `azure.yml` file in this repository into your new file.
4. Customize the workflow to fit your needs. For example, you might want to change the `AZURE_WEBAPP_NAME` and `AZURE_WEBAPP_PACKAGE_PATH` environment variables to match the name of your App Service and the path to your application code, respectively.

## Deploying the Application

To deploy the application, you can use the `deploy.json` ARM template and the `azure.yml` GitHub Actions workflow. When you push changes to your repository, the GitHub Actions workflow will automatically build your application, deploy the ARM template to Azure, and then deploy your application code to the App Service created by the template.

For more information on how to use ARM templates and GitHub Actions, see the [Azure Resource Manager documentation](https://docs.microsoft.com/en-us/azure/azure-resource-manager/templates/) and the [GitHub Actions documentation](https://docs.github.com/en/actions).