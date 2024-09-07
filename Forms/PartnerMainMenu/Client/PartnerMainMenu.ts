export default class PartnerMainMenu extends Form.SYNERGY {

	async PartnerProduct1_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
	}

	async PartnerMainMenu_OnChildFormReturn(args: Controls.EventArgs.IChildFormReturnEventArgs) {
        const PartnerInformation = await this.fetch.post("DataSource/GetPartnerInformation");
        if(PartnerInformation != null)
        {
            this.PartnerInfo1.text.setText(PartnerInformation.data["result"][0]["PARTNERCOMPANYNAME"]);
            this.PartnerInfo2.text.setText(PartnerInformation.data["result"][0]["PARTNERWEBADDRESS"]);
            this.PartnerInfo3.text.setText(
                PartnerInformation.data["result"][0]["STREET"] + " " +
                PartnerInformation.data["result"][0]["NEIGHBOURHOOD"] + " " +
                PartnerInformation.data["result"][0]["ADDRESSNUMBER"]
                );
            this.PartnerInfo4.text.setText(
                PartnerInformation.data["result"][0]["PROVINCE"] + "/" +
                PartnerInformation.data["result"][0]["DISTRICT"]);


            this.PartnerProduct1.text.setText(PartnerInformation.data["result"][0]["BEAM"]);
            this.PartnerProduct2.text.setText(PartnerInformation.data["result"][0]["QDMS"]);
            this.PartnerProduct3.text.setText(PartnerInformation.data["result"][0]["CSP"]);
            this.PartnerProduct4.text.setText(PartnerInformation.data["result"][0]["ENSEMBLE"]);
            this.PartnerProduct5.text.setText(PartnerInformation.data["result"][0]["EBA"]);
            this.PartnerProduct6.text.setText(PartnerInformation.data["result"][0]["SYNERGY"]);

            this.FirmNumber.text.setText(PartnerInformation.data["result"][0]["FIRMNUMBER"]);
            this.FaxNumber.text.setText(PartnerInformation.data["result"][0]["FAXNUMBER"]);
            this.MusteriTemsilciNo.text.setText(PartnerInformation.data["result"][0]["MaskInput3"]);

            this.AccountantAddress.text.setText(PartnerInformation.data["result"][0]["ACCOUNTANTADDRESS"]);
            this.AccountantNumber.text.setText(PartnerInformation.data["result"][0]["AccountantNumber"]);

        }
        else
        {
            this.showToaster("Veri Hatası","Veritabanından veri sağlanamadı.","Error");
        }
        await this.applyChanges();
	}
    
	async PartnerMainMenu_OnLoad(args: Controls.EventArgs.ILoadEventArgs) 
    {
        const PartnerInformation = await this.fetch.post("DataSource/GetPartnerInformation");
        if(PartnerInformation != null)
        {
            this.PartnerInfo1.text.setText(PartnerInformation.data["result"][0]["PARTNERCOMPANYNAME"]);
            this.PartnerInfo2.text.setText(PartnerInformation.data["result"][0]["PARTNERWEBADDRESS"]);
            this.PartnerInfo3.text.setText(
                PartnerInformation.data["result"][0]["STREET"] + " " +
                PartnerInformation.data["result"][0]["NEIGHBOURHOOD"] + " " +
                PartnerInformation.data["result"][0]["ADDRESSNUMBER"]
                );
            this.PartnerInfo4.text.setText(
                PartnerInformation.data["result"][0]["PROVINCE"] + "/" +
                PartnerInformation.data["result"][0]["DISTRICT"]);
                
            this.PartnerProduct1.text.setText(PartnerInformation.data["result"][0]["BEAM"]);
            this.PartnerProduct2.text.setText(PartnerInformation.data["result"][0]["QDMS"]);
            this.PartnerProduct2.customClassName = "certificateGold";
            this.PartnerProduct3.text.setText(PartnerInformation.data["result"][0]["CSP"]);
            this.PartnerProduct4.text.setText(PartnerInformation.data["result"][0]["ENSEMBLE"]);
            this.PartnerProduct5.text.setText(PartnerInformation.data["result"][0]["EBA"]);
            this.PartnerProduct6.text.setText(PartnerInformation.data["result"][0]["SYNERGY"]);

            this.FirmNumber.text.setText(PartnerInformation.data["result"][0]["FIRMNUMBER"]);
            this.FaxNumber.text.setText(PartnerInformation.data["result"][0]["FAXNUMBER"]);
            this.MusteriTemsilciNo.text.setText(PartnerInformation.data["result"][0]["MaskInput3"]);
            
            this.AccountantAddress.text.setText(PartnerInformation.data["result"][0]["ACCOUNTANTADDRESS"]);
            this.AccountantNumber.text.setText(PartnerInformation.data["result"][0]["AccountantNumber"]);
        }
        else
        {
            this.showToaster("Veri Hatası","Veritabanından veri sağlanamadı.","Error");
        }
        await this.applyChanges();
	}

	async Label1_OnLoad(args: Controls.EventArgs.ILoadEventArgs) {
	}

	async PartnerMainMenu_OnToolbarButtonClicked(args: Controls.EventArgs.IToolbarButtonClickEventArgs) {
        if(args.name === "Edit")
        {
            this.createForm(
                {
                    formName: "PartnerDetailDescription",
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
        else if(args.name === "Users")
        {
            this.createForm(
                {
                    formName: "PartnerUserLast2_Archive",
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
        else if(args.name === "ConsultancyServices")
        {
            this.createForm(
                {
                    formName: "ConsultingDefinition2_Archive",
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
        else if(args.name === "Applications")
        {
            this.createForm(
                {
                    formName: "SupplyPageLast2_Archive",
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