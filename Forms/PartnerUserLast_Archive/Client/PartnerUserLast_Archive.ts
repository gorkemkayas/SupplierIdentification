export default class PartnerUserLast_Archive extends Form.Designer {

	async PartnerUserLast_Archive_OnMessageReceived(args: Controls.EventArgs.IMessageReceivedEventArgs) {
        this.PartnerUserLast_Archive_Grid.reload(true);
	}

	async PartnerUserLast_Archive_OnToolbarButtonClicked(args: Controls.EventArgs.IToolbarButtonClickEventArgs) {
        if(args.name === "New")
        {
            this.createForm(
                {
                    formName: "PartnerUser",
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