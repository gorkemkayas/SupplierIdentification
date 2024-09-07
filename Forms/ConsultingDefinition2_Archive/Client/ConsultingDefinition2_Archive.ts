export default class ConsultingDefinition2_Archive extends Form.SYNERGY {

	async ctxConsultingDefinition_OnShowing(args: Controls.EventArgs.IContextMenuOnShowingEventArgs) {
         const hideStatus: boolean = args.targetArgs.row.data['ACTIVITY'];
        
        args.contextMenuItems.forEach(( item ) => {
            if (item.name === "MakePassive") {
                item.visible = hideStatus;
            }
            else if ( item.name === "MakeActive" ) {
                item.visible = !hideStatus;
            }
            else if ( item.name === "Delete" ) {
                item.visible = true;
            }
            else if ( item.name === "Edit" ) {
                item.visible = true;
            }
            else if ( item.name === "View" ) {
                item.visible = true;
            }
            else {
                item.visible = hideStatus;
            }
        });

        await this.applyChanges();
	}

	async ctxConsultingDefinition_OnItemClick(args: Controls.EventArgs.IContextMenuItemClickEventArgs) {
        if (args.baseArgs.data.key === "Edit") {
            this.openForm({
                projectName: "SupplierIdentification",
                documentId: args.targetArgs.row.data.DOCUMENTID,
                typeName: "OpenFormArgs",
                showOn: "drawer", 
                parameters: [
                    { type: "string", name: "Mode", value: "Update" },
                    { type: "number", name: "DOCUMENTID", value: args.targetArgs.row.data.DOCUMENTID }
                ]
            });

        }
        else if (args.baseArgs.data.key === "Delete") {
            this.deleteItem(args, "DeleteConsultingDefinition", this.ConsultingDefinition2_Archive_Grid);
        }
        else if (args.baseArgs.data.key === "MakeActive") {
            const culture = this.__form.currentLanguage.culture;
            let title = "Warning";
            let message = "The selected record will be activated. Do you want to continue?";
            if (culture === "tr-TR") {
                title = "Uyarı";
                message = "Seçili kayıt aktif edilecektir. Devam etmek istiyor musunuz?";
            }
            args.baseArgs.cancel = true;
            return await this.showConfirm(title, message).then(() => {
                this.fetch.post("DataSource/UpdateConsultingDefinition", { DocumentId: args.targetArgs.row.data.DOCUMENTID }).then(result => {
                    this.ConsultingDefinition2_Archive_Grid.reload(true);
                    this.applyChanges();
                });
            }).catch(() => {
                args.baseArgs.cancel = true;
            });

        }
        else if (args.baseArgs.data.key === "MakePassive") {
            const culture = this.__form.currentLanguage.culture;
            let title = "Warning";
            let message = "The selected record will be disabled. Do you want to continue?";
            if (culture === "tr-TR") {
                title = "Uyarı";
                message = "Seçili kayıt pasif edilecektir. Devam etmek istiyor musunuz?";
            }
            args.baseArgs.cancel = true;
            return await this.showConfirm(title, message).then(() => {
                this.fetch.post("DataSource/UpdateConsultingDefinition", { DocumentId: args.targetArgs.row.data.DOCUMENTID }).then(result => {
                    this.ConsultingDefinition2_Archive_Grid.reload(true);
                    this.applyChanges();
                });
            }).catch(() => {
                args.baseArgs.cancel = true;
            });

        }
        else if (args.baseArgs.data.key === "Copy") {
            this.openForm({
                projectName: "SupplierIdentification",
                typeName: "OpenFormArgs",
                documentId: args.targetArgs.row.data.DOCUMENTID,
                isSaveAsForm: true,
                showOn: "drawer",
                size: 1,
                parameters: [
                    { type: "string", name: "Mode", value: "Copy" },
                    { type: "number", name: "Id", value: args.targetArgs.row.data.DOCUMENTID }
                ]
            });
        }
	}

	async ConsultingDefinition2_Archive_OnMessageReceived(args: Controls.EventArgs.IMessageReceivedEventArgs) {
        this.ConsultingDefinition2_Archive_Grid.reload(true);
	}

	async ConsultingDefinition2_Archive_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
        await this.applyChanges().then(() => this.FILTERPARAMS.value = "1");
	}

	async ConsultingDefinition2_Archive_OnToolbarButtonClicked(args: Controls.EventArgs.IToolbarButtonClickEventArgs) {
        if(args.name === "New")
        {
            this.createForm(
                {
                    formName: "ConsultingDefinition",
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
        if (args.name === "listPassive") {
            this.toolbarButtons.find(x => x.name === "listPassive").enabled = false;
            this.toolbarButtons.find(x => x.name === "closePassive").enabled = true;
            // this.SupplyPageLast2_Archive_Grid.columns.find(x => x.name === "ACTIVITY1").visible = true;
            this.FILTERPARAMS.value = "0";
            this.ConsultingDefinition2_Archive_Grid.reload(true);
        }
        if (args.name === "closePassive") {
            this.toolbarButtons.find(x => x.name === "closePassive").enabled = false;
            this.toolbarButtons.find(x => x.name === "listPassive").enabled = true;
            // this.SupplyPageLast2_Archive_Grid.columns.find(x => x.name === "ACTIVITY1").visible = false;
            this.FILTERPARAMS.value = "1";
            this.ConsultingDefinition2_Archive_Grid.reload(true);
        }
	}

}