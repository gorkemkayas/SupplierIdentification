export default class ConsultingDefinition extends Form.Designer {

	async FeeStatus_OnValueChanging(args: Controls.EventArgs.IPropertyChangingEventArgs<any>) {

	}

	async FeeStatus_OnSelectedItemChanging(args: Controls.EventArgs.IPropertyChangingEventArgs<Controls.Common.IListItem<Controls.Common.MultiLanguageText>>) {
	}

	async ConsultingFees_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<string>) {

	}

	async FeeStatus_OnSelectedItemChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<Controls.Common.IListItem<Controls.Common.MultiLanguageText>>) {
	}

	async FeeStatus_OnTextChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<string>) {
	}

	async FeeStatus_OnValueChanged(args: Controls.EventArgs.IPropertyChangedEventArgs<any>) {
		if(args.newValue == "2")
		{
			this.ConsultingFees.clientEnabled = true;
			this.CurrencyType.clientEnabled = true;	
		}
		else
		{
			this.ConsultingFees.clientEnabled = false;
			this.CurrencyType.clientEnabled = false;
		}

	}

}