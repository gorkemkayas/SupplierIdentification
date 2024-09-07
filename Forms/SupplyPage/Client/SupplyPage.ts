export default class SupplyPage extends Form.Designer {

	async SupplyPage_OnChildFormReturn(args: Controls.EventArgs.IChildFormReturnEventArgs) {
	}

	async SolutionSelect_OnClick(args: Controls.EventArgs.IClickEventArgs) {
	}

	async SupplyPage_OnMessageReceived(args: Controls.EventArgs.IMessageReceivedEventArgs) {

	}

	async SupplyPage_OnToolbarButtonClicked(args: Controls.EventArgs.IToolbarButtonClickEventArgs) {
        if(args.name === "AddNewSolution")
        {
            this.createForm(
                {
                    formName: "SolutionEdit",
                    projectName: "SupplierIdentification",
                    typeName: "CreateFormArgs",
                    isDataEntryForm: false,
                    validate: true,
                    showOn: "drawer",
                    size: 2,
                    parameters: [{type: "string", name: "Mode", value: "Insert"}]
                }
            )
        }
	}

}